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
        public void Limpar()
        {
            texBoxValorUni.Clear();
            textBoxNome.Clear();
            textBoxQtd.Clear();
            textBoxSubTotal.Clear();
            textBoxTroco.Clear();
            textBoxValorPago.Clear();
            comboBoxFrmPag.SelectedIndex = -1;
            dt.Rows.Clear();
        }
        private void Vender_Load(object sender, EventArgs e)
        {
            textBoxCod.Focus();
            dt.Columns.Add("id");
            dt.Columns.Add("Produto");
            dt.Columns.Add("qtde");
            dt.Columns.Add("preco");

            dt2.Columns.Add("id");
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
            if (e.KeyChar == 'c')
            {
                textBoxCod.Focus();
            }
        }
        string produto;
        decimal preco;
        decimal qtde;
        string subTotal;
        int idProduto;
        private void textBoxCod_TextChanged(object sender, EventArgs e)
        {

                string keywords = textBoxCod.Text;
                dt2 = dal.PegarProdutoVenda(keywords);

            
                if (dt2.Rows.Count == 1 && textBoxQtd.Text != "")
                {
                    idProduto = int.Parse(dt2.Rows[0]["id"].ToString());
                    produto = dt2.Rows[0]["nome"].ToString();
                    preco = decimal.Parse(dt2.Rows[0]["preco"].ToString());
                    qtde = decimal.Parse(textBoxQtd.Text);

                    dal.criarNovaLinha(dt, idProduto, produto, preco, qtde);
                    
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

        private void btnConcluirVenda_Click(object sender, EventArgs e)
        {

            if (dt.Rows.Count > 0)
            {
                bool sucess = dal.Retornar();
                MessageBox.Show(sucess.ToString());
                if (sucess)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        int idProduto = Convert.ToInt32(row["id"]);
                        decimal qtdSub = Convert.ToDecimal(row["qtde"]);
                    
                        dal.AtualizaQuantidade(idProduto, qtdSub);                   
                    }

                }
                else
                {
                    return;
                }
            }

            if (dt.Rows.Count > 0 && textBoxSubTotal.Text != "")
            {
                Vendas_BLL v = new Vendas_BLL();
                v.total = decimal.Parse(textBoxSubTotal.Text);
                v.transacao_data = DateTime.Now;
                Login l = new Login();
                v.add_for = l.IdLogado();                
                v.forma_pagamento = comboBoxFrmPag.Text;

                bool sucess = dal.Insert(v);
                if (sucess)
                {
                    MessageBox.Show("Concluído com sucesso", "Sucesso");
                    Limpar();
                    textBoxCod.Focus();
                }
                else
                {
                    MessageBox.Show("Erro ao finalizar a venda", "Erro");
                    Limpar();
                    textBoxCod.Focus();
                }
            }
            else
            {
                MessageBox.Show("Nenhum valor cadastrado, tente novamente", "Erro");
                textBoxCod.Focus(); 
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpar();
        }
    }
}
