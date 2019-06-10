using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pregunta2
{
    public partial class Frm3 : Form
    {
        public Frm3(Fraterno p, Fraterno.Ropa r)
        {
            InitializeComponent();
            label1.Text = p.nombre + " " + p.apellidos + " con  ci:" + p.ci +
                ",\n tiene las tallas de hombre" + r.hombros;
        }
    }
}
