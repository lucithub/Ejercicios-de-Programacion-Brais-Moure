﻿/*
 * Escribe un programa que muestre por consola (con un print) los
 * números de 1 a 100 (ambos incluidos y con un salto de línea entre
 * cada impresión), sustituyendo los siguientes:
 * - Múltiplos de 3 por la palabra "fizz".
 * - Múltiplos de 5 por la palabra "buzz".
 * - Múltiplos de 3 y de 5 a la vez por la palabra "fizzbuzz".
 */
public class Program
{
    static void Main(string[] args)
    {
        int numero = 1;
        while (numero < 101)    
        {
            if (numero % 3 == 0 && numero % 5 == 0)
            {
                Console.WriteLine("fizzbuzz\n");
            }
            else if (numero % 3 == 0)    
            {
                Console.WriteLine("fizz\n");
            }
            else if (numero % 5 == 0)
            {
                Console.WriteLine("buzz\n");
            }
            else
            {
                Console.WriteLine(numero + "\n");
            }
            numero++;
        }
    }
}