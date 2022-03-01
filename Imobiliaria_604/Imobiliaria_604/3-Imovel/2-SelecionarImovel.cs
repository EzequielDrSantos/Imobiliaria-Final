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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            
            Form4 form4 = new Form4();
            form4.Show();
            this.Close();
            
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            
             dataGridView1.DataSource = BLL.Imovel.Load();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Global.row = dataGridView1.Rows[e.RowIndex];
            //MessageBox.Show("" + Global.row.Cells[0].Value, "");

            
        }
    }
}
