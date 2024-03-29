﻿using BusinessLogicLayer;
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
    public partial class Form21 : Form
    {
        public Form21()
        {
            InitializeComponent();
        }
        bool adm ;

        private void Form21_Load(object sender, EventArgs e)
        {
            textBox9.Text = "True";

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            textBox1.Text = "" + Global.row.Cells[0].Value;
            textBox2.Text = "" + Global.row.Cells[1].Value;
            textBox3.Text = "" + Global.row.Cells[2].Value;
            textBox4.Text = "" + Global.row.Cells[3].Value;
            textBox5.Text = "" + Global.row.Cells[4].Value;
            textBox6.Text = "" + Global.row.Cells[5].Value;
            textBox7.Text = "" + Global.row.Cells[6].Value;
            comboBox1.Text = "" +Global.row.Cells[7].Value;
            if (Convert.ToBoolean(Global.row.Cells[7].Value) == true)
            {
                comboBox1.Text = "Administrador";
            }
            else
            {
                comboBox1.Text = "Corretor";  
            }

           
            textBox8.Text = "" + Global.row.Cells[8].Value;

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            BLL.Funcionario.updateFuncionario(Convert.ToInt32(textBox1.Text), textBox2.Text, textBox3.Text, Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text), Convert.ToInt32(textBox7.Text), adm, textBox8.Text, Convert.ToBoolean(textBox9.Text));
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            comboBox1.Items.Clear();
            

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Administrador")
            {
                adm = true;
            }
            if (comboBox1.SelectedItem.ToString() == "Corretor")
            {
                adm = false;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
