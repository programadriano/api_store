using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api_store.Model;
using Microsoft.AspNetCore.Mvc;

namespace api_store.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        public List<Transactions> transactions;

        public ValuesController()
        {
            transactions = new List<Transactions>
            {
                new Transactions
                {
                    Id = 1,
                    Data = DateTime.Now,
                    Loja = "Loja A",
                    Produto = "Produto de teste",
                    Total = 300,
                    Vendido_para = "Comprador A"
                },
                 new Transactions
                {
                    Id = 2,
                    Data = DateTime.Now,
                    Loja = "Loja A",
                    Produto = "Produto de teste",
                    Total = 300,
                    Vendido_para = "Comprador A"
                },
                  new Transactions
                {
                    Id = 3,
                    Data = DateTime.Now,
                    Loja = "Loja A",
                    Produto = "Produto de teste",
                    Total = 300,
                    Vendido_para = "Comprador A"
                },
                   new Transactions
                {
                    Id = 4,
                    Data = DateTime.Now,
                    Loja = "Loja A",
                    Produto = "Produto de teste",
                    Total = 300,
                    Vendido_para = "Comprador A"
                },
                    new Transactions
                {
                    Id = 5,
                    Data = DateTime.Now,
                    Loja = "Loja A",
                    Produto = "Produto de teste",
                    Total = 300,
                    Vendido_para = "Comprador A"
                }
            };




        }

        // GET api/values
        [HttpGet]
        public IEnumerable<Transactions> Get()
        {
            return transactions.OrderBy(x => x.Data).ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IEnumerable<Transactions> Get(int id)
        {
            return transactions.Where(x => x.Id == id).OrderBy(x => x.Data).ToList();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Transactions transaction)
        {
            transactions.Add(transaction);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Transactions transaction)
        {
            var t = transactions.FirstOrDefault(x => x.Id == id);

            if (t != null)
            {
                t.Data = transaction.Data;
                t.Loja = transaction.Loja;
                t.Produto = transaction.Produto;
                t.Total = transaction.Total;
                t.Vendido_para = transaction.Vendido_para;
            }
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var t = transactions.FirstOrDefault(x => x.Id == id);

            if (t != null)
            {
                transactions.Remove(t);
            }
        }
    }
}
