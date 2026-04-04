namespace DLWMS.WinApp.IspitIB230030
{
    partial class frmStipendijeIB230030
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
            components = new System.ComponentModel.Container();
            btnPotvrda = new Button();
            cbStipendija = new ComboBox();
            txtIznos = new TextBox();
            label1 = new Label();
            btnDodaj = new Button();
            err = new ErrorProvider(components);
            dgvStipendije = new DataGridView();
            Godina = new DataGridViewTextBoxColumn();
            Stipendija = new DataGridViewTextBoxColumn();
            Iznos = new DataGridViewTextBoxColumn();
            Ukupno = new DataGridViewTextBoxColumn();
            Aktivan = new DataGridViewCheckBoxColumn();
            cbGodina = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            btnGenerisi = new Button();
            errorProvider1 = new ErrorProvider(components);
            groupBox1 = new GroupBox();
            txtInfo = new TextBox();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvStipendije).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnPotvrda
            // 
            btnPotvrda.Location = new Point(711, 332);
            btnPotvrda.Name = "btnPotvrda";
            btnPotvrda.Size = new Size(94, 29);
            btnPotvrda.TabIndex = 0;
            btnPotvrda.Text = "Potvrda";
            btnPotvrda.UseVisualStyleBackColor = true;
            btnPotvrda.Click += btnPotvrda_Click;
            // 
            // cbStipendija
            // 
            cbStipendija.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStipendija.FormattingEnabled = true;
            cbStipendija.Location = new Point(218, 60);
            cbStipendija.Name = "cbStipendija";
            cbStipendija.Size = new Size(200, 28);
            cbStipendija.TabIndex = 1;
            // 
            // txtIznos
            // 
            txtIznos.Location = new Point(424, 61);
            txtIznos.Name = "txtIznos";
            txtIznos.Size = new Size(167, 27);
            txtIznos.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(218, 37);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 3;
            label1.Text = "Stipendija:";
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(597, 61);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(94, 29);
            btnDodaj.TabIndex = 4;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // dgvStipendije
            // 
            dgvStipendije.AllowUserToAddRows = false;
            dgvStipendije.AllowUserToDeleteRows = false;
            dgvStipendije.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStipendije.Columns.AddRange(new DataGridViewColumn[] { Godina, Stipendija, Iznos, Ukupno, Aktivan });
            dgvStipendije.Location = new Point(12, 93);
            dgvStipendije.Name = "dgvStipendije";
            dgvStipendije.ReadOnly = true;
            dgvStipendije.RowHeadersWidth = 51;
            dgvStipendije.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStipendije.Size = new Size(793, 226);
            dgvStipendije.TabIndex = 5;
            // 
            // Godina
            // 
            Godina.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Godina.DataPropertyName = "Godina";
            Godina.HeaderText = "Godina";
            Godina.MinimumWidth = 6;
            Godina.Name = "Godina";
            Godina.ReadOnly = true;
            // 
            // Stipendija
            // 
            Stipendija.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Stipendija.DataPropertyName = "Stipendija";
            Stipendija.HeaderText = "Stipendija";
            Stipendija.MinimumWidth = 6;
            Stipendija.Name = "Stipendija";
            Stipendija.ReadOnly = true;
            // 
            // Iznos
            // 
            Iznos.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Iznos.DataPropertyName = "Iznos";
            Iznos.HeaderText = "Mjesečni iznos";
            Iznos.MinimumWidth = 6;
            Iznos.Name = "Iznos";
            Iznos.ReadOnly = true;
            // 
            // Ukupno
            // 
            Ukupno.DataPropertyName = "Ukupno";
            Ukupno.HeaderText = "Ukupni iznos";
            Ukupno.MinimumWidth = 6;
            Ukupno.Name = "Ukupno";
            Ukupno.ReadOnly = true;
            Ukupno.Width = 125;
            // 
            // Aktivan
            // 
            Aktivan.DataPropertyName = "Aktivan";
            Aktivan.HeaderText = "Aktivna";
            Aktivan.MinimumWidth = 6;
            Aktivan.Name = "Aktivan";
            Aktivan.ReadOnly = true;
            Aktivan.Width = 125;
            // 
            // cbGodina
            // 
            cbGodina.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGodina.FormattingEnabled = true;
            cbGodina.Items.AddRange(new object[] { "2025", "2024", "2023", "2022", "2021", "2020" });
            cbGodina.Location = new Point(12, 60);
            cbGodina.Name = "cbGodina";
            cbGodina.Size = new Size(200, 28);
            cbGodina.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 37);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 3;
            label2.Text = "Godina:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(424, 37);
            label3.Name = "label3";
            label3.Size = new Size(154, 20);
            label3.TabIndex = 3;
            label3.Text = "Mjesečni iznos (BAM):";
            // 
            // btnGenerisi
            // 
            btnGenerisi.Location = new Point(12, 332);
            btnGenerisi.Name = "btnGenerisi";
            btnGenerisi.Size = new Size(218, 29);
            btnGenerisi.TabIndex = 6;
            btnGenerisi.Text = "Generiši stipendije >>>>>";
            btnGenerisi.UseVisualStyleBackColor = true;
            btnGenerisi.Click += btnGenerisi_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtInfo);
            groupBox1.Location = new Point(12, 368);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(795, 224);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Generator info";
            // 
            // txtInfo
            // 
            txtInfo.Location = new Point(6, 26);
            txtInfo.Multiline = true;
            txtInfo.Name = "txtInfo";
            txtInfo.Size = new Size(783, 192);
            txtInfo.TabIndex = 0;
            // 
            // frmStipendijeIB230030
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(819, 604);
            Controls.Add(groupBox1);
            Controls.Add(btnGenerisi);
            Controls.Add(dgvStipendije);
            Controls.Add(btnDodaj);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtIznos);
            Controls.Add(cbGodina);
            Controls.Add(cbStipendija);
            Controls.Add(btnPotvrda);
            Name = "frmStipendijeIB230030";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Upravljanje stipendijama";
            FormClosed += frmStipendijeIB230030_FormClosed;
            Load += frmStipendijeIB230030_Load;
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvStipendije).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPotvrda;
        private ComboBox cbStipendija;
        private TextBox txtIznos;
        private Label label1;
        private Button btnDodaj;
        private ErrorProvider err;
        private DataGridView dgvStipendije;
        private Label label3;
        private Label label2;
        private ComboBox cbGodina;
        private DataGridViewTextBoxColumn Godina;
        private DataGridViewTextBoxColumn Stipendija;
        private DataGridViewTextBoxColumn Iznos;
        private DataGridViewTextBoxColumn Ukupno;
        private DataGridViewCheckBoxColumn Aktivan;
        private GroupBox groupBox1;
        private TextBox txtInfo;
        private Button btnGenerisi;
        private ErrorProvider errorProvider1;
    }
}