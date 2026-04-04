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
using DLWMS.WinApp.Izvjestaji;
using Microsoft.EntityFrameworkCore;

namespace DLWMS.WinApp.IspitIB230030
{
    public partial class frmStipendijeIB230030 : Form
    {
        DLWMSContext db = new DLWMSContext();
        List<StipendijeGodineIB230030> stipendijeGod;
        public frmStipendijeIB230030()
        {
            InitializeComponent();
        }

        private void frmStipendijeIB230030_Load(object sender, EventArgs e)
        {
            dgvStipendije.AutoGenerateColumns = false;
            ucitajcomboBox();
            ucitajStipendijeGod();
        }

        private void ucitajcomboBox()
        {
            cbGodina.SelectedIndex = 0;
            cbStipendija.DataSource = db.stipendijeIB230030.ToList();
        }

        private void ucitajStipendijeGod()
        {
            stipendijeGod = db.StipendijeGodineIB230030
               .Include(x => x.Stipendija)
               .ToList();

            if (stipendijeGod != null)
            {
                dgvStipendije.DataSource = null;
                dgvStipendije.DataSource = stipendijeGod;
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (validacija())
            {

                var godina = cbGodina.SelectedItem.ToString();
                var stipendija = cbStipendija.SelectedItem as StipendijeIB230030;
                var iznos = int.Parse(txtIznos.Text);
                if (stipendijeGod.Exists(x => x.Godina == godina && x.StipendijaId == stipendija.Id))
                {
                    MessageBox.Show($"Već postoji {stipendija} stipendija u {godina} godini.",
                        "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    var novaStipendijaGod = new StipendijeGodineIB230030()
                    {
                        Godina = godina,
                        Stipendija = stipendija,
                        StipendijaId = stipendija.Id,
                        Iznos = iznos,
                        Aktivan = true

                    };
                    db.StipendijeGodineIB230030.Add(novaStipendijaGod);
                    db.SaveChanges();

                    ucitajStipendijeGod();
                    MessageBox.Show($"uspjesno ste dodali novu stipendiju "
                 , "info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private bool validacija()
        {
            return Helpers.Validator.ProvjeriUnos(txtIznos, err, Kljucevi.RequiredField);

        }

        private void frmStipendijeIB230030_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private async void btnGenerisi_Click(object sender, EventArgs e)
        {
            var odabranaStipendijaGodina = dgvStipendije.SelectedRows[0].DataBoundItem as StipendijeGodineIB230030;
            await Task.Run(() => GenerisiStipendijeGod(odabranaStipendijaGodina));
        }

        private void GenerisiStipendijeGod(StipendijeGodineIB230030? odabranaStipendijaGodina)
        {
            var studenti = db.Studenti.ToList();
            var info = "";
            var redniBroj = 1;
            for (int i = 0; i < studenti.Count(); i++)
            {
                if (!db.StudentiStipendijeIB230030.ToList().Exists(x => x.StipendijaGodina.Godina == odabranaStipendijaGodina!.Godina && x.StudentId == studenti[i].Id))
                {
                    Thread.Sleep(300);
                    var novaStudentiStipendije = new StudentiStipendijeIB230030()
                    {
                        StudentId = studenti[i].Id,
                        StipendijaGodinaId = odabranaStipendijaGodina!.Id
                    };
                    db.StudentiStipendijeIB230030.Add(novaStudentiStipendije);
                    db.SaveChanges();
                    redniBroj++;
                    
                }
            }

            Action action = () =>
            {
                if (redniBroj != 1)
                {
                    MessageBox.Show($"Uspješno su generisane stipendije",
                        "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Ne postoje stipendije koje zadovoljavaju uslove generisanja",
                        "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                txtInfo.Text = info;
                ucitajStipendijeGod();

            };
            BeginInvoke(action);
        }

        private void btnPotvrda_Click(object sender, EventArgs e)
        {
            var odabranaStipendija = dgvStipendije.SelectedRows[0].DataBoundItem as StipendijeGodineIB230030;

            var frmIzvjestaj = new frmIzvjestaji(odabranaStipendija);
            frmIzvjestaj.ShowDialog();
        }
    }
}
