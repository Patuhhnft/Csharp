using System;

class Aula12
{
    static void Main()
    {
        // IF < > || && === !=
        // int num = 0;
        string resultado = "Errou bonito, lindão";
        // num = int.Parse(Console.ReadLine());

        int n1,n2,n3,n4;
        n1=n2=n3=n4=0;

        Console.WriteLine("Digite a nota 1");
        n1 = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Digite a nota 2");
        n2 = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Digite a nota 3");
        n3 = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Digite a nota 4");
        n4 = int.Parse(Console.ReadLine()!);

        int res = n1+n2+n3+n4;

        if (res < 10)
        {
            Console.WriteLine("Está certo parceiro!!!");
        }
        else
        {
            Console.WriteLine("{0}", resultado);
        };
    }
}