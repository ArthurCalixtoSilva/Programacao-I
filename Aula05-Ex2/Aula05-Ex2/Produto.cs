using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula05_Ex2
{
    internal class Produto
    {


        public string nome { get; set; }
        public double preco { get; set; }
        public int quantidade { get; set; }


        public Produto(string nome, double preco, int quantidade)
        {
            this.nome = nome;
            this.preco = preco;
            this.quantidade = quantidade;
        }
        public double TotalEmEstoque()
        {
            return preco * quantidade;
        }

        public void exibir()
        {
            Console.WriteLine($"{nome} - R${preco} x {quantidade} = {TotalEmEstoque()}");
        }
    }
}
