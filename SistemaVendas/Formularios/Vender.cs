using SistemaVendas.BLL_classes;
using SistemaVendas.DAL_classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaVendas.Formularios
{
    public partial class Vender : Form
    {
        public Vender()
        {
            InitializeComponent();
        }
        produtos_DAL dal = new produtos_DAL();
        Vendas_BLL vendas = new Vendas_BLL();
        //private void limpar()
        //{
        //    textBoxNome.Clear();
        //    textBoxNome.Clear();
        //}

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Vender_Load(object sender, EventArgs e)
        {
           textBoxCod.Focus();
        }

        private void textBoxCod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && (sender as System.Windows.Forms.TextBox).Text.Contains('.'))
            {
                e.Handled = true;
            }
        }

        private void textBoxQtd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && (sender as System.Windows.Forms.TextBox).Text.Contains('.'))
            {
                e.Handled = true;
            }
        }

        private void textBoxCod_TextChanged(object sender, EventArgs e)
        {
            string keywords = textBoxCod.Text;

            produtos_BLL p = dal.PegarProdutoVenda(keywords);

            textBoxNome.Text = p.nome;
            texBoxValorUni.Text = p.preco.ToString();  
            
        }

        private void textBoxNome_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
         

        }
    }
}
