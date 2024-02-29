using System;
using System.Globalization;
using System.Net.Http.Headers;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite a primeira nota: ");
        int nota1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite a primeira nota: ");
        int nota2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite a primeira nota: ");
        int nota3 = int.Parse(Console.ReadLine());

        int media = (nota1 + nota2 + nota3) / 3;
        Console.WriteLine("A sua nota é " + media);



    }
}
