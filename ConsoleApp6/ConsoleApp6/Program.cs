using System;
using System.ComponentModel.Design;

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
            Console.WriteLine("A sua média é " + media + " você foi aprovado");
        }
        else if (media >= 3 && media == 6){
            Console.WriteLine("A sua média é " + media + " você está de recuperação");
        }
        else
            Console.WriteLine("A sua média é " + media + " você foi reprovado");
    }
}