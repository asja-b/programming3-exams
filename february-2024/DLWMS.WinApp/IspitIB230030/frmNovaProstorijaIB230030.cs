using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DLWMS.Data.IspitIB230030;
using DLWMS.Infrastructure;
using DLWMS.WinApp.Helpers;

namespace DLWMS.WinApp.IspitIB230030
{
    public partial class frmNovaProstorijaIB230030 : Form
    {
        DLWMSContext db = new DLWMSContext();
        private ProstorijeIB230030? odabranaProstorija;

        public frmNovaProstorijaIB230030()
        {
            InitializeComponent();
        }

        public frmNovaProstorijaIB230030(ProstorijeIB230030? odabranaProstorija)
        {
            this.odabranaProstorija = odabranaProstorija;
            InitializeComponent();
        }

        private void pbLogo_DoubleClick(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbLogo.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (validacija())
            {
                var logo = pbLogo.Image.ToByteArray();
                var kapacitet = int.Parse(txtKapacitet.Text);
                var oznaka = txtOznaka.Text;
                var naziv = txtNaziv.Text;
                if (odabranaProstorija == null)
                {

                    var novaProstorija = new ProstorijeIB230030()
                    {
                        Logo = logo,
                        Kapacitet = kapacitet,
                        Oznaka = oznaka,
                        Naziv = naziv,
                    };
                    db.ProstorijeIB230030.Add(novaProstorija);
                }
                else
                {
                    odabranaProstorija.Logo = logo;
                    odabranaProstorija.Oznaka = oznaka;
                    odabranaProstorija.Kapacitet = kapacitet;
                    odabranaProstorija.Naziv = naziv;

                    db.ProstorijeIB230030.Update(odabranaProstorija);
                }
                db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
        }

        private bool validacija()
        {
            return Helpers.Validator.ProvjeriUnos(pbLogo, err, Kljucevi.RequiredField)
                && Helpers.Validator.ProvjeriUnos(txtKapacitet, err, Kljucevi.RequiredField)
                && Helpers.Validator.ProvjeriUnos(txtNaziv, err, Kljucevi.RequiredField)
                && Helpers.Validator.ProvjeriUnos(txtOznaka, err, Kljucevi.RequiredField);
        }

        private void frmNovaProstorijaIB230030_Load(object sender, EventArgs e)
        {
            ucitajInfo();
        }

        private void ucitajInfo()
        {
            if (odabranaProstorija != null)
            {
                pbLogo.Image = odabranaProstorija.Logo.ToImage();
                txtKapacitet.Text = odabranaProstorija.Kapacitet.ToString();
                txtNaziv.Text = odabranaProstorija.Naziv;
                txtOznaka.Text = odabranaProstorija.Oznaka;

            }
        }
    }
}
