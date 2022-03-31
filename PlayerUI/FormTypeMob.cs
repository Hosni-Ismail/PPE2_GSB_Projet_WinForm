using System;
using System.Windows.Forms;

namespace PlayerUI
{
    using System.Data.Odbc;
    public partial class FormTypeMob : Form
    {

        public FormTypeMob()
        {
            InitializeComponent();
        }

        private void FormTypeMob_Load(object sender, EventArgs e)

        {
            //Lire le contenue du fichier connexion .ini
            varglob.chaineconnect = System.IO.File.ReadAllText(Application.StartupPath + "\\connexion.ini");

            // Affichage à l'ouverture du form de la table typemobil
            OdbcConnection cnn = new OdbcConnection();
            OdbcCommand cmd = new OdbcCommand();
            OdbcDataReader drr;
            Boolean existenreg;
            grdtype.ColumnCount = 6;
            grdtype.Rows.Clear();
            cnn.ConnectionString = varglob.chaineconnect;
            cnn.Open();
            cmd.CommandText = "select * from typemobil";
            cmd.Connection = cnn;
            drr = cmd.ExecuteReader();
            existenreg = drr.Read();
            while (existenreg == true)
            {
                grdtype.Rows.Add(drr["idtyp"], drr["libtyp"], drr["nbpers"], drr["descripcourte"], drr["descriplongue"], drr["tarifsemaine"]);
                existenreg = drr.Read();
            }
            drr.Close();
            cnn.Close();

            // Aide à la saisie du libtyp
            cnn.ConnectionString = varglob.chaineconnect;
            {
                cmd.CommandText = "select libtyp from typemobil";
                cnn.Open();
                cmd.Connection = cnn;
                drr = cmd.ExecuteReader();
                existenreg = drr.Read();
                AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();
                while (drr.Read())
                {
                    MyCollection.Add(drr.GetString(0));
                }
                rechtyp.AutoCompleteCustomSource = MyCollection;
                cnn.Close();
            }
        }


        void ClearAllText(Control con)
            //Fonction permettant de vider tout les textbox après saisie
        {
            foreach (Control c in con.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();
                else
                    ClearAllText(c);
            }
        }

        private void btnAjouterTyp_Click(object sender, EventArgs e)
        {
            // Ajout à la table des données saisie dans les textbox

            int nbenreg;
            OdbcConnection cnn = new OdbcConnection();
            OdbcCommand cmd = new OdbcCommand();
            // Vérifier si les textbox sont complétées
            if (txtidtyp.Text == "")
            {
                string myStringVariable1 = string.Empty;
                MessageBox.Show("Un ID doit être saisi!");
            }
            else if (txtlibtyp.Text == "")
            {
                string myStringVariable2 = string.Empty;
                MessageBox.Show("Un libellé doit être saisi!");
            }
            else if (txtnbpers.Text == "")
            {
                string myStringVariable2 = string.Empty;
                MessageBox.Show("Un nombre de personne doit être saisi");
            }
            else if (txtdescripcourte.Text == "")
            {
                string myStringVariable2 = string.Empty;
                MessageBox.Show("Une description courte doit être saisi!");
            }
            else if (txtdescriplongue.Text == "")
            {
                string myStringVariable2 = string.Empty;
                MessageBox.Show("Une description longue doit être saisi!");
            }
            else if (txttarifsemaine.Text == "")
            {
                string myStringVariable2 = string.Empty;
                MessageBox.Show("Un tarif doit être saisi!");
            }

            else
            {
                // Ajout des éléments dans la base de données
                try
                {

                    cnn.ConnectionString = varglob.chaineconnect;
                    cnn.Open();
                    cmd.CommandText = "insert into typemobil (idtyp,libtyp,nbpers,descripcourte,descriplongue,tarifsemaine) values ('" + txtidtyp.Text + "', '" + txtlibtyp.Text.Replace("'", "''") + "','" + txtnbpers.Text + "','" + txtdescripcourte.Text.Replace("'", "''") + "','" + txtdescriplongue.Text.Replace("'", "''") + "','" + txttarifsemaine.Text + "')";
                    cmd.Connection = cnn;
                    nbenreg = cmd.ExecuteNonQuery();
                    cnn.Close();


                    if (nbenreg > 0)
                    {
                        lblsupprimermessage.Text = "";
                        lblmodifiermessage.Text = "";
                        lblerrormodif.Text = "";
                        lblerrorsupp.Text = "";
                        lblerrorajout.Text = "";
                        lblajoutermessage.Text = "Ajout réussi du type de mobilhome :" + " " + txtlibtyp.Text;
                        ClearAllText(this);
                        OdbcDataReader drr;
                        Boolean existenreg;
                        grdtype.ColumnCount = 6;
                        grdtype.Rows.Clear();
                        cnn.ConnectionString = varglob.chaineconnect;
                        cnn.Open();
                        cmd.CommandText = "select * from typemobil order by idtyp desc";
                        cmd.Connection = cnn;
                        drr = cmd.ExecuteReader();
                        existenreg = drr.Read();
                        while (existenreg == true)
                        {
                            grdtype.Rows.Add(drr["idtyp"], drr["libtyp"], drr["nbpers"], drr["descripcourte"], drr["descriplongue"], drr["tarifsemaine"]);
                            existenreg = drr.Read();
                        }
                        cnn.Close();
                    }

                    else
                    {
                        lblerrorajout.Text = "Erreur ajout non effectué";
                        lblajoutermessage.Text = "";
                        lblerrormodif.Text = "";
                        lblerrorsupp.Text = "";
                        lblsupprimermessage.Text = "";
                        lblmodifiermessage.Text = "";

                    }

                    cnn.Close();
                }
                catch
                {
                    // Afficher un message d'erreur si la requete est impossible à executer
                    MessageBox.Show("Erreur");
                }

            }


        }

        private void btnmodifier_Click(object sender, EventArgs e)
        {
            // Modification de la cellule sélectionner

            int nbenreg;
            OdbcConnection cnn = new OdbcConnection();
            OdbcCommand cmd = new OdbcCommand();

            // Vérifier si les textbox sont complétées
            if (txtidtyp.Text == "")
            {
                string myStringVariable1 = string.Empty;
                MessageBox.Show("Un ID doit être saisi!");
            }
            else if (txtlibtyp.Text == "")
            {
                string myStringVariable2 = string.Empty;
                MessageBox.Show("Un libellé doit être saisi!");
            }
            else if (txtnbpers.Text == "")
            {
                string myStringVariable2 = string.Empty;
                MessageBox.Show("Un nombre de personne doit être saisi!");
            }
            else if (txtdescripcourte.Text == "")
            {
                string myStringVariable2 = string.Empty;
                MessageBox.Show("Une description courte doit être saisi!");
            }
            else if (txtdescriplongue.Text == "")
            {
                string myStringVariable2 = string.Empty;
                MessageBox.Show("Une description longue doit être saisi!");
            }
            else if (txttarifsemaine.Text == "")
            {
                string myStringVariable2 = string.Empty;
                MessageBox.Show("Un tarif doit être saisi!");
            }

            else
            {
                // Ajout des éléments dans la base de données
                try
                {

                    cnn.ConnectionString = varglob.chaineconnect;
                    cnn.Open();
                    cmd.CommandText = "update typemobil set idtyp='" + txtidtyp.Text + "', libtyp='" + txtlibtyp.Text.Replace("'", "''") + "', nbpers='" + txtnbpers.Text + "', descripcourte='" + txtdescripcourte.Text.Replace("'", "''") + "', descriplongue='" + txtdescriplongue.Text.Replace("'", "''") + "', tarifsemaine='" + txttarifsemaine.Text + "' where idtyp=" + txtidtyp.Text;
                    cmd.Connection = cnn;
                    nbenreg = cmd.ExecuteNonQuery();
                    cnn.Close();

                    if (nbenreg > 0)
                    {
                        lblajoutermessage.Text = "";
                        lblsupprimermessage.Text = "";
                        lblerrorsupp.Text = "";
                        lblerrorajout.Text = "";
                        lblerrormodif.Text = "";
                        lblmodifiermessage.Text = "Modification réussie du type de mobilhome n°" + txtidtyp.Text;
                        ClearAllText(this);
                        OdbcDataReader drr;
                        Boolean existenreg;
                        grdtype.ColumnCount = 6;
                        grdtype.Rows.Clear();
                        cnn.ConnectionString = varglob.chaineconnect;
                        cnn.Open();
                        cmd.CommandText = "select * from typemobil order by idtyp desc";
                        cmd.Connection = cnn;
                        drr = cmd.ExecuteReader();
                        existenreg = drr.Read();
                        while (existenreg == true)
                        {
                            grdtype.Rows.Add(drr["idtyp"], drr["libtyp"], drr["nbpers"], drr["descripcourte"], drr["descriplongue"], drr["tarifsemaine"]);
                            existenreg = drr.Read();
                        }
                        cnn.Close();
                    }
                    else
                    {
                        lblerrormodif.Text = "Erreur modification non effectuée";
                        lblerrorsupp.Text = "";
                        lblerrorajout.Text = "";
                        lblajoutermessage.Text = "";
                        lblsupprimermessage.Text = "";
                        lblmodifiermessage.Text = "";
                    }
                    cnn.Close();
                }
                catch
                {
                    // Afficher un message d'erreur si la requete est impossible à executer
                    MessageBox.Show("Erreur");
                }
            }

        }


        private void btnsupprimertyp_Click(object sender, EventArgs e)
        {
            // Suppression de la cellule sélectionner

            int nbenreg;
            try
            {
                OdbcConnection cnn = new OdbcConnection();
                OdbcCommand cmd = new OdbcCommand();
                cnn.ConnectionString = varglob.chaineconnect;
                cnn.Open();
                cmd.CommandText = "delete from typemobil where idtyp=" + grdtype[0, grdtype.CurrentCell.RowIndex].Value;
                cmd.Connection = cnn;
                nbenreg = cmd.ExecuteNonQuery();
                if (nbenreg > 0)
                {
                    // Ajout des éléments dans la base de données

                    lblmodifiermessage.Text = "";
                    lblajoutermessage.Text = "";
                    lblerrorajout.Text = "";
                    lblerrormodif.Text = "";
                    lblerrorsupp.Text = "";
                    lblsupprimermessage.Text = "Suppression réussie du type de mobilhome n°" + grdtype[0, grdtype.CurrentCell.RowIndex].Value;
                    grdtype.Rows.RemoveAt(grdtype.CurrentCell.RowIndex);
                    ClearAllText(this);
                    OdbcDataReader drr;
                    Boolean existenreg;
                    grdtype.ColumnCount = 6;
                    grdtype.Rows.Clear();
                    cmd.CommandText = "select * from typemobil order by idtyp desc";
                    cmd.Connection = cnn;
                    drr = cmd.ExecuteReader();
                    existenreg = drr.Read();
                    while (existenreg == true)
                    {
                        grdtype.Rows.Add(drr["idtyp"], drr["libtyp"], drr["nbpers"], drr["descripcourte"], drr["descriplongue"], drr["tarifsemaine"]);
                        existenreg = drr.Read();
                    }
                    cnn.Close();
                }
                else
                {
                    lblerrorsupp.Text = "Erreur suppression non effectuée";
                    lblsupprimermessage.Text = "";
                    lblerrorajout.Text = "";
                    lblerrormodif.Text = "";
                    lblmodifiermessage.Text = "";
                    lblajoutermessage.Text = "";
                }
                cnn.Close();
            }
            catch
            {
                // Afficher un message d'erreur si la requete est impossible à executer
                MessageBox.Show("Erreur");
            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            // Bouton rafraichir la table SQL 

            OdbcConnection cnn = new OdbcConnection();
            OdbcCommand cmd = new OdbcCommand();
            OdbcDataReader drr;
            Boolean existenreg;
            grdtype.ColumnCount = 6;
            grdtype.Rows.Clear();
            cnn.ConnectionString = varglob.chaineconnect;
            cnn.Open();
            cmd.CommandText = "select * from typemobil";
            cmd.Connection = cnn;
            drr = cmd.ExecuteReader();
            existenreg = drr.Read();
            while (existenreg == true)
            {
                grdtype.Rows.Add(drr["idtyp"], drr["libtyp"], drr["nbpers"], drr["descripcourte"], drr["descriplongue"], drr["tarifsemaine"]);
                existenreg = drr.Read();
            }
            
            drr.Close();
            cnn.Close();
        }

        private void grdtype_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtidtyp.Text = Convert.ToString(grdtype[0, grdtype.CurrentCell.RowIndex].Value);
            txtlibtyp.Text = Convert.ToString(grdtype[1, grdtype.CurrentCell.RowIndex].Value);
            txtnbpers.Text = Convert.ToString(grdtype[2, grdtype.CurrentCell.RowIndex].Value);
            txtdescripcourte.Text = Convert.ToString(grdtype[3, grdtype.CurrentCell.RowIndex].Value);
            txtdescriplongue.Text = Convert.ToString(grdtype[4, grdtype.CurrentCell.RowIndex].Value);
            txttarifsemaine.Text = Convert.ToString(grdtype[5, grdtype.CurrentCell.RowIndex].Value);
        }


        private void Retour_Click(object sender, EventArgs e)
        {
            //Retour sur la page d'acceuil
            this.Close();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            // Bouton rechercher un type de mobilhome
            OdbcConnection cnn = new OdbcConnection();
            OdbcCommand cmd = new OdbcCommand();
            OdbcDataReader drr;
            Boolean existenreg;
            grdtype.ColumnCount = 8;
            grdtype.Rows.Clear();
            cnn.ConnectionString = varglob.chaineconnect;
            cnn.Open();
            cmd.CommandText = "select* from typemobil where libtyp like '" + rechtyp.Text.Replace("'", "''") + "%' order by idtyp";
            cmd.Connection = cnn;
            drr = cmd.ExecuteReader();
            existenreg = drr.Read();
            while (existenreg == true)
            {
                grdtype.Rows.Add(drr["idtyp"], drr["libtyp"], drr["nbpers"], drr["descripcourte"], drr["descriplongue"], drr["tarifsemaine"]);
                existenreg = drr.Read();
            }
            drr.Close();
            cnn.Close();

            txtidtyp.Text = Convert.ToString(grdtype[0, grdtype.CurrentCell.RowIndex].Value);
            txtlibtyp.Text = Convert.ToString(grdtype[1, grdtype.CurrentCell.RowIndex].Value);
            txtnbpers.Text = Convert.ToString(grdtype[2, grdtype.CurrentCell.RowIndex].Value);
            txtdescripcourte.Text = Convert.ToString(grdtype[3, grdtype.CurrentCell.RowIndex].Value);
            txtdescriplongue.Text = Convert.ToString(grdtype[4, grdtype.CurrentCell.RowIndex].Value);
            txttarifsemaine.Text = Convert.ToString(grdtype[5, grdtype.CurrentCell.RowIndex].Value);

        }

        // Empecher la saisie de lettre dans les textbox concernées
        private void txtidtyp_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtnbpers_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txttarifsemaine_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void rechtyp_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
