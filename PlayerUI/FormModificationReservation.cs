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
    public partial class FormModificationReservation : Form
    {
        public FormModificationReservation()
        {
            InitializeComponent();
        }

        List<string> typemob = new List<string>();
        List<string> idclires = new List<string>();

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
        private void FormModificationReservation_Load(object sender, EventArgs e)
        {
            //Lire le contenue du fichier connexion .ini
            varglob.chaineconnect = System.IO.File.ReadAllText(Application.StartupPath + "\\connexion.ini");

            //Afficher la table client au démarrage 
            OdbcConnection cnn = new OdbcConnection();
            OdbcCommand cmd = new OdbcCommand();
            OdbcDataReader drr;
            Boolean existenreg;
            grdcli.ColumnCount = 7;
            grdcli.Rows.Clear();
            cnn.ConnectionString = varglob.chaineconnect;
            cnn.Open();
            cmd.CommandText = "select* from client";
            cmd.Connection = cnn;
            drr = cmd.ExecuteReader();
            existenreg = drr.Read();
            while (existenreg == true)
            {
                grdcli.Rows.Add(drr["idcli"], drr["nomcli"], drr["adresse"], drr["cp"], drr["ville"], drr["telephone"], drr["mail"]);
                existenreg = drr.Read();
            }
            drr.Close();
            cnn.Close();

            // Afficher la table reservation au démarrage 
            grdreservation.ColumnCount = 7;
            grdreservation.Rows.Clear();
            cnn.ConnectionString = varglob.chaineconnect;
            cnn.Open();
            cmd.CommandText = "select* from reservation order by idres desc";
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

            // Afficher la table mobilhome au demarrage
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

            // Configuration du combobox typemobil
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

            // Aide à la saisie des nom clients
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
                txtnomclient.AutoCompleteCustomSource = MyCollection;
                cnn.Close();

                debuttime.Value = DateTime.Now;
                fintime.Value = DateTime.Now;
                timeres.Value = DateTime.Now;
            }

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

            }

            // Configuration du combobox client
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

        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            //Retour sur la page d'acceuil
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Bouton rechercher client
            OdbcConnection cnn = new OdbcConnection();
            OdbcCommand cmd = new OdbcCommand();
            OdbcDataReader drr;
            Boolean existenreg;
            grdcli.ColumnCount = 7;
            grdcli.Rows.Clear();
            cnn.ConnectionString = varglob.chaineconnect;
            cnn.Open();
            cmd.CommandText = "select* from client where nomcli like '" + txtnomclient.Text.Replace("'", "''") + "%' order by nomcli";
            cmd.Connection = cnn;
            drr = cmd.ExecuteReader();
            existenreg = drr.Read();
            while (existenreg == true)
            {
                grdcli.Rows.Add(drr["idcli"], drr["nomcli"], drr["adresse"], drr["cp"], drr["ville"], drr["telephone"], drr["mail"]);
                existenreg = drr.Read();
            }
            drr.Close();
            cnn.Close();

            grdreservation.ColumnCount = 6;
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


            lblmessagecli.Text = "";
            lblerrorcli.Text = "";

            txtnomclient.Text = Convert.ToString(grdcli[1, grdcli.CurrentCell.RowIndex].Value);
            txtadresseclient.Text = Convert.ToString(grdcli[2, grdcli.CurrentCell.RowIndex].Value);
            txtcodepostalclient.Text = Convert.ToString(grdcli[3, grdcli.CurrentCell.RowIndex].Value);
            txtvilleclient.Text = Convert.ToString(grdcli[4, grdcli.CurrentCell.RowIndex].Value);
            txttelephoneclient.Text = Convert.ToString(grdcli[5, grdcli.CurrentCell.RowIndex].Value);
            txtmailclient.Text = Convert.ToString(grdcli[6, grdcli.CurrentCell.RowIndex].Value);


           if (grdreservation.RowCount>0)
            {

                timeres.Value = Convert.ToDateTime(grdreservation[1, grdreservation.CurrentCell.RowIndex].Value);
                debuttime.Value = Convert.ToDateTime(grdreservation[2, grdreservation.CurrentCell.RowIndex].Value);
                fintime.Value = Convert.ToDateTime(grdreservation[3, grdreservation.CurrentCell.RowIndex].Value);
                regleonchek.Checked = Convert.ToBoolean(grdreservation[4, grdreservation.CurrentCell.RowIndex].Value);
                txtidmob.Text = Convert.ToString(grdreservation[5, grdreservation.CurrentCell.RowIndex].Value);

                // Afficher les informations du clients dans les textbox et tableaux 
                DateTime ladate, ladate2;
                ladate = debuttime.Value;
                ladate2 = fintime.Value;

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

                cboidclient.Text = Convert.ToString(grdcli[1, grdcli.CurrentCell.RowIndex].Value);
            }

        else
            {
                MessageBox.Show("Ce client n'a pas de réservation!");
            }
        }


        // Empecher la saisie de lettre dans les textbox concernées
        private void txtcodepostalclient_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txttelephoneclient_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnmodifierclient_Click(object sender, EventArgs e)
        {
            // Bouton modifier les informations client 
            int nbenreg;
            OdbcConnection cnn = new OdbcConnection();
            OdbcCommand cmd = new OdbcCommand();

            // Vérifier si les textbox sont complétées
            if (txtadresseclient.Text == "")
            {
                string myStringVariable2 = string.Empty;
                MessageBox.Show("Une adresse doit être saisi");
                return;
            }
            else if (txtcodepostalclient.Text == "")
            {
                string myStringVariable2 = string.Empty;
                MessageBox.Show("Un code postal doit être saisi");
            }
            else if (txtvilleclient.Text == "")
            {
                string myStringVariable2 = string.Empty;
                MessageBox.Show("Une ville doit être saisi");
            }
            else if (txttelephoneclient.Text == "")
            {
                string myStringVariable2 = string.Empty;
                MessageBox.Show("Un numéro de télephone doit être saisi");
            }
            else if (txtmailclient.Text == "")
            {
                string myStringVariable2 = string.Empty;
                MessageBox.Show("Une adresse mail doit être saisi");
            }

            else
            {
                // Ajout des éléments dans la base de données
                cnn.ConnectionString = varglob.chaineconnect;
                cnn.Open();
                cmd.CommandText = "update client set adresse='" + txtadresseclient.Text.Replace("'", "''") + "', cp='" + txtcodepostalclient.Text + "', ville='" + txtvilleclient.Text.Replace("'", "''") + "', telephone='" + txttelephoneclient.Text + "', mail='" + txtmailclient.Text.Replace("'", "''") + "'";
                cmd.Connection = cnn;
                nbenreg = cmd.ExecuteNonQuery();
                cnn.Close();
                if (nbenreg > 0)
                {
                    lblerrorcli.Text = "";

                    lblmessagecli.Text = "Modification réussie du client" + " " + txtnomclient.Text;
                    OdbcDataReader drr;
                    Boolean existenreg;
                    grdcli.ColumnCount = 7;
                    grdcli.Rows.Clear();
                    cnn.Open();
                    cmd.CommandText = "select* from client where nomcli like '" + txtnomclient.Text.Replace("'", "''") + "%' order by nomcli";
                    cmd.Connection = cnn;
                    drr = cmd.ExecuteReader();
                    existenreg = drr.Read();
                    while (existenreg == true)
                    {
                        grdcli.Rows.Add(drr["idcli"], drr["nomcli"], drr["adresse"], drr["cp"], drr["ville"], drr["telephone"], drr["mail"]);
                        existenreg = drr.Read();
                    }
                    drr.Close();
                    cnn.Close();
                    
                }
                else
                {
                    lblerrorcli.Text = "Erreur modification non effectuée : nom non modifiable";
                    lblmessagecli.Text = "";
                }
                cnn.Close();
            }
           
        }

        private void grdreservation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            timeres.Value = Convert.ToDateTime(grdreservation[1, grdreservation.CurrentCell.RowIndex].Value);
            debuttime.Value = Convert.ToDateTime(grdreservation[2, grdreservation.CurrentCell.RowIndex].Value);
            fintime.Value = Convert.ToDateTime(grdreservation[3, grdreservation.CurrentCell.RowIndex].Value);
            regleonchek.Checked = Convert.ToBoolean(grdreservation[4, grdreservation.CurrentCell.RowIndex].Value);
            txtidmob.Text = Convert.ToString(grdreservation[5, grdreservation.CurrentCell.RowIndex].Value);
        }

        private void btnmodifierres_Click(object sender, EventArgs e)
        {
            // Bouton modifier réservations
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
                // Ajout des éléments dans la base de données
                try
                {
                    cnn.ConnectionString = varglob.chaineconnect;
                    cnn.Open();
                    cmd.CommandText = "update reservation set dateres='" + ladate.ToString("yyyy-MM-dd") + "', datedebut='" + ladate2.ToString("yyyy-MM-dd") + "', datefin='" + ladate3.ToString("yyyy-MM-dd") + "', regleon=" + regleonchek.Checked + ", idmob='" + txtidmob.Text + "', idcli='" + idclires[cboidclient.SelectedIndex] + "' where idcli=" + idclires[cboidclient.SelectedIndex];
                    cmd.Connection = cnn;
                    nbenreg = cmd.ExecuteNonQuery();
                    cnn.Close();
                    if (nbenreg > 0)
                    {
                        lblmessageres.Text = "Modification de la reservation réussi";
                        lblmessagecli.Text = "";
                        lblerrorres.Text = "";

                        OdbcDataReader drr;
                        Boolean existenreg;
                        grdcli.ColumnCount = 7;
                        grdcli.Rows.Clear();
                        cnn.ConnectionString = varglob.chaineconnect;
                        cnn.Open();
                        cmd.CommandText = "select* from client";
                        cmd.Connection = cnn;
                        drr = cmd.ExecuteReader();
                        existenreg = drr.Read();
                        while (existenreg == true)
                        {
                            grdcli.Rows.Add(drr["idcli"], drr["nomcli"], drr["adresse"], drr["cp"], drr["ville"], drr["telephone"], drr["mail"]);
                            existenreg = drr.Read();
                        }
                        drr.Close();
                        cnn.Close();

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

                        grdreservation.ColumnCount = 7;
                        grdreservation.Rows.Clear();
                        cnn.ConnectionString = varglob.chaineconnect;
                        cnn.Open();
                        cmd.CommandText = "select* from reservation order by idres desc";
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

                        ClearAllText(this);
                        cboidclient.SelectedItem = null;
                        cbotypmob.SelectedItem = null;
                        timeres.Value = DateTime.Now;
                        debuttime.Value = DateTime.Now;
                        fintime.Value = DateTime.Now;

                    }
                    else
                    {
                        lblerrorres.Text = "Erreur modification non effectué";
                        lblerrorcli.Text = "";
                        lblmessageres.Text = "";
                    }
                }
                catch
                {
                    MessageBox.Show("Erreur");
                    // Afficher un message d'erreur si la requete est impossible à executer
                }

            }

        }

        private void txtnomclient_TextChanged(object sender, EventArgs e)
        {
            OdbcConnection cnn = new OdbcConnection();
            OdbcCommand cmd = new OdbcCommand();
            OdbcDataReader drr;
            Boolean existenreg;
            grdcli.ColumnCount = 7;
            grdcli.Rows.Clear();
            cnn.ConnectionString = varglob.chaineconnect;
            cnn.Open();
            cmd.CommandText = "select* from client";
            cmd.Connection = cnn;
            drr = cmd.ExecuteReader();
            existenreg = drr.Read();
            while (existenreg == true)
            {
                grdcli.Rows.Add(drr["idcli"], drr["nomcli"], drr["adresse"], drr["cp"], drr["ville"], drr["telephone"], drr["mail"]);
                existenreg = drr.Read();
            }
            drr.Close();
            cnn.Close();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            OdbcConnection cnn = new OdbcConnection();
            OdbcCommand cmd = new OdbcCommand();
            OdbcDataReader drr;
            Boolean existenreg;
            grdcli.ColumnCount = 7;
            grdcli.Rows.Clear();
            cnn.ConnectionString = varglob.chaineconnect;
            cnn.Open();
            cmd.CommandText = "select* from client";
            cmd.Connection = cnn;
            drr = cmd.ExecuteReader();
            existenreg = drr.Read();
            while (existenreg == true)
            {
                grdcli.Rows.Add(drr["idcli"], drr["nomcli"], drr["adresse"], drr["cp"], drr["ville"], drr["telephone"], drr["mail"]);
                existenreg = drr.Read();
            }
            drr.Close();
            cnn.Close();
        }

        private void grdcli_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtnomclient.Text = Convert.ToString(grdcli[1, grdcli.CurrentCell.RowIndex].Value);
            txtadresseclient.Text = Convert.ToString(grdcli[2, grdcli.CurrentCell.RowIndex].Value);
            txtcodepostalclient.Text = Convert.ToString(grdcli[3, grdcli.CurrentCell.RowIndex].Value);
            txtvilleclient.Text = Convert.ToString(grdcli[4, grdcli.CurrentCell.RowIndex].Value);
            txttelephoneclient.Text = Convert.ToString(grdcli[5, grdcli.CurrentCell.RowIndex].Value);
            txtmailclient.Text = Convert.ToString(grdcli[6, grdcli.CurrentCell.RowIndex].Value);
        }



        private void btnrecherchemob_Click(object sender, EventArgs e)
        {
            // Bouton rechercher mobil-home disponibile 
            DateTime ladate, ladate2;
            ladate = debuttime.Value;
            ladate2 = fintime.Value;


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

        private void button2_Click(object sender, EventArgs e)
        {
            // Bouton rechercher mobil-home avec type
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

        private void grdmob_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtidmob.Text = Convert.ToString(grdmob[0, grdmob.CurrentCell.RowIndex].Value);
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
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
    }
}
