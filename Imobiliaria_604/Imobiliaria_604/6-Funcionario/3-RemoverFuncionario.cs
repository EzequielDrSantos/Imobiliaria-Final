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
    public partial class Form22 : Form
    {
        public Form22()
        {
            InitializeComponent();
        }

        private void Form22_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL.Funcionario.Load();
            dataGridView1.Columns["Cargo"].Visible = false;
            dataGridView1.Columns["Password"].Visible = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Global.row = dataGridView1.Rows[e.RowIndex];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
