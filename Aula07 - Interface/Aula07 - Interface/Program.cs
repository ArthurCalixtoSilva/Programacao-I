using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula07_Parte_2
{
    internal class Program
    {

        interface IVoador
        {
            void Voar();
            void Comer();
        }

        interface INadador
        {
            void Nadar();
            void Comer();
        }

        public class Pássaro : IVoador
        {
            public void Voar()
            {
                Console.WriteLine("Voando!!!");
            }
            public void Comer()
            {
                Console.WriteLine("Comendo!!!");
            }
        }

        public class Pinguin : INadador
        {
            public void Nadar()
            {
                Console.WriteLine("Nadando!!!");
            }
            public void Comer()
            {
                Console.WriteLine("Comendo!!!");
            }
        }

        public class Pato : IVoador, INadador
        {
            public void Nadar()
            {
                Console.WriteLine("Nadando!!!");
            }

            public void Voar()
            {
                Console.WriteLine("Voando!!!");
            }
            public void Comer()
            {
                Console.WriteLine("Comendo!!!");
            }
        }

       
        static void Main(string[] args)
        {

        }
    }
}
