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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int NºdoImovel = 0;

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("TEM CETEZA ?", "?", MessageBoxButtons.YesNo);
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Global.row = dataGridView1.Rows[e.RowIndex];
            dataGridView1.DataSource = BLL.Imovel.Load();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL.Imovel.Load();
            dataGridView1.Columns["AreaTotal"].Visible = false;
            dataGridView1.Columns["AreaBruta"].Visible = false;
            dataGridView1.Columns["Quarto"].Visible = false;
            dataGridView1.Columns["CasaDeBanho"].Visible = false;
            dataGridView1.Columns["Elevador"].Visible = false;
            dataGridView1.Columns["Estacionamento"].Visible = false;
            dataGridView1.Columns["Eficiencia"].Visible = false;
            dataGridView1.Columns["AnoConstrucao"].Visible = false;
            dataGridView1.Columns["TipoImovel"].Visible = false;
            dataGridView1.Columns["Para"].Visible = false;

            dataGridView1.Columns["Observacao"].Visible = false;
            dataGridView1.Columns["Imagem"].Visible = false;
            dataGridView1.Columns["Atividade"].Visible = false;
        }
    }
}
