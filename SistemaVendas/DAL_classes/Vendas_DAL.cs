using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using SistemaVendas.BLL_classes;
using SistemaVendas.Formularios;

namespace SistemaVendas.DAL_classes
{
    internal class Vendas_DAL
    {
        #region String de conexão
        static string connString =
        ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        #endregion
        #region Selecionar na base de dados
        public DataTable Select()
        {
            SqlConnection con = new SqlConnection(connString);
            DataTable dt = new DataTable();
            try
            {
                string sql = "select * from tabela_transacao";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                con.Open();
                adapter.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

            return dt;
        }

        #endregion
        #region Pegar produtos
        public DataTable PegarProdutoVenda(string keyWords)
        {
            //produtos_BLL p = new produtos_BLL();
            SqlConnection con = new SqlConnection(connString);
            DataTable dt = new DataTable();

            try
            {
                string sql = "select nome, preco from tabela_produtos WHERE id = @keywords ";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@keywords", keyWords);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                con.Open();
                adapter.Fill(dt);

                //if (dt.Rows.Count == 1)
                //{
                //    p.nome = dt.Rows[0]["nome"].ToString();
                //    p.preco = decimal.Parse(dt.Rows[0]["preco"].ToString());

                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "ERRO");
            }
            finally
            {
                con.Close();
            }

            return dt;

        }

        #endregion
        #region Calculos de venda
        public string CalculosVenda(DataTable dt)
        {
           decimal somaResultados = 0;
            if (dt.Rows.Count >= 1)
            {
                foreach (DataRow row in dt.Rows)
                {
                    int valor1 = Convert.ToInt32(row["qtde"]);
                    decimal valor2 = Convert.ToDecimal(row["preco"]);

                    decimal resultado = valor1 * valor2;

                    somaResultados += resultado;
                }
            }
            return somaResultados.ToString();
        }

        #endregion
        #region
        public void criarNovaLinha(DataTable dt, string produto,decimal preco,decimal qtde)
        {
            DataRow novaLinha = dt.NewRow();
            novaLinha["produto"] = produto;
            novaLinha["preco"] = preco;
            novaLinha["qtde"] = qtde;

            dt.Rows.Add(novaLinha);
        }
        #endregion
    }
}
