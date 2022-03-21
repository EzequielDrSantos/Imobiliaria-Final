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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

            textBox1.Text = "" + Global.row.Cells[0].Value;
            textBox2.Text = "" + Global.row.Cells[1].Value;
            textBox3.Text = "" + Global.row.Cells[2].Value;
            textBox4.Text = "" + Global.row.Cells[3].Value;
            textBox5.Text = "" + Global.row.Cells[4].Value;
            comboBox1.Text = "" + Global.row.Cells[5].Value;
            textBox14.Text = "" + Global.row.Cells[6].Value;
            textBox6.Text = "" + Global.row.Cells[7].Value;
             
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            
        }

       

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            Form15 form15 = new Form15();
            form15.Show();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            BLL.Cliente.updateCliente(Convert.ToInt32(textBox1.Text), textBox2.Text, textBox3.Text, Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text), comboBox1.Text, textBox14.Text, Convert.ToInt32(textBox6.Text));
            textBox2.Clear();
            textBox1.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            comboBox1.Items.Clear();
            textBox14.Clear();
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
    }
}
