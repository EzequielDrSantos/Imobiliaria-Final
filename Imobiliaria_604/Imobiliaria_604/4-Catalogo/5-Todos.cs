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
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            Form12 form12 = new Form12();
            form12.Show();  
        }

        private void Form17_Load(object sender, EventArgs e)
        {

        }
    }
}
