using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula05
{
    internal class Turma
    {
        Aluno[] alunos = new Aluno[3];
        int contador = 0;
        public void Cadastrar()
        {
            if (contador < alunos.Length)
            {
                Console.Write("Nome do aluno: ");
                String nome = Console.ReadLine();
                Console.Write("Nota: ");
                double nota = double.Parse(Console.ReadLine());
                alunos[contador] = new Aluno(nome, nota);
                contador++;
            }

            else
            {
                Console.WriteLine("Limite de cadastros atingido");
            }
        }
        public void Listar()
        {
            for (int i = 0; i < contador; i++)
            {
                alunos[i].exibir();
            }
        }
    }
}
