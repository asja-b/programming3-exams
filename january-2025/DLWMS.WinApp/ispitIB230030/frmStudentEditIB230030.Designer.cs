namespace DLWMS.WinApp.ispitIB230030
{
    partial class frmStudentEditIB230030
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
            err = new ErrorProvider(components);
            pbSlika = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            btnSacuvaj = new Button();
            cbDrzava = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            cbGrad = new ComboBox();
            btnUcitaj = new Button();
            lblStudent = new Label();
            lblIndeks = new Label();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSlika).BeginInit();
            SuspendLayout();
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // pbSlika
            // 
            pbSlika.Location = new Point(12, 29);
            pbSlika.Name = "pbSlika";
            pbSlika.Size = new Size(166, 193);
            pbSlika.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSlika.TabIndex = 0;
            pbSlika.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(439, 228);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(94, 29);
            btnSacuvaj.TabIndex = 1;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // cbDrzava
            // 
            cbDrzava.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDrzava.FormattingEnabled = true;
            cbDrzava.Location = new Point(248, 120);
            cbDrzava.Name = "cbDrzava";
            cbDrzava.Size = new Size(285, 28);
            cbDrzava.TabIndex = 2;
            cbDrzava.SelectedIndexChanged += cbDrzava_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(184, 171);
            label1.Name = "label1";
            label1.Size = new Size(44, 20);
            label1.TabIndex = 3;
            label1.Text = "Grad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(184, 128);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 3;
            label2.Text = "Država:";
            // 
            // cbGrad
            // 
            cbGrad.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGrad.FormattingEnabled = true;
            cbGrad.Location = new Point(248, 163);
            cbGrad.Name = "cbGrad";
            cbGrad.Size = new Size(285, 28);
            cbGrad.TabIndex = 2;
            // 
            // btnUcitaj
            // 
            btnUcitaj.Location = new Point(12, 228);
            btnUcitaj.Name = "btnUcitaj";
            btnUcitaj.Size = new Size(166, 29);
            btnUcitaj.TabIndex = 1;
            btnUcitaj.Text = "Učitaj sliku";
            btnUcitaj.UseVisualStyleBackColor = true;
            btnUcitaj.Click += btnUcitaj_Click;
            // 
            // lblStudent
            // 
            lblStudent.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblStudent.Location = new Point(184, 29);
            lblStudent.Name = "lblStudent";
            lblStudent.Size = new Size(315, 45);
            lblStudent.TabIndex = 3;
            lblStudent.Text = "Student placeholder";
            // 
            // lblIndeks
            // 
            lblIndeks.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblIndeks.Location = new Point(184, 72);
            lblIndeks.Name = "lblIndeks";
            lblIndeks.Size = new Size(315, 45);
            lblIndeks.TabIndex = 3;
            lblIndeks.Text = "Indeks placeholder";
            // 
            // frmStudentEditIB230030
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 269);
            Controls.Add(lblIndeks);
            Controls.Add(lblStudent);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbGrad);
            Controls.Add(cbDrzava);
            Controls.Add(btnUcitaj);
            Controls.Add(btnSacuvaj);
            Controls.Add(pbSlika);
            Name = "frmStudentEditIB230030";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Podaci o studentu";
            Load += frmStudentEditIB230030_Load;
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSlika).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ErrorProvider err;
        private Label lblStudent;
        private Label label2;
        private Label label1;
        private ComboBox cbGrad;
        private ComboBox cbDrzava;
        private Button btnUcitaj;
        private Button btnSacuvaj;
        private PictureBox pbSlika;
        private OpenFileDialog openFileDialog1;
        private Label lblIndeks;
    }
}