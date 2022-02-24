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
    public partial class CancelarVisita : Form
    {
        public CancelarVisita()
        {
            InitializeComponent();
        }

        int NºVisita=0;

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Tens certeza madje??", "?", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                int x = BLL.Visita.deleteVisita(NºVisita);
                dataGridView1.DataSource = BLL.Visita.Load();

            }
        }
    }
}
