using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula05_Ex2
{ /*Crie a classe `Produto` com os atributos `nome`, `preco` e `quantidade`. Adicione 
um método que calcule e retorne o valor total em estoque (preço × quantidade). 
Utilize um vetor de 3 produtos e exiba os dados e o total para cada um. */
    class Program
    {
        static void Main()
        {
            Produto[] produtos = new Produto[3];
            for (int i = 0; i < produtos.Length; i++)
            {
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Preço: ");
                double preco = double.Parse(Console.ReadLine());
                Console.Write("Quantidade: ");
                int qtd = int.Parse(Console.ReadLine());
                produtos[i] = new Produto(nome, preco, qtd);
            }
            Console.WriteLine("\nProdutos cadastrados:");
            foreach (Produto p in produtos)
            {
                p.exibir();
            }
        }
    }
}
