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
    public partial class frmStipendijaAddEditIB230030 : Form
    {
        DLWMSContext db = new DLWMSContext();
        private StudentiStipendijeIB230030 odabranaStipendija;

        public frmStipendijaAddEditIB230030()
        {
            InitializeComponent();
        }

        public frmStipendijaAddEditIB230030(StudentiStipendijeIB230030 odabranaStipendija)
        {
            this.odabranaStipendija = odabranaStipendija;
            InitializeComponent();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (validacija())
            {
                var student = cbStudent.SelectedItem as Student;
                var stipendijaGodina = cbStipendija.SelectedItem as StipendijeGodineIB230030;

                if (odabranaStipendija == null)
                {
                    // Provjera da student već nema stipendiju u odabranoj godini
                    /*if (db.StudentiStipendijeIB230030.Include(x => x.StipendijaGodina).ToList().Exists(x => x.StipendijaGodina.Godina == stipendijaGodina.Godina && x.StudentId == student.Id))
                    {
                        MessageBox.Show($"Student {student} već ima stipendiju " +
                            $"u {stipendijaGodina.Godina} godini.", "Upozorenje",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else
                    {*/
                     var novaStudentiStipendija= new StudentiStipendijeIB230030{
                     StudentId=student.Id,
                     StipendijaGodinaId=stipendijaGodina.Id
                     };
                     db.StudentiStipendijeIB230030.Add(novaStudentiStipendija);
                    //}
                    
                }
                else
                {
                    /*if (stipendijaGodina != odabranaStipendija.StipendijaGodina)
                    {
                        MessageBox.Show($"Student {student} se ne može urediti" +
                            $" stipendija na drugoj godini jer postoji mogućnost" +
                            $" da već ima stipendije na toj godini.", "Upozorenje",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }*/
                    odabranaStipendija.StipendijaGodinaId = stipendijaGodina.Id;
                    odabranaStipendija.StipendijaGodina = stipendijaGodina;

                    odabranaStipendija.StudentId = student.Id;
                    odabranaStipendija.Student = student;

                    db.StudentiStipendijeIB230030.Update(odabranaStipendija);
                }
                db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
        }

        private bool validacija()
        {
            return Helpers.Validator.ProvjeriUnos(cbStipendija, err, Kljucevi.RequiredField);
        }

        private void frmStipendijaAddEditIB230030_Load(object sender, EventArgs e)
        {
            ucitajComboBox();
            ucitajInfo();

        }

        private void ucitajInfo()
        {
            if (odabranaStipendija != null)
            {
                // ovdje trazimo da se indexu u cb doda index koji se poklapa odabranoj stip tj njebom studentu i idu studenta
                cbStudent.SelectedIndex = db.Studenti.ToList().FindIndex(x => x.Id == odabranaStipendija.StudentId);
                cbStudent.Enabled = false;//ovdje zabrana promjene studenta
                cbGodina.SelectedItem = odabranaStipendija.StipendijaGodina.Godina;
                // preko odstip sto je stipgodine idemo u stip godine jer ono sadrzi godine

                // i ovdje stavljamo stip samo one koje se poklapaju s odabranim 
                cbStipendija.SelectedIndex = db.StipendijeGodineIB230030.ToList().FindIndex(x => x.StipendijaId == odabranaStipendija.StipendijaGodina.StipendijaId);
            }
            else
            {
                cbGodina.SelectedIndex = 0; 
                //ovo je za add pa da se odmah
                //prikaze nesto a kod edita ce se morati prikazati
                //stvarna stip top studenta
            }
            
        }

        private void ucitajComboBox()
        {
           cbStudent.DataSource = db.Studenti.ToList();
        }

        private void cbGodina_SelectedIndexChanged(object sender, EventArgs e)
        {
            var godina = cbGodina.SelectedItem.ToString();

            cbStipendija.DataSource = db.StipendijeGodineIB230030
                .Include(x=>x.Stipendija)
                .Where(x=>x.Godina==godina)
                .ToList();
        }
    }
}
