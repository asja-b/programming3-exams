using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data.IspitIB230030
{
    public class StudentiStipendijeIB230030
    {
        // biramo studentistip za dgvpretraga jer nam trebaju podaci i o studentu i o stip god
        //da sm0o uzeli bilo koju drugu ne bi mogli dohvatiti ili studenta ili stip god
        public int Id { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int StipendijaGodinaId { get; set; }
        public StipendijeGodineIB230030 StipendijaGodina { get; set; }

        //hvatamo godinu jer se nalazi u stipgod
        public string GodinaInfo => StipendijaGodina?.Godina ?? "N/A";

        //hvatamo naziv stipendije
        public string StipendijaInfo => StipendijaGodina?.Stipendija?.Naziv ?? "N/A";

        //hvatamo mjesecni iznos sto je zapravo iznos u stipgod
        public int MjesecniIznosInfo => StipendijaGodina?.Iznos ?? 0;

        //nije 100% ali najbrzi nacin
        public int Ukupno => StipendijaGodina?.Iznos * 12 ?? 0;
    }
}
