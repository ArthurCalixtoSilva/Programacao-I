using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula06_Ex05
{

        public class Conta
        {
            public int nmr_conta {  get; set; }
            public double saldo {  get; set; }


            public Conta(int nmr_conta, double saldo)
            {
                this.nmr_conta = nmr_conta;
                this.saldo = saldo;
            }
            public virtual void depósito(double valor)
            {
                if ( valor > 0)
                {
                    saldo += valor;
                Console.WriteLine($"Foi depósitado {valor}");
                }
                else 
                {
                    Console.WriteLine("O valor deve ser positivo");
                }
            }

            public virtual void saque(double valor)
            {
                if ( valor > 0 && saldo >= valor)
                {
                    saldo -= valor;
                    Console.WriteLine($"Foi sacado {valor}");
                }
                else
                {
                    Console.WriteLine("Saldo insuficiente");
                }
            }

            public virtual void VerSaldo()
            {
                Console.WriteLine($"O saldo da conta {nmr_conta} é:{saldo}");
            }
        }

        public class ContaEspecial : Conta 
        {
            public double limite {  get; set; }
        
        public ContaEspecial(int nroConta, double saldo, double limite): base (nroConta, saldo)
        {
            this.limite = limite;
        }

        public override void saque(double valor)
        {
            if (valor > 0 && (saldo + limite) >= valor)
            {
                saldo -= valor;
                Console.WriteLine($"Saque de {valor} realizado utilizando limite especial. Saldo atual: {saldo}");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente, mesmo considerando o limite especial.");
            }
        }

        static void Main(string[] args)
        {
            /*Conta conta = new Conta(2, 5000);
            conta.depósito(500);
            conta.saque(400);
            conta.VerSaldo();*/

            ContaEspecial contaEspecial = new ContaEspecial(3, 10000, 20000);

            contaEspecial.VerSaldo();
            contaEspecial.depósito(10000);
            contaEspecial.VerSaldo();
            contaEspecial.saque(11000);
            contaEspecial.VerSaldo();
            contaEspecial.saque(20000);
            contaEspecial.VerSaldo();
            contaEspecial.saque(9000);
            contaEspecial.VerSaldo();



        }
    }
}
