using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVendas.BLL_classes
{
    internal class Vendas_BLL
    {
        public int id {  get; set; }
        public decimal total { get; set; }
        public DateTime transacao_data { get; set; }
        public int add_for { get; set; }
    }
}
