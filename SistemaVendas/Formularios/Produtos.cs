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
    public partial class Produtos : Form
    {
        public Produtos()
        {
            InitializeComponent();
        }
        produtos_BLL p = new produtos_BLL();
        produtos_DAL dal = new produtos_DAL();
        Login login = new Login();

        public void limpar()
        {
            textBoxID.Clear();
            textBoxNomeCat.Clear();
            textBoxDesc.Clear();
            textBoxQtde.Clear();    
            comboBoxCategorias.SelectedIndex = -1;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public int Random()
        {
            Random random = new Random();
            int numeroAleatorio = random.Next(1000, 10000);
            return numeroAleatorio;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            p.id = Random();
            p.nome = textBoxNomeCat.Text;
            p.categoria = comboBoxCategorias.Text;
            p.descricao = textBoxDesc.Text;
            p.data_cadastro = DateTime.Now;
            if (textBoxQtde.Text != "") 
            {
                p.qtde = decimal.Parse(textBoxQtde.Text);
            };
            
            int logado_sistema = login.IdLogado();

            if (logado_sistema != 0)
            {
                p.add_for = logado_sistema;
            }

            if (p.nome == "")
            {
                MessageBox.Show("Por favor preencha os campos antes de cadastrar", "Erro");
                return;
            }

            if (dal.Validar(textBoxID.Text))
            {
                dal.Insert(p);
                limpar();
                MessageBox.Show("Cadastrado com sucesso", "sucesso");
            }

            DataTable dt = dal.Select();
            usersGrid.DataSource = dt;
            usersGrid.ClearSelection();
        }

        private void textBoxQtde_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; 
            }
            
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains('.'))
            {
                e.Handled = true; 
            }
        }
        private void usersGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (usersGrid.SelectedCells.Count > 0)
            {
                if (e.KeyCode == Keys.Escape)
                {
                    limpar();
                    usersGrid.ClearSelection();
                }
            }
        }
        private void formCategorias_MouseClick(object sender, MouseEventArgs e)
        {
            if (usersGrid.SelectedCells.Count > 0)
            {
                limpar();
                usersGrid.ClearSelection();
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

        private void Produtos_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            usersGrid.DataSource = dt;
        }

        private void usersGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(e.RowIndex < 0))
            {
                int rowIndex = e.RowIndex;
                textBoxID.Text = usersGrid.Rows[rowIndex].Cells[0].Value.ToString();
                textBoxID.Enabled = false;
                textBoxNomeCat.Text = usersGrid.Rows[rowIndex].Cells[1].Value.ToString();
                comboBoxCategorias.Text = usersGrid.Rows[rowIndex].Cells[2].Value.ToString();
                textBoxDesc.Text = usersGrid.Rows[rowIndex].Cells[3].Value.ToString();
                textBoxQtde.Text = usersGrid.Rows[rowIndex].Cells[4].Value.ToString();

            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (!(textBoxID.Text == ""))
            {
                p.id = Convert.ToInt32(textBoxID.Text);

                bool sucesso = dal.Delete(p);

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

        private void btnAtualizar_Click_1(object sender, EventArgs e)
        {
            if (!(textBoxID.Text == ""))
            {
                p.id = Convert.ToInt32(textBoxID.Text);
                p.nome = textBoxNomeCat.Text;
                p.categoria = comboBoxCategorias.Text;
                p.descricao = textBoxDesc.Text;
                p.qtde = decimal.Parse(textBoxQtde.Text);
                p.data_atualizacao = DateTime.Now;
                int logado_sistema = login.IdLogado();

                if (logado_sistema != 0)
                {
                    p.modified_for = logado_sistema;
                }

                bool sucesso = dal.Update(p);

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

        private void Produtos_MouseClick(object sender, MouseEventArgs e)
        {
            if (usersGrid.SelectedCells.Count > 0)
            {
                limpar();
                usersGrid.ClearSelection();
                textBoxID.Enabled = true;
            }
        }

        private void usersGrid_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (usersGrid.SelectedCells.Count > 0)
            {
                if (e.KeyCode == Keys.Escape)
                {
                    limpar();
                    usersGrid.ClearSelection();
                    textBoxID.Enabled = true;
                }
            }
        }


    }
}
