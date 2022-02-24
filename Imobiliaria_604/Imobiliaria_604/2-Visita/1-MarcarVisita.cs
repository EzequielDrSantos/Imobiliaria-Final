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

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            Form15 form15 = new Form15();
            form15.Show();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            Form18 form18 = new Form18();
            form18.Show();

        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            Form19 form19 = new Form19();
            form19.Show();
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {

            //try
            //{
            //    BLL.Visita.insertVisita(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), textBox3.Text, Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text), textBox6.Text, comboBox1.Text);
            //    textBox2.Clear();
            //    textBox1.Clear();
            //    textBox3.Clear();
            //    textBox4.Clear();
            //    textBox5.Clear();
            //    textBox6.Clear();


            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Erro:" + ex, "Dados Não Inseridos");
            //}
        }
    

        private void Form9_Load(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
