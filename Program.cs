using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n--- Calculadora Básica ---");
            Console.Write("Número 1: ");
            double n1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Número 2: ");
            double n2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nElige operación:");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.WriteLine("5. Salir");
            Console.Write("Opción: ");

            int op = int.Parse(Console.ReadLine());
            double resultado = 0;

            switch (op)
            {
                case 1:
                    resultado = n1 + n2;
                    break;
                case 2:
                    resultado = n1 - n2;
                    break;
                case 3:
                    resultado = n1 * n2;
                    break;
                case 4:
                    if (n2 != 0)
                        resultado = n1 / n2;
                    else
                        Console.WriteLine("❌ No se puede dividir entre 0");
                    break;
                case 5:
                    Console.WriteLine("Saliendo...");
                    return;
                default:
                    Console.WriteLine("Opción no válida.");
                    continue;
            }

            Console.WriteLine($"\nResultado: {resultado}");
        }
    }
}
