namespace MayorNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[3];

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"Ingrese numero {i + 1}: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }
            int n = numeros.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (numeros[j] < numeros[j + 1])
                    {
                        int temp = numeros[j];
                        numeros[j] = numeros[j + 1];
                        numeros[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("El orden de mayor a menor es: ");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"{numeros[i]}");
            }
        }
    }
}
