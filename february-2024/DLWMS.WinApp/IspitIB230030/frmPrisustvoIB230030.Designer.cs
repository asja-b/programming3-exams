namespace DLWMS.WinApp.IspitIB230030
{
    partial class frmPrisustvoIB230030
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
            lblNazivOznaka = new Label();
            cbNastava = new ComboBox();
            label2 = new Label();
            dgvPrisustvo = new DataGridView();
            Nastava = new DataGridViewTextBoxColumn();
            Student = new DataGridViewTextBoxColumn();
            btnDodaj = new Button();
            cbStudent = new ComboBox();
            label3 = new Label();
            lblKapacitet = new Label();
            err = new ErrorProvider(components);
            btnGenerisi = new Button();
            groupBox1 = new GroupBox();
            label1 = new Label();
            txtBrojZapisa = new TextBox();
            txtInfo = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPrisustvo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblNazivOznaka
            // 
            lblNazivOznaka.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblNazivOznaka.Location = new Point(12, 9);
            lblNazivOznaka.Name = "lblNazivOznaka";
            lblNazivOznaka.Size = new Size(431, 50);
            lblNazivOznaka.TabIndex = 0;
            lblNazivOznaka.Text = "naziv - oznaka";
            // 
            // cbNastava
            // 
            cbNastava.DropDownStyle = ComboBoxStyle.DropDownList;
            cbNastava.FormattingEnabled = true;
            cbNastava.Location = new Point(8, 91);
            cbNastava.Name = "cbNastava";
            cbNastava.Size = new Size(309, 28);
            cbNastava.TabIndex = 1;
            cbNastava.SelectedIndexChanged += cbNastava_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 68);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 2;
            label2.Text = "Nastava:";
            // 
            // dgvPrisustvo
            // 
            dgvPrisustvo.AllowUserToAddRows = false;
            dgvPrisustvo.AllowUserToDeleteRows = false;
            dgvPrisustvo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrisustvo.Columns.AddRange(new DataGridViewColumn[] { Nastava, Student });
            dgvPrisustvo.Location = new Point(8, 125);
            dgvPrisustvo.Name = "dgvPrisustvo";
            dgvPrisustvo.ReadOnly = true;
            dgvPrisustvo.RowHeadersWidth = 51;
            dgvPrisustvo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPrisustvo.Size = new Size(750, 202);
            dgvPrisustvo.TabIndex = 3;
            // 
            // Nastava
            // 
            Nastava.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nastava.DataPropertyName = "Nastava";
            Nastava.HeaderText = "Predmet, prostorija, vrijeme";
            Nastava.MinimumWidth = 6;
            Nastava.Name = "Nastava";
            Nastava.ReadOnly = true;
            // 
            // Student
            // 
            Student.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Student.DataPropertyName = "Student";
            Student.HeaderText = "Student";
            Student.MinimumWidth = 6;
            Student.Name = "Student";
            Student.ReadOnly = true;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(638, 91);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(120, 29);
            btnDodaj.TabIndex = 4;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // cbStudent
            // 
            cbStudent.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStudent.FormattingEnabled = true;
            cbStudent.Location = new Point(323, 91);
            cbStudent.Name = "cbStudent";
            cbStudent.Size = new Size(309, 28);
            cbStudent.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(323, 68);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 0;
            label3.Text = "Student:";
            // 
            // lblKapacitet
            // 
            lblKapacitet.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblKapacitet.Location = new Point(647, 9);
            lblKapacitet.Name = "lblKapacitet";
            lblKapacitet.Size = new Size(101, 66);
            lblKapacitet.TabIndex = 0;
            lblKapacitet.Text = "?/?";
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // btnGenerisi
            // 
            btnGenerisi.Location = new Point(194, 38);
            btnGenerisi.Name = "btnGenerisi";
            btnGenerisi.Size = new Size(94, 29);
            btnGenerisi.TabIndex = 5;
            btnGenerisi.Text = "Generiši";
            btnGenerisi.UseVisualStyleBackColor = true;
            btnGenerisi.Click += btnGenerisi_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtInfo);
            groupBox1.Controls.Add(txtBrojZapisa);
            groupBox1.Controls.Add(btnGenerisi);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(8, 360);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(750, 264);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Generator";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 45);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 0;
            label1.Text = "Broj zapisa:";
            // 
            // txtBrojZapisa
            // 
            txtBrojZapisa.Location = new Point(106, 38);
            txtBrojZapisa.Name = "txtBrojZapisa";
            txtBrojZapisa.Size = new Size(82, 27);
            txtBrojZapisa.TabIndex = 1;
            // 
            // txtInfo
            // 
            txtInfo.Location = new Point(15, 99);
            txtInfo.Multiline = true;
            txtInfo.Name = "txtInfo";
            txtInfo.Size = new Size(725, 149);
            txtInfo.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 76);
            label4.Name = "label4";
            label4.Size = new Size(38, 20);
            label4.TabIndex = 0;
            label4.Text = "info:";
            // 
            // frmPrisustvoIB230030
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(770, 631);
            Controls.Add(groupBox1);
            Controls.Add(btnDodaj);
            Controls.Add(dgvPrisustvo);
            Controls.Add(label2);
            Controls.Add(cbStudent);
            Controls.Add(cbNastava);
            Controls.Add(label3);
            Controls.Add(lblKapacitet);
            Controls.Add(lblNazivOznaka);
            Name = "frmPrisustvoIB230030";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Evidencija nastave";
            Load += frmPrisustvoIB230030_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPrisustvo).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNazivOznaka;
        private ComboBox cbNastava;
        private Label label2;
        private DataGridView dgvPrisustvo;
        private Button btnDodaj;
        private ComboBox cbStudent;
        private Label label3;
        private Label lblKapacitet;
        private DataGridViewTextBoxColumn Nastava;
        private DataGridViewTextBoxColumn Student;
        private ErrorProvider err;
        private GroupBox groupBox1;
        private TextBox txtInfo;
        private TextBox txtBrojZapisa;
        private Button btnGenerisi;
        private Label label4;
        private Label label1;
    }
}