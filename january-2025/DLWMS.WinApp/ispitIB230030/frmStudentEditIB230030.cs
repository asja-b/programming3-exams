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
using DLWMS.Infrastructure;
using DLWMS.WinApp.Helpers;

namespace DLWMS.WinApp.ispitIB230030
{
    public partial class frmStudentEditIB230030 : Form
    {
        DLWMSContext db = new DLWMSContext();
        private Student odabraniStudent;

        public frmStudentEditIB230030()
        {
            InitializeComponent();
        }

        public frmStudentEditIB230030(Student odabraniStudent)
        {
            this.odabraniStudent = odabraniStudent;
            InitializeComponent();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (validacija())
            {
                var grad = cbGrad.SelectedItem as Grad;
                var slika = pbSlika.Image.ToByteArray();

                odabraniStudent.Slika = slika;
                odabraniStudent.GradId = grad!.Id;
                odabraniStudent.Grad = grad;

                db.Studenti.Update(odabraniStudent);
                db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
        }

        private bool validacija()
        {
            return Helpers.Validator.ProvjeriUnos(pbSlika, err, Kljucevi.RequiredField)
                && Helpers.Validator.ProvjeriUnos(cbDrzava, err, Kljucevi.RequiredField)
                && Helpers.Validator.ProvjeriUnos(cbGrad, err, Kljucevi.RequiredField);
        }

        private void btnUcitaj_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbSlika.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void frmStudentEditIB230030_Load(object sender, EventArgs e)
        {
            cbDrzava.DataSource = db.Drzave.ToList();
            ucitajInfo();
        }

        private void ucitajInfo()
        {
            pbSlika.Image = odabraniStudent.Slika.ToImage();
            lblStudent.Text = $"{odabraniStudent.Ime} {odabraniStudent.Prezime}";
            lblIndeks.Text = odabraniStudent.BrojIndeksa;

            cbDrzava.SelectedIndex = db.Drzave.ToList().FindIndex(x => x.Id == odabraniStudent.Grad!.DrzavaId);

            var gradoviNaseDrzave = db.Gradovi
                .Where(x=>x.DrzavaId==odabraniStudent.Grad!.DrzavaId)
                .ToList();

            cbGrad.SelectedIndex = gradoviNaseDrzave.FindIndex(x => x.Id == odabraniStudent.GradId);
        }

        private void cbDrzava_SelectedIndexChanged(object sender, EventArgs e)
        {
            var odabranaDrzava = cbDrzava.SelectedItem as Drzava;

            cbGrad.DataSource = db.Gradovi
                .Where(x=>x.DrzavaId==odabranaDrzava.Id)
                .ToList();
        }
    }
}
