using System;

class Aula15
{
    static void Main()
    {
        int tempo=0;
        char escolha;

        Console.WriteLine("Belo Horizonte/MG a Vitória/ES");
        Console.WriteLine("Escolha o transporte: [A] Avião, [C] Carro, [O] Ônibus");

        escolha = char.Parse(Console.ReadLine()!);

        switch (escolha)
        {
            case 'A':
            case 'a':
            tempo = 50;
            break;
            case 'C':
            case 'c':
            tempo = 480;
            break;
            case 'O':
            case 'o':
            tempo = 660;
            break;
            default:
            tempo = -1;
            break;
        }

        if (tempo < 0)
        {
            Console.WriteLine("Transporte indisponível");
        }
        else
        {
            Console.WriteLine("O tempo de viagem é: {0} minutos", tempo);
        }
    }
}