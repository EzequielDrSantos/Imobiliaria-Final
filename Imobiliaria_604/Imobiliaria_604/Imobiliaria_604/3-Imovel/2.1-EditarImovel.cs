using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Imobiliaria_604
{
    public partial class Form4 : Form
    {
        public Form4()
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

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            Form15 form15 = new Form15();
            form15.Show();
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            //openFileDialog1.ShowDialog();
            //string img = openFileDialog1.FileName;
            //pictureBox1.Image = Image.FromFile(img);
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            textBox2.Text=Global.row.Cells["Morada"].Value.ToString();


            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox5.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
