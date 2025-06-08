using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03
{
    internal class Program

    {
        public class Aluno
        {
            public string nome { get; set; }
            public double nota { get; set; }

            public Aluno(string nome, double nota)
            {
                this.nome = nome;
                this.nota = nota;
            }

            public void exibir()
            {
                Console.WriteLine($"Aluno: {nome} | Nota: {nota} ");
            }

            public class Mensagem
        {
            
            }
            public void Saudacao(string nome)
            {
                Console.WriteLine($"Olá {nome} seja bem vindo!");
            }
        }
        static void Main(string[] args)
        {
            /*Mensagem mensagem = new Mensagem();
            //mensagem.Saudacao("Sergio");
            Console.WriteLine("Qual o nome? ");
            mensagem.Saudacao(Console.ReadLine());*/
            Aluno[] alunos = new Aluno[3];
            alunos[2] = new Aluno("Igor", 8.8);
            alunos[0] = new Aluno("Sarah", 2.5);
            alunos[1] = new Aluno("Arthur", 10.0);

            for(int i = 0; i < alunos.Length; i++)
            {
                alunos[i].exibir();
            }

        }
    }
}
