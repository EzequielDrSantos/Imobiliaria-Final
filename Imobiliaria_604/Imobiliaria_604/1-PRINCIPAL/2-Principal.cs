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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void marcarVisitaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Marcar Visita
            Form9 f10 = new Form9();
            f10.MdiParent = this;
            f10.Show();
        }

        private void editarVisitaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Editar Visita
            Form16  form16 = new Form16();
            form16.MdiParent = this;
            form16.Show();
        }

        private void visitasMarcadasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Visitas Marcadas
            Form10 f11 = new Form10();  
            f11.MdiParent = this;
            f11.Show();
        }

        private void novoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //Novo Imovel
            Form3 f3 = new Form3();
            f3.MdiParent = this;
            f3.Show();
        }

        private void editarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
         
            //Escolher o Imovel
              Form11 f11 = new Form11();
            f11.MdiParent = this;
            f11.Show();


        }

       
        private void novoToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            //Novo Cliente
            Form5 f6 = new Form5();
            f6.MdiParent = this;
            f6.Show();
        }
           
        private void edittarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Editar Cliente
            Form12 f12 = new Form12();
            f12.MdiParent = this;
            f12.Show();
        }

        private void procurarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Procurar Cliente
            Form8 f8 = new Form8();
            f8.MdiParent = this;
            f8.Show();
            
        }

        private void cancelarVisitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CancelarVisita cancelarVisita = new CancelarVisita();
            cancelarVisita.MdiParent = this;
            cancelarVisita.Show();
        }

        private void visitasMarcadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();   
            form10.MdiParent = this;    
            form10.Show();
        }

        private void removerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.MdiParent = this;
            form7.Show();
        }

        private void removerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.MdiParent = this; 
            form1.Show();
        }

        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form13 form13 = new Form13();
            form13.MdiParent = this;
            form13.Show();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form20 form20 = new Form20();
            form20.MdiParent = this;
            form20.Show();
        }

        private void procurarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form23 form23 = new Form23();
            form23.MdiParent = this;
            form23.Show();
        }

        private void removerToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form22 form22 = new Form22();
            form22.MdiParent = this;
            form22.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
