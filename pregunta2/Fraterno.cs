using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pregunta2
{
    public class Fraterno
    {
        public string nombre { get; set; }
        public string apellidos { get; set; }

        public string ci { get; set; }
        public string direccion { get; set; }
        public Int64 telenofo { get; set; }
        public class Ropa {
            public decimal hombros { get; set; }
            public decimal cintura { get; set; }
            public decimal brazos { get; set; }
            public decimal piernas { get; set; }
        }
    }
}
