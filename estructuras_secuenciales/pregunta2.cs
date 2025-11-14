using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el precio del producto: ");
        double precio = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese la cantidad comprada: ");
        int cantidad = Convert.ToInt32(Console.ReadLine());

        double subtotal = precio * cantidad;
        double igv = subtotal * 0.18;
        double total = subtotal + igv;

        Console.WriteLine("\n--- RESULTADOS ---");
        Console.WriteLine("Subtotal: " + subtotal);
        Console.WriteLine("IGV (18%): " + igv);
        Console.WriteLine("Total a pagar: " + total);

        Console.ReadKey();
    }
}
