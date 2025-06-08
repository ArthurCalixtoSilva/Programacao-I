using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula06_Ex4
{
    internal class Program
    {
        public class colaborador
        {
            public virtual void calculo()
            {
                Console.WriteLine("Os colaboradores receberam um bônus");
            }
        }
        public class gerente : colaborador
        {
            public override void calculo()
            {
                Console.WriteLine("Os gerentes receberam 15% de bônus");
            }
        }
        public class vendedor : colaborador
        {
            public override void calculo()
            {
                Console.WriteLine("Os vendedores receberam 10% de bônus");
            }
        }

        static void Main(string[] args)
        {
            colaborador colaborador = new colaborador();
            gerente gerente = new gerente();
            vendedor vendedor = new vendedor(); 
            colaborador.calculo();
            gerente.calculo();
            vendedor.calculo();
        }
    }
}
