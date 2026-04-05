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
using DLWMS.WinApp.Izvjestaji;
using Microsoft.EntityFrameworkCore;

namespace DLWMS.WinApp.ispitIB230030
{
    public partial class frmUvjerenjaIB230030 : Form
    {
        private Student odabraniStudent;
        DLWMSContext db = new DLWMSContext();
        List<StudentiUvjerenjaIB230030> uvjerenja;

        public frmUvjerenjaIB230030(Student odabraniStudent)
        {
            this.odabraniStudent = odabraniStudent;
            InitializeComponent();
        }

        private void frmUvjerenjaIB230030_Load(object sender, EventArgs e)
        {
            dgvUvjerenja.AutoGenerateColumns = false;

            ucitajUvjerenja();
            cbVrsta.SelectedIndex = 0;
        }

        private void ucitajUvjerenja()
        {
            uvjerenja = db.StudentiUvjerenjaIB230030
               .Include(x => x.Student)
               .Where(x => x.StudentId == odabraniStudent.Id)
               .ToList();


            if (uvjerenja != null)
            {
                dgvUvjerenja.DataSource = null;
                dgvUvjerenja.DataSource = uvjerenja;
            }
            this.Text = $"broj uvjerenja => {uvjerenja.Count()}";
        }

        private void dgvUvjerenja_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //var odabranoUvjerenje = dgvUvjerenja.SelectedRows[0].DataBoundItem as StudentiUvjerenjaIB230030;
            var odabranoUvjerenje = uvjerenja[e.RowIndex];
            if (e.ColumnIndex == 5)
            {
                if (MessageBox.Show("da li ste sigurni da zelite izbrisati odabrano uvjerenje? "
                    , "pitanje", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    db.StudentiUvjerenjaIB230030.Remove(odabranoUvjerenje);
                    
                }
            }else if (e.ColumnIndex == 6)
            {
                var frmizvjestaj = new frmIzvjestaji(odabranoUvjerenje);
                frmizvjestaj.ShowDialog();
                odabranoUvjerenje.Prinatno = true;
                db.StudentiUvjerenjaIB230030.Update(odabranoUvjerenje);
            }
            db.SaveChanges();
            ucitajUvjerenja();
        }

        private void btnNoviZahtjev_Click(object sender, EventArgs e)
        {
            var frmNoviZahtjev = new frmNovoUvjerenjeIB230030(odabraniStudent);
            if (frmNoviZahtjev.ShowDialog() == DialogResult.OK)
            {
                ucitajUvjerenja();
            }
        }

        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            if (validacijaMultiThreadinga())
            {
                var vrsta = cbVrsta.SelectedItem.ToString();
                await Task.Run(()=>generisiUvjerenja(vrsta));
            }
        }

        private void generisiUvjerenja(string? vrsta)
        {
            var info = "";
            var broj = int.Parse(txtBroj.Text);
            var svrha = txtSvrha.Text;
            for (int i = 0; i < broj; i++)
            {
                Thread.Sleep(300);
                var novoUvjerenje = new StudentiUvjerenjaIB230030() { 
                StudentId=odabraniStudent.Id,
                Vrsta=vrsta,
                Svrha=svrha,
                Uplatnica = uvjerenja[0].Uplatnica,
                Vrijeme=DateTime.Now,
                Prinatno=false,
                };
                info+= $"{DateTime.Now.ToString("HH:mm:ss")}-> " +
                    $"{vrsta} studentu {odabraniStudent} u svrhu {svrha}{Environment.NewLine}";
                db.StudentiUvjerenjaIB230030.Add(novoUvjerenje);
                db.SaveChanges();
            }
            Action action = () =>
            {
                MessageBox.Show($"uspjesno je generisan {broj} zahtjeva", "info",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtInfo.Text = info;
                ucitajUvjerenja();
            };
            BeginInvoke(action);
        }

        private bool validacijaMultiThreadinga()
        {
            return Helpers.Validator.ProvjeriUnos(txtBroj, err, Kljucevi.RequiredField)
                && Helpers.Validator.ProvjeriUnos(txtSvrha, err, Kljucevi.RequiredField);
        }
    }
}
