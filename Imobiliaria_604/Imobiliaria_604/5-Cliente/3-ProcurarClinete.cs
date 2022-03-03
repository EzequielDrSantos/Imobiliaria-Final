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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Global.row = dataGridView1.Rows[e.RowIndex];
            
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL.Cliente.Load();
        }
    }
}
