namespace DLWMS.WinApp.IspitIB230030
{
    partial class frmNovaProstorijaIB230030
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
            label1 = new Label();
            pbLogo = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            txtNaziv = new TextBox();
            txtOznaka = new TextBox();
            txtKapacitet = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            err = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(441, 191);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(94, 29);
            btnSacuvaj.TabIndex = 0;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 1;
            label1.Text = "Logo:";
            // 
            // pbLogo
            // 
            pbLogo.Location = new Point(12, 46);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(184, 171);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 3;
            pbLogo.TabStop = false;
            pbLogo.DoubleClick += pbLogo_DoubleClick;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtNaziv
            // 
            txtNaziv.Location = new Point(217, 67);
            txtNaziv.Name = "txtNaziv";
            txtNaziv.Size = new Size(318, 27);
            txtNaziv.TabIndex = 4;
            // 
            // txtOznaka
            // 
            txtOznaka.Location = new Point(217, 143);
            txtOznaka.Name = "txtOznaka";
            txtOznaka.Size = new Size(156, 27);
            txtOznaka.TabIndex = 4;
            // 
            // txtKapacitet
            // 
            txtKapacitet.Location = new Point(379, 143);
            txtKapacitet.Name = "txtKapacitet";
            txtKapacitet.Size = new Size(156, 27);
            txtKapacitet.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(217, 44);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 1;
            label2.Text = "Naziv:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(217, 120);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 1;
            label3.Text = "Oznaka:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(379, 120);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 1;
            label4.Text = "Kapacitet:";
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // frmNovaProstorijaIB230030
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(547, 232);
            Controls.Add(txtKapacitet);
            Controls.Add(txtOznaka);
            Controls.Add(txtNaziv);
            Controls.Add(pbLogo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSacuvaj);
            Name = "frmNovaProstorijaIB230030";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Podaci o prostoriji";
            Load += frmNovaProstorijaIB230030_Load;
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSacuvaj;
        private Label label1;
        private PictureBox pbLogo;
        private OpenFileDialog openFileDialog1;
        private TextBox txtNaziv;
        private TextBox txtOznaka;
        private TextBox txtKapacitet;
        private Label label2;
        private Label label3;
        private Label label4;
        private ErrorProvider err;
    }
}