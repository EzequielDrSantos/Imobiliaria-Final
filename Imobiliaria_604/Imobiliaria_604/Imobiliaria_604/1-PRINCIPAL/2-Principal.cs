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

        private void vendaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Catalago Venda 
            Venda f10 = new Venda();
            f10.MdiParent = this;
            f10.Show();
        }

        private void compraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Catalago Compra 
            Compra f12 = new Compra();
            f12.MdiParent = this;
            f12.Show();
        }

        private void arrendarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Catalago Arrendar
            Form14 f13 = new Form14();
            f13.MdiParent = this;
            f13.Show();
        }

        private void investimentoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Catalago Investimentos
            Investimento f14 = new Investimento();
            f14.MdiParent = this;
            f14.Show();
        }

        private void todosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form17 form17 = new Form17();
            form17.MdiParent = this;
            form17.Show();
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
    }
}
