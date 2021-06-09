using System;
using library;

namespace client
{
    class Program
    {
        static void Main(string[] args)
        {
           ILectorArchivo lector = new LectorArchivo();
           ProcesadorDePalabras procesador = new ProcesadorDePalabras(lector);

           Console.WriteLine($"Palabras {procesador.ContarPalabras()}");
           Console.WriteLine($"Caracteres:{procesador.ContarCaracteres()}");
        }
    }
}
