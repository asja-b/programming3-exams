using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IdentityModel.Tokens;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DLWMS.Data;
using DLWMS.Data.ispitIB230030;
using DLWMS.Infrastructure;
using DLWMS.WinApp.Helpers;
using DLWMS.WinApp.Izvjestaji;
using Microsoft.EntityFrameworkCore;

namespace DLWMS.WinApp.ispitIB230030
{
    public partial class frmRazmjeneIB230030 : Form
    {
        DLWMSContext db = new DLWMSContext();
        private Student odabraniStudent;
        List<RazmjeneIB230030> razmjene;
        public frmRazmjeneIB230030()
        {
            InitializeComponent();
        }

        public frmRazmjeneIB230030(Student odabraniStudent)
        {
            this.odabraniStudent = odabraniStudent;
            InitializeComponent();
        }

        private void frmRazmjeneIB230030_Load(object sender, EventArgs e)
        {
            dgvRazmjene.AutoGenerateColumns = false;
            this.Text = $"Razmjene studenata: {odabraniStudent.StudentInfo}";

            ucitajComboBox();
            ucitajRazmjene();

            cbUni.DataSource = db.UniverzitetiIB230030.ToList();
            cbUni.DisplayMember = "Naziv";
        }

        private void ucitajComboBox()
        {
            cbDrzava.DataSource = db.Drzave.ToList();
            cbUniverzitet.DataSource = db.UniverzitetiIB230030.ToList();
            cbUniverzitet.DisplayMember = "Naziv";
        }

        private void ucitajRazmjene()
        {
            razmjene = db.RazmjeneIB230030
               .Include(x => x.Univerzitet.Drzava)
               .Include(x => x.Student)
               .Where(x => x.StudentId == odabraniStudent.Id)
               .ToList();

            if (razmjene != null)
            {
                dgvRazmjene.DataSource = null;
                dgvRazmjene.DataSource = razmjene;
            }
        }

        private void cbDrzava_SelectedIndexChanged(object sender, EventArgs e)
        {

            var odabranaDrzava = cbDrzava.SelectedItem as Drzava;
            cbUniverzitet.DataSource = db.UniverzitetiIB230030
                .Where(x => x.DrzavaId == odabranaDrzava.Id)
                .ToList();
            cbUniverzitet.DisplayMember = "Naziv";
        }


        private void dgvRazmjene_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var odabranaRazmjena = razmjene[e.RowIndex];
            if (e.ColumnIndex == 5)
            {
                if (MessageBox.Show($"da li ste sigurni da zelize izbrisati razmjenu?",
                    "question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    db.RazmjeneIB230030.Remove(odabranaRazmjena);
                    db.SaveChanges();
                    ucitajRazmjene();
                }
            }
        }
        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (validacija())
            {
                var univerzitet = cbUniverzitet.SelectedItem as UniverzitetiIB230030;
                var datumOD = dtpPocetak.Value;
                var datumDO = dtpKraj.Value;
                var ects = int.Parse(txtBrojKredita.Text);
                var okoncana = datumDO > DateTime.Now ? false : true;
                if (datumOD > datumDO)
                {
                    MessageBox.Show("Datum pocetka ne moze biti veci od datuma kraja",
                        "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    var novaRazmjena = new RazmjeneIB230030()
                    {
                        DatumPocetak = datumOD,
                        DatumKraj = datumDO,
                        Okoncana = okoncana,
                        ECTS = ects,

                        UniverzitetId = univerzitet.Id,
                        StudentId = odabraniStudent.Id,

                    };
                    db.RazmjeneIB230030.Add(novaRazmjena);
                    db.SaveChanges();
                    ucitajRazmjene();
                }

            }
        }

        private bool validacija()
        {
            return Helpers.Validator.ProvjeriUnos(txtBrojKredita, err, Kljucevi.RequiredField)
                && Helpers.Validator.ProvjeriUnos(cbUniverzitet, err, Kljucevi.RequiredField);
        }

        private void button1_Click(object sender, EventArgs e)// slucajno ime zab
        {
            if (validacijaMultiThreadinga())
            {
                var odabraniUni = cbUni.SelectedItem as UniverzitetiIB230030;
                Thread thread = new Thread(() => generisi(odabraniUni));
                thread.Start();

            }
        }

        private void generisi(UniverzitetiIB230030? odabraniUni)
        {
            var info = "";
            var broj = int.Parse(txtBrojRazmjena.Text);
            var ects = int.Parse(txtEcts.Text);
            var datumOd = new DateTime(2025, 1, 1, 12, 0, 0);
            var datumDo = DateTime.Now;
            var okoncana = true;

            for (int i = 0; i < broj; i++)
            {
                Thread.Sleep(300);
                var novaRazmjena = new RazmjeneIB230030()
                {
                    DatumPocetak = datumOd,
                    DatumKraj = datumDo,
                    Okoncana = okoncana,
                    StudentId = odabraniStudent.Id,
                    UniverzitetId = odabraniUni.Id,
                    ECTS = ects,
                };
                info += $"{i + 1} razmjena za {odabraniStudent.StudentInfo} na {odabraniUni.Naziv} " +
                    $"({novaRazmjena.DatumPocetak.ToString("dd.MM.yyyy")}-" +
                    $"{novaRazmjena.DatumKraj.ToString("dd.MM.yyyy")}){Environment.NewLine}";
                db.RazmjeneIB230030.Add(novaRazmjena);
                db.SaveChanges();
            }
            Action action = () =>
            {
                ucitajRazmjene();
                txtInfo.Text = info;
                MessageBox.Show($"uspjesno gen {broj} razmjena", "info",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);

            };
            BeginInvoke(action);
        }

        private bool validacijaMultiThreadinga()
        {
            return Helpers.Validator.ProvjeriUnos(txtBrojRazmjena, err, Kljucevi.RequiredField)
                && Helpers.Validator.ProvjeriUnos(txtEcts, err, Kljucevi.RequiredField);
        }

        private void btnPotvrda_Click(object sender, EventArgs e)
        {
            
            var frmIzvjestaj = new frmIzvjestaji(odabraniStudent);
            frmIzvjestaj.ShowDialog();
        }
    }
}
