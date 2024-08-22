namespace Trabajador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre, cargo;
            double salario, newsal;
            Console.Write("Nombre del trabajador: ");
            nombre = Console.ReadLine();
            Console.Write("Cargo del Trabajador: ");
            cargo = Console.ReadLine();
            Console.Write("Salario actual: ");
            salario = double.Parse(Console.ReadLine());

            newsal = (salario * 0.1) + salario;

            Console.WriteLine(nombre);
            Console.WriteLine("Cargo: "+ cargo +".");
            Console.WriteLine("Nuevo Salario: " + newsal + ".");
        }
    }
}
