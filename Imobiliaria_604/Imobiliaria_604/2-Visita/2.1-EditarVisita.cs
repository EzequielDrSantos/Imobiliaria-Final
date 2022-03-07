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
            BLL.Visita.updateVisita(id, Convert.ToInt32(textBox1.Text), textBox2.Text, textBox3.Text, Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text), comboBox1.Text, dateTimePicker1.Value);
            textBox2.Clear();
            textBox1.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            comboBox1.Items.Clear();

        }
    }
}
