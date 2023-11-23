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
    public partial class HistóricoVendas : Form
    {
        public HistóricoVendas()
        {
            InitializeComponent();
        }
        Vendas_DAL dal = new Vendas_DAL();
        historico_DAL dalh = new historico_DAL();
        private void HistóricoVendas_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            hstGridView.DataSource = dt;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pesquisarBtn_Click(object sender, EventArgs e)
        {
            string dataini = dataInicio.Text;
            string dataFin = dataFinal.Text;

            dalh.Select(dataini, dataFin);
        }
    }
}
