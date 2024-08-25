using Compras.clases;

namespace Compras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejemplo 1");
            Factura fact = new Factura();
            string producto=null;
            double precio=0, monto;
            int cantidad=0;

            Console.Write("Producto: ");
            producto=Console.ReadLine();
            Console.Write("Precio: ");
            precio=double.Parse(Console.ReadLine());
            Console.Write("Cantidad: ");
            cantidad=int.Parse(Console.ReadLine());

            fact.producto = producto;
            fact.precio = precio;
            fact.cantidad = cantidad;
            monto = fact.calcularMonto();

            Console.WriteLine($"\n{producto}");
            Console.WriteLine($"Precio ${precio}");
            Console.WriteLine($"monto ${monto}");
        }
    }
}
