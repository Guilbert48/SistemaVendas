using SistemaVendas.BLL_classes;
using SistemaVendas.Classes;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVendas.DAL_classes
{
    internal class categorias_DAL
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
                    string sql = "select * from tabela_categorias";
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
            public bool Insert(categorias_BLL c)
            {
                bool isSucesso = false;

                SqlConnection con = new SqlConnection(connString);

                try
                {
                    string sql =
                        "INSERT into tabela_categorias(nome, descricao, data_cadastro, add_for)" +
                        $"values(@nome, @descricao, @data_cadastro, @add_for)";

                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@nome", c.nome);
                    cmd.Parameters.AddWithValue("@descricao", c.descricao);
                    cmd.Parameters.AddWithValue("@data_cadastro", c.data_cadastro);
                    cmd.Parameters.AddWithValue("@add_for", c.add_for);

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
            #region Atualizar dados do banco de dados 
            public bool Update(categorias_BLL c)
            {
                bool isSucesso = false;

                SqlConnection con = new SqlConnection(connString);

                try
                {
                    string sql =
                        "UPDATE tabela_categorias SET nome=@nome,descricao=@descricao, modified_for=@modified_for, data_atualizacao=@data_atualizacao where id=@id";

                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@nome", c.nome);
                    cmd.Parameters.AddWithValue("@descricao", c.descricao);
                    cmd.Parameters.AddWithValue("@data_atualizacao", c.data_atualizacao);
                    cmd.Parameters.AddWithValue("@modified_for", c.modified_for);
                    cmd.Parameters.AddWithValue("@id", c.id);

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
        public bool Delete(categorias_BLL c)
        {
            bool isSucesso = false;

            SqlConnection con = new SqlConnection(connString);

            try
            {
                string sql =
                    "Delete from tabela_categorias where id=@id";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", c.id);

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
                            $"select * from tabela_categorias where id LIKE '%{keyWords}%'" +
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

                    string validação = "select * from tabela_categorias where id = @campo_id";

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


    }

}

