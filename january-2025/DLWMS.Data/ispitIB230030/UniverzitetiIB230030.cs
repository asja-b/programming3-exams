using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data.ispitIB230030
{
    public class UniverzitetiIB230030
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public int DrzavaId { get; set; }
        public Drzava Drzava { get; set; }

        public override string ToString()
        {
            return Naziv;
        }
    }
}
