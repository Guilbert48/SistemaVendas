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
    public partial class MenuCancelamento : Form
    {
        public MenuCancelamento()
        {
            InitializeComponent();
        }
        bool cancel = false;
        private void buttonCancelVend_Click(object sender, EventArgs e)
        {
            if(textBoxCodCancel.Text == "074896")
            {
                cancel = true;
                Close();
                MessageBox.Show("Venda cancelada com sucesso");
            }
            else
            {
                MessageBox.Show("Código incorreto", "Erro");
            }
        }
        public bool CancelarVenda()
        {
            return cancel;
        }
        private void buttonContinue_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
