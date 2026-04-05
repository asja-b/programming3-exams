using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data.IspitIB230030
{
    public class NastavaIB230030
    {
        public int Id { get; set; }
        public int ProstorijaId { get; set; }
        public ProstorijeIB230030 Prostorija { get; set; }
        public int PredmetId { get; set; }
        public Predmet Predmet { get; set; }
        public string Vrijeme { get; set; }
        public string Dan { get; set; }
        public string  Oznaka { get; set; }

        public string NastavaInfo => $"{Predmet} - u {Dan} @ {Vrijeme}" ?? "N/A";
        public override string ToString()
        {
            return $"{Predmet} - u {Dan} @ {Vrijeme}";
        }
    }
}
