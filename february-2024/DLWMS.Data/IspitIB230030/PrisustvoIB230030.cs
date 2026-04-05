using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data.IspitIB230030
{
    public class PrisustvoIB230030
    {
        public int Id { get; set; }
        public int NastavaId { get; set; }
        public NastavaIB230030 Nastava { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}
