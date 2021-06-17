using System;
using library;

namespace client
{
    class Program
    {
        static void Main(string[] args)
        {
           //ILectorArchivo lector = new LectorArchivo();
           //ProcesadorDePalabras procesador = new ProcesadorDePalabras(lector);

           //Console.WriteLine($"Palabras {procesador.ContarPalabras()}");
           //Console.WriteLine($"Caracteres:{procesador.ContarCaracteres()}");

            Producto producto = new Producto();
            producto.Nombre = "Nevera";
            producto.Descripcion = "No-Frost de 365lt marca LG";
            producto.Precio = 500;

            var productoAsJson = System.Text.Json.JsonSerializer.Serialize(producto);

            Console.WriteLine(productoAsJson);
        }
    }
}
