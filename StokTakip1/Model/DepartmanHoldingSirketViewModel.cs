using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip1.Model
{
    public class DepartmanHoldingSirketViewModel
    {
        public Departmanlar Departman { get; set; }
        public Sirketler Sirket { get; set; }
        public Holdingler Holding { get; set; }
    }
}
