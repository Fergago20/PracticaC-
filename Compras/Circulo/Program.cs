using Circulo.clas;
namespace Circulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculo cal = new Calculo();
            double radio, area;
            Console.Write("Ingrese el valor del radio: ");
            radio = double.Parse(Console.ReadLine());
            cal.radio = radio;
            area = cal.area();
            Console.WriteLine($"Ela area del circulo es de {area}.");
        }
    }
}
