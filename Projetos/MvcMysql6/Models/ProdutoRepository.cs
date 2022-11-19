using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvc1.Models
{
    public class ProdutoRepository
    {
         private AppDbContext context;
        public ProdutoRepository(AppDbContext ctx) {
            context = ctx;
        }
        public IEnumerable<Produto> Produtos => context.Produtos;
    }
}