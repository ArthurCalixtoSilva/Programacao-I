using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula07
{
    internal class Program
    {
        public abstract class Funcionario
        {
            public string matricula {  get; set; }
            public string nome { get; set; }

            public void exibir()
            {
                Console.WriteLine($"Matricula {matricula} - Nome {nome}");
            }

            public abstract double comissao();
        }

        public class vendedor : Funcionario
        {
            public override double comissao()
            {
                return Convert.ToDouble("0,1");
            }
        }

        public class atendente : Funcionario
        {
            public override double comissao()
            {
                return Convert.ToDouble("0,05");
            }
        }

        public class gerente : Funcionario
        {
            public override double comissao()
            {
                return Convert.ToDouble("0,2");
            }
        }
        static void Main(string[] args)
        {
            vendedor Murilo = new vendedor();
            gerente Wagner = new gerente();
            atendente Gustavo = new atendente();
            /*
            Murilo.exibir();
            Wagner.exibir();
            Gustavo.exibir();
            */

            Console.WriteLine($"Comissão do Murilo: {Murilo.comissao() * 100}%");
            Console.WriteLine($"Comissão do Wagner: {Wagner.comissao() * 100}%");
            Console.WriteLine($"Comissão do Gustavo: {Gustavo.comissao() * 100}%");


        }
    }
}
