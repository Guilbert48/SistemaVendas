using SistemaVendas.BLL_classes;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaVendas.Formularios;

namespace SistemaVendas.DAL_classes
{
    internal class produtos_DAL
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
                string sql = "select * from tabela_produtos";
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
        #region Inserir na base de dados
        public bool Insert(produtos_BLL p)
        {
            bool isSucesso = false;

            SqlConnection con = new SqlConnection(connString);

            try
            {
                string sql =
                    "INSERT into tabela_produtos(id, nome, categoria, descricao, qtde, data_cadastro, add_for, preco)" +
                    $"values(@id, @nome, @categoria, @descricao, @qtde, @data_cadastro, @add_for, @preco)";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", p.id);
                cmd.Parameters.AddWithValue("@nome", p.nome);
                cmd.Parameters.AddWithValue("categoria", p.categoria);
                cmd.Parameters.AddWithValue("@descricao", p.descricao);
                cmd.Parameters.AddWithValue("@qtde", p.qtde);
                cmd.Parameters.AddWithValue("@data_cadastro", p.data_cadastro);
                cmd.Parameters.AddWithValue("@add_for", p.add_for);
                cmd.Parameters.AddWithValue("@preco", p.preco);

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
        #region Atualizar dados do banco de dados 
        public bool Update(produtos_BLL p)
        {
            bool isSucesso = false;

            SqlConnection con = new SqlConnection(connString);

            try
            {
                string sql =
                    "UPDATE tabela_produtos SET nome=@nome, categoria=@categoria, descricao=@descricao, qtde=@qtde, atualizado_por=@modified_for, data_att=@data_att, preco=@preco where id=@id";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@nome", p.nome);
                cmd.Parameters.AddWithValue("@categoria", p.categoria);
                cmd.Parameters.AddWithValue("@descricao", p.descricao);
                cmd.Parameters.AddWithValue("@qtde", p.qtde);
                cmd.Parameters.AddWithValue("@data_att", p.data_atualizacao);
                cmd.Parameters.AddWithValue("@modified_for", p.modified_for);
                cmd.Parameters.AddWithValue("@id", p.id);
                cmd.Parameters.AddWithValue("@preco", p.preco);



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
            }
            finally
            {
                con.Close();
            }
            return isSucesso;
        }

        #endregion
        #region Deletar dados do banco de dados 
        public bool Delete(produtos_BLL p)
        {
            bool isSucesso = false;

            SqlConnection con = new SqlConnection(connString);

            try
            {
                string sql =
                    "Delete from tabela_produtos where id=@id";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", p.id);

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
            }
            finally
            {
                con.Close();
            }
            return isSucesso;
        }

        #endregion
        #region Pesquisas na base de dados
        public DataTable Source(string keyWords)
        {
            SqlConnection con = new SqlConnection(connString);
            DataTable dt = new DataTable();
            try
            {
                string sql =
                    $"select * from tabela_produtos where id LIKE '%{keyWords}%'" +
                    $"or nome LIKE '%{keyWords}%'";

                SqlCommand cmd = new SqlCommand(sql, con);

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
        #region Validar cadastro
        public bool Validar(string id)
        {
            bool val = false;

            string connString = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
            SqlConnection con = new SqlConnection(connString);

            string validação = "select * from tabela_produtos where id = @campo_id";

            SqlCommand cmdVal = new SqlCommand(validação, con);
            cmdVal.Parameters.AddWithValue("@campo_id", id);

            con.Open();
            SqlDataReader reader = cmdVal.ExecuteReader();

            if (reader.HasRows)
            {
                MessageBox.Show("Usuário já cadastrado. \nSe deseja modificar, selecione o usuário e clique em 'Atualizar'", "ERRO");
                   
            }
            else
            {
                val = true;
            }
            con.Close();
            return val;
        }

        #endregion
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



    }
}
