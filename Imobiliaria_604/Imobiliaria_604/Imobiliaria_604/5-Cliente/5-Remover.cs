using BusinessLogicLayer;
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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        int IdCliente = 0;

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Tens certeza madje??", "?", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                int x = BLL.Cliente.deleteCliente(IdCliente);
                dataGridView1.DataSource = BLL.Cliente.Load();

            }
        }
    }
}
