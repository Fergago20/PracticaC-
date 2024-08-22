namespace AreaCirculo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radio, area;
            Console.Write("Ingrese Valor del Radio: ");
            radio = double.Parse(Console.ReadLine());
            area = Math.PI * Math.Pow(2, radio);

            Console.WriteLine("El area del circulo es: " + area + ".");

        }
    }
}
