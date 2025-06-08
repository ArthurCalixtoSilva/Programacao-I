using System;

namespace Aula06_Ex3
{
    internal class Program
    {
        public class Animal
        {
            public virtual void EmitirSom()
            {
                Console.WriteLine("O animal faz x som");
            }
        }

        public class Cachorro : Animal
        {
            public override void EmitirSom()
            {
                Console.WriteLine("O cachorro faz au au");
            }
        }

        public class Gato : Animal
        {
            public override void EmitirSom()
            {
                Console.WriteLine("O gato faz miau");
            }
        }

        static void Main(string[] args)
        {
            Cachorro cachorro = new Cachorro();
            Gato gato = new Gato();
            Animal animal = new Animal();
            cachorro.EmitirSom();
            gato.EmitirSom();
            animal.EmitirSom();
        }
    }
}