using System;

namespace media
{
    class Program
    {
        static void Main(string[] args)
        {
int prova1;
int prova2;
string nome;
int media;

Console.WriteLine("Digite seu nome:");
nome = Console.ReadLine();

    Console.WriteLine("Digite o valor da prova 1:");
    prova1 = int.Parse( Console.ReadLine());

        Console.WriteLine("Digite o valor da prova 2:");
        prova2 = int.Parse( Console.ReadLine());

            media = (prova1 + prova2) / 2;

            Console.WriteLine($"A média de {nome} é {media}");

                if (media > 5){
                Console.WriteLine("Você foi aprovado");
                } else{
                Console.WriteLine("Você foi reprovado");
                }
        }
    }
}