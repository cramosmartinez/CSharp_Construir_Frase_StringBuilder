using System;
using System.Text;

class Program
{
    static void Main()
    {
        // Solicitar cuatro números al usuario
        Console.Write("Por favor, introduce el primer número: ");
        string numero1 = Console.ReadLine();

        Console.Write("Por favor, introduce el segundo número: ");
        string numero2 = Console.ReadLine();

        Console.Write("Por favor, introduce el tercer número: ");
        string numero3 = Console.ReadLine();

        Console.Write("Por favor, introduce el cuarto número: ");
        string numero4 = Console.ReadLine();

        // Usar StringBuilder para construir la frase
        StringBuilder frase = new StringBuilder();
        frase.Append("El primer número introducido es el ");
        frase.Append(numero1);
        frase.Append(", después han introducido el ");
        frase.Append(numero2);
        frase.Append(" y ");
        frase.Append(numero3);
        frase.Append(", y por último el ");
        frase.Append(numero4);
        frase.Append(".");

        // Imprimir la frase
        Console.WriteLine(frase.ToString());
    }
}
