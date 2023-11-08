using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVendas.BLL_classes
{
    internal class produtos_BLL
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string categoria { get; set; }
        public string descricao { get; set; }
        public decimal qtde { get; set; }
        public DateTime data_cadastro { get; set; }
        public int add_for { get; set; }
        public int modified_for { get; set; }
        public DateTime data_atualizacao { get; set; }
        public decimal preco { get; set; }  


    }
}
