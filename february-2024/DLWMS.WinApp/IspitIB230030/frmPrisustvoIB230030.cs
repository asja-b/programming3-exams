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
using DLWMS.WinApp.Helpers;
using Microsoft.EntityFrameworkCore;

namespace DLWMS.WinApp.IspitIB230030
{
    public partial class frmPrisustvoIB230030 : Form
    {
        DLWMSContext db = new DLWMSContext();
        private ProstorijeIB230030? odabranaProstorija;
        List<PrisustvoIB230030> prisustvo;

        public frmPrisustvoIB230030()
        {
            InitializeComponent();
        }

        public frmPrisustvoIB230030(ProstorijeIB230030? odabranaProstorija)
        {
            this.odabranaProstorija = odabranaProstorija;
            InitializeComponent();
        }

        private void frmPrisustvoIB230030_Load(object sender, EventArgs e)
        {
            dgvPrisustvo.AutoGenerateColumns = false;
            lblNazivOznaka.Text = $"{odabranaProstorija} - {odabranaProstorija.Oznaka}";
            ucitajComboBox();

        }

        private void ucitajComboBox()
        {
            cbNastava.DataSource = db.NastavaIB230030
                .Where(x => x.ProstorijaId == odabranaProstorija.Id)
                .ToList();
            cbNastava.DisplayMember = "Oznaka";
            cbStudent.DataSource = db.Studenti.ToList();
        }

        private void cbNastava_SelectedIndexChanged(object sender, EventArgs e)
        {
            ucitajPrisustva();
        }

        private void ucitajPrisustva()
        {
            var odabranaNastava = cbNastava.SelectedItem as NastavaIB230030;
            prisustvo = db.PrisustvoIB230030
                .Include(x => x.Nastava.Predmet)
                .Where(x => x.NastavaId == odabranaNastava.Id)
                .ToList();
            if (prisustvo != null)
            {
                dgvPrisustvo.DataSource = null;
                dgvPrisustvo.DataSource = prisustvo;
            }
            lblKapacitet.Text = $"{prisustvo.Count()}/{odabranaProstorija.Kapacitet}";
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {

            if (validacija())
            {
                var nastava = cbNastava.SelectedItem as NastavaIB230030;
                var student = cbStudent.SelectedItem as Student;
                if (prisustvo.Count > odabranaProstorija.Kapacitet)
                {
                    MessageBox.Show($"kapacitet {odabranaProstorija} je pun", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (prisustvo.Exists(x => x.StudentId == student.Id))
                {
                    MessageBox.Show($"student je na drugoj nastavu", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    var novoPrisustvo = new PrisustvoIB230030
                    {
                        NastavaId = nastava.Id,
                        StudentId = student.Id
                    };
                    db.PrisustvoIB230030.Add(novoPrisustvo);
                    db.SaveChanges();
                    ucitajPrisustva();
                }


            }
        }

        private bool validacija()
        {
            return Helpers.Validator.ProvjeriUnos(cbNastava, err, Kljucevi.RequiredField);
        }

        private async void btnGenerisi_Click(object sender, EventArgs e)
        {
            if (validirajMultiThreading())
            {
                var nastava = cbNastava.SelectedItem as NastavaIB230030;
                var student = cbStudent.SelectedItem as Student;
                await Task.Run(() => Generisi(nastava,student));
            }
        }

        private void Generisi(NastavaIB230030? nastava, Student? student)
        {
            var info= "";
            var broj=int.Parse(txtBrojZapisa.Text);
            for (int i = 0; i < broj; i++)
            {
                Thread.Sleep(300);

                var novoPrisustvo = new PrisustvoIB230030 { 
                StudentId=student.Id,
                NastavaId=nastava.Id
                };
                db.PrisustvoIB230030.Add(novoPrisustvo);
                db.SaveChanges();
                info += $"{DateTime.Now.ToString("dd.MM HH::mm::ss")}->{student} za {nastava}{Environment.NewLine}";

            }
            Action action = () => {

                MessageBox.Show($"uspjesno ste dodali {broj} prisustva ", "info"
                     , MessageBoxButtons.OK, MessageBoxIcon.Information);
                ucitajPrisustva();
                txtInfo.Text = info;
            };
            BeginInvoke(action);
        }

        private bool validirajMultiThreading()
        {
            return Helpers.Validator.ProvjeriUnos(txtBrojZapisa,err, Kljucevi.RequiredField);
        }
    }
}
