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
    public partial class CancelarVisita : Form
    {
        public CancelarVisita()
        {
            InitializeComponent();
        }

      

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("TEM CERTEZA ?", "?", MessageBoxButtons.YesNo);
           
        }

        private void CancelarVisita_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL.Visita.Load();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Global.row = dataGridView1.Rows[e.RowIndex];
        }
    }
}
