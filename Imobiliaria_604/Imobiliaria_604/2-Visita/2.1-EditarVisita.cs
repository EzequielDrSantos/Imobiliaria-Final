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
    public partial class EditarVisita : Form
    {
        int id;
        public EditarVisita()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form11 form11 = new Form11();
            form11.Show();  
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form12 form12 = new Form12();
            form12.Show();  
        }

        private void EditarVisita_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL.Funcionario.Load();
            dataGridView2.DataSource = BLL.Cliente.Load();
            dataGridView3.DataSource = BLL.Imovel.Load();

            dataGridView1.Columns["Cargo"].Visible = false;
            dataGridView1.Columns["Password"].Visible = false;
            dataGridView1.Columns["Email"].Visible = false;
            dataGridView1.Columns["Telefone"].Visible = false;
            dataGridView1.Columns["CC"].Visible = false;
            dataGridView1.Columns["NIF"].Visible = false;
            dataGridView1.Columns["NIB"].Visible = false;
            dataGridView1.Columns["Atividade"].Visible = false;


            dataGridView2.Columns["CC"].Visible = false;
          
            dataGridView2.Columns["Telefone"].Visible = false;
            dataGridView2.Columns["CC"].Visible = false;
            dataGridView2.Columns["Distrito"].Visible = false;
            dataGridView2.Columns["Cidade"].Visible = false;
            dataGridView2.Columns["Atividade"].Visible = false;

            dataGridView3.Columns["AreaTotal"].Visible = false;
            dataGridView3.Columns["AreaBruta"].Visible = false;
            dataGridView3.Columns["Quarto"].Visible = false;
            dataGridView3.Columns["CasaDeBanho"].Visible = false;
            dataGridView3.Columns["Elevador"].Visible = false;
            dataGridView3.Columns["Estacionamento"].Visible = false;
            dataGridView3.Columns["Eficiencia"].Visible = false;
            dataGridView3.Columns["AnoConstrucao"].Visible = false;
            dataGridView3.Columns["Distrito"].Visible = false;
            dataGridView3.Columns["Cidade"].Visible = false;
            dataGridView3.Columns["TipoImovel"].Visible = false;
            dataGridView3.Columns["Para"].Visible = false;
            dataGridView3.Columns["Preco"].Visible = false;
            dataGridView3.Columns["Nfunc"].Visible = false;
            dataGridView3.Columns["Observacao"].Visible = false;
            dataGridView3.Columns["Imagem"].Visible = false;
            dataGridView3.Columns["Atividade"].Visible = false;

            textBox6.Text = "True";

            id = (int)Global.row.Cells[0].Value;
            textBox1.Text = "" + Global.row.Cells[1].Value;
            textBox2.Text = "" + Global.row.Cells[2].Value;
            textBox3.Text = "" + Global.row.Cells[3].Value;
            textBox4.Text = "" + Global.row.Cells[4].Value;
            textBox5.Text = "" + Global.row.Cells[5].Value;
            comboBox1.Text = "" + Global.row.Cells[6].Value;
           dateTimePicker1.Value = Convert.ToDateTime(Global.row.Cells[7].Value);
            

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            BLL.Visita.updateVisita(id, Convert.ToInt32(textBox1.Text), textBox2.Text, textBox3.Text, Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text), comboBox1.Text, dateTimePicker1.Value,Convert.ToBoolean(textBox6.Text));
            textBox2.Clear();
            textBox1.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            comboBox1.Items.Clear();
            this.Close();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Global.row = dataGridView1.Rows[e.RowIndex];
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Global.row = dataGridView2.Rows[e.RowIndex];
            textBox3.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox4.Text = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Global.row = dataGridView3.Rows[e.RowIndex];
            textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
    }
}
