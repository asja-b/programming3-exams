namespace DLWMS.WinApp.IspitIB230030
{
    partial class frmNastavaIB230030
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
            btnDodaj = new Button();
            cbPredmet = new ComboBox();
            errorProvider1 = new ErrorProvider(components);
            dgvNastava = new DataGridView();
            PredmetId = new DataGridViewTextBoxColumn();
            Dan = new DataGridViewTextBoxColumn();
            Vrijeme = new DataGridViewTextBoxColumn();
            cbDan = new ComboBox();
            cbVrijeme = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvNastava).BeginInit();
            SuspendLayout();
            // 
            // lblNazivOznaka
            // 
            lblNazivOznaka.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblNazivOznaka.Location = new Point(12, 4);
            lblNazivOznaka.Name = "lblNazivOznaka";
            lblNazivOznaka.Size = new Size(449, 51);
            lblNazivOznaka.TabIndex = 0;
            lblNazivOznaka.Text = "stakeholder naziv - oznaka";
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(556, 77);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(128, 29);
            btnDodaj.TabIndex = 1;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // cbPredmet
            // 
            cbPredmet.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPredmet.FormattingEnabled = true;
            cbPredmet.Location = new Point(8, 78);
            cbPredmet.Name = "cbPredmet";
            cbPredmet.Size = new Size(228, 28);
            cbPredmet.TabIndex = 2;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // dgvNastava
            // 
            dgvNastava.AllowUserToAddRows = false;
            dgvNastava.AllowUserToDeleteRows = false;
            dgvNastava.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNastava.Columns.AddRange(new DataGridViewColumn[] { PredmetId, Dan, Vrijeme });
            dgvNastava.Location = new Point(8, 112);
            dgvNastava.Name = "dgvNastava";
            dgvNastava.ReadOnly = true;
            dgvNastava.RowHeadersWidth = 51;
            dgvNastava.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNastava.Size = new Size(676, 264);
            dgvNastava.TabIndex = 3;
            // 
            // PredmetId
            // 
            PredmetId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PredmetId.DataPropertyName = "Predmet";
            PredmetId.HeaderText = "Predmet";
            PredmetId.MinimumWidth = 6;
            PredmetId.Name = "PredmetId";
            PredmetId.ReadOnly = true;
            // 
            // Dan
            // 
            Dan.DataPropertyName = "Dan";
            Dan.HeaderText = "Dan";
            Dan.MinimumWidth = 6;
            Dan.Name = "Dan";
            Dan.ReadOnly = true;
            Dan.Width = 125;
            // 
            // Vrijeme
            // 
            Vrijeme.DataPropertyName = "Vrijeme";
            Vrijeme.HeaderText = "Vrijeme";
            Vrijeme.MinimumWidth = 6;
            Vrijeme.Name = "Vrijeme";
            Vrijeme.ReadOnly = true;
            Vrijeme.Width = 125;
            // 
            // cbDan
            // 
            cbDan.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDan.FormattingEnabled = true;
            cbDan.Items.AddRange(new object[] { "Ponedjeljak", "Utorak", "Srijeda", "Četvrtak", "Petak", "Subota", "Nedjelja" });
            cbDan.Location = new Point(242, 78);
            cbDan.Name = "cbDan";
            cbDan.Size = new Size(151, 28);
            cbDan.TabIndex = 2;
            // 
            // cbVrijeme
            // 
            cbVrijeme.DropDownStyle = ComboBoxStyle.DropDownList;
            cbVrijeme.FormattingEnabled = true;
            cbVrijeme.Items.AddRange(new object[] { "08 - 10", "10 - 12", "12 - 14" });
            cbVrijeme.Location = new Point(399, 78);
            cbVrijeme.Name = "cbVrijeme";
            cbVrijeme.Size = new Size(151, 28);
            cbVrijeme.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 55);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 0;
            label2.Text = "Predmet:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(242, 55);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 0;
            label3.Text = "Dan:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(399, 55);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 0;
            label4.Text = "Vrijeme:";
            // 
            // frmNastavaIB230030
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(696, 399);
            Controls.Add(dgvNastava);
            Controls.Add(cbVrijeme);
            Controls.Add(cbDan);
            Controls.Add(cbPredmet);
            Controls.Add(btnDodaj);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblNazivOznaka);
            Name = "frmNastavaIB230030";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nastava";
            FormClosed += frmNastavaIB230030_FormClosed;
            Load += frmNastavaIB230030_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvNastava).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNazivOznaka;
        private Button btnDodaj;
        private ComboBox cbPredmet;
        private ErrorProvider errorProvider1;
        private DataGridView dgvNastava;
        private ComboBox cbVrijeme;
        private ComboBox cbDan;
        private Label label4;
        private Label label3;
        private Label label2;
        private DataGridViewTextBoxColumn PredmetId;
        private DataGridViewTextBoxColumn Dan;
        private DataGridViewTextBoxColumn Vrijeme;
    }
}