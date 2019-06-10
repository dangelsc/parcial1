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
    public partial class Frm2 : Form
    {
        Fraterno persona;
        public Frm2(Fraterno per)
        {
            InitializeComponent();
            persona = per;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Fraterno.Ropa ropa = new Fraterno.Ropa();
            decimal x;
            decimal.TryParse(tbbrazo.Text, out x);
            ropa.brazos = x;

            decimal.TryParse(tbcintura.Text, out x);
            ropa.cintura = x;
            decimal.TryParse( tbhombros.Text, out x);
            ropa.hombros = x;
            decimal.TryParse(tbpierna.Text, out x);
            ropa.piernas = x;
            Frm3 aux = new Frm3(persona,ropa);
            aux.ShowDialog();
        }
    }
}

