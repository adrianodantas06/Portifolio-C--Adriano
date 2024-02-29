using System;
using System.Globalization;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite o valor: ");
        float a = float.Parse(Console.ReadLine());
        Console.WriteLine("Digite o desconto: ");
        float b = float.Parse(Console.ReadLine());
       

        float total = (a * b) / 100;
        float total1 = a - total;
        Console.WriteLine("O valor de desconto é: R$ " + total);
        Console.WriteLine("O valor total a pagar é: R$ " + total1);

    }
}
