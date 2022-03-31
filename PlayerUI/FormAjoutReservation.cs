using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PlayerUI
{
    using System.Data.Odbc;
    public partial class FormAjoutReservation : Form
    {

        public FormAjoutReservation()
        {
            InitializeComponent();
        }

        List<string> idclires = new List<string>();
        List<string> typemob = new List<string>();

        void ClearAllText(Control con)
        {
            // Fonction permettant de vider tout les textbox
            foreach (Control c in con.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();
                else
                    ClearAllText(c);
            }
        }

        private void FormAjoutReservation_Load(object sender, EventArgs e)
        {
            //Lire le contenue du fichier connexion .ini
            varglob.chaineconnect = System.IO.File.ReadAllText(Application.StartupPath + "\\connexion.ini");

            //Afficher la table mobilhome au démarrage 
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
                grdmob.Rows.Add(drr["idmob"], drr["nom"]);
                existenreg = drr.Read();
            }
            drr.Close();
            cnn.Close();

            //Afficher la table reservation au démarrage 
            grdreservation.ColumnCount = 7;
            grdreservation.Rows.Clear();
            cnn.ConnectionString = varglob.chaineconnect;
            cnn.Open();
            cmd.CommandText = "select* from reservation order by dateres desc";
            cmd.Connection = cnn;
            drr = cmd.ExecuteReader();
            existenreg = drr.Read();
            while (existenreg == true)
            {
                grdreservation.Rows.Add(drr["idres"], drr["dateres"], drr["datedebut"], drr["datefin"], drr["regleon"], drr["idmob"], drr["idcli"]);
                existenreg = drr.Read();
            }
            drr.Close();
            cnn.Close();

            // Afficher la table client au démarrage
            grdclient.ColumnCount = 7;
            grdclient.Rows.Clear();
            cnn.ConnectionString = varglob.chaineconnect;
            cnn.Open();
            cmd.CommandText = "select* from client";
            cmd.Connection = cnn;
            drr = cmd.ExecuteReader();
            existenreg = drr.Read();
            while (existenreg == true)
            {
                grdclient.Rows.Add(drr["idcli"], drr["nomcli"], drr["adresse"], drr["cp"], drr["ville"], drr["telephone"], drr["mail"]);
                existenreg = drr.Read();
            }
            drr.Close();
            cnn.Close();

            //Récupérer les données de la table client pour les afficher dans le menu deroulant  
            cboidclient.Items.Clear();
            cnn.ConnectionString = varglob.chaineconnect;
            cnn.Open();
            cmd.CommandText = "select nomcli,idcli from client order by nomcli";
            cmd.Connection = cnn;
            drr = cmd.ExecuteReader();
            existenreg = drr.Read();
            while (existenreg == true)
            {
                idclires.Add(Convert.ToString(drr["idcli"]));
                cboidclient.Items.Add(drr["nomcli"]);
                existenreg = drr.Read();
            }

            drr.Close();
            cnn.Close();

            // Aide à la saisie pour le nom des clients
            cnn.ConnectionString = varglob.chaineconnect;
            {
                cmd.CommandText = "select nomcli from client";
                cnn.Open();
                cmd.Connection = cnn;
                drr = cmd.ExecuteReader();
                existenreg = drr.Read();
                AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();
                while (drr.Read())
                {
                    MyCollection.Add(drr.GetString(0));
                }
                cboidclient.AutoCompleteCustomSource = MyCollection;
                txtnomclient.AutoCompleteCustomSource = MyCollection;
                cnn.Close();

            }

            // Affichage de la table typemobil au démarrage 
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

            // Aide à la saisie des nom
            cnn.ConnectionString = varglob.chaineconnect;
            {
                cmd.CommandText = "select nomcli from client";
                cnn.Open();
                cmd.Connection = cnn;
                drr = cmd.ExecuteReader();
                existenreg = drr.Read();
                AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();
                while (drr.Read())
                {
                    MyCollection.Add(drr.GetString(0));
                }
                cboidclient.AutoCompleteCustomSource = MyCollection;
                cnn.Close();

                timeres.Value = DateTime.Now;
                debuttime.Value = DateTime.Now;
                fintime.Value = DateTime.Now;

            }

        }


        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            txtnomclient.Text = Convert.ToString(grdclient[1, grdclient.CurrentCell.RowIndex].Value);
            txtadresseclient.Text = Convert.ToString(grdclient[2, grdclient.CurrentCell.RowIndex].Value);
            txtcodepostalclient.Text = Convert.ToString(grdclient[3, grdclient.CurrentCell.RowIndex].Value);
            txtvilleclient.Text = Convert.ToString(grdclient[4, grdclient.CurrentCell.RowIndex].Value);
            txttelephoneclient.Text = Convert.ToString(grdclient[5, grdclient.CurrentCell.RowIndex].Value);
            txtmailclient.Text = Convert.ToString(grdclient[6, grdclient.CurrentCell.RowIndex].Value);

        }


        private void btnajouterclient_Click_1(object sender, EventArgs e)
        {
            // Bouton ajout de nouveaux clients 
            int nbenreg;
            OdbcConnection cnn = new OdbcConnection();
            OdbcCommand cmd = new OdbcCommand();
            // Vérifier si les textbox sont complétées
            if (txtnomclient.Text == "")
            {
                string myStringVariable1 = string.Empty;
                MessageBox.Show("Un nom doit être saisi!");
                return;
            }
            else if (txtadresseclient.Text == "")
            {
                string myStringVariable2 = string.Empty;
                MessageBox.Show("Une adresse doit être saisi!");
            }
            else if (txtcodepostalclient.Text == "")
            {
                string myStringVariable2 = string.Empty;
                MessageBox.Show("Un code postal doit être saisi!");
            }
            else if (txtvilleclient.Text == "")
            {
                string myStringVariable2 = string.Empty;
                MessageBox.Show("Une ville doit être saisi!");
            }
            else if (txttelephoneclient.Text == "")
            {
                string myStringVariable2 = string.Empty;
                MessageBox.Show("Un numéro de télephone doit être saisi!");
            }
            else if (txtmailclient.Text == "")
            {
                string myStringVariable2 = string.Empty;
                MessageBox.Show("Une adresse mail doit être saisi!");
            }
            else
            {
                // Ajout des éléments dans la base de données
                cnn.ConnectionString = varglob.chaineconnect;
                cnn.Open();
                cmd.CommandText = "insert into client (nomcli,adresse,cp,ville,telephone,mail) values ('" + txtnomclient.Text.Replace("'", "''") + "','" + txtadresseclient.Text.Replace("'", "''") + "','" + txtcodepostalclient.Text + "','" + txtvilleclient.Text.Replace("'", "''") + "','" + txttelephoneclient.Text + "', '" + txtmailclient.Text.Replace("'", "''") + "')";
                cmd.Connection = cnn;
                nbenreg = cmd.ExecuteNonQuery();
                cnn.Close();

                if (nbenreg > 0)
                {
                    // Rafraichir les tableaux 
                    lblresmessage.Text = "Ajout réussi du client :" + " " + txtnomclient.Text;
                    lblmessageres.Text = "";
                    ClearAllText(this);
                    OdbcDataReader drr;
                    Boolean existenreg;
                    cnn.ConnectionString = varglob.chaineconnect;
                    cnn.Open();
                    grdclient.ColumnCount = 7;
                    grdclient.Rows.Clear();
                    cmd.CommandText = "select* from client order by idcli desc";
                    cmd.Connection = cnn;
                    drr = cmd.ExecuteReader();
                    existenreg = drr.Read();
                    while (existenreg == true)
                    {
                        grdclient.Rows.Add(drr["idcli"], drr["nomcli"], drr["adresse"], drr["cp"], drr["ville"], drr["telephone"], drr["mail"]);
                        existenreg = drr.Read();
                    }
                    cnn.Close();

                    cnn.ConnectionString = varglob.chaineconnect;
                    cnn.Open();
                    cboidclient.Items.Clear();
                    cmd.CommandText = "select nomcli,idcli from client order by nomcli";
                    cmd.Connection = cnn;
                    drr = cmd.ExecuteReader();
                    existenreg = drr.Read();
                    while (existenreg == true)
                    {
                        idclires.Add(Convert.ToString(drr["idcli"]));
                        cboidclient.Items.Add(drr["nomcli"]);
                        existenreg = drr.Read();
                    }
                    cnn.Close();

                    cboidclient.Text = Convert.ToString(grdclient[1, grdclient.CurrentCell.RowIndex].Value);
                }

                else
                {
                    lblerrorcli.Text = "Erreur ajout non effectué";
                    lblerrorres.Text = "";
                }
                cnn.Close();
            }


        }


        private void gunaButton1_Click_1(object sender, EventArgs e)
        {
            // Bouton permetant de rafraichir la table client 
            OdbcConnection cnn = new OdbcConnection();
            OdbcCommand cmd = new OdbcCommand();
            OdbcDataReader drr;
            Boolean existenreg;
            grdclient.ColumnCount = 7;
            grdclient.Rows.Clear();
            cnn.ConnectionString = varglob.chaineconnect;
            cnn.Open();
            cmd.CommandText = "select* from client";
            cmd.Connection = cnn;
            drr = cmd.ExecuteReader();
            existenreg = drr.Read();
            while (existenreg == true)
            {
                grdclient.Rows.Add(drr["idcli"], drr["nomcli"], drr["adresse"], drr["cp"], drr["ville"], drr["telephone"], drr["mail"]);
                existenreg = drr.Read();
            }
            drr.Close();
            cnn.Close();

        }


        private void gunaButton2_Click(object sender, EventArgs e)
        {
            // Bouton permetant de rafraichir la table reservation
            OdbcConnection cnn = new OdbcConnection();
            OdbcCommand cmd = new OdbcCommand();
            OdbcDataReader drr;
            Boolean existenreg;
            grdreservation.ColumnCount = 7;
            grdreservation.Rows.Clear();
            cnn.ConnectionString = varglob.chaineconnect;
            cnn.Open();
            cmd.CommandText = "select* from reservation";
            cmd.Connection = cnn;
            drr = cmd.ExecuteReader();
            existenreg = drr.Read();
            while (existenreg == true)
            {
                grdreservation.Rows.Add(drr["idres"], drr["dateres"], drr["datedebut"], drr["datefin"], drr["regleon"], drr["idmob"], drr["idcli"]);
                existenreg = drr.Read();
            }
            drr.Close();
            cnn.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Initialisation des datatime
            DateTime ladate, ladate2, ladate3;
            ladate = timeres.Value;
            ladate2 = debuttime.Value;
            ladate3 = fintime.Value;

            int nbenreg;
            OdbcConnection cnn = new OdbcConnection();
            OdbcCommand cmd = new OdbcCommand();
            // Vérifier si les textbox sont complétées
            if (cboidclient.Text == "")
            {
                string myStringVariable2 = string.Empty;
                MessageBox.Show("Un client doit être saisi!");
            }
            else if (txtidmob.Text == "")
            {
                string myStringVariable2 = string.Empty;
                MessageBox.Show("Un mobil-home doit être saisi!");
            }
            else if (ladate2 > ladate3)
            {
                MessageBox.Show("Date de début supérieur à la date de fin!");
            }
            else if (ladate3 < ladate2)
            {
                MessageBox.Show("Date de fin antérieur à la date de début!");
            }
            else
            {
                try
                {

                    cnn.ConnectionString = varglob.chaineconnect;
                    cnn.Open();
                    cmd.CommandText = "insert into reservation(dateres,datedebut,datefin,regleon,idmob,idcli) values ('" + ladate.ToString("yyyy-MM-dd") + "','" + ladate2.ToString("yyyy-MM-dd") + "','" + ladate3.ToString("yyyy-MM-dd") + "'," + regleonchek.Checked + ",'" + txtidmob.Text + "','" + idclires[cboidclient.SelectedIndex] + "')";
                    cmd.Connection = cnn;
                    nbenreg = cmd.ExecuteNonQuery();
                    if (nbenreg > 0)
                    {
                        lblmessageres.Text = "Ajout de la reservation réussi";
                        lblresmessage.Text = "";
                        OdbcDataReader drr;
                        Boolean existenreg;
                        grdreservation.ColumnCount = 7;
                        grdreservation.Rows.Clear();
                        cmd.CommandText = "select* from reservation order by idres desc";
                        cmd.Connection = cnn;
                        drr = cmd.ExecuteReader();
                        existenreg = drr.Read();
                        while (existenreg == true)
                        {
                            grdreservation.Rows.Add(drr["idres"], drr["dateres"], drr["datedebut"], drr["datefin"], drr["regleon"], drr["idmob"], drr["idcli"]);
                            existenreg = drr.Read();
                        }

                        // Vider tout les textbox 
                        ClearAllText(this);
                        cboidclient.SelectedItem = null;
                        cbotypmob.SelectedItem = null;
                        timeres.Value = DateTime.Now;
                        debuttime.Value = DateTime.Now;
                        fintime.Value = DateTime.Now;
                    }
                    else
                    {
                        lblerrorres.Text = "Erreur ajout non effectué";
                        lblerrorcli.Text = "";
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

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime ladate, ladate2;
            ladate = debuttime.Value;
            ladate2 = fintime.Value;

            //Afficher uniquemment les mobil-home disponible entre deux dates  
            OdbcConnection cnn = new OdbcConnection();
            OdbcCommand cmd = new OdbcCommand();
            OdbcDataReader drr;
            Boolean existenreg;
            grdmob.ColumnCount = 4;
            grdmob.Rows.Clear();
            cnn.ConnectionString = varglob.chaineconnect;
            cnn.Open();
            cmd.CommandText = "SELECT idmob, nom FROM mobilhome WHERE idmob NOT IN(SELECT idmob FROM reservation WHERE(datedebut <= '" + ladate.ToString("yyyy-MM-dd") + "' AND datefin >= '" + ladate.ToString("yyyy-MM-dd") + "') OR(datedebut < '" + ladate2.ToString("yyyy-MM-dd") + "' AND datefin >= '" + ladate2.ToString("yyyy-MM-dd") + "') OR('" + ladate.ToString("yyyy-MM-dd") + "' <= datedebut AND '" + ladate2.ToString("yyyy-MM-dd") + "' >= datedebut))";
            cmd.Connection = cnn;
            drr = cmd.ExecuteReader();
            existenreg = drr.Read();
            while (existenreg == true)
            {
                grdmob.Rows.Add(drr["idmob"], drr["nom"]);
                existenreg = drr.Read();
            }
            drr.Close();
            cnn.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DateTime ladate, ladate2;
            ladate = debuttime.Value;
            ladate2 = fintime.Value;

            OdbcConnection cnn = new OdbcConnection();
            OdbcCommand cmd = new OdbcCommand();
            OdbcDataReader drr;
            if (cbotypmob.SelectedItem == null)
            {
                string myStringVariable3 = string.Empty;
                MessageBox.Show("Sélectionnez un type de mobil-home");
            }
            else
            {
                //Afficher uniquemment les mobil-home disponible entre deux dates et selon un type
                Boolean existenreg;
                grdmob.ColumnCount = 4;
                grdmob.Rows.Clear();
                cnn.ConnectionString = varglob.chaineconnect;
                cnn.Open();
                cmd.CommandText = "SELECT idmob, nom, idtyp FROM mobilhome WHERE idtyp='" + typemob[cbotypmob.SelectedIndex] + "' AND idmob NOT IN(SELECT idmob FROM reservation WHERE(datedebut <= '" + ladate.ToString("yyyy-MM-dd") + "' AND datefin >= '" + ladate.ToString("yyyy-MM-dd") + "') OR(datedebut < '" + ladate2.ToString("yyyy-MM-dd") + "' AND datefin >= '" + ladate2.ToString("yyyy-MM-dd") + "') OR('" + ladate.ToString("yyyy-MM-dd") + "' <= datedebut AND '" + ladate2.ToString("yyyy-MM-dd") + "' >= datedebut))";
                cmd.Connection = cnn;
                drr = cmd.ExecuteReader();
                existenreg = drr.Read();
                while (existenreg == true)
                {
                    grdmob.Rows.Add(drr["idmob"], drr["nom"]);
                    existenreg = drr.Read();
                }
                drr.Close();
                cnn.Close();
            }

        }

        private void grdmob_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtidmob.Text = Convert.ToString(grdmob[0, grdmob.CurrentCell.RowIndex].Value);
        }

        private void btnAjouterTyp_Click(object sender, EventArgs e)
        {
            // Bouton recherher client et resevation 
            OdbcConnection cnn = new OdbcConnection();
            OdbcCommand cmd = new OdbcCommand();
            OdbcDataReader drr;
            Boolean existenreg;
            grdclient.ColumnCount = 7;
            grdclient.Rows.Clear();
            cnn.ConnectionString = varglob.chaineconnect;
            cnn.Open();
            cmd.CommandText = "select* from client where nomcli like '" + txtnomclient.Text.Replace("'", "''") + "%' order by nomcli";
            cmd.Connection = cnn;
            drr = cmd.ExecuteReader();
            existenreg = drr.Read();
            while (existenreg == true)
            {
                grdclient.Rows.Add(drr["idcli"], drr["nomcli"], drr["adresse"], drr["cp"], drr["ville"], drr["telephone"], drr["mail"]);
                existenreg = drr.Read();
            }
            drr.Close();
            cnn.Close();
            grdreservation.ColumnCount = 7;
            grdreservation.Rows.Clear();
            cnn.ConnectionString = varglob.chaineconnect;
            cnn.Open();
            cmd.CommandText = "select* from reservation inner join client on reservation.idcli=client.idcli where client.nomcli like '" + txtnomclient.Text.Replace("'", "''") + "%' order by dateres desc";
            cmd.Connection = cnn;
            drr = cmd.ExecuteReader();
            existenreg = drr.Read();
            while (existenreg == true)
            {
                grdreservation.Rows.Add(drr["idres"], drr["dateres"], drr["datedebut"], drr["datefin"], drr["regleon"], drr["idmob"], drr["idcli"]);
                existenreg = drr.Read();
            }
            drr.Close();
            cnn.Close();

        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            //Retour sur la page d'acceuil
            this.Close();
        }

        // Empecher la saisie de lettre dans les textbox concernées
        private void txtidclient_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }


        private void txtcodepostalclient_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txttelephoneclient_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtnomclient_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

