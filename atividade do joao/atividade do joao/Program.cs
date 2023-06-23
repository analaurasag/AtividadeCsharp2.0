using System;

namespace ExemploInterface
{
    public interface Ianimal
    {
        void EmiteSom();
    }
    public class Cachorro : Ianimal
    {
        public void EmiteSom()
        {
            Console.WriteLine("Cachorro late.");
        }
    }
    public class Gato : Ianimal
    {
        public void EmiteSom()
        {
            Console.WriteLine("Gato mia.");

        }
    }
    class program
    {
        static void Main(string[] largs)
        {

            Ianimal cachorro1 = new Cachorro();
            Ianimal Gato1 = new Gato();
            cachorro1.EmiteSom();
            Gato1.EmiteSom();
        }
    }
}