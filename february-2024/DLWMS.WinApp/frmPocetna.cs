using DLWMS.Infrastructure;
using DLWMS.WinApp.IspitIB230030;
using DLWMS.WinApp.Izvjestaji;

namespace DLWMS.WinApp
{
    public partial class frmPocetna : Form
    {
        DLWMSContext db = new DLWMSContext();
        public frmPocetna()
        {
            InitializeComponent();
        }

        private void frmPocetna_Load(object sender, EventArgs e)
        {
            lblKonekcijaInfo.Text = $"Broj studenata u bazi -> {db.Studenti.Count()}";
        }

        private void btnIspit_Click(object sender, EventArgs e)
        {
            var frmProstorije = new frmProstorijeIB230030();
            frmProstorije.ShowDialog();
            
        }
    }
}
