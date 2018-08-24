using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_store.Model
{
    public class Transactions
    {

        public int Id { get; set; }
        public DateTime Data { get; set; }
        public decimal Total { get; set; }
        public string Produto { get; set; }
        public string Loja { get; set; }
        public string Vendido_para { get; set; }
    }
}
