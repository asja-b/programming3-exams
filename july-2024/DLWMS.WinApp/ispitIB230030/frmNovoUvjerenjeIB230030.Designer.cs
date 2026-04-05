namespace DLWMS.WinApp.ispitIB230030
{
    partial class frmNovoUvjerenjeIB230030
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
            err = new ErrorProvider(components);
            label1 = new Label();
            pbUplatnica = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            txtSvrha = new TextBox();
            label2 = new Label();
            cbVrsta = new ComboBox();
            label3 = new Label();
            btnOtkazi = new Button();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbUplatnica).BeginInit();
            SuspendLayout();
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(612, 307);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(94, 29);
            btnSacuvaj.TabIndex = 0;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 76);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 1;
            label1.Text = "Svrha uvjerenja:";
            // 
            // pbUplatnica
            // 
            pbUplatnica.Location = new Point(206, 22);
            pbUplatnica.Name = "pbUplatnica";
            pbUplatnica.Size = new Size(500, 279);
            pbUplatnica.SizeMode = PictureBoxSizeMode.StretchImage;
            pbUplatnica.TabIndex = 2;
            pbUplatnica.TabStop = false;
            pbUplatnica.DoubleClick += pbUplatnica_DoubleClick;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtSvrha
            // 
            txtSvrha.Location = new Point(12, 99);
            txtSvrha.Multiline = true;
            txtSvrha.Name = "txtSvrha";
            txtSvrha.Size = new Size(178, 227);
            txtSvrha.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 22);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 1;
            label2.Text = "Vrsta uvjerenja:";
            // 
            // cbVrsta
            // 
            cbVrsta.DropDownStyle = ComboBoxStyle.DropDownList;
            cbVrsta.FormattingEnabled = true;
            cbVrsta.Items.AddRange(new object[] { "Uvjerenje o položenim predmetima", "Uvjerenje o statusu studenta" });
            cbVrsta.Location = new Point(12, 45);
            cbVrsta.Name = "cbVrsta";
            cbVrsta.Size = new Size(178, 28);
            cbVrsta.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(206, -1);
            label3.Name = "label3";
            label3.Size = new Size(141, 20);
            label3.TabIndex = 1;
            label3.Text = "Skenirana uplatnica:";
            // 
            // btnOtkazi
            // 
            btnOtkazi.Location = new Point(512, 307);
            btnOtkazi.Name = "btnOtkazi";
            btnOtkazi.Size = new Size(94, 29);
            btnOtkazi.TabIndex = 5;
            btnOtkazi.Text = "Otkazi";
            btnOtkazi.UseVisualStyleBackColor = true;
            btnOtkazi.Click += btnOtkazi_Click;
            // 
            // frmNovoUvjerenjeIB230030
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(718, 338);
            Controls.Add(btnOtkazi);
            Controls.Add(cbVrsta);
            Controls.Add(txtSvrha);
            Controls.Add(pbUplatnica);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSacuvaj);
            Name = "frmNovoUvjerenjeIB230030";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Novi zathjev za izdavanjem uvjerenja";
            Load += frmNovoUvjerenjeIB230030_Load;
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbUplatnica).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSacuvaj;
        private ErrorProvider err;
        private ComboBox cbVrsta;
        private TextBox txtSvrha;
        private PictureBox pbUplatnica;
        private Label label3;
        private Label label2;
        private Label label1;
        private OpenFileDialog openFileDialog1;
        private Button btnOtkazi;
    }
}