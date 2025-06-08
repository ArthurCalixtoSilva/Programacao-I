using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa("Arthur", 19);

            p1.Apresentar();

        }

        public class Pessoa
        {
            public string nome { get; set; }
            public int idade { get; set; }

            public Pessoa(string nome, int idade)
            {
                this.nome = nome;
                this.idade = idade;
            }

            public void Apresentar()
            {
                Console.WriteLine($"Olá meu nome é {this.nome} e tenho {this.idade}");
            }

        }
    }

}
