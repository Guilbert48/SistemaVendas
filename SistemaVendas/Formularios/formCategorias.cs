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

namespace SistemaVendas.Formularios
{
    public partial class formCategorias : Form
    {
        public formCategorias()
        {
            InitializeComponent();
        }
        categorias_BLL c = new categorias_BLL();
        categorias_DAL dal = new categorias_DAL();  
        Login login = new Login();
  
        public void limpar()
        {
            textBoxID.Clear();
            textBoxNomeCat.Clear();
            textBoxDesc.Clear();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            c.nome = textBoxNomeCat.Text;
            c.descricao = textBoxDesc.Text;
            c.data_cadastro = DateTime.Now;
            int logado_sistema = login.IdLogado();

            if (logado_sistema != 0)
            {
                c.add_for = logado_sistema;
            }

            if (c.nome == "")
            {
                MessageBox.Show("Por favor preencha os campos antes de cadastrar", "Erro");
                return;
            }

            if (dal.Validar(textBoxID.Text))
            {
                dal.Insert(c);
                limpar();
                MessageBox.Show("Cadastrado com sucesso", "sucesso"); 
            }

            DataTable dt = dal.Select();
            usersGrid.DataSource = dt;
            usersGrid.ClearSelection();
            
        }

        private void formCategorias_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            usersGrid.DataSource = dt;
            usersGrid.ClearSelection();

        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (!(textBoxID.Text == ""))
            {
                c.id = Convert.ToInt32(textBoxID.Text);

                bool sucesso = dal.Delete(c);

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

        private void usersGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(!(e.RowIndex < 0))
            {
                int rowIndex = e.RowIndex;
                textBoxID.Text = usersGrid.Rows[rowIndex].Cells[0].Value.ToString();
                textBoxNomeCat.Text = usersGrid.Rows[rowIndex].Cells[1].Value.ToString();
                textBoxDesc.Text = usersGrid.Rows[rowIndex].Cells[2].Value.ToString();
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (!(textBoxID.Text == ""))
            {
                c.id = Convert.ToInt32(textBoxID.Text);
                c.nome = textBoxNomeCat.Text;
                c.descricao = textBoxDesc.Text;
                c.data_atualizacao = DateTime.Now;
                int logado_sistema = login.IdLogado();

                if (logado_sistema != 0)
                {
                    c.modified_for = logado_sistema;
                }

                bool sucesso = dal.Update(c);

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

        private void formCategorias_MouseClick(object sender, MouseEventArgs e)
        {
            if (usersGrid.SelectedCells.Count > 0)
            {
                limpar();
                usersGrid.ClearSelection();
            }
        }

        private void usersGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (usersGrid.SelectedCells.Count > 0)
            {
                if (e.KeyCode == Keys.Escape)
                {            
                    usersGrid.ClearSelection();
                    limpar();
                }
            }
        }

        private void textBoxPesquisarFunc_TextChanged(object sender, EventArgs e)
        {
            string keyWords = textBoxPesquisarFunc.Text;
            if (keyWords != null)
            {
                DataTable dt = dal.Source(keyWords);
                usersGrid.DataSource = dt;
            }
            else
            {
                DataTable dt = dal.Select();
                usersGrid.DataSource = dt;
            }
        }

   
    }
}
