using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula06_Ex2
{
    internal class Program
    {
        public class veiculo
        {
            public virtual void mover()
            {
                Console.WriteLine("O veiculo está se movendo");

            }
        }
        public class carro : veiculo
        {
            public override void mover()
            {
                Console.WriteLine("O carro está se movendo");
            }
        }

        public class moto : veiculo
        {
            public override void mover()
            {
                Console.WriteLine("A moto está se movendo");
                base.mover();
            }
        }
        static void Main(string[] args)
        {
            veiculo veiculo = new veiculo();
            carro carro = new carro();
            veiculo.mover();
            carro.mover();
            moto moto = new moto();
            moto.mover();
            veiculo[] veiculos = new veiculo[3];
            veiculos[1] = new veiculo();
            veiculos[2] = new carro();
            veiculos[3] = new moto();
        }
    }
}
