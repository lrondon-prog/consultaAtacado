using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encontro26.Engine
{
    public class EngineCategorias
    {
        //CRUD
        //c - create
        //r - read
        //u - update
        //d - delete


        //BREAD
        //b - browse
        //r - read
        //e - edit
        //a - add
        //d - delete
        private List<Categoria> categorias;

        public EngineCategorias()
        {
            this.Carregar();
        }

        public List<Categoria>  Browse()
        {
            return this.categorias;
        }

        public Categoria Add(int CategoriaID, String Descricao)
        {
            Categoria c = new Categoria();
            c.CategoriaID = CategoriaID;
            c.Descricao = Descricao;
            c.DataInsert = DateTime.Now;

            return c;

        }

        private void Carregar()
        {
            if (this.categorias == null)
            {
                this.categorias = new List<Categoria>();
            }
            if (this.categorias.Count == 0)
            {
                this.categorias.Add(this.Add(1, "Alimento Infantil"));
                this.categorias.Add(this.Add(2, "Suplementos"));
                this.categorias.Add(this.Add(3, "Bebidas"));
                this.categorias.Add(this.Add(4, "Biscoitos, Bolos e Bolacha"));
                this.categorias.Add(this.Add(5, "Carnes"));
                this.categorias.Add(this.Add(6, "Congelado"));
                this.categorias.Add(this.Add(7, "Conservas"));
                this.categorias.Add(this.Add(8, "Doces, Balas, Chocolates e Cia"));
                this.categorias.Add(this.Add(9, "Farinhas, Cereais e Complementos"));
                this.categorias.Add(this.Add(10, "Fast-Food, Aperitivos e Petiscos"));
                this.categorias.Add(this.Add(11, "Frios e Embutidos"));
                this.categorias.Add(this.Add(12, "Frutas"));
                this.categorias.Add(this.Add(13, "Legumes, Verduras e Grãos"));
                this.categorias.Add(this.Add(14, "Massas"));
                this.categorias.Add(this.Add(15, "Molhos, Caldos e Condimentos"));
                this.categorias.Add(this.Add(16, "Ovos, Leite e Queijo e Cia"));
                this.categorias.Add(this.Add(17, "Pães"));
                this.categorias.Add(this.Add(18, "Sopas & Cremes"));
                this.categorias.Add(this.Add(19, "Diversos"));

            }

        }
    }
}
