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
using DLWMS.WinApp.Izvjestaji;
using DocumentFormat.OpenXml.EMMA;
using Microsoft.VisualBasic;

namespace DLWMS.WinApp.IspitIB230030
{
    public partial class frmProstorijeIB230030 : Form
    {
        DLWMSContext db = new DLWMSContext();
        List<ProstorijeIB230030> prostorije;
        public frmProstorijeIB230030()
        {
            InitializeComponent();
        }
        private void frmProstorijeIB230030_Load(object sender, EventArgs e)
        {
            dgvProstorije.AutoGenerateColumns = false;
            ucitajProstorije();
        }


        private void ucitajProstorije()
        {
            prostorije = db.ProstorijeIB230030.ToList();

            for (int i = 0; i < prostorije.Count(); i++)
            {
                prostorije[i].Broj = db.NastavaIB230030.
                    Where(x => x.ProstorijaId == prostorije[i].Id)
                    .Count();
            }

            if (dgvProstorije != null)
            {
                dgvProstorije.DataSource = null;
                dgvProstorije.DataSource = prostorije;
            }
        }

        private void BtnNovaProstorija_Click(object sender, EventArgs e)
        {
            var frmNovaProstorija = new frmNovaProstorijaIB230030();
            if (frmNovaProstorija.ShowDialog() == DialogResult.OK)
            {
                ucitajProstorije();
                MessageBox.Show("uspjesno ste dodali NOVU prostoriju", "info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvProstorije_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var odabranaProstorija = dgvProstorije.SelectedRows[0].DataBoundItem as ProstorijeIB230030;
            if (e.ColumnIndex == 5)
            {
                var frmNastava = new frmNastavaIB230030(odabranaProstorija);
                if (frmNastava.ShowDialog() == DialogResult.OK)
                {
                    ucitajProstorije();
                }

            }
            if (e.ColumnIndex == 6)
            {
                var frmPrisustvo = new frmPrisustvoIB230030(odabranaProstorija);
                if (frmPrisustvo.ShowDialog() == DialogResult.OK)
                {
                    ucitajProstorije();
                }
            }
        }

        private void dgvProstorije_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var odabranaProstorija = dgvProstorije.SelectedRows[0].DataBoundItem as ProstorijeIB230030;
            if (e.ColumnIndex < 5)
            {
                var frmEditProstorija = new frmNovaProstorijaIB230030(odabranaProstorija);
                if (frmEditProstorija.ShowDialog() == DialogResult.OK)
                {
                    ucitajProstorije();
                    MessageBox.Show($"uspjesno ste dodali EDITOVALI {odabranaProstorija}", "info",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void BtnPrintaj_Click(object sender, EventArgs e)
        {
            var odabranaProstorija = dgvProstorije.SelectedRows[0].DataBoundItem as ProstorijeIB230030;
            var frmIzvjestaj = new frmIzvjestaji(odabranaProstorija);
            frmIzvjestaj.ShowDialog();
        }
    }
}
