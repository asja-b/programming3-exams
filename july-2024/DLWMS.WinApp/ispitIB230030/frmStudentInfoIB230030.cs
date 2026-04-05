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
using DLWMS.WinApp.Helpers;

namespace DLWMS.WinApp.ispitIB230030
{
    public partial class frmStudentInfoIB230030 : Form
    {
        DLWMSContext db=new DLWMSContext();
        private Student odabraniStudent;

        public frmStudentInfoIB230030()
        {
            InitializeComponent();
        }

        public frmStudentInfoIB230030(Student odabraniStudent)
        {
            this.odabraniStudent = odabraniStudent;
            InitializeComponent();
        }

        private void frmStudentInfoIB230030_Load(object sender, EventArgs e)
        {
            this.Text = odabraniStudent.BrojIndeksa;
            pbSlika.Image = odabraniStudent.Slika.ToImage();
            lblIme.Text = odabraniStudent.ImePrezime;
            lblGrad.Text = $"Grad: {odabraniStudent.Grad}";
        }
    }
}
