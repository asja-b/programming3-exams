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
using DLWMS.Data.IspitIB230030;
using DLWMS.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace DLWMS.WinApp.IspitIB230030
{
    public partial class frmNastavaIB230030 : Form
    {
        DLWMSContext db = new DLWMSContext();
        List<NastavaIB230030> nastava;
        private ProstorijeIB230030? odabranaProstorija;

        public frmNastavaIB230030()
        {
            InitializeComponent();
        }

        public frmNastavaIB230030(ProstorijeIB230030? odabranaProstorija)
        {
            InitializeComponent();
            this.odabranaProstorija = odabranaProstorija;
            
        }

        private void frmNastavaIB230030_Load(object sender, EventArgs e)
        {
            dgvNastava.AutoGenerateColumns = false;
            lblNazivOznaka.Text = $"{odabranaProstorija} - {odabranaProstorija.Oznaka}";
            
            ucitajComboBox();
            ucitajNastavu();
        }
        private void ucitajComboBox()
        {
            cbDan.SelectedIndex = 0;
            cbVrijeme.SelectedIndex = 0;
            cbPredmet.DataSource = db.Predmeti.ToList();
        }
        private void ucitajNastavu()
        {
            nastava = db.NastavaIB230030
                .Include(x => x.Predmet)
                .Where(x => x.ProstorijaId == odabranaProstorija.Id).ToList();
            if (nastava != null)
            {
                dgvNastava.DataSource = null;
                dgvNastava.DataSource = nastava;
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            var dan = cbDan.SelectedItem.ToString();
            var vrijeme = cbVrijeme.SelectedItem.ToString();
            var predmet = cbPredmet.SelectedItem as Predmet;

            if (nastava.Exists(x => x.Dan == dan && x.Vrijeme == vrijeme))
            {
                MessageBox.Show("vec postoji nastava ", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var novaNastava = new NastavaIB230030
                {
                    Dan = dan,
                    Vrijeme = vrijeme,
                    PredmetId = predmet.Id,
                    Oznaka = $"{predmet} :: {dan} :: {vrijeme}",
                    ProstorijaId = odabranaProstorija.Id
                };
                db.NastavaIB230030.Add(novaNastava);
                db.SaveChanges();
            }
            ucitajNastavu();
        }

        private void frmNastavaIB230030_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
