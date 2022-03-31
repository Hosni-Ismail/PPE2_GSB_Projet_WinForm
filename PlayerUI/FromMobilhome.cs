using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerUI

{
    using System.Data.Odbc;
    public partial class FormMobilhome : Form
    {
        

        public FormMobilhome()
        {
            InitializeComponent();
        }
        List<string> typemob = new List<string>();
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void FormMobilhome_Load(object sender, EventArgs e)
        {
            //Lire le contenue du fichier connexion .ini
            varglob.chaineconnect = System.IO.File.ReadAllText(Application.StartupPath + "\\connexion.ini");

            // Configuration du menu déroulant de sélection du type de mobilhome

            OdbcConnection cnn = new OdbcConnection();
            OdbcCommand cmd = new OdbcCommand();
            OdbcDataReader drr;
            Boolean existenreg;
            cbotypmob.Items.Clear();
            cnn.ConnectionString = varglob.chaineconnect;
            cnn.Open();
            cmd.CommandText = "select libtyp,idtyp from typemobil order by idtyp";
            cmd.Connection = cnn;
            drr = cmd.ExecuteReader();
            existenreg = drr.Read();
            while (existenreg == true)
            {
                typemob.Add(Convert.ToString(drr["idtyp"]));
                cbotypmob.Items.Add(drr["libtyp"]);
                existenreg = drr.Read();
            }

            drr.Close();
            cnn.Close();

            // Affichage à l'ouverture du form de la table mobilhome

            grdmob.ColumnCount = 4;
            grdmob.Rows.Clear();
            cnn.ConnectionString = varglob.chaineconnect;
            cnn.Open();
            cmd.CommandText = "select* from mobilhome order by idmob";
            cmd.Connection = cnn;
            drr = cmd.ExecuteReader();
            existenreg = drr.Read();
            while (existenreg == true)
            {
                grdmob.Rows.Add(drr["idmob"], drr["nom"], drr["numemp"], drr["idtyp"]);
                existenreg = drr.Read();
            }
            drr.Close();
            cnn.Close();

            // Aide à la saisie du nom
            cnn.ConnectionString = varglob.chaineconnect;
            {
                cmd.CommandText = "select nom from mobilhome";
                cnn.Open();
                cmd.Connection = cnn;
                drr = cmd.ExecuteReader();
                existenreg = drr.Read();
                AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();
                while (drr.Read())
                {
                    MyCollection.Add(drr.GetString(0));
                }
                rechmob.AutoCompleteCustomSource = MyCollection;
                cnn.Close();
            }
        }


        private void btnajoutermob_Click(object sender, EventArgs e)
        {
            // Ajout à la table des données saisie dans les textbox
            int nbenreg;
            OdbcConnection cnn = new OdbcConnection();
            OdbcCommand cmd = new OdbcCommand();
            // Vérifier si les textbox sont complétées
            if (txtidmob.Text == "")
            {
                string myStringVariable1 = string.Empty;
                MessageBox.Show("Un ID doit être saisi!");
            }
            else if (txtnom.Text == "")
            {
                string myStringVariable2 = string.Empty;
                MessageBox.Show("Un nom doit être saisi!");
            }
            else if (txtnumemp.Text == "")
            {
                string myStringVariable2 = string.Empty;
                MessageBox.Show("Un numero d'emplacement doit être saisi!");
            }
            else if (cbotypmob.SelectedItem == null)
            {
                string myStringVariable3 = string.Empty;
                MessageBox.Show("Sélectionnez un type de mobil-home!");
            }

            else
            {
                // Ajout des éléments dans la base de données
                try
                {

                    cnn.ConnectionString = varglob.chaineconnect;
                    cnn.Open();
                    cmd.CommandText = "insert into mobilhome (idmob,nom,numemp,idtyp) values ('" + txtidmob.Text + "', '" + txtnom.Text.Replace("'", "''") + "','" + txtnumemp.Text + "','" + typemob[cbotypmob.SelectedIndex] + "')";
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
                        lblajoutermessage.Text = "Ajout réussie du mobilhome n°" + txtidmob.Text;
                        ClearAllText(this);
                        OdbcDataReader drr;
                        Boolean existenreg;
                        grdmob.ColumnCount = 4;
                        grdmob.Rows.Clear();
                        cnn.ConnectionString = varglob.chaineconnect;
                        cnn.Open();
                        cmd.CommandText = "select* from mobilhome order by idmob desc";
                        cmd.Connection = cnn;
                        drr = cmd.ExecuteReader();
                        existenreg = drr.Read();
                        while (existenreg == true)
                        {
                            grdmob.Rows.Add(drr["idmob"], drr["nom"], drr["numemp"], drr["idtyp"]);
                            existenreg = drr.Read();
                        }
                        drr.Close();
                        cnn.Close();
                    }
                    else
                    {
                        lblerrorajout.Text = "Erreur modification non effectuée";
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


        private void gunaButton1_Click(object sender, EventArgs e)
        {
            // Bouton rafraichir la table SQL

            OdbcConnection cnn = new OdbcConnection();
            OdbcCommand cmd = new OdbcCommand();
            OdbcDataReader drr;
            Boolean existenreg;
            grdmob.ColumnCount = 4;
            grdmob.Rows.Clear();
            cnn.ConnectionString = varglob.chaineconnect;
            cnn.Open();
            cmd.CommandText = "select* from mobilhome";
            cmd.Connection = cnn;
            drr = cmd.ExecuteReader();
            existenreg = drr.Read();
            while (existenreg == true)
            {
                grdmob.Rows.Add(drr["idmob"], drr["nom"], drr["numemp"], drr["idtyp"]);
                existenreg = drr.Read();
            }
            drr.Close();
            cnn.Close();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            //Retour sur la page d'acceuil
            this.Close();
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            // Bouton rechercher un mobilhome
            OdbcConnection cnn = new OdbcConnection();
            OdbcCommand cmd = new OdbcCommand();
            OdbcDataReader drr;
            Boolean existenreg;
            grdmob.ColumnCount = 8;
            grdmob.Rows.Clear();
            cnn.ConnectionString = varglob.chaineconnect;
            cnn.Open();
            cmd.CommandText = "select* from mobilhome where nom like '" + rechmob.Text.Replace("'", "''") + "%' order by nom";
            cmd.Connection = cnn;
            drr = cmd.ExecuteReader();
            existenreg = drr.Read();
            while (existenreg == true)
            {
                grdmob.Rows.Add(drr["idmob"], drr["nom"], drr["numemp"], drr["idtyp"]);
                existenreg = drr.Read();
            }
            drr.Close();
            cnn.Close();

            txtidmob.Text = Convert.ToString(grdmob[0, grdmob.CurrentCell.RowIndex].Value);
            txtnom.Text = Convert.ToString(grdmob[1, grdmob.CurrentCell.RowIndex].Value);
            txtnumemp.Text = Convert.ToString(grdmob[2, grdmob.CurrentCell.RowIndex].Value);
            cbotypmob.Text = Convert.ToString(grdmob[3, grdmob.CurrentCell.RowIndex].Value);
        }

        // Empecher la saisie de lettre dans les textbox concernées
        private void txtidmob_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtnumemp_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void grdmob_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtidmob.Text = Convert.ToString(grdmob[0, grdmob.CurrentCell.RowIndex].Value);
            txtnom.Text = Convert.ToString(grdmob[1, grdmob.CurrentCell.RowIndex].Value);
            txtnumemp.Text = Convert.ToString(grdmob[2, grdmob.CurrentCell.RowIndex].Value);
            cbotypmob.Text = Convert.ToString(grdmob[3, grdmob.CurrentCell.RowIndex].Value);
        }

        private void btnmodifier_Click_1(object sender, EventArgs e)
        {
            // Modification de la cellule sélectionner

            int nbenreg;
            OdbcConnection cnn = new OdbcConnection();
            OdbcCommand cmd = new OdbcCommand();
            // Vérifier si les textbox sont complétées
            if (txtidmob.Text == "")
            {
                string myStringVariable1 = string.Empty;
                MessageBox.Show("Un ID doit être saisi!");
            }
            else if (txtnom.Text == "")
            {
                string myStringVariable2 = string.Empty;
                MessageBox.Show("Un nom doit être saisi!");
            }
            else if (txtnumemp.Text == "")
            {
                string myStringVariable2 = string.Empty;
                MessageBox.Show("Un numero d'emplacement doit être saisi!");
            }
            else if (cbotypmob.SelectedItem == null)
            {
                string myStringVariable3 = string.Empty;
                MessageBox.Show("Sélectionnez un type de mobil-home!");
            }

            else
            {
                // Ajout des éléments dans la base de donnée
                try
                {

                    cnn.ConnectionString = varglob.chaineconnect;
                    cnn.Open();
                    cmd.CommandText = "update mobilhome set idmob='" + txtidmob.Text + "', nom='" + txtnom.Text.Replace("'", "''") + "', numemp='" + txtnumemp.Text + "', idtyp='" + typemob[cbotypmob.SelectedIndex] + "' where idmob=" + txtidmob.Text;
                    cmd.Connection = cnn;
                    nbenreg = cmd.ExecuteNonQuery();
                    cnn.Close();

                    if (nbenreg > 0)
                    {
                        lblajoutermessage.Text = "";
                        lblsupprimermessage.Text = "";
                        lblerrorajout.Text = "";
                        lblerrorsupp.Text = "";
                        lblerrormodif.Text = "";
                        lblmodifiermessage.Text = "Modification réussie du mobilhome n°" + " " + txtidmob.Text;
                        ClearAllText(this);
                        OdbcDataReader drr;
                        Boolean existenreg;
                        grdmob.ColumnCount = 4;
                        grdmob.Rows.Clear();
                        cnn.ConnectionString = varglob.chaineconnect;
                        cnn.Open();
                        cmd.CommandText = "select* from mobilhome order by idmob desc";
                        cmd.Connection = cnn;
                        drr = cmd.ExecuteReader();
                        existenreg = drr.Read();
                        while (existenreg == true)
                        {
                            grdmob.Rows.Add(drr["idmob"], drr["nom"], drr["numemp"], drr["idtyp"]);
                            existenreg = drr.Read();
                        }
                        drr.Close();
                        cnn.Close();
                    }
                    else
                    {
                        lblerrormodif.Text = "Erreur modification non effectuée";
                        lblmodifiermessage.Text = "";
                        lblerrorajout.Text = "";
                        lblerrorsupp.Text = "";
                        lblajoutermessage.Text = "";
                        lblsupprimermessage.Text = "";
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

        private void btnsupprimertyp_Click_1(object sender, EventArgs e)
        {
            // Suppression de la cellule sélectionner

            int nbenreg;
            try
            {
                OdbcConnection cnn = new OdbcConnection();
                OdbcCommand cmd = new OdbcCommand();
                cnn.ConnectionString = varglob.chaineconnect;
                cnn.Open();
                cmd.CommandText = "delete from mobilhome where idmob=" + grdmob[0, grdmob.CurrentCell.RowIndex].Value;
                cmd.Connection = cnn;
                nbenreg = cmd.ExecuteNonQuery();
                if (nbenreg > 0)
                {
                    lblmodifiermessage.Text = "";
                    lblajoutermessage.Text = "";
                    lblerrorajout.Text = "";
                    lblerrormodif.Text = "";
                    lblerrorsupp.Text = "";
                    lblsupprimermessage.Text = "Suppression réussie du mobilhome n°" + grdmob[0, grdmob.CurrentCell.RowIndex].Value;
                    grdmob.Rows.RemoveAt(grdmob.CurrentCell.RowIndex);
                    ClearAllText(this);
                    OdbcDataReader drr;
                    Boolean existenreg;
                    grdmob.ColumnCount = 4;
                    grdmob.Rows.Clear();
                    cmd.CommandText = "select* from mobilhome order by idmob desc";
                    cmd.Connection = cnn;
                    drr = cmd.ExecuteReader();
                    existenreg = drr.Read();
                    while (existenreg == true)
                    {
                        grdmob.Rows.Add(drr["idmob"], drr["nom"], drr["numemp"], drr["idtyp"]);
                        existenreg = drr.Read();
                    }
                    drr.Close();
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
    }

}
