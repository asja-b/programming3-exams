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
using Microsoft.EntityFrameworkCore;

namespace DLWMS.WinApp.IspitIB230030
{
    public partial class frmPretragaIB230030 : Form
    {
        DLWMSContext db = new DLWMSContext();
        List<StudentiStipendijeIB230030> studentiStipendije;

        public frmPretragaIB230030()
        {
            InitializeComponent();
        }

        private void frmPretragaIB230030_Load(object sender, EventArgs e)
        {
            dgvStudentiStipendije.AutoGenerateColumns = false;
            ucitajComboBox();
        }

        private void ucitajComboBox()
        {
            cbGodina.SelectedIndex = 0;
            cbStipendije.DataSource = db.stipendijeIB230030.ToList();
        }

        private void cbGodina_SelectedIndexChanged(object sender, EventArgs e)
        {
            ucitajStudentiStipendije();
        }

        private void cbStipendije_SelectedIndexChanged(object sender, EventArgs e)
        {
            ucitajStudentiStipendije();
        }

        private void ucitajStudentiStipendije()
        {
            var godina = cbGodina.SelectedItem?.ToString() ?? string.Empty;
            // odabranu godinu stavi kao string ili posalji prazan
            var stipendija = cbStipendije.SelectedItem as StipendijeIB230030 ?? new StipendijeIB230030();
            studentiStipendije = db.StudentiStipendijeIB230030
                .Include(x => x.Student)
                .Include(x => x.StipendijaGodina.Stipendija)
                .Where(x => x.StipendijaGodina.Godina == godina)
                .Where(x => x.StipendijaGodina.StipendijaId == stipendija.Id)
                .ToList();

            this.Text = $"Broj prikazanih studenata {studentiStipendije.Count()}";

            if (studentiStipendije != null)
            {
                dgvStudentiStipendije.DataSource = null;
                dgvStudentiStipendije.DataSource = studentiStipendije;
            }

            if (studentiStipendije.Count() == 0)
            {
                MessageBox.Show($"u bazi nisu evidentirani studenti kojima je " +
                    $"u {godina}. godini dodijeljena {stipendija} stipendija "
                    , "upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvStudentiStipendije_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var odabraniStudentStipendije = studentiStipendije[e.RowIndex];
            if (e.ColumnIndex == 5)
            {
                if (MessageBox.Show("Da li ste sigurni da želite ukloniti stipendiju ?", "Upit",
                     MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    db.StudentiStipendijeIB230030.Remove(odabraniStudentStipendije);
                    db.SaveChanges();
                    ucitajStudentiStipendije();
                }
            }
        }

        private void btnDodajStipendiju_Click(object sender, EventArgs e)
        {
            var frmStipendijaAdd = new frmStipendijaAddEditIB230030();
            if (frmStipendijaAdd.ShowDialog() == DialogResult.OK)
            {
                ucitajStudentiStipendije();
                MessageBox.Show($"uspjesno ste dodali novu stipendiju "
                   , "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvStudentiStipendije_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var odabranaStipendija = studentiStipendije[e.RowIndex];
            if (e.ColumnIndex != 5)
            {
                var frmStipendijeEdit = new frmStipendijaAddEditIB230030(odabranaStipendija);
                if (frmStipendijeEdit.ShowDialog() == DialogResult.OK)
                {
                    ucitajStudentiStipendije();
                    MessageBox.Show($"uspjesno ste editovali "
                   , "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnStipendijePoGodinama_Click(object sender, EventArgs e)
        {
            var frmStipendije = new frmStipendijeIB230030();
            if (frmStipendije.ShowDialog() == DialogResult.OK)
            {

              
                ucitajStudentiStipendije();
            }
        }
    }
}
