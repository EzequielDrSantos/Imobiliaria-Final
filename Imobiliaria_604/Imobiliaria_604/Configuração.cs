using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Imobiliaria_604
{
    public partial class Configuração : Form
    {
        public Configuração()
        {
            InitializeComponent();
        }
        string t1;
        string t2;
        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            textBox2.Text = t1;
            textBox3.Text = t2;
            if (t1 == t2)
            {
              
            }
        }
    }
}
