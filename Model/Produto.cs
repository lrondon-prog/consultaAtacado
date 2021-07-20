using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encontro26
{
   public class Produto
    {
        public int ProdutoID { get; set; }

        public int SubcategiraID { get; set; }

        public int CategoriaID { get; set; }

        public string Descricao { get; set; }

        public DateTime DataInsert { get; set; }


        public Produto() { }

    }
}
