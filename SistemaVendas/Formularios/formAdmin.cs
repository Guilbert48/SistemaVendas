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
    }
}
