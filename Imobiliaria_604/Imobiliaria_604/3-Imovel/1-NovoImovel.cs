using System;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using BusinessLogicLayer;
using System.Collections;
using System.Data;

namespace Imobiliaria_604
{
    public partial class Form3 : Form
    {
        bool elevador = false;  
        bool estacionamento=false;
        int IDistrito;


        public static DataTable DataSource { get; private set; }

        public Form3()
        {
            InitializeComponent();
           
        }

        public byte[] imgToByteArray(Image img)

        {
            using (MemoryStream mStream = new MemoryStream())

            {
                img.Save(mStream, img.RawFormat);

                return mStream.ToArray();
            }

        }
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream mStream = new MemoryStream(byteArrayIn))
            {
                return Image.FromStream(mStream);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Sim")
            {
                elevador = true;
            }
            else { elevador = false; }
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem.ToString() == "Sim")
            {
                estacionamento = true;
            }
            else {estacionamento = false; }
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
             Form15 form15 = new Form15();
            form15.Show();
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string img = openFileDialog1.FileName;
            pictureBox1.Image = Image.FromFile(img);
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            byte[] foto = imgToByteArray(pictureBox1.Image);
            try
            {
                BLL.Imovel.insertNvImovel(Convert.ToInt32(textBox1.Text), textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text, textBox9.Text, elevador, estacionamento, comboBox3.Text, textBox10.Text, comboBox4.Text, comboBox5.Text, checkedListBox1.Text, checkedListBox2.Text, textBox11.Text, textBox12.Text, textBox13.Text, foto);
                textBox2.Clear();
                textBox1.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();
                textBox9.Clear();
                comboBox1.Items.Clear();
                comboBox2.Items.Clear();
                comboBox3.Items.Clear();
                textBox10.Clear();
                comboBox4.Items.Clear();
                comboBox5.Items.Clear();
                textBox11.Clear();
                textBox12.Clear();
                textBox13.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex, "Dados Não Inseridos");
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //Distrito
            DataTable dis = BLL.Distrito.Distritos();
            comboBox4.DataSource = dis;
            comboBox4.DisplayMember = "NomeDistrito";

            //Comnselho
            //DataTable cons = BLL.Conselho.Conselhoo();
            //comboBox5.DataSource = cons;
            //comboBox5.DisplayMember = "Conselho";

            //NºImvovel
            int idImovel = (int)BLL.IdImovel.IdoImovel();
            if (idImovel == 0)
            {
                textBox1.Text = "1";
            }
            else
            {
                idImovel = (int)BLL.IdImovel.IdoImovel();
                textBox1.Text = "" + (idImovel + 1);
            }

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox5.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (char.IsDigit(e.KeyChar) || e.KeyChar.Equals((char)Keys.Back))
            {
                TextBox t = (TextBox)sender;
                string w = Regex.Replace(t.Text, "[^0-9]", string.Empty);
                if (w == string.Empty) w = "00";

                if (e.KeyChar.Equals((char)Keys.Back))      
                    w = w.Substring(0, w.Length - 1);      
                else
                    w += e.KeyChar;
                t.Text = string.Format("{0:#,##0.00}", Double.Parse(w) / 100);
                t.Select(t.Text.Length, 0);
            }
            e.Handled = true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))    
    {
        e.Handled = true;       
    }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}


