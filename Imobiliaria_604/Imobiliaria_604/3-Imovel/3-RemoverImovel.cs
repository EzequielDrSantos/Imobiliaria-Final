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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int NºdoImovel = 0;

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Tens certeza ??", "?", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                int x = BLL.Imovel.deleteImovel(NºdoImovel);
                dataGridView1.DataSource = BLL.Imovel.Load();

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Global.row = dataGridView1.Rows[e.RowIndex];
            dataGridView1.DataSource = BLL.Imovel.Load();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL.Imovel.Load();
        }
    }
}
