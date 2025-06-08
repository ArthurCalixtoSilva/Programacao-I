using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula06
{
    internal class Program
    {


        public class veiculo
        {
            public string modelo {  get; set; }
            public int ano { get; set; }

            public  veiculo(string modelo, int ano)
            {
                this.modelo = modelo;
                this.ano = ano;
            }
            public void Exibir()
            {
                Console.WriteLine($"Modelo:{modelo} - Ano:{ano}");
            }
        }

        public class carro : veiculo
        {
            public int num_portas { get; set; }
            public carro(string modelo, int ano, int num_portas) : base(modelo, ano) 
            {
                this.num_portas = num_portas;
            }
            

            public void ExibirCarro()
            {
                Exibir();
                Console.WriteLine($"Nº de portas:{num_portas}");
            }
        }
        static void Main(string[] args)

        {

            carro veiculo1 = new carro("Fusca", 2000, 2);
            veiculo1.ExibirCarro();
            veiculo veiculo2 = new veiculo("Uno", 1990);
            veiculo2.Exibir();

        }
        
    }
}
