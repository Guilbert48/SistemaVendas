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


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        private void Vender_Load(object sender, EventArgs e)
        {
            textBoxCod.Focus();    
            dt.Columns.Add("Produto");
            dt.Columns.Add("qtde");
            dt.Columns.Add("preco");

            dt2.Columns.Add("Produto");
            dt2.Columns.Add("qtde");
            dt2.Columns.Add("preco");
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
        string produto;
        decimal preco;
        decimal qtde;
        private void textBoxCod_TextChanged(object sender, EventArgs e)
        {
            string keywords = textBoxCod.Text;
            dt2 = dal.PegarProdutoVenda(keywords);

            
                if (dt2.Rows.Count == 1 && textBoxQtd.Text != "")
                {
                
                    produto = dt2.Rows[0]["nome"].ToString();
                    preco = decimal.Parse(dt2.Rows[0]["preco"].ToString());
                    qtde = decimal.Parse(textBoxQtd.Text);

                    DataRow novaLinha = dt.NewRow();
                    novaLinha["produto"] = produto;
                    novaLinha["preco"] = preco;
                    novaLinha["qtde"] = qtde;

                    dt.Rows.Add(novaLinha);

                    texBoxValorUni.Text = preco.ToString();
                    textBoxNome.Text = produto.ToString();

                    vendasGrid.DataSource = dt;
                    textBoxCod.Clear();
                    textBoxQtd.Text = "1";

            }
            



           
            // decimal valorUni = decimal.Parse(texBoxValorUni.Text);
            //string produtoNome = p.nome;
            //decimal preco = p.preco;
            //decimal qtd = decimal.Parse(textBoxQtd.Text);

            //dt.Rows.Add(produtoNome,qtd, preco);

        }
        private void textBoxQtd_TextChanged(object sender, EventArgs e)
        {
            if(dt.Rows.Count >= 1 && textBoxQtd.Text != "")
            {
               qtde = decimal.Parse(textBoxQtd.Text);
               DataRow row = dt.Rows[dt.Rows.Count - 1];
               row["qtde"] = qtde;
  
                decimal subTotal = preco * qtde;
                textBoxSubTotal.Text = subTotal.ToString();
            }

        }
        
        private void vendasGrid_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //if (dt.Rows.Count >= 1)
            //{
            //    DataGridViewRow ultimaLinha = vendasGrid.Rows[e.RowIndex];
            //    ultimaLinha.Cells["qtde"].Value = textBoxQtd.Text;
            //    vendasGrid.DataSource = dt;

            //}
        }

        private void textBoxQtd_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
