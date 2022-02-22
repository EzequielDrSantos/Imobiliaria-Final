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
          
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
