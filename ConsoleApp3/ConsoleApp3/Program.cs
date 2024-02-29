using System;
using System.Globalization;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite a primeira nota: ");
        float nota1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Digite a segunda nota: ");
        float nota2 = float.Parse(Console.ReadLine());

        float media = (nota1 + nota2) / 2;

        if (media >= 6)
        {
            Console.WriteLine("A sua média é:  " + media + " você está aprovado");
        }
        else
        {
            Console.WriteLine("A sua média é:  " + media + " você não foi aprovado");
        }


    }
}