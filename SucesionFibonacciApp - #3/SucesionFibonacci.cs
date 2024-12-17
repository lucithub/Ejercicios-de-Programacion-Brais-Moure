using System;

public class Program
{
    public static void Main(string[] args)
    {
        int primerNumero = 0;
        int segundoNumero = 1;
        Console.WriteLine(primerNumero);
        Console.WriteLine(segundoNumero);
        for (int i = 0; i < 49; i++)
        {
            int tercerNumero = primerNumero + segundoNumero;
            Console.WriteLine(tercerNumero);
            primerNumero = segundoNumero;
            segundoNumero = tercerNumero;
        }
    }
}
