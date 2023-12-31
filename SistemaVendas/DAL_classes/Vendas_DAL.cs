﻿using System;
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
            SqlConnection con = new SqlConnection(connString);
            DataTable dt = new DataTable();

            try
            {
                string sql = "select id, nome, preco from tabela_produtos WHERE id = @keywords ";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@keywords", keyWords);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                con.Open();
                adapter.Fill(dt);
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
        #region Criar nova linha
            public void criarNovaLinha(DataTable dt, int idProduto, string produto,decimal preco,decimal qtde)
            {
                DataRow novaLinha = dt.NewRow();
                novaLinha["id"] = idProduto;
                novaLinha["produto"] = produto;
                novaLinha["preco"] = preco;
                novaLinha["qtde"] = qtde;

                dt.Rows.Add(novaLinha);
            }
        #endregion
        #region Inserir na base de dados
        public bool Insert(Vendas_BLL v)
        {
            bool isSucesso = false;

            SqlConnection con = new SqlConnection(connString);

            try
            {
                string sql =
                    "INSERT into tabela_transacao(total_geral, transacao_data, add_for, forma_pagamento)" +
                    $"values(@total_geral, @transacao_data, @add_for, @forma_pagamento)";

                SqlCommand cmd = new SqlCommand(sql, con);
                
                cmd.Parameters.AddWithValue("@total_geral", v.total);
                cmd.Parameters.AddWithValue("transacao_data", v.transacao_data);
                cmd.Parameters.AddWithValue("@add_for", v.add_for);
                cmd.Parameters.AddWithValue("@forma_pagamento", v.forma_pagamento);


                con.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSucesso = true;
                }
                else
                {
                    isSucesso = false;
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                isSucesso = false;
            }
            finally
            {
                con.Close();
            }
            return isSucesso;
        }

        #endregion
        #region pegar qtd

        public void AtualizaQuantidade(int idProduto, decimal qtdSub)
        {
            decimal qtdFinal;
            SqlConnection con = new SqlConnection(connString);
            DataTable dt = new DataTable();

            try
            {
                string sql = $"select qtde from tabela_produtos where id = '{idProduto}'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                con.Open();
                adapter.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            con.Close();

            decimal qtdTotal = Convert.ToDecimal(dt.Rows[0][0]);

            if(qtdTotal >= qtdSub) 
            {
                qtdFinal = qtdTotal - qtdSub;

                string sqlATT =
                $"UPDATE tabela_produtos SET qtde={qtdFinal} where id = '{idProduto}'";

                SqlCommand cmd = new SqlCommand(sqlATT, con);
                con.Open();

                cmd.ExecuteNonQuery();

            }
        
        }
        #endregion
        #region Checar quantidade de produtos
        public bool ChecarQuantidade(int idProduto, decimal qtdSub)
        {
            bool estoque = false;
            SqlConnection con = new SqlConnection(connString);
            DataTable dt = new DataTable();

            try
            {
                string sql = $"select qtde from tabela_produtos where id = '{idProduto}'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                con.Open();
                adapter.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            con.Close();

            decimal qtdTotal = Convert.ToDecimal(dt.Rows[0][0]);

            if (qtdTotal >= qtdSub)
            {
                estoque = true;
            }
            else
            {
                MessageBox.Show("Quantidade de produtos em estoque é inferior à quantidade selecionada");
                estoque = false;

            }
            return estoque;
        }
        #endregion
    }
}
