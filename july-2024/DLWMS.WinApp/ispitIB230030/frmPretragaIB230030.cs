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
            cbSpol.DataSource = db.Spolovi.ToList();
        }
        private void ucitajStudente()
        {
            var spol = cbSpol.SelectedItem as Spol ?? new Spol();
            var datumOd = dtpDatumOd.Value;
            var datumDo = dtpDatumDo.Value;

            studenti = db.Studenti
                .Include(x => x.Spol)
                .Include(x => x.Grad)
                .Where(x => x.SpolId == spol.Id)
                .Where(x => x.DatumRodjenja >= datumOd && x.DatumRodjenja <= datumDo)
                .ToList();


            if (studenti != null)
            {
                dgvStudent.DataSource = null;
                dgvStudent.DataSource = studenti;
            }
            if (studenti.Count() == 0)
            {
                MessageBox.Show($"U bazi podataka ne postoji \r\nevidencija" +
                   $" o studentima  {spol} spola rođenih u periodu" +
                   $"  {datumOd.Date}-{datumDo.Date}.godine", "info", MessageBoxButtons.OK
                   , MessageBoxIcon.Information);
            }
        }
        private void dtpDatumOd_ValueChanged(object sender, EventArgs e)
        {
            ucitajStudente();
        }



        private void dtpDatumDo_ValueChanged(object sender, EventArgs e)
        {
            ucitajStudente();
        }

        private void cbSpol_SelectedIndexChanged(object sender, EventArgs e)
        {
            ucitajStudente();
        }

        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var odabraniStudent = studenti[e.RowIndex];
            if (e.ColumnIndex <= 4)
            {
                var frmInfoStudent = new frmStudentInfoIB230030(odabraniStudent);
                frmInfoStudent.ShowDialog();
            }
        }

        private void dgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var odabraniStudent=studenti[e.RowIndex];
            if (e.ColumnIndex == 5)
            {
                var frmUvjerenja = new frmUvjerenjaIB230030(odabraniStudent);
                frmUvjerenja.ShowDialog();
            }
        }
    }
}
