using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data.IspitIB230030
{
    public class StipendijeGodineIB230030
    {
        public int Id { get; set; }
        public int StipendijaId { get; set; }
        public StipendijeIB230030 Stipendija { get; set; }
        public string Godina { get; set; }
        public int Iznos { get; set; }
        public bool Aktivan { get; set; }
        public int Ukupno => Iznos * 12 ;

        public override string ToString()
        {
            return $"{Stipendija.Naziv}";
        }

    }
}
