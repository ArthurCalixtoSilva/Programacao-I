using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Aula05
{
    /* Crie a classe `Aluno` com atributos privados `nome` e `nota`, um constructor que 
preencha esses parâmetros, e o método `Exibir()`. Crie uma segunda classe chamada 
`Turma` que armazene até 3 alunos e forneça os métodos `Cadastrar()` e `Listar()`. 
Crie um menu na classe `Program` com as opções: 1 - Cadastrar, 2 - Listar, 3 - Sair. */
    internal class Program
    {

        static void Main(string[] args)
        {
            int opcao;

            Turma alunos = new Turma();
            do
            {
                Console.WriteLine("1 - Cadastrar\n2 - Listar\n3 - Sair.");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        alunos.Cadastrar();
                        break;
                    case 2:
                    alunos.Listar();
                        break;
                }


            } while (opcao != 3);
        }
    }
}
