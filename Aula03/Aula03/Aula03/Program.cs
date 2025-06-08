using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula3_Vetores
{
    internal class Program
    {

        class Aluno
        {
            public string nome;
            public double nota;

            public Aluno(string nome, double nota)
            {
                this.nome = nome;
                this.nota = nota;
            }

            public void Exibir()
            {
                Console.WriteLine($"Aluno: {nome}, Nota: {nota}");

            }
        }

        public static void Main()
        {
            Aluno[] alunos = new Aluno[3];

            alunos[2] = new Aluno("Igor", 7.5);
            alunos[0] = new Aluno("Ana", 4.6);
            alunos[1] = new Aluno("Fred", 10.0);

            for (int i = 0; i < alunos.Length; i++)
            {
                alunos[i].Exibir();
            }
        }
    }
}
        

