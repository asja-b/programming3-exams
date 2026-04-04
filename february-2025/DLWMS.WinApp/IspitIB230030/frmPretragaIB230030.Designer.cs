namespace DLWMS.WinApp.IspitIB230030
{
    partial class frmPretragaIB230030
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
            btnStipendijePoGodinama = new Button();
            cbGodina = new ComboBox();
            label1 = new Label();
            dgvStudentiStipendije = new DataGridView();
            Student = new DataGridViewTextBoxColumn();
            Godina = new DataGridViewTextBoxColumn();
            Stipendija = new DataGridViewTextBoxColumn();
            Iznos = new DataGridViewTextBoxColumn();
            Ukupno = new DataGridViewTextBoxColumn();
            Ukloni = new DataGridViewButtonColumn();
            cbStipendije = new ComboBox();
            btnDodajStipendiju = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvStudentiStipendije).BeginInit();
            SuspendLayout();
            // 
            // btnStipendijePoGodinama
            // 
            btnStipendijePoGodinama.Location = new Point(978, 44);
            btnStipendijePoGodinama.Name = "btnStipendijePoGodinama";
            btnStipendijePoGodinama.Size = new Size(191, 29);
            btnStipendijePoGodinama.TabIndex = 0;
            btnStipendijePoGodinama.Text = "Stipendije po godinama";
            btnStipendijePoGodinama.UseVisualStyleBackColor = true;
            btnStipendijePoGodinama.Click += btnStipendijePoGodinama_Click;
            // 
            // cbGodina
            // 
            cbGodina.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGodina.FormattingEnabled = true;
            cbGodina.Items.AddRange(new object[] { "2025", "2024", "2023", "2022", "2021", "2020" });
            cbGodina.Location = new Point(0, 44);
            cbGodina.Name = "cbGodina";
            cbGodina.Size = new Size(196, 28);
            cbGodina.TabIndex = 1;
            cbGodina.SelectedIndexChanged += cbGodina_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 21);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 2;
            label1.Text = "Godina:";
            // 
            // dgvStudentiStipendije
            // 
            dgvStudentiStipendije.AllowUserToAddRows = false;
            dgvStudentiStipendije.AllowUserToDeleteRows = false;
            dgvStudentiStipendije.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudentiStipendije.Columns.AddRange(new DataGridViewColumn[] { Student, Godina, Stipendija, Iznos, Ukupno, Ukloni });
            dgvStudentiStipendije.Location = new Point(0, 78);
            dgvStudentiStipendije.Name = "dgvStudentiStipendije";
            dgvStudentiStipendije.ReadOnly = true;
            dgvStudentiStipendije.RowHeadersWidth = 51;
            dgvStudentiStipendije.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudentiStipendije.Size = new Size(1169, 307);
            dgvStudentiStipendije.TabIndex = 3;
            dgvStudentiStipendije.CellContentClick += dgvStudentiStipendije_CellContentClick;
            dgvStudentiStipendije.CellDoubleClick += dgvStudentiStipendije_CellDoubleClick;
            // 
            // Student
            // 
            Student.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Student.DataPropertyName = "Student";
            Student.HeaderText = "(Indeks) Ime i prezime";
            Student.MinimumWidth = 6;
            Student.Name = "Student";
            Student.ReadOnly = true;
            // 
            // Godina
            // 
            Godina.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Godina.DataPropertyName = "GodinaInfo";
            Godina.HeaderText = "Godina";
            Godina.MinimumWidth = 6;
            Godina.Name = "Godina";
            Godina.ReadOnly = true;
            // 
            // Stipendija
            // 
            Stipendija.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Stipendija.DataPropertyName = "StipendijaInfo";
            Stipendija.HeaderText = "Stipendija";
            Stipendija.MinimumWidth = 6;
            Stipendija.Name = "Stipendija";
            Stipendija.ReadOnly = true;
            // 
            // Iznos
            // 
            Iznos.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Iznos.DataPropertyName = "MjesecniIznosInfo";
            Iznos.HeaderText = "Mjesecni iznos";
            Iznos.MinimumWidth = 6;
            Iznos.Name = "Iznos";
            Iznos.ReadOnly = true;
            // 
            // Ukupno
            // 
            Ukupno.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Ukupno.DataPropertyName = "Ukupno";
            Ukupno.HeaderText = "Ukupno";
            Ukupno.MinimumWidth = 6;
            Ukupno.Name = "Ukupno";
            Ukupno.ReadOnly = true;
            // 
            // Ukloni
            // 
            Ukloni.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Ukloni.HeaderText = "";
            Ukloni.MinimumWidth = 6;
            Ukloni.Name = "Ukloni";
            Ukloni.ReadOnly = true;
            Ukloni.Text = "Ukloni";
            Ukloni.UseColumnTextForButtonValue = true;
            // 
            // cbStipendije
            // 
            cbStipendije.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStipendije.FormattingEnabled = true;
            cbStipendije.Location = new Point(202, 44);
            cbStipendije.Name = "cbStipendije";
            cbStipendije.Size = new Size(196, 28);
            cbStipendije.TabIndex = 1;
            cbStipendije.SelectedIndexChanged += cbStipendije_SelectedIndexChanged;
            // 
            // btnDodajStipendiju
            // 
            btnDodajStipendiju.Location = new Point(793, 44);
            btnDodajStipendiju.Name = "btnDodajStipendiju";
            btnDodajStipendiju.Size = new Size(179, 29);
            btnDodajStipendiju.TabIndex = 0;
            btnDodajStipendiju.Text = "Dodaj stipendiju";
            btnDodajStipendiju.UseVisualStyleBackColor = true;
            btnDodajStipendiju.Click += btnDodajStipendiju_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(202, 21);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 2;
            label2.Text = "Stipendije:";
            // 
            // frmPretragaIB230030
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1185, 405);
            Controls.Add(dgvStudentiStipendije);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbStipendije);
            Controls.Add(cbGodina);
            Controls.Add(btnDodajStipendiju);
            Controls.Add(btnStipendijePoGodinama);
            Name = "frmPretragaIB230030";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmPretragaIB230030";
            Load += frmPretragaIB230030_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudentiStipendije).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStipendijePoGodinama;
        private ComboBox cbGodina;
        private Label label1;
        private DataGridView dgvStudentiStipendije;
        private ComboBox cbStipendije;
        private Button btnDodajStipendiju;
        private Label label2;
        private DataGridViewTextBoxColumn Student;
        private DataGridViewTextBoxColumn Godina;
        private DataGridViewTextBoxColumn Stipendija;
        private DataGridViewTextBoxColumn Iznos;
        private DataGridViewTextBoxColumn Ukupno;
        private DataGridViewButtonColumn Ukloni;
    }
}