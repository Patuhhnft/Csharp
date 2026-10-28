using System;

class Aula14
{
    static void Main()
    {
        Console.WriteLine("Fala ae irmão, o que quer fazer?\n1 - Casar\n2 - Comprar um porco ilegal\n3 - Dormir");
        int n1 = int.Parse(Console.ReadLine()!);
        if (n1 == 1)
        {
            Console.WriteLine("Comigo? Se for mulher aceito kkkk");
        } else if (n1 == 2)
        {
            Console.WriteLine("Quantos?");
        } else if(n1 == 3)
        {
          Console.WriteLine("ZZZZZZZZZZZZ");
        };
    }
}