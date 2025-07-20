using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula07_Ex01
{
    /*
     1 – Crie uma interface chamada Conta. Conta terá os métodos depositar(double valor), sacar (double 
valor), ambos void por não retornarem nenhum dado e receberem valor do tipo double para realizar 
suas operações, e um método double getSaldo(), que irá retornar o valor do saldo da conta.
    
2 – Crie uma classe chamada ContaCorrente, que herda a interface Conta. Esta classe possui dois 
atributos/propriedades chamados saldo e tarifa, do tipo double. Realize a implementação dos métodos 
desta interface. Faça com que, a cada saque, seja descontado além do valor, o valor colocado no 
atributo chamado tarifa. Por exemplo. Se o saldo for 100, a tarifa for 1.50 e o valor solicitado para saque 
for 50, o novo saldo será 100 – 50 – 1.50 (saldo – valor – tarifa) = 48,50. Não permita sacar se o saldo for 
insuficiente (não pode deixar a conta com saldo menor do que zero). 

3 – Crie uma classe chamada ContaPoupanca, que herda a interface conta. Esta classe possui um 
atributos/propriedade chamado saldo, como a classe anterior (do tipo double). Realize a implementação 
dos métodos desta interface. No saque, faça o mesmo procedimento como colocado no exercício 2, 
porém em poupança não teremos o desconto da tarifa. Por exemplo, se o saldo é 100 e o valor do saque 
for 50, o novo saldo será 100 – 50 (saldo – valor) = 50. Não permita sacar se o saldo for insuficiente (não 
pode deixar a conta com saldo menor do que zero). 

4 – Crie uma outra classe chamada GeradordeExtratos, que possui um método que recebe a interface 
Conta como parâmetro, chamado GerarExtrato (Conta c), que mostre o saldo de qualquer uma das duas 
contas. (para isso, deve chamar c.getSaldo()). 

5 – Escreva o Main() de seu programa de forma a testar os métodos criados.
    */
    internal class Program
    {
        interface IConta
        {
            void Depositar(double valor);
            void Sacar(double valor);

            double Getsaldo();
       
        }

        public class ContaCorrente : IConta
        {

            private double saldo { get; set; }
            private double tarifa {  get; set; }



            public ContaCorrente(double saldo, double tarifa)
            {
                this.tarifa = tarifa;
                this.saldo = saldo;

            }

            public void Depositar(double valor)
            {
                saldo += valor;
            }
            public void Sacar(double valor)
            {
                if (saldo > 0)
                {
                    saldo -= valor + tarifa;
                }
                else
                {
                    Console.WriteLine("O valor do saque é maior que o valor do saldo, por gentileza, tente novamente");
                }
            }
            public double Getsaldo()
            {
                return saldo;
            }


        }

        static void Main(string[] args)
        {
            ContaCorrente contas = new ContaCorrente(100, 5);
            contas.Depositar(50);
            Console.WriteLine(contas.Getsaldo());
            contas.Sacar(50);
            Console.WriteLine(contas.Getsaldo());

        }
    }
}
