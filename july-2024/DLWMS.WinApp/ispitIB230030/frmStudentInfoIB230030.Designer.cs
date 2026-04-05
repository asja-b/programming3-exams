namespace DLWMS.WinApp.ispitIB230030
{
    partial class frmStudentInfoIB230030
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
            lblGrad = new Label();
            lblIme = new Label();
            pbSlika = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbSlika).BeginInit();
            SuspendLayout();
            // 
            // lblGrad
            // 
            lblGrad.AutoSize = true;
            lblGrad.Location = new Point(98, 300);
            lblGrad.Name = "lblGrad";
            lblGrad.Size = new Size(124, 20);
            lblGrad.TabIndex = 0;
            lblGrad.Text = "Grad placeholder";
            lblGrad.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblIme
            // 
            lblIme.AutoSize = true;
            lblIme.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblIme.Location = new Point(57, 254);
            lblIme.Name = "lblIme";
            lblIme.Size = new Size(220, 31);
            lblIme.TabIndex = 1;
            lblIme.Text = "Student placeholder";
            lblIme.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pbSlika
            // 
            pbSlika.Location = new Point(29, 12);
            pbSlika.Name = "pbSlika";
            pbSlika.Size = new Size(266, 224);
            pbSlika.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSlika.TabIndex = 2;
            pbSlika.TabStop = false;
            // 
            // frmStudentInfoIB230030
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 329);
            Controls.Add(pbSlika);
            Controls.Add(lblIme);
            Controls.Add(lblGrad);
            Name = "frmStudentInfoIB230030";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmStudentInfoIB230030";
            Load += frmStudentInfoIB230030_Load;
            ((System.ComponentModel.ISupportInitialize)pbSlika).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGrad;
        private Label lblIme;
        private PictureBox pbSlika;
    }
}