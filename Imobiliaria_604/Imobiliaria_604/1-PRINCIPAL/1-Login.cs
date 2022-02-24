using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;

namespace Imobiliaria_604
{

    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
        }
        

        private void bunifuButton1_Click(object sender, EventArgs e)

        {
            if (textBox1.Text == "" | textBox2.Text == "")
            {
                MessageBox.Show("ERRO", "?");

            }

            else
            {

                DataTable dt = BLL.login.loginUtilizador(Convert.ToInt32(textBox1.Text), textBox2.Text);

                try
                {
                    Global.perfil = (String)dt.Rows[0][2];

                    if (dt.Rows.Count > 0)
                    {
                        Form2 f2 = new Form2();
                        f2.Show();
                        this.Visible = false;
                    }

                }
                catch (InvalidCastException)
                {
                    errorProvider1.SetError(textBox1, "Alguma coisa está errada");
                }
            }

        }
    }
}

