using SistemaVendas.Classes;
using SistemaVendas.DAL_classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVendas.Formularios
{
    public partial class formUsuarios : Form
    {
        public formUsuarios()
        {
            InitializeComponent();
        }

        userBLL_class u = new userBLL_class();
        userDAL_class dal = new userDAL_class();
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            u.nome = textBoxNomeUser.Text;
            u.usuario = textBoxLoginUser.Text;
            u.senha = textBoxSenhaUser.Text;
            u.tipo = comboBoxTipoUser.Text;
          
           if(u.nome == "" || u.senha == "" || u.tipo == "" || u.usuario == "")
            {
                MessageBox.Show("Por favor preencha os campos antes de cadastrar", "Erro");
                return;
            }
            if (dal.Validar(textBoxID.Text))
            {
                dal.Insert(u);
                limpar();
                usersGrid.ClearSelection();
            }
         
            DataTable dt = dal.Select();
            usersGrid.DataSource = dt;

            usersGrid.ClearSelection();
        }
        private void formUsuarios_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            usersGrid.DataSource = dt;
            usersGrid.ClearSelection();
        }
        private void limpar()
        {
            textBoxID.Clear();
            textBoxNomeUser.Clear();
            textBoxLoginUser.Clear();
            textBoxSenhaUser.Clear();
            comboBoxTipoUser.SelectedIndex = -1 ;
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (!(textBoxID.Text == ""))
            {
                u.id = Convert.ToInt32(textBoxID.Text);

                bool sucesso = dal.Delete(u);

                if (sucesso)
                {
                    MessageBox.Show("Deletado com sucesso");
                    limpar();
                }
            }
            else
            {
                MessageBox.Show("Por favor selecione a linha que deseja deletar");
            }

            DataTable dt = dal.Select();
            usersGrid.DataSource = dt;
            usersGrid.ClearSelection();

        }

        private void usersGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(e.RowIndex < 0))
            {
                int rowIndex = e.RowIndex;
                textBoxID.Text = usersGrid.Rows[rowIndex].Cells[0].Value.ToString();
                textBoxNomeUser.Text = usersGrid.Rows[rowIndex].Cells[1].Value.ToString();
                textBoxLoginUser.Text = usersGrid.Rows[rowIndex].Cells[2].Value.ToString();
                textBoxSenhaUser.Text = usersGrid.Rows[rowIndex].Cells[3].Value.ToString();
                comboBoxTipoUser.Text = usersGrid.Rows[rowIndex].Cells[4].Value.ToString();
            }

        }

        private void formUsuarios_MouseClick(object sender, MouseEventArgs e)
        {
            if(usersGrid.SelectedCells.Count > 0)
            {
                limpar();
                usersGrid.ClearSelection();
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if(!(textBoxID.Text == ""))
            {
                u.id = Convert.ToInt32(textBoxID.Text);

                u.nome = textBoxNomeUser.Text;
                u.usuario = textBoxLoginUser.Text;
                u.senha = textBoxSenhaUser.Text;
                u.tipo = comboBoxTipoUser.Text;

                bool sucesso = dal.Update(u);

                if (sucesso)
                {
                    MessageBox.Show("Atualizado com sucesso");
                    limpar();
                }
            }

            else
            {
                MessageBox.Show("Por favor selecione uma linha antes de atualizar");
                return;
            }
            
            DataTable dt = dal.Select();
            usersGrid.DataSource = dt;
            usersGrid.ClearSelection();
        }

        private void textBoxPesquisarFunc_TextChanged(object sender, EventArgs e)
        {
            string keyWords = textBoxPesquisarFunc.Text;

            if (keyWords != null)
            {
                DataTable dt = dal.Source(keyWords);
                usersGrid.DataSource= dt;
            }
            else
            {
                DataTable dt = dal.Select();
                usersGrid.DataSource = dt;
            }
        }


    }
}
