using mate.Raiz;
namespace mate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero, resultado;
            Calculo cal = new Calculo();
            Console.Write("Ingrese un numero: ");
            numero = double.Parse(Console. ReadLine());
            cal.numero = numero;
            resultado = cal.resultado();
            Console.WriteLine($"La raiz es {resultado}.");
        }
    }
}
