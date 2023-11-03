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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaVendas.DAL_classes
{
    internal class userDAL_class 
    {
        #region String de conexão
          static string connString =
          ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        #endregion
        #region Selecionar base de dados do banco de dados
        public DataTable Select()
        {

            SqlConnection con = new SqlConnection(connString);
            DataTable dt = new DataTable();

            try
            {
                string sql = "select * from tabela_users";
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
        #region Cadastrando dados no banco de dados 
        public bool Insert(userBLL_class u)
        {
            bool isSucesso = false;

            SqlConnection con = new SqlConnection(connString);

            try
            {
                string sql = 
                    "INSERT into tabela_users(nome, usuario, senha, usuario_tipo)" +
                    $"values(@nome, @usuario, @senha, @usuario_tipo)";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@nome", u.nome);
                cmd.Parameters.AddWithValue("@usuario", u.usuario);
                cmd.Parameters.AddWithValue("@senha", u.senha);
                cmd.Parameters.AddWithValue("@usuario_tipo", u.tipo);

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
        public bool Update(userBLL_class u)
        {
            bool isSucesso = false;

            SqlConnection con = new SqlConnection(connString);

            try
            {
                string sql = 
                    "UPDATE tabela_users SET nome=@nome,usuario=@usuario,senha=@senha,usuario_tipo=@usuario_tipo where id=@id";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@nome", u.nome);
                cmd.Parameters.AddWithValue("@usuario", u.usuario);
                cmd.Parameters.AddWithValue("@senha", u.senha);
                cmd.Parameters.AddWithValue("@usuario_tipo", u.tipo);
                cmd.Parameters.AddWithValue("@id", u.id);

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
        public bool Delete(userBLL_class u)
        {
            bool isSucesso = false;

            SqlConnection con = new SqlConnection(connString);

            try
            {
                string sql =
                    "Delete from tabela_users where id=@id";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", u.id);

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
        #region Validar cadastro
         public bool Validar(string id)
        {
            bool val = false;

            string connString = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
            SqlConnection con = new SqlConnection(connString);

            string validação = "select * from tabela_users where id = @campo_id";

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
            return val;
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
                    $"select * from tabela_users where id LIKE '%{keyWords}%'" +
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


    }
}
