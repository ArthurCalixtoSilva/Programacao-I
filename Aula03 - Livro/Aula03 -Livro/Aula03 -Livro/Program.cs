using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03__Livro
{
    internal class Program


    {
        public class Livro
        {
            public string titulo { get; set; }
            public string autor {  get; set; }

            public Livro(string titulo, string autor)
            {
                this.titulo = titulo;
                this.autor = autor;
            }

            public void Exibir()
            {
                Console.WriteLine($"Livro:{titulo}| Autor:{autor}");
            }
        }



        static void Main()
        {
            Livro[] livros = new Livro[4];
            livros[0] = new Livro("Livro 1", "Arthur");
            livros[1] = new Livro("Livro 2", "Murilo");
            livros[2] = new Livro("Livro 3", "Sergio");
            livros[3] = new Livro("Livro 4", "Peixe");

            foreach(var livro in livros)
            {
                livro.Exibir();
            }

        }

    }
}
