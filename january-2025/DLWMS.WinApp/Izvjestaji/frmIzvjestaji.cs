using DLWMS.Data;
using DLWMS.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Reporting.WinForms;

namespace DLWMS.WinApp.Izvjestaji
{
    public partial class frmIzvjestaji : Form
    {
        DLWMSContext db = new DLWMSContext();
        private Student odabraniStudent;

        public frmIzvjestaji()
        {
            InitializeComponent();            
        }

        public frmIzvjestaji(Student odabraniStudent)
        {
            this.odabraniStudent = odabraniStudent;
            InitializeComponent();
        }

        private void frmIzvjestaji_Load(object sender, EventArgs e)
        {
            printajReport();
            reportViewer1.RefreshReport(); 
        }

        private void printajReport()
        {
            var razmjene = db.RazmjeneIB230030
                .Include(x => x.Univerzitet.Drzava)
                .Where(x => x.StudentId == odabraniStudent.Id)
                .ToList();

            var tblRazmjene = new dsDLWMS.dsRazmjeneDataTable();
            for (int i = 0; i < razmjene.Count(); i++)
            {
                var red = tblRazmjene.NewdsRazmjeneRow();
                red.Rb = (i + 1).ToString();
                red.Univerzitet = $"{razmjene[i].Univerzitet.Naziv} ({razmjene[i].Univerzitet.Drzava.Naziv})";
                red.Pocetak = razmjene[i].DatumPocetak.ToString();
                red.Kraj = razmjene[i].DatumKraj.ToString();
                red.ECTS = razmjene[i].ECTS.ToString();
                red.Okoncano = razmjene[i].Okoncana ? "DA" : "NE";

                tblRazmjene.Rows.Add(red);
            }
            var rds = new ReportDataSource();
            rds.Value = tblRazmjene;
            rds.Name = "dsRazmjene";
            reportViewer1.LocalReport.DataSources.Add(rds);

            var sumaEcts = razmjene.Sum(x => x.ECTS);
            var rpc = new ReportParameterCollection();
            rpc.Add(new ReportParameter("student", odabraniStudent.StudentInfo));
            rpc.Add(new ReportParameter("ects", sumaEcts.ToString()));
            reportViewer1.LocalReport.SetParameters(rpc);
        }
    }
}
