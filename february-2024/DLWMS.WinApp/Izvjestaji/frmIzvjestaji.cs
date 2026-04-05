using DLWMS.Data.IspitIB230030;
using DLWMS.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Reporting.WinForms;

namespace DLWMS.WinApp.Izvjestaji
{
    public partial class frmIzvjestaji : Form
    {
        DLWMSContext db = new DLWMSContext();
        private ProstorijeIB230030? odabranaProstorija;

        public frmIzvjestaji()
        {
            InitializeComponent();
        }
        public frmIzvjestaji(ProstorijeIB230030? odabranaProstorija)
        {
            this.odabranaProstorija = odabranaProstorija;
            InitializeComponent();
        }

        private void frmIzvjestaji_Load(object sender, EventArgs e)
        {
            printajReport();
            reportViewer1.RefreshReport(); 
        }

        private void printajReport()
        {
            var prisustvo = db.PrisustvoIB230030
                .Include(x=>x.Nastava.Predmet)
                .Include(x=>x.Student)
                .Where(x=>x.Nastava.ProstorijaId==odabranaProstorija.Id)
                .ToList();

            var tblNastava = new dsIzvjestajIB230030.dsNastavaDataTable();
            for (int i = 0; i < prisustvo.Count(); i++)
            {
                var red = tblNastava.NewdsNastavaRow();
                red.Rb = (i + 1).ToString();
                red.Predmet = prisustvo[i].Nastava.Predmet.Naziv;
                red.Vrijeme = prisustvo[i].Nastava.Vrijeme;
                red.BrojIndeksa = prisustvo[i].Student.BrojIndeksa;
                red.ImePrezime = $"{prisustvo[i].Student.Ime} {prisustvo[i].Student.Prezime}";

                tblNastava.Rows.Add(red);
            }
            var rds = new ReportDataSource();
            rds.Value = tblNastava;
            rds.Name = "dsNastava";
            reportViewer1.LocalReport.DataSources.Add(rds);

            var rpc = new ReportParameterCollection();
            rpc.Add(new ReportParameter("Prostorija", odabranaProstorija.Naziv));
            rpc.Add(new ReportParameter("Broj", prisustvo.Count().ToString()));
            reportViewer1.LocalReport.SetParameters(rpc);
        }
    }
}
