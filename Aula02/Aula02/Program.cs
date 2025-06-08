using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Aula02
{
    internal class Program
    {   
        public class pessoa
        {
            public string nome { get; set; }
            
            public int idade { get; set; }

            public pessoa()
            {
                Console.Write("Digite o nome da pessoa: ");
                this.nome = Console.ReadLine();
                Console.Write("Digite a idade da pessoa: ");
                this.idade = int.Parse(Console.ReadLine());
            }

            ~pessoa()
            {
                Console.WriteLine("O Objeto foi destruido!");
            }




            public void apresentar()
            {
                Console.WriteLine($"Olá meu nome é {this.nome} e tenho {this.idade} anos");

            }

            public int AnoNascimento()
            {
                int resposta = 2025 - this.idade;
                //Console.WriteLine($"{this.nome} nasceu em {resposta}");
                return resposta;
            }
        }
        static void Main(string[] args)
        {/*
        
          pessoa p1 = new pessoa();
            p1.nome = "Arthur";
            p1.idade = 19;
            p1.apresentar();
         pessoa p2 = new pessoa();
            p2.nome = "Sofia";
            p2.idade = 18;
            p2.apresentar();
         pessoa p3 = new pessoa();
            Console.WriteLine("Informe o nome da pessoa 3: ");
            
            p3.nome = Console.ReadLine();
            p3.idade = 40;
            p3.apresentar();
            //p1.AnoNascimento();
            int resp;
            resp = p1.AnoNascimento();
            Console.WriteLine($"resp = {resp}");*/
        pessoa p4 = new pessoa();
            p4.apresentar();
            int resp;
            resp = p4.AnoNascimento();
            Console.WriteLine($"Ano de nascimento = {resp}");









        }
    }
}
