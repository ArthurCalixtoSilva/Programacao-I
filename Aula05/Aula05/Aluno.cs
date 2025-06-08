using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula05
{
    internal class Aluno
    {
        private string nome { get; set; }
        private double nota { get; set; }


        public Aluno(string nome, double nota)
        {
            this.nome = nome;
            this.nota = nota;

        }

        public void exibir()
        {
            Console.WriteLine($"Aluno:{nome} -> Nota:{nota}");
        }

    }
}