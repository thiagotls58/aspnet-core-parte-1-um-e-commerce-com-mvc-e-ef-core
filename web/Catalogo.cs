using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web
{
    public class Catalogo : ICatalogo
    {
        public List<Livro> GetLivros()
        {
            var livros = new List<Livro>();
            livros.Add(new Livro("001", "Anjos de demonios", 29.99m));
            livros.Add(new Livro("002", "O codigo da vinci", 29.99m));
            livros.Add(new Livro("003", "O simbolo perdido", 29.99m));

            return livros;
        }
    }
}
