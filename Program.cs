using System;
using C__Fundamentals;

class Program
{
    public static void Main(string[] args)
    {
        Retangulo retangulo = new Retangulo();
        retangulo.Altura = 5;
        retangulo.Largura = 10;

        retangulo.CalcularArea();

        // IForma iforma = new IForma(); vAI DAR ERRO

        IForma iforma = new Retangulo();

        Console.ReadKey();
    }
}