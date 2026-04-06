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
using Microsoft.EntityFrameworkCore;
// u cilju pripreme za ispit u formi pretraga koristila sam sve nacine pretrage koje bi mogle doci
// zbog toga forma ima dodatne stvari u odnosu na postavku zadatka
namespace DLWMS.WinApp.ispitIB230030
{
    public partial class frmPretragaIB230030 : Form
    {
        DLWMSContext db = new DLWMSContext();
        List<Student> studenti;
        public frmPretragaIB230030()
        {
            InitializeComponent();
        }

        private void frmPretragaIB230030_Load(object sender, EventArgs e)
        {
            dgvStudent.AutoGenerateColumns = false;
            ucitajComboBox();

        }

        private void ucitajComboBox()
        {
            cbSpol.DataSource = db.Spolovi.ToList();
            cbDrzava.DataSource = db.Drzave.ToList();
        }

        private void ucitajStudente()
        {
            var drzava = cbDrzava.SelectedItem as Drzava ?? new Drzava();//ako je null pravi se nova i tako zaobilazimo RE
            var spol = cbSpol.SelectedItem as Spol ?? new Spol();
            var imePrezime = txtImePrezime.Text.ToLower();
            var aktivan = chbAktivan.Checked;
            var datumOd = dtpDatumOd.Value;
            var datumDo = dtpDatumDo.Value;

            studenti = db.Studenti
                .Include(x => x.Spol)
                .Include(x => x.Grad.Drzava)
                .Where(x => x.Grad.DrzavaId == drzava.Id)
                .Where(x => x.SpolId == spol.Id)
                .Where(x => x.Ime.ToLower().Contains(imePrezime) ||
                x.Prezime.ToLower().Contains(imePrezime))
                .Where(x => x.Aktivan == aktivan)
                .Where(x => x.DatumRodjenja >= datumOd && x.DatumRodjenja <= datumDo)
                .ToList();

            if (dgvStudent != null)
            {
                dgvStudent.DataSource = null;
                dgvStudent.DataSource = studenti;

            }
            if (studenti.Count() == 0)
            {
                /* i mbox sam zakomentarisala kako mi ne bi iskako prilikom svakog pokretanja programa
                 * odkomentarisi za test!*/
                    MessageBox.Show($"u bazi nisu evidentirani studenti" +
                    $" spola {spol}, koji u imenu i prezimenu posjeduju sadrzaj" +
                    $"{imePrezime} a koji su drzavljani {drzava}", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Text = $"Broj prikazanih studenata => {studenti.Count()}";
        }

        private void cbDrzava_SelectedIndexChanged(object sender, EventArgs e)
        {
            ucitajStudente();//na promjenu svakog ucitaj novu selekciju studenata prema odabranom
        }

        private void cbSpol_SelectedIndexChanged(object sender, EventArgs e)
        {
            ucitajStudente();
        }

        private void chbAktivan_CheckedChanged(object sender, EventArgs e)
        {
            ucitajStudente();
        }

        private void dtpDatumOd_ValueChanged(object sender, EventArgs e)
        {
            ucitajStudente();
        }

        private void dtpDatumDo_ValueChanged(object sender, EventArgs e)
        {
            ucitajStudente();
        }

        private void txtImePrezime_TextChanged(object sender, EventArgs e)
        {
            ucitajStudente();
        }

        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var odabraniStudent = studenti[e.RowIndex];
            if (e.ColumnIndex == 4)
            {
                odabraniStudent.Aktivan = !odabraniStudent.Aktivan;

                db.Studenti.Update(odabraniStudent);
                db.SaveChanges();
                ucitajStudente();
            }
        }

        private void dgvStudent_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var odabraniStudent = studenti[e.RowIndex];
            if (e.ColumnIndex < 4)
            {
                var frmStudentEdit = new frmStudentEditIB230030(odabraniStudent);
                if (frmStudentEdit.ShowDialog() == DialogResult.OK)
                {
                    ucitajStudente();
                    MessageBox.Show($"uspjesno ste editovali{odabraniStudent}.", "info",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            var odabraniStudent = studenti[e.RowIndex];
            if (e.ColumnIndex == 5)
            {
                var frmRazmjene = new frmRazmjeneIB230030(odabraniStudent);
                frmRazmjene.ShowDialog();
            }
        }
    }
}
