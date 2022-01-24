using System;

namespace FindMaxUsingGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Maximum number is :");
            int[] intarray = { 991, 112, 96 };
           Generics<int> genericint = new Generics<int>(intarray);
            genericint.PrintMaxValue();

            float[] floatArray = { 515.64f, 378.96f, 432f, 791, 974.35f };
            Generics<float> genericfloat = new Generics<float>(floatArray);
            genericfloat.PrintMaxValue();

            string[] stringArray = { "123", "789", "156", "122", "678" };
            Generics<string> genericstring = new Generics<string>(stringArray);
            genericstring.PrintMaxValue();


        }
    }
}