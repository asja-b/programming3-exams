using DLWMS.Data.IspitIB230030;
using DLWMS.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Reporting.WinForms;

namespace DLWMS.WinApp.Izvjestaji
{
    public partial class frmIzvjestaji : Form
    {
        DLWMSContext db = new DLWMSContext();
        private StipendijeGodineIB230030? odabranaStipendija;

        public frmIzvjestaji()
        {
            InitializeComponent();            
        }

        public frmIzvjestaji(StipendijeGodineIB230030? odabranaStipendija)
        {
            this.odabranaStipendija = odabranaStipendija;
            InitializeComponent();
        }

        private void frmIzvjestaji_Load(object sender, EventArgs e)
        {
            printajReport();
            reportViewer1.RefreshReport(); 
        }

        private void printajReport()
        {
            var stipendijeStudenata = db.StudentiStipendijeIB230030
                .Include(x=>x.Student)
                .Include(x=>x.StipendijaGodina)
                .Where(x=>x.StipendijaGodinaId==odabranaStipendija.Id)
                .ToList();

            var tblStipendije = new dsDLWMS.dsStipendijeDataTable();

            for (int i = 0; i < stipendijeStudenata.Count(); i++)
            {
                var red = tblStipendije.NewdsStipendijeRow();

                red.Rb = (i + 1).ToString();
                red.BrojIndeksaImePrezime = stipendijeStudenata[i].Student.ToString();
                red.MjesečniIznos = stipendijeStudenata[i].StipendijaGodina.Iznos.ToString();
                red.UkupniIznos = stipendijeStudenata[i].Ukupno.ToString();

                tblStipendije.Rows.Add(red);
            }
            var rds = new ReportDataSource();
            rds.Value = tblStipendije;
            rds.Name = "dsStipendije";
            reportViewer1.LocalReport.DataSources.Add(rds);

            var sumaUkupno = stipendijeStudenata.Sum(x => x.Ukupno);
            var rpc = new ReportParameterCollection();
            rpc.Add(new ReportParameter("godina", odabranaStipendija.Godina));
            rpc.Add(new ReportParameter("naziv", odabranaStipendija.Stipendija.Naziv));
            rpc.Add(new ReportParameter("ukupno", $"{sumaUkupno} BAM"));
            reportViewer1.LocalReport.SetParameters(rpc);
        }
    }
}
