using System;
using System.Linq;

public class Anagrama
{
    public static bool SonAnagramas(string palabra1, string palabra2)
    {
        // Si las palabras son iguales, no son anagramas
        if (palabra1.Equals(palabra2, StringComparison.OrdinalIgnoreCase))
        {
            return false;
        }

        // Convertir las palabras a minúsculas y ordenarlas
        var palabra1Ordenada = String.Concat(palabra1.ToLower().OrderBy(c => c));
        var palabra2Ordenada = String.Concat(palabra2.ToLower().OrderBy(c => c));

        // Comparar las palabras ordenadas
        return palabra1Ordenada == palabra2Ordenada;
    }
}
public class Program
{
    public static void Main()
    {
        string palabra1 = "amor";
        string palabra2 = "roma";

        bool resultado = Anagrama.SonAnagramas(palabra1, palabra2);
        Console.WriteLine($"¿Son anagramas \"{palabra1}\" y \"{palabra2}\"? {resultado}");
    }
}

