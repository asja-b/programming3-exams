using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DLWMS.Data;
using DLWMS.Data.ispitIB230030;
using DLWMS.Infrastructure;
using DLWMS.WinApp.Helpers;

namespace DLWMS.WinApp.ispitIB230030
{
    public partial class frmNovoUvjerenjeIB230030 : Form
    {
        DLWMSContext db = new DLWMSContext();
        private Student odabraniStudent;

        public frmNovoUvjerenjeIB230030()
        {
            InitializeComponent();
        }

        public frmNovoUvjerenjeIB230030(Student odabraniStudent)
        {
            this.odabraniStudent = odabraniStudent;
            InitializeComponent();
        }

        private void frmNovoUvjerenjeIB230030_Load(object sender, EventArgs e)
        {
            cbVrsta.SelectedIndex = 0;
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (validacija())
            {
                var uplatnica = pbUplatnica.Image.ToByteArray();
                var vrsta = cbVrsta.SelectedItem.ToString();
                var svrha = txtSvrha.Text;
                var novoUvjerenje = new StudentiUvjerenjaIB230030()
                {
                    StudentId = odabraniStudent.Id,
                    Uplatnica = uplatnica,
                    Vrsta = vrsta,
                    Svrha = svrha,
                    Vrijeme = DateTime.Now,
                    Prinatno = false
                };
                db.StudentiUvjerenjaIB230030.Add(novoUvjerenje);
                db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
        }

        private bool validacija()
        {
            return Helpers.Validator.ProvjeriUnos(txtSvrha, err, Kljucevi.RequiredField)
                && Helpers.Validator.ProvjeriUnos(pbUplatnica, err, Kljucevi.RequiredField);
        }

        private void pbUplatnica_DoubleClick(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbUplatnica.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
