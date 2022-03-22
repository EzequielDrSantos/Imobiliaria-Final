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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
       

        private void Form5_Load(object sender, EventArgs e)
        {

            textBox7.Text = "True";


            int idClinete = (int)BLL.IdClinete.IdoCliente();
            if (idClinete == 0)
            {
                textBox1.Text = "1";
            }
            else
            {
                 idClinete = (int)BLL.IdClinete.IdoCliente();
                textBox1.Text = "" + (idClinete + 1);
            }

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            try
            {
                int x = BLL.Cliente.insertCliente(Convert.ToInt32(textBox1.Text), textBox2.Text, textBox3.Text, Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text), comboBox1.Text, textBox14.Text, Convert.ToBoolean(textBox7.Text));
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox1.Clear();
                comboBox1.Items.Clear();
                textBox14.Clear();
                
                this.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex, "Dados Não Inseridos");
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            //{
            //    e.Handled = true;
            //}
        }

        private void textBox14_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

       
    }
}
