using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenParcial1
{
    public partial class Form1 : Form
    {
        List<String> nombres = new List<string>();
        public Form1()
        {
            InitializeComponent();
            nombres.Add("juan");
            nombres.Add("marco");
            nombres.Add("daniel");
            nombres.Add("tomas");
            nombres.Add("alex");
            nombres.Add("juanita");
            nombres.Add("julia");
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            string x=textBox1.Text;
            x=((TextBox)sender).Text;
            dataGridView1.DataSource = nombres.Where(a => a.Contains(x)).Select(a=>new { nombre=a}).ToList();
        }
    }
}
