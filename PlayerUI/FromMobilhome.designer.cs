namespace PlayerUI
{
    partial class FormMobilhome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMobilhome));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblsupprimermessage = new System.Windows.Forms.Label();
            this.btnsupprimertyp = new System.Windows.Forms.Button();
            this.btnmodifier = new System.Windows.Forms.Button();
            this.lblmodifiermessage = new System.Windows.Forms.Label();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.grdmob = new Guna.UI.WinForms.GunaDataGridView();
            this.Identifiant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnajoutermob = new System.Windows.Forms.Button();
            this.lblajoutermessage = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.cbotypmob = new Guna.UI.WinForms.GunaComboBox();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rechmob = new Guna.UI.WinForms.GunaTextBox();
            this.gunaButton3 = new Guna.UI.WinForms.GunaButton();
            this.txtidmob = new Guna.UI.WinForms.GunaTextBox();
            this.txtnom = new Guna.UI.WinForms.GunaTextBox();
            this.txtnumemp = new Guna.UI.WinForms.GunaTextBox();
            this.lblerrorsupp = new System.Windows.Forms.Label();
            this.lblerrorajout = new System.Windows.Forms.Label();
            this.lblerrormodif = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdmob)).BeginInit();
            this.SuspendLayout();
            // 
            // lblsupprimermessage
            // 
            this.lblsupprimermessage.AutoSize = true;
            this.lblsupprimermessage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblsupprimermessage.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsupprimermessage.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblsupprimermessage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblsupprimermessage.Location = new System.Drawing.Point(216, 772);
            this.lblsupprimermessage.Name = "lblsupprimermessage";
            this.lblsupprimermessage.Size = new System.Drawing.Size(0, 20);
            this.lblsupprimermessage.TabIndex = 50;
            // 
            // btnsupprimertyp
            // 
            this.btnsupprimertyp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsupprimertyp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnsupprimertyp.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnsupprimertyp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnsupprimertyp.Location = new System.Drawing.Point(91, 761);
            this.btnsupprimertyp.Name = "btnsupprimertyp";
            this.btnsupprimertyp.Size = new System.Drawing.Size(113, 36);
            this.btnsupprimertyp.TabIndex = 49;
            this.btnsupprimertyp.Text = "Supprimer";
            this.btnsupprimertyp.UseVisualStyleBackColor = true;
            this.btnsupprimertyp.Click += new System.EventHandler(this.btnsupprimertyp_Click_1);
            // 
            // btnmodifier
            // 
            this.btnmodifier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmodifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnmodifier.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnmodifier.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnmodifier.Location = new System.Drawing.Point(91, 696);
            this.btnmodifier.Name = "btnmodifier";
            this.btnmodifier.Size = new System.Drawing.Size(113, 36);
            this.btnmodifier.TabIndex = 27;
            this.btnmodifier.Text = "Modifier";
            this.btnmodifier.UseVisualStyleBackColor = true;
            this.btnmodifier.Click += new System.EventHandler(this.btnmodifier_Click_1);
            // 
            // lblmodifiermessage
            // 
            this.lblmodifiermessage.AutoSize = true;
            this.lblmodifiermessage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblmodifiermessage.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmodifiermessage.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblmodifiermessage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblmodifiermessage.Location = new System.Drawing.Point(216, 707);
            this.lblmodifiermessage.Name = "lblmodifiermessage";
            this.lblmodifiermessage.Size = new System.Drawing.Size(0, 20);
            this.lblmodifiermessage.TabIndex = 28;
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BaseColor = System.Drawing.Color.Green;
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton1.Image")));
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(1199, 827);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.Green;
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(37, 35);
            this.gunaButton1.TabIndex = 56;
            this.gunaButton1.Text = "gunaButton1";
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // grdmob
            // 
            this.grdmob.AllowUserToAddRows = false;
            this.grdmob.AllowUserToDeleteRows = false;
            this.grdmob.AllowUserToOrderColumns = true;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.grdmob.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.grdmob.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdmob.BackgroundColor = System.Drawing.Color.White;
            this.grdmob.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdmob.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grdmob.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdmob.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.grdmob.ColumnHeadersHeight = 19;
            this.grdmob.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Identifiant,
            this.Nom,
            this.NumEmp,
            this.IDType});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdmob.DefaultCellStyle = dataGridViewCellStyle9;
            this.grdmob.EnableHeadersVisualStyles = false;
            this.grdmob.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grdmob.Location = new System.Drawing.Point(651, 129);
            this.grdmob.Name = "grdmob";
            this.grdmob.ReadOnly = true;
            this.grdmob.RowHeadersVisible = false;
            this.grdmob.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdmob.Size = new System.Drawing.Size(585, 733);
            this.grdmob.TabIndex = 32;
            this.grdmob.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.grdmob.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.grdmob.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.grdmob.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.grdmob.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.grdmob.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.grdmob.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.grdmob.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grdmob.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.SeaGreen;
            this.grdmob.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grdmob.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdmob.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.grdmob.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.grdmob.ThemeStyle.HeaderStyle.Height = 19;
            this.grdmob.ThemeStyle.ReadOnly = true;
            this.grdmob.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.grdmob.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grdmob.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.grdmob.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grdmob.ThemeStyle.RowsStyle.Height = 22;
            this.grdmob.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grdmob.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grdmob.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdmob_CellContentClick);
            // 
            // Identifiant
            // 
            this.Identifiant.HeaderText = "Identifiant";
            this.Identifiant.Name = "Identifiant";
            this.Identifiant.ReadOnly = true;
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            // 
            // NumEmp
            // 
            this.NumEmp.HeaderText = "NumEmp";
            this.NumEmp.Name = "NumEmp";
            this.NumEmp.ReadOnly = true;
            // 
            // IDType
            // 
            this.IDType.HeaderText = "IDType";
            this.IDType.Name = "IDType";
            this.IDType.ReadOnly = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.SeaGreen;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(112, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(400, 21);
            this.label7.TabIndex = 22;
            this.label7.Text = "Ajouter, modifier ou supprimer un mobilhome";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.SeaGreen;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(112, 301);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "Identifiant :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.SeaGreen;
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(112, 527);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(165, 20);
            this.label11.TabIndex = 36;
            this.label11.Text = "Identifiant de type :";
            // 
            // btnajoutermob
            // 
            this.btnajoutermob.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnajoutermob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnajoutermob.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnajoutermob.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnajoutermob.Location = new System.Drawing.Point(91, 628);
            this.btnajoutermob.Name = "btnajoutermob";
            this.btnajoutermob.Size = new System.Drawing.Size(113, 36);
            this.btnajoutermob.TabIndex = 27;
            this.btnajoutermob.Text = "Ajouter";
            this.btnajoutermob.UseVisualStyleBackColor = true;
            this.btnajoutermob.Click += new System.EventHandler(this.btnajoutermob_Click);
            // 
            // lblajoutermessage
            // 
            this.lblajoutermessage.AutoSize = true;
            this.lblajoutermessage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblajoutermessage.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblajoutermessage.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblajoutermessage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblajoutermessage.Location = new System.Drawing.Point(216, 639);
            this.lblajoutermessage.Name = "lblajoutermessage";
            this.lblajoutermessage.Size = new System.Drawing.Size(0, 20);
            this.lblajoutermessage.TabIndex = 28;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.SeaGreen;
            this.label19.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label19.Location = new System.Drawing.Point(112, 355);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(55, 20);
            this.label19.TabIndex = 29;
            this.label19.Text = "Nom :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.SeaGreen;
            this.label20.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label20.Location = new System.Drawing.Point(112, 460);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(207, 20);
            this.label20.TabIndex = 30;
            this.label20.Text = "Numéro d\'emplacement :";
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
            this.cbotypmob.Location = new System.Drawing.Point(283, 526);
            this.cbotypmob.Name = "cbotypmob";
            this.cbotypmob.OnHoverItemBaseColor = System.Drawing.Color.SeaGreen;
            this.cbotypmob.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbotypmob.Size = new System.Drawing.Size(208, 26);
            this.cbotypmob.TabIndex = 57;
            // 
            // gunaButton2
            // 
            this.gunaButton2.AnimationHoverSpeed = 0.07F;
            this.gunaButton2.AnimationSpeed = 0.03F;
            this.gunaButton2.BaseColor = System.Drawing.Color.Green;
            this.gunaButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.gunaButton2.ForeColor = System.Drawing.Color.White;
            this.gunaButton2.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton2.Image")));
            this.gunaButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton2.Location = new System.Drawing.Point(12, 12);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton2.OnHoverImage = null;
            this.gunaButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton2.Size = new System.Drawing.Size(112, 28);
            this.gunaButton2.TabIndex = 60;
            this.gunaButton2.Text = "Retour";
            this.gunaButton2.Click += new System.EventHandler(this.gunaButton2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(976, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 21);
            this.label1.TabIndex = 61;
            this.label1.Text = "Visualisation des Mobil-Home\r\n";
            // 
            // rechmob
            // 
            this.rechmob.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.rechmob.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.rechmob.BaseColor = System.Drawing.Color.White;
            this.rechmob.BorderColor = System.Drawing.Color.Silver;
            this.rechmob.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rechmob.FocusedBaseColor = System.Drawing.Color.White;
            this.rechmob.FocusedBorderColor = System.Drawing.Color.SeaGreen;
            this.rechmob.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.rechmob.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rechmob.Location = new System.Drawing.Point(651, 97);
            this.rechmob.Name = "rechmob";
            this.rechmob.PasswordChar = '\0';
            this.rechmob.SelectedText = "";
            this.rechmob.Size = new System.Drawing.Size(535, 26);
            this.rechmob.TabIndex = 62;
            // 
            // gunaButton3
            // 
            this.gunaButton3.AnimationHoverSpeed = 0.07F;
            this.gunaButton3.AnimationSpeed = 0.03F;
            this.gunaButton3.BaseColor = System.Drawing.Color.Green;
            this.gunaButton3.BorderColor = System.Drawing.Color.Black;
            this.gunaButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton3.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton3.ForeColor = System.Drawing.Color.White;
            this.gunaButton3.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton3.Image")));
            this.gunaButton3.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton3.Location = new System.Drawing.Point(1192, 97);
            this.gunaButton3.Name = "gunaButton3";
            this.gunaButton3.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gunaButton3.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton3.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton3.OnHoverImage = null;
            this.gunaButton3.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton3.Size = new System.Drawing.Size(44, 26);
            this.gunaButton3.TabIndex = 63;
            this.gunaButton3.Click += new System.EventHandler(this.gunaButton3_Click);
            // 
            // txtidmob
            // 
            this.txtidmob.BaseColor = System.Drawing.Color.White;
            this.txtidmob.BorderColor = System.Drawing.Color.Silver;
            this.txtidmob.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtidmob.FocusedBaseColor = System.Drawing.Color.White;
            this.txtidmob.FocusedBorderColor = System.Drawing.Color.SeaGreen;
            this.txtidmob.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtidmob.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidmob.Location = new System.Drawing.Point(219, 299);
            this.txtidmob.Name = "txtidmob";
            this.txtidmob.PasswordChar = '\0';
            this.txtidmob.SelectedText = "";
            this.txtidmob.Size = new System.Drawing.Size(75, 29);
            this.txtidmob.TabIndex = 64;
            this.txtidmob.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtidmob_KeyPress_1);
            // 
            // txtnom
            // 
            this.txtnom.BaseColor = System.Drawing.Color.White;
            this.txtnom.BorderColor = System.Drawing.Color.Silver;
            this.txtnom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnom.FocusedBaseColor = System.Drawing.Color.White;
            this.txtnom.FocusedBorderColor = System.Drawing.Color.SeaGreen;
            this.txtnom.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtnom.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnom.Location = new System.Drawing.Point(173, 355);
            this.txtnom.Multiline = true;
            this.txtnom.Name = "txtnom";
            this.txtnom.PasswordChar = '\0';
            this.txtnom.SelectedText = "";
            this.txtnom.Size = new System.Drawing.Size(318, 85);
            this.txtnom.TabIndex = 65;
            // 
            // txtnumemp
            // 
            this.txtnumemp.BaseColor = System.Drawing.Color.White;
            this.txtnumemp.BorderColor = System.Drawing.Color.Silver;
            this.txtnumemp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnumemp.FocusedBaseColor = System.Drawing.Color.White;
            this.txtnumemp.FocusedBorderColor = System.Drawing.Color.SeaGreen;
            this.txtnumemp.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtnumemp.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumemp.Location = new System.Drawing.Point(325, 456);
            this.txtnumemp.Name = "txtnumemp";
            this.txtnumemp.PasswordChar = '\0';
            this.txtnumemp.SelectedText = "";
            this.txtnumemp.Size = new System.Drawing.Size(75, 29);
            this.txtnumemp.TabIndex = 66;
            this.txtnumemp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnumemp_KeyPress_1);
            // 
            // lblerrorsupp
            // 
            this.lblerrorsupp.AutoSize = true;
            this.lblerrorsupp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblerrorsupp.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerrorsupp.ForeColor = System.Drawing.Color.Red;
            this.lblerrorsupp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblerrorsupp.Location = new System.Drawing.Point(210, 769);
            this.lblerrorsupp.Name = "lblerrorsupp";
            this.lblerrorsupp.Size = new System.Drawing.Size(0, 20);
            this.lblerrorsupp.TabIndex = 69;
            // 
            // lblerrorajout
            // 
            this.lblerrorajout.AutoSize = true;
            this.lblerrorajout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblerrorajout.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerrorajout.ForeColor = System.Drawing.Color.Red;
            this.lblerrorajout.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblerrorajout.Location = new System.Drawing.Point(210, 636);
            this.lblerrorajout.Name = "lblerrorajout";
            this.lblerrorajout.Size = new System.Drawing.Size(0, 20);
            this.lblerrorajout.TabIndex = 67;
            // 
            // lblerrormodif
            // 
            this.lblerrormodif.AutoSize = true;
            this.lblerrormodif.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblerrormodif.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerrormodif.ForeColor = System.Drawing.Color.Red;
            this.lblerrormodif.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblerrormodif.Location = new System.Drawing.Point(210, 704);
            this.lblerrormodif.Name = "lblerrormodif";
            this.lblerrormodif.Size = new System.Drawing.Size(0, 20);
            this.lblerrormodif.TabIndex = 68;
            // 
            // FormMobilhome
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1277, 884);
            this.Controls.Add(this.lblerrorsupp);
            this.Controls.Add(this.lblerrorajout);
            this.Controls.Add(this.lblerrormodif);
            this.Controls.Add(this.txtnumemp);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.txtidmob);
            this.Controls.Add(this.gunaButton3);
            this.Controls.Add(this.rechmob);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gunaButton2);
            this.Controls.Add(this.cbotypmob);
            this.Controls.Add(this.lblsupprimermessage);
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.btnsupprimertyp);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.grdmob);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.btnmodifier);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.btnajoutermob);
            this.Controls.Add(this.lblajoutermessage);
            this.Controls.Add(this.lblmodifiermessage);
            this.Name = "FormMobilhome";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FormMobilhome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdmob)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblsupprimermessage;
        private System.Windows.Forms.Button btnsupprimertyp;
        private System.Windows.Forms.Button btnmodifier;
        private System.Windows.Forms.Label lblmodifiermessage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnajoutermob;
        private System.Windows.Forms.Label lblajoutermessage;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private Guna.UI.WinForms.GunaDataGridView grdmob;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identifiant;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDType;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaComboBox cbotypmob;
        private Guna.UI.WinForms.GunaButton gunaButton2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox rechmob;
        private Guna.UI.WinForms.GunaButton gunaButton3;
        private Guna.UI.WinForms.GunaTextBox txtidmob;
        private Guna.UI.WinForms.GunaTextBox txtnom;
        private Guna.UI.WinForms.GunaTextBox txtnumemp;
        private System.Windows.Forms.Label lblerrorsupp;
        private System.Windows.Forms.Label lblerrorajout;
        private System.Windows.Forms.Label lblerrormodif;
    }
}