using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVendas.DAL_classes
{
    internal class historico_DAL
    {
        #region String de conexão
        static string connString =
        ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        #endregion
        #region Selecionar na base de dados
        public DataTable Select(string ini, string fin)
        {
            SqlConnection con = new SqlConnection(connString);
            DataTable dt = new DataTable();

            try
            {
                string sql = $"SELECT * FROM tabela_transacao WHERE transacao_data >= '{ini}' and transacao_data <= '{fin}'";
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
    }
}
