namespace DLWMS.WinApp.ispitIB230030
{
    partial class frmRazmjeneIB230030
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
            btnSacuvaj = new Button();
            dtpPocetak = new DateTimePicker();
            err = new ErrorProvider(components);
            label1 = new Label();
            cbUniverzitet = new ComboBox();
            dgvRazmjene = new DataGridView();
            Univerzitet = new DataGridViewTextBoxColumn();
            DatumPocetak = new DataGridViewTextBoxColumn();
            DatumKraj = new DataGridViewTextBoxColumn();
            ECTS = new DataGridViewTextBoxColumn();
            Okoncana = new DataGridViewCheckBoxColumn();
            Obrisi = new DataGridViewButtonColumn();
            btnPotvrda = new Button();
            dtpKraj = new DateTimePicker();
            cbDrzava = new ComboBox();
            txtBrojKredita = new TextBox();
            label2 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            label7 = new Label();
            txtInfo = new TextBox();
            label6 = new Label();
            label5 = new Label();
            txtEcts = new TextBox();
            txtBrojRazmjena = new TextBox();
            cbUni = new ComboBox();
            label4 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRazmjene).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(793, 48);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(115, 29);
            btnSacuvaj.TabIndex = 0;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // dtpPocetak
            // 
            dtpPocetak.Location = new Point(537, 12);
            dtpPocetak.Name = "dtpPocetak";
            dtpPocetak.Size = new Size(250, 27);
            dtpPocetak.TabIndex = 1;
            dtpPocetak.Value = new DateTime(2020, 1, 23, 0, 0, 0, 0);
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 21);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 2;
            label1.Text = "Država:";
            // 
            // cbUniverzitet
            // 
            cbUniverzitet.DropDownStyle = ComboBoxStyle.DropDownList;
            cbUniverzitet.FormattingEnabled = true;
            cbUniverzitet.Location = new Point(226, 44);
            cbUniverzitet.Name = "cbUniverzitet";
            cbUniverzitet.Size = new Size(212, 28);
            cbUniverzitet.TabIndex = 3;
            // 
            // dgvRazmjene
            // 
            dgvRazmjene.AllowUserToAddRows = false;
            dgvRazmjene.AllowUserToDeleteRows = false;
            dgvRazmjene.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRazmjene.Columns.AddRange(new DataGridViewColumn[] { Univerzitet, DatumPocetak, DatumKraj, ECTS, Okoncana, Obrisi });
            dgvRazmjene.Location = new Point(8, 80);
            dgvRazmjene.Name = "dgvRazmjene";
            dgvRazmjene.ReadOnly = true;
            dgvRazmjene.RowHeadersWidth = 51;
            dgvRazmjene.Size = new Size(900, 250);
            dgvRazmjene.TabIndex = 4;
            dgvRazmjene.CellContentClick += dgvRazmjene_CellContentClick;
            // 
            // Univerzitet
            // 
            Univerzitet.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Univerzitet.DataPropertyName = "Univerzitet";
            Univerzitet.HeaderText = "Univerzitet";
            Univerzitet.MinimumWidth = 6;
            Univerzitet.Name = "Univerzitet";
            Univerzitet.ReadOnly = true;
            // 
            // DatumPocetak
            // 
            DatumPocetak.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DatumPocetak.DataPropertyName = "DatumPocetak";
            DatumPocetak.HeaderText = "Početak";
            DatumPocetak.MinimumWidth = 6;
            DatumPocetak.Name = "DatumPocetak";
            DatumPocetak.ReadOnly = true;
            // 
            // DatumKraj
            // 
            DatumKraj.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DatumKraj.DataPropertyName = "DatumKraj";
            DatumKraj.HeaderText = "Kraj";
            DatumKraj.MinimumWidth = 6;
            DatumKraj.Name = "DatumKraj";
            DatumKraj.ReadOnly = true;
            // 
            // ECTS
            // 
            ECTS.DataPropertyName = "ECTS";
            ECTS.HeaderText = "ECTS";
            ECTS.MinimumWidth = 6;
            ECTS.Name = "ECTS";
            ECTS.ReadOnly = true;
            ECTS.Width = 125;
            // 
            // Okoncana
            // 
            Okoncana.DataPropertyName = "Okoncana";
            Okoncana.HeaderText = "Okoncana";
            Okoncana.MinimumWidth = 6;
            Okoncana.Name = "Okoncana";
            Okoncana.ReadOnly = true;
            Okoncana.Resizable = DataGridViewTriState.True;
            Okoncana.SortMode = DataGridViewColumnSortMode.Automatic;
            Okoncana.Width = 125;
            // 
            // Obrisi
            // 
            Obrisi.HeaderText = "";
            Obrisi.MinimumWidth = 6;
            Obrisi.Name = "Obrisi";
            Obrisi.ReadOnly = true;
            Obrisi.Text = "Obrisi";
            Obrisi.UseColumnTextForButtonValue = true;
            Obrisi.Width = 125;
            // 
            // btnPotvrda
            // 
            btnPotvrda.Location = new Point(793, 341);
            btnPotvrda.Name = "btnPotvrda";
            btnPotvrda.Size = new Size(115, 29);
            btnPotvrda.TabIndex = 0;
            btnPotvrda.Text = "Potvrda";
            btnPotvrda.UseVisualStyleBackColor = true;
            btnPotvrda.Click += btnPotvrda_Click;
            // 
            // dtpKraj
            // 
            dtpKraj.Location = new Point(537, 47);
            dtpKraj.Name = "dtpKraj";
            dtpKraj.Size = new Size(250, 27);
            dtpKraj.TabIndex = 1;
            // 
            // cbDrzava
            // 
            cbDrzava.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDrzava.FormattingEnabled = true;
            cbDrzava.Location = new Point(8, 44);
            cbDrzava.Name = "cbDrzava";
            cbDrzava.Size = new Size(212, 28);
            cbDrzava.TabIndex = 3;
            cbDrzava.SelectedIndexChanged += cbDrzava_SelectedIndexChanged;
            // 
            // txtBrojKredita
            // 
            txtBrojKredita.Location = new Point(446, 44);
            txtBrojKredita.Name = "txtBrojKredita";
            txtBrojKredita.Size = new Size(85, 27);
            txtBrojKredita.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(226, 21);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 2;
            label2.Text = "Univerzitet:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(444, 21);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 2;
            label3.Text = "Broj kredita:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtInfo);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtEcts);
            groupBox1.Controls.Add(txtBrojRazmjena);
            groupBox1.Controls.Add(cbUni);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(8, 376);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(900, 256);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Generator razmjena";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(199, 23);
            label7.Name = "label7";
            label7.Size = new Size(38, 20);
            label7.TabIndex = 8;
            label7.Text = "Info:";
            // 
            // txtInfo
            // 
            txtInfo.Location = new Point(199, 48);
            txtInfo.Multiline = true;
            txtInfo.Name = "txtInfo";
            txtInfo.Size = new Size(695, 202);
            txtInfo.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(102, 72);
            label6.Name = "label6";
            label6.Size = new Size(38, 20);
            label6.TabIndex = 6;
            label6.Text = "ects:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(0, 72);
            label5.Name = "label5";
            label5.Size = new Size(104, 20);
            label5.TabIndex = 5;
            label5.Text = "Broj razmjena:";
            // 
            // txtEcts
            // 
            txtEcts.Location = new Point(92, 92);
            txtEcts.Name = "txtEcts";
            txtEcts.Size = new Size(101, 27);
            txtEcts.TabIndex = 4;
            // 
            // txtBrojRazmjena
            // 
            txtBrojRazmjena.Location = new Point(3, 92);
            txtBrojRazmjena.Name = "txtBrojRazmjena";
            txtBrojRazmjena.Size = new Size(93, 27);
            txtBrojRazmjena.TabIndex = 3;
            // 
            // cbUni
            // 
            cbUni.DropDownStyle = ComboBoxStyle.DropDownList;
            cbUni.FormattingEnabled = true;
            cbUni.Location = new Point(3, 41);
            cbUni.Name = "cbUni";
            cbUni.Size = new Size(173, 28);
            cbUni.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(0, 23);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 1;
            label4.Text = "Univerzitet:";
            // 
            // button1
            // 
            button1.Location = new Point(0, 125);
            button1.Name = "button1";
            button1.Size = new Size(193, 29);
            button1.TabIndex = 0;
            button1.Text = "Generiši razmjene >>>>";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmRazmjeneIB230030
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 631);
            Controls.Add(groupBox1);
            Controls.Add(txtBrojKredita);
            Controls.Add(dgvRazmjene);
            Controls.Add(cbDrzava);
            Controls.Add(cbUniverzitet);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtpKraj);
            Controls.Add(dtpPocetak);
            Controls.Add(btnPotvrda);
            Controls.Add(btnSacuvaj);
            Name = "frmRazmjeneIB230030";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Razmjena studenta: placeholder";
            Load += frmRazmjeneIB230030_Load;
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRazmjene).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSacuvaj;
        private DateTimePicker dtpPocetak;
        private ErrorProvider err;
        private TextBox txtBrojKredita;
        private DataGridView dgvRazmjene;
        private ComboBox cbDrzava;
        private ComboBox cbUniverzitet;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dtpKraj;
        private Button btnPotvrda;
        private DataGridViewTextBoxColumn Univerzitet;
        private DataGridViewTextBoxColumn DatumPocetak;
        private DataGridViewTextBoxColumn DatumKraj;
        private DataGridViewTextBoxColumn ECTS;
        private DataGridViewCheckBoxColumn Okoncana;
        private DataGridViewButtonColumn Obrisi;
        private GroupBox groupBox1;
        private Label label7;
        private TextBox txtInfo;
        private Label label6;
        private Label label5;
        private TextBox txtEcts;
        private TextBox txtBrojRazmjena;
        private ComboBox cbUni;
        private Label label4;
        private Button button1;
    }
}