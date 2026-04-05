using DLWMS.Data.ispitIB230030;
using DLWMS.Infrastructure;
using Microsoft.Reporting.WinForms;

namespace DLWMS.WinApp.Izvjestaji
{
    public partial class frmIzvjestaji : Form
    {
        DLWMSContext db = new DLWMSContext();
        private StudentiUvjerenjaIB230030 odabranoUvjerenje;

        public frmIzvjestaji()
        {
            InitializeComponent();            
        }

        public frmIzvjestaji(StudentiUvjerenjaIB230030 odabranoUvjerenje)
        {
            this.odabranoUvjerenje = odabranoUvjerenje;
            InitializeComponent();
        }

        private void frmIzvjestaji_Load(object sender, EventArgs e)
        {
            printajReport();
            reportViewer1.RefreshReport(); 

        }

        private void printajReport()
        {
            var rpc = new ReportParameterCollection();
            rpc.Add(new ReportParameter("student", $"{odabranoUvjerenje.Student.ImePrezime} " +
                $"({odabranoUvjerenje.Student.BrojIndeksa})"));
            rpc.Add(new ReportParameter("vrsta", odabranoUvjerenje.Vrsta));
            rpc.Add(new ReportParameter("svrha",odabranoUvjerenje.Svrha));
            rpc.Add(new ReportParameter("status",odabranoUvjerenje.Student.Aktivan?"AKTIVAN":"NEAKTIVAN"));

            reportViewer1.LocalReport.SetParameters(rpc);
        }
    }
}
