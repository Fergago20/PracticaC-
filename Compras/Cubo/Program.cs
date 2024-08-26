using Cubo.clas;
namespace Cubos;

class Program
{
    static void Main(string[] args)
    {
        Calculo cub = new Calculo();
        double numero, resultado;
        Console.Write("Ingrese un numero: ");
        numero = double.Parse(Console.ReadLine());
        cub.numero = numero;
        resultado = cub.potencia();

        Console.WriteLine($"El cubo es {resultado}.");
        Console.ReadLine();
    }
}
