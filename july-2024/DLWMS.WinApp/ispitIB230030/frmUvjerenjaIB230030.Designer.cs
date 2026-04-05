namespace DLWMS.WinApp.ispitIB230030
{
    partial class frmUvjerenjaIB230030
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
            btnNoviZahtjev = new Button();
            dgvUvjerenja = new DataGridView();
            Vrijeme = new DataGridViewTextBoxColumn();
            Vrsta = new DataGridViewTextBoxColumn();
            Svrha = new DataGridViewTextBoxColumn();
            Uplatnica = new DataGridViewImageColumn();
            Prinatno = new DataGridViewCheckBoxColumn();
            Brisi = new DataGridViewButtonColumn();
            Printaj = new DataGridViewButtonColumn();
            btnDodaj = new Button();
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            label1 = new Label();
            txtInfo = new TextBox();
            txtBroj = new TextBox();
            txtSvrha = new TextBox();
            cbVrsta = new ComboBox();
            err = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvUvjerenja).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // btnNoviZahtjev
            // 
            btnNoviZahtjev.Location = new Point(813, 12);
            btnNoviZahtjev.Name = "btnNoviZahtjev";
            btnNoviZahtjev.Size = new Size(127, 29);
            btnNoviZahtjev.TabIndex = 0;
            btnNoviZahtjev.Text = "Novi zahtjev";
            btnNoviZahtjev.UseVisualStyleBackColor = true;
            btnNoviZahtjev.Click += btnNoviZahtjev_Click;
            // 
            // dgvUvjerenja
            // 
            dgvUvjerenja.AllowUserToAddRows = false;
            dgvUvjerenja.AllowUserToDeleteRows = false;
            dgvUvjerenja.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUvjerenja.Columns.AddRange(new DataGridViewColumn[] { Vrijeme, Vrsta, Svrha, Uplatnica, Prinatno, Brisi, Printaj });
            dgvUvjerenja.Location = new Point(12, 47);
            dgvUvjerenja.Name = "dgvUvjerenja";
            dgvUvjerenja.ReadOnly = true;
            dgvUvjerenja.RowHeadersWidth = 51;
            dgvUvjerenja.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUvjerenja.Size = new Size(928, 215);
            dgvUvjerenja.TabIndex = 1;
            dgvUvjerenja.CellContentClick += dgvUvjerenja_CellContentClick;
            // 
            // Vrijeme
            // 
            Vrijeme.DataPropertyName = "Vrijeme";
            Vrijeme.HeaderText = "Datum";
            Vrijeme.MinimumWidth = 6;
            Vrijeme.Name = "Vrijeme";
            Vrijeme.ReadOnly = true;
            Vrijeme.Width = 125;
            // 
            // Vrsta
            // 
            Vrsta.DataPropertyName = "Vrsta";
            Vrsta.HeaderText = "Vrsta";
            Vrsta.MinimumWidth = 6;
            Vrsta.Name = "Vrsta";
            Vrsta.ReadOnly = true;
            Vrsta.Width = 125;
            // 
            // Svrha
            // 
            Svrha.DataPropertyName = "Svrha";
            Svrha.HeaderText = "Svrha";
            Svrha.MinimumWidth = 6;
            Svrha.Name = "Svrha";
            Svrha.ReadOnly = true;
            Svrha.Width = 125;
            // 
            // Uplatnica
            // 
            Uplatnica.DataPropertyName = "Uplatnica";
            Uplatnica.HeaderText = "Uplatnica";
            Uplatnica.ImageLayout = DataGridViewImageCellLayout.Stretch;
            Uplatnica.MinimumWidth = 6;
            Uplatnica.Name = "Uplatnica";
            Uplatnica.ReadOnly = true;
            Uplatnica.Resizable = DataGridViewTriState.True;
            Uplatnica.SortMode = DataGridViewColumnSortMode.Automatic;
            Uplatnica.Width = 125;
            // 
            // Prinatno
            // 
            Prinatno.DataPropertyName = "Prinatno";
            Prinatno.HeaderText = "Printano";
            Prinatno.MinimumWidth = 6;
            Prinatno.Name = "Prinatno";
            Prinatno.ReadOnly = true;
            Prinatno.Width = 125;
            // 
            // Brisi
            // 
            Brisi.HeaderText = "";
            Brisi.MinimumWidth = 6;
            Brisi.Name = "Brisi";
            Brisi.ReadOnly = true;
            Brisi.Text = "Brisi";
            Brisi.UseColumnTextForButtonValue = true;
            Brisi.Width = 125;
            // 
            // Printaj
            // 
            Printaj.HeaderText = "";
            Printaj.MinimumWidth = 6;
            Printaj.Name = "Printaj";
            Printaj.ReadOnly = true;
            Printaj.Text = "Printaj";
            Printaj.UseColumnTextForButtonValue = true;
            Printaj.Width = 125;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(647, 52);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(94, 29);
            btnDodaj.TabIndex = 2;
            btnDodaj.Text = "Dodaj =>";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtInfo);
            groupBox1.Controls.Add(txtBroj);
            groupBox1.Controls.Add(txtSvrha);
            groupBox1.Controls.Add(btnDodaj);
            groupBox1.Controls.Add(cbVrsta);
            groupBox1.Location = new Point(12, 291);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(919, 260);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dodavanje zahtjeva za izdavanjem uvjerenja";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(508, 31);
            label3.Name = "label3";
            label3.Size = new Size(98, 20);
            label3.TabIndex = 5;
            label3.Text = "Broj zahtjeva:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(257, 31);
            label2.Name = "label2";
            label2.Size = new Size(112, 20);
            label2.TabIndex = 5;
            label2.Text = "Svrha uvjerenja:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 84);
            label4.Name = "label4";
            label4.Size = new Size(38, 20);
            label4.TabIndex = 5;
            label4.Text = "Info:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 30);
            label1.Name = "label1";
            label1.Size = new Size(108, 20);
            label1.TabIndex = 5;
            label1.Text = "Vrsta uvjerenja:";
            // 
            // txtInfo
            // 
            txtInfo.Location = new Point(6, 108);
            txtInfo.Multiline = true;
            txtInfo.Name = "txtInfo";
            txtInfo.Size = new Size(907, 146);
            txtInfo.TabIndex = 4;
            // 
            // txtBroj
            // 
            txtBroj.Location = new Point(508, 54);
            txtBroj.Name = "txtBroj";
            txtBroj.Size = new Size(133, 27);
            txtBroj.TabIndex = 4;
            // 
            // txtSvrha
            // 
            txtSvrha.Location = new Point(257, 54);
            txtSvrha.Name = "txtSvrha";
            txtSvrha.Size = new Size(245, 27);
            txtSvrha.TabIndex = 4;
            // 
            // cbVrsta
            // 
            cbVrsta.FormattingEnabled = true;
            cbVrsta.Items.AddRange(new object[] { "Uvjerenje o položenim predmetima", "Uvjerenje o statusu studenta" });
            cbVrsta.Location = new Point(6, 53);
            cbVrsta.Name = "cbVrsta";
            cbVrsta.Size = new Size(245, 28);
            cbVrsta.TabIndex = 0;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // frmUvjerenjaIB230030
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 563);
            Controls.Add(groupBox1);
            Controls.Add(dgvUvjerenja);
            Controls.Add(btnNoviZahtjev);
            Name = "frmUvjerenjaIB230030";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Broj uvjerenja ->";
            Load += frmUvjerenjaIB230030_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUvjerenja).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnNoviZahtjev;
        private DataGridView dgvUvjerenja;
        private DataGridViewTextBoxColumn Vrijeme;
        private DataGridViewTextBoxColumn Vrsta;
        private DataGridViewTextBoxColumn Svrha;
        private DataGridViewImageColumn Uplatnica;
        private DataGridViewCheckBoxColumn Prinatno;
        private DataGridViewButtonColumn Brisi;
        private DataGridViewButtonColumn Printaj;
        private Button btnDodaj;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label1;
        private TextBox txtInfo;
        private TextBox txtBroj;
        private TextBox txtSvrha;
        private ComboBox cbVrsta;
        private ErrorProvider err;
    }
}