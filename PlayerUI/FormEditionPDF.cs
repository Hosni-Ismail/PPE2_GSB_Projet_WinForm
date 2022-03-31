using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;


namespace PlayerUI
{
    using System.Data.Odbc;
    public partial class FormEditionPDF : Form
    {
        List<string> typemob = new List<string>();
        public FormEditionPDF()
        {
            InitializeComponent();
        }


        private void FormEditionPDF_Load(object sender, EventArgs e)
        {

            varglob.chaineconnect = System.IO.File.ReadAllText(Application.StartupPath + "\\connexion.ini");


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

            grdtabtype.ColumnCount = 6;
            grdtabtype.Rows.Clear();
            cnn.ConnectionString = varglob.chaineconnect;
            cnn.Open();
            cmd.CommandText = "select * from typemobil";
            cmd.Connection = cnn;
            drr = cmd.ExecuteReader();
            existenreg = drr.Read();
            while (existenreg == true)
            {
                grdtabtype.Rows.Add(drr["idtyp"], drr["libtyp"], drr["nbpers"], drr["descripcourte"], drr["descriplongue"], drr["tarifsemaine"]);
                existenreg = drr.Read();
            }
            drr.Close();
            cnn.Close();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo = new System.Diagnostics.ProcessStartInfo("plancamping.pdf");
            p.Start();
            p.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo = new System.Diagnostics.ProcessStartInfo("plaquettecamping.pdf");
            p.Start();
            p.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            OdbcConnection cnn = new OdbcConnection();
            OdbcCommand cmd = new OdbcCommand();
            OdbcDataReader drr;
            Boolean existenreg;

            Document doc = new Document();
            PdfWriter.GetInstance(doc, new FileStream("Brochure type de mobil-home.pdf", FileMode.Create));
            doc.Open();
            doc.Add(new Paragraph("Brochure de type de mobil-home"));
            doc.Add(new Paragraph("\n" + Convert.ToString(grdtabtype[4, grdtabtype.CurrentCell.RowIndex].Value)));
            cnn.ConnectionString = varglob.chaineconnect;
            cnn.Open();
            cmd.CommandText = "select nomfichier from Photo where idtyp =" + Convert.ToString(grdtabtype[0, grdtabtype.CurrentCell.RowIndex].Value);
            cmd.Connection = cnn;
            drr = cmd.ExecuteReader();
            existenreg = drr.Read();
            while (existenreg == true)
            {
                iTextSharp.text.Image image1 = iTextSharp.text.Image.GetInstance(Application.StartupPath + "\\photo\\" + drr["nomfichier"]);
                doc.SetPageSize(new iTextSharp.text.Rectangle(0, 0, Width, Height));
                doc.SetMargins(0, 0, 0, 0);
                doc.Add(image1);
                existenreg = drr.Read();
            }
            drr.Close();
            cnn.Close();
            doc.Close();
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo = new System.Diagnostics.ProcessStartInfo("Brochure type de mobil-home.pdf");
            p.Start();
            p.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
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
                grdtabtype.ColumnCount = 5;
                grdtabtype.Rows.Clear();
                cnn.ConnectionString = varglob.chaineconnect;
                cnn.Open();
                cmd.CommandText = "select* from typemobil where idtyp='" + typemob[cbotypmob.SelectedIndex] + "'";
                cmd.Connection = cnn;
                drr = cmd.ExecuteReader();
                existenreg = drr.Read();
                while (existenreg == true)
                {
                    grdtabtype.Rows.Add(drr["idtyp"], drr["libtyp"], drr["nbpers"], drr["descripcourte"], drr["descriplongue"], drr["tarifsemaine"]);
                    existenreg = drr.Read();
                }
                drr.Close();
                cnn.Close();
            }
        }
    }
}

