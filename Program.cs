using System;
using System.Collections;
using C__Fundamentals;

class Program
{
    public static void Main(string[] args)
    {
        Retangulo retangulo = new Retangulo();
        retangulo.Altura = 5;
        retangulo.Largura = 10;

        retangulo.CalcularArea();

        // IForma iforma = new IForma(); // Vai dar erro

        // IForma iforma = new Retangulo(); Pode fazer
        IForma iforma = retangulo; 

        Console.ReadKey();

        ArrayList ArrayList = new ArrayList(); // esse array list ocupa mais espaço de memória que a forma abaixo

        
        IEnumerable arrayListIEnumerable = new ArrayList();


    }
}