using BusinessLogicLayer;
using System;
using System.Windows.Forms;

namespace Imobiliaria_604
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        int nCorretor;
        string nmCorretor;



       

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            try
            {
                BLL.Visita.insertVisita(Convert.ToInt32(textBox1.Text), textBox2.Text, textBox3.Text, Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text), comboBox1.Text, dateTimePicker1.Value, Convert.ToBoolean(textBox6.Text));
              
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                this.Close();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO","ERRO");
            }
        }


        private void Form9_Load(object sender, EventArgs e)
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
            
            dataGridView3.Columns["Observacao"].Visible = false;
            dataGridView3.Columns["Imagem"].Visible = false;
            dataGridView3.Columns["Atividade"].Visible = false;

            textBox6.Text = "True";

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            this.dateTimePicker1.Value = DateTime.Now.Date;
        }

        private void bunifuButton5_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();   
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Global.row = dataGridView1.Rows[e.RowIndex];
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}
