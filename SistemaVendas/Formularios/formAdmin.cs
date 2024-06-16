using SistemaVendas.Classes;
using SistemaVendas.DAL_classes;
using SistemaVendas.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVendas
{
    public partial class formAdmin : Form
    {
        public formAdmin()
        {
            InitializeComponent();
        }
        userBLL_class user = new userBLL_class();   
        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formUsuarios user = new formUsuarios();
            user.ShowDialog();
        } 

        private void formAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCategorias c = new formCategorias(); 
            c.ShowDialog();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Produtos produtos = new Produtos(); 
            produtos.ShowDialog();  
        }

        private void transaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vender vender = new Vender();
            vender.ShowDialog();            
        }

        private void formAdmin_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F2)
            {
                Vender v = new Vender();    
                v.ShowDialog();
            }
            if (e.KeyCode == Keys.P)
            {
                Produtos p = new Produtos();
                p.ShowDialog();
            }
            if (e.KeyCode == Keys.C)
            {
                formCategorias c = new formCategorias();
                c.ShowDialog();
            }
            if (e.KeyCode == Keys.T)
            {
                HistóricoVendas h = new HistóricoVendas();
                h.ShowDialog();
            }

        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistóricoVendas h = new HistóricoVendas();
            h.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Vender v = new Vender();
            v.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Produtos p = new Produtos();    
            p.ShowDialog(); 
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            formCategorias f = new formCategorias();
            f.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            HistóricoVendas h = new HistóricoVendas();
            h.ShowDialog(); 
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }
    }
}
