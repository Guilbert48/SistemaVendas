using SistemaVendas.BLL_classes;
using SistemaVendas.Classes;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVendas.DAL_classes
{
    internal class Login_DAL
    {
        #region String de conexão
        static string connString =
        ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        #endregion

        #region Checar login
        public bool LoginChecar(Login_BLL l)
        {
            bool isSucesso = false;
            SqlConnection con = new SqlConnection(connString);
            try
            {
                string sql =
                    "select * from tabela_users where usuario=@usuario and senha=@senha and usuario_tipo=@usuario_tipo";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@usuario", l.usuario);
                cmd.Parameters.AddWithValue("@senha", l.senha);
                cmd.Parameters.AddWithValue("@usuario_tipo", l.usuario_tipo);
                con.Open();
                SqlDataReader rows = cmd.ExecuteReader();

                if (rows.HasRows)
                {
                    isSucesso = true;
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

        #region Pegar valor do id
        public int usuario_logado(string usuario, string senha)
        {

            using (SqlConnection con = new SqlConnection(connString))
            {
                int idUsuario = 0;
                string sql = "select id from tabela_users where usuario=@usuario and senha=@senha";

                using (SqlCommand cmd = new SqlCommand(sql, con)
)
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@senha", senha);

                    object resultado = cmd.ExecuteScalar();

                    if (resultado != null)
                    {
                        idUsuario = Convert.ToInt32(resultado);
                    }

                }

                return idUsuario;
            }

        }

        #endregion


    }
}
