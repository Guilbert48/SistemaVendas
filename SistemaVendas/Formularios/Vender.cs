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
        Vendas_DAL dal = new Vendas_DAL();


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

            if (e.KeyChar == 'q') 
            { 
                textBoxQtd.Focus();
            } ;
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
        string subTotal;
      
        private void textBoxCod_TextChanged(object sender, EventArgs e)
        {

                string keywords = textBoxCod.Text;
                dt2 = dal.PegarProdutoVenda(keywords);

            
                if (dt2.Rows.Count == 1 && textBoxQtd.Text != "")
                {
                   
                    produto = dt2.Rows[0]["nome"].ToString();
                    preco = decimal.Parse(dt2.Rows[0]["preco"].ToString());
                    qtde = decimal.Parse(textBoxQtd.Text);

                    dal.criarNovaLinha(dt, produto, preco, qtde);
                    
                    texBoxValorUni.Text = preco.ToString();
                    textBoxNome.Text = produto.ToString();

                    vendasGrid.DataSource = dt;
                    textBoxCod.Clear();
                    textBoxQtd.Text = "1";

                    subTotal = dal.CalculosVenda(dt);
                    textBoxSubTotal.Text = subTotal;

            }
            

        }
        private void textBoxQtd_TextChanged(object sender, EventArgs e)
        {
            if(dt.Rows.Count >= 1 && textBoxQtd.Text != "")
            {
               qtde = decimal.Parse(textBoxQtd.Text);
               DataRow row = dt.Rows[dt.Rows.Count - 1];
               row["qtde"] = qtde;
               subTotal = dal.CalculosVenda(dt);
               textBoxSubTotal.Text = subTotal;
            }
        }

        private void textBoxValorPago_TextChanged(object sender, EventArgs e)
        {
            if (textBoxValorPago.Text != "" && textBoxSubTotal.Text != "")
            {      
                decimal troco = decimal.Parse(textBoxValorPago.Text) - decimal.Parse(subTotal);
                textBoxTroco.Text = troco.ToString();
            }
        }

        private void textBoxCod_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxValorPago.Clear();
            textBoxTroco.Clear();
        }

        private void textBoxQtd_Enter(object sender, EventArgs e)
        {
            textBoxQtd.SelectionStart = textBoxQtd.Text.Length;
            textBoxQtd.SelectionLength = 0;
            textBoxValorPago.Clear();
            textBoxTroco.Clear();
        }

        private void vendasGrid_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            vendasGrid.Rows[0].Selected = false;
        }

        private void textBoxDesc_TextChanged(object sender, EventArgs e)
        {
            if(textBoxDesc.Text != "")
            {

            }
        }
    }
}
