using SistemaVendas.BLL_classes;
using SistemaVendas.DAL_classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVendas.Formularios
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        Login_BLL l = new Login_BLL();
        Login_DAL dal = new Login_DAL();
        public static string logado_sistema;
        public void Limpar()
        {
            textBoxLoginUser.Clear();
            textBoxSenhaUser.Clear();
            comboBoxTipoUser.SelectedIndex = -1;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
        static int idLogado;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            l.usuario = textBoxLoginUser.Text.Trim();
            l.senha = textBoxSenhaUser.Text.Trim();
            l.tipo = comboBoxTipoUser.Text.Trim();

            Login_DAL log = new Login_DAL();
            idLogado = log.usuario_logado(l.usuario, l.senha);


            bool isSucess = dal.LoginChecar(l);

            if (isSucess)
            {
                MessageBox.Show("Login realizado com sucesso", "Sucesso");
                this.Hide();
                Limpar();

                switch (l.tipo)
                {
                    case "ADMIN":
                        {
                            formAdmin adm = new formAdmin();
                            adm.ShowDialog();
                        }
                        break;

                    case "USER":
                        {
                            formUsuario user = new formUsuario();
                            user.ShowDialog();

                        }
                        break;

                    default:
                        {
                            MessageBox.Show("Dados incorretos", "ERRO");
                        } break;
                }

            }
            else
            {
                MessageBox.Show("Dados incorretos", "Erro");
            }

        }
        static string connString =
        ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        public int IdLogado(){
           return idLogado;

        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }
        private void comboBoxTipoUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }
        private void textBoxSenhaUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }
        private void textBoxLoginUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }
    }
}
