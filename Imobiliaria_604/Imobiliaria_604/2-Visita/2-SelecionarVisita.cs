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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            EditarVisita editarVisita = new EditarVisita();
            editarVisita.Show();
            this.Close();
        }

        private void Form16_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL.Visita.Load();
            dataGridView1.Columns["Atividade"].Visible = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            

            Global.row = dataGridView1.Rows[e.RowIndex];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

