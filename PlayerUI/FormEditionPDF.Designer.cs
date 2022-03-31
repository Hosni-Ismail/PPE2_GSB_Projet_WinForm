namespace PlayerUI
{
    partial class FormEditionPDF
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbotypmob = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.button3 = new System.Windows.Forms.Button();
            this.grdtabtype = new Guna.UI.WinForms.GunaDataGridView();
            this.Identifiant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Libellé = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NbPersonnes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionCourte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionLongue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TarifSemaine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdtabtype)).BeginInit();
            this.SuspendLayout();
            // 
            // cbotypmob
            // 
            this.cbotypmob.BackColor = System.Drawing.Color.Transparent;
            this.cbotypmob.BaseColor = System.Drawing.Color.White;
            this.cbotypmob.BorderColor = System.Drawing.Color.Silver;
            this.cbotypmob.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbotypmob.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbotypmob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotypmob.FocusedColor = System.Drawing.Color.Empty;
            this.cbotypmob.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbotypmob.ForeColor = System.Drawing.Color.Black;
            this.cbotypmob.FormattingEnabled = true;
            this.cbotypmob.Location = new System.Drawing.Point(303, 240);
            this.cbotypmob.Name = "cbotypmob";
            this.cbotypmob.OnHoverItemBaseColor = System.Drawing.Color.SeaGreen;
            this.cbotypmob.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbotypmob.Size = new System.Drawing.Size(516, 26);
            this.cbotypmob.TabIndex = 87;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.SeaGreen;
            this.gunaLabel2.Location = new System.Drawing.Point(329, 127);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(611, 42);
            this.gunaLabel2.TabIndex = 88;
            this.gunaLabel2.Text = "Générer un document pdf de présentation des types de mobil-home \r\n\r\n";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.SeaGreen;
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(835, 564);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 41);
            this.button1.TabIndex = 89;
            this.button1.Text = "Générer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.SeaGreen;
            this.button2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button2.Location = new System.Drawing.Point(835, 693);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 41);
            this.button2.TabIndex = 90;
            this.button2.Text = "Générer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.SeaGreen;
            this.gunaLabel1.Location = new System.Drawing.Point(299, 573);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(256, 21);
            this.gunaLabel1.TabIndex = 91;
            this.gunaLabel1.Text = "Générer le plan du camping\r\n";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.SeaGreen;
            this.gunaLabel3.Location = new System.Drawing.Point(299, 702);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(307, 21);
            this.gunaLabel3.TabIndex = 92;
            this.gunaLabel3.Text = "Générer la plaquette du camping\r\n";
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.SeaGreen;
            this.button3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button3.Location = new System.Drawing.Point(294, 480);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(663, 33);
            this.button3.TabIndex = 93;
            this.button3.Text = "Générer";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // grdtabtype
            // 
            this.grdtabtype.AllowUserToAddRows = false;
            this.grdtabtype.AllowUserToDeleteRows = false;
            this.grdtabtype.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.grdtabtype.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdtabtype.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdtabtype.BackgroundColor = System.Drawing.Color.White;
            this.grdtabtype.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdtabtype.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grdtabtype.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdtabtype.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdtabtype.ColumnHeadersHeight = 19;
            this.grdtabtype.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Identifiant,
            this.Libellé,
            this.NbPersonnes,
            this.DescriptionCourte,
            this.DescriptionLongue,
            this.TarifSemaine});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdtabtype.DefaultCellStyle = dataGridViewCellStyle3;
            this.grdtabtype.EnableHeadersVisualStyles = false;
            this.grdtabtype.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grdtabtype.Location = new System.Drawing.Point(294, 287);
            this.grdtabtype.Name = "grdtabtype";
            this.grdtabtype.ReadOnly = true;
            this.grdtabtype.RowHeadersVisible = false;
            this.grdtabtype.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdtabtype.Size = new System.Drawing.Size(663, 178);
            this.grdtabtype.TabIndex = 94;
            this.grdtabtype.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.grdtabtype.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.grdtabtype.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.grdtabtype.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.grdtabtype.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.grdtabtype.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.grdtabtype.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.grdtabtype.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grdtabtype.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.SeaGreen;
            this.grdtabtype.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grdtabtype.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdtabtype.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.grdtabtype.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.grdtabtype.ThemeStyle.HeaderStyle.Height = 19;
            this.grdtabtype.ThemeStyle.ReadOnly = true;
            this.grdtabtype.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.grdtabtype.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grdtabtype.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.grdtabtype.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grdtabtype.ThemeStyle.RowsStyle.Height = 22;
            this.grdtabtype.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grdtabtype.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Identifiant
            // 
            this.Identifiant.HeaderText = "Identifiant";
            this.Identifiant.Name = "Identifiant";
            this.Identifiant.ReadOnly = true;
            // 
            // Libellé
            // 
            this.Libellé.HeaderText = "Libellé";
            this.Libellé.Name = "Libellé";
            this.Libellé.ReadOnly = true;
            // 
            // NbPersonnes
            // 
            this.NbPersonnes.HeaderText = "NbPersonnes";
            this.NbPersonnes.Name = "NbPersonnes";
            this.NbPersonnes.ReadOnly = true;
            // 
            // DescriptionCourte
            // 
            this.DescriptionCourte.HeaderText = "DescriptionCourte";
            this.DescriptionCourte.Name = "DescriptionCourte";
            this.DescriptionCourte.ReadOnly = true;
            // 
            // DescriptionLongue
            // 
            this.DescriptionLongue.HeaderText = "DescriptionLongue";
            this.DescriptionLongue.Name = "DescriptionLongue";
            this.DescriptionLongue.ReadOnly = true;
            // 
            // TarifSemaine
            // 
            this.TarifSemaine.HeaderText = "TarifSemaine";
            this.TarifSemaine.Name = "TarifSemaine";
            this.TarifSemaine.ReadOnly = true;
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.SeaGreen;
            this.button4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button4.Location = new System.Drawing.Point(835, 230);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(122, 43);
            this.button4.TabIndex = 95;
            this.button4.Text = "Rechercher";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // FormEditionPDF
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1277, 884);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.grdtabtype);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.cbotypmob);
            this.Name = "FormEditionPDF";
            this.Text = "FormEditionPDF";
            this.Load += new System.EventHandler(this.FormEditionPDF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdtabtype)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaComboBox cbotypmob;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private System.Windows.Forms.Button button3;
        private Guna.UI.WinForms.GunaDataGridView grdtabtype;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identifiant;
        private System.Windows.Forms.DataGridViewTextBoxColumn Libellé;
        private System.Windows.Forms.DataGridViewTextBoxColumn NbPersonnes;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionCourte;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionLongue;
        private System.Windows.Forms.DataGridViewTextBoxColumn TarifSemaine;
        private System.Windows.Forms.Button button4;
    }
}