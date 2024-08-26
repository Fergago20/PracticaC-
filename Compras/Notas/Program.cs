using Notas.clas;
namespace Notas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Nota not = new Nota();
            string Asignatura;
            double nota1, nota2, nota3, promedio;

            Console.Write("Nombre de la asignatura: ");
            Asignatura = Console.ReadLine();
            Console.Write("Nota 1: ");
            nota1 = double.Parse(Console.ReadLine());
            Console.Write("Nota 2: ");
            nota2 = double.Parse(Console.ReadLine());
            Console.Write("Nota 3: ");
            nota3 = double.Parse(Console.ReadLine());

            not.Asignatura = Asignatura;
            not.nota1 = nota1;
            not.nota2 = nota2;
            not.nota3 = nota3;

            promedio = not.promedio();
            Console.WriteLine($"El promedio de {Asignatura} es de {promedio}.");
            Console.ReadLine();
        }
    }
}
