namespace SumarDosNumero
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Escribe el primer número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Escribe el segundo número: ");
            int num2 = int.Parse(Console.ReadLine());


            Console.Write("Escribe el segundo número: ");
            int num3 = int.Parse(Console.ReadLine());

            int resultado = num1 + num2  + num3;

            Console.WriteLine("La suma es: " + resultado);
            Console.ReadKey();
            Console.WriteLine("gracias");
        }
    }
}
