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
    public partial class Form1 : Form
    {
        Fraterno per = new Fraterno();
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            per.apellidos = tbapellidos.Text;
            per.nombre = tbnombre.Text;
            per.ci = tbci.Text;
            per.direccion = tbdireccion.Text;
            Int64 x;
            Int64.TryParse(tbtelefono.Text, out x);
            per.telenofo = x;
            Frm2 aux = new Frm2(per);
            aux.ShowDialog();
        }
    }
}
