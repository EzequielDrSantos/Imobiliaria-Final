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
            dataGridView1.Columns["AreaTotal"].Visible = false;
            dataGridView1.Columns["AreaBruta"].Visible = false;
            dataGridView1.Columns["Quarto"].Visible = false;
            dataGridView1.Columns["CasaDeBanho"].Visible = false;
            dataGridView1.Columns["Elevador"].Visible = false;
            dataGridView1.Columns["Estacionamento"].Visible = false;
            dataGridView1.Columns["Eficiencia"].Visible = false;
            dataGridView1.Columns["AnoConstrucao"].Visible = false;
            dataGridView1.Columns["TipoImovel"].Visible = false;
            dataGridView1.Columns["Para"].Visible = false;
            dataGridView1.Columns["Nfunc"].Visible = false;
            dataGridView1.Columns["Observacao"].Visible = false;
            dataGridView1.Columns["Imagem"].Visible = false;
            dataGridView1.Columns["Atividade"].Visible = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Global.row = dataGridView1.Rows[e.RowIndex];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
