using System;

namespace ModelConverter
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var x = new Transformer();
            x.Transform();
            Console.ReadLine();
        }
    }
}