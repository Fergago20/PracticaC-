namespace ParImpar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Digita un numero entero cualquiera: ");
            num = int.Parse(Console.ReadLine());
            if (num%2==0)
            {
                Console.Write($"El numero {num} es par");
            }
            else
            {
                Console.Write($"El numero {num} es impar");
            }
        }
    }
}
