using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite o número: ");
        int a = int.Parse(Console.ReadLine());

        if (a >= 1)
        {
            Console.WriteLine("O número " + a + " é positivo");
        }
        else if (a == 0)
        {
            Console.WriteLine("O número " + a + " é neutro");
        }
        else
        {
            Console.WriteLine("O número " + a + " é negativo");
        }
            
        
    }
}