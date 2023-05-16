using System;
using System.Globalization;

namespace Course {

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo: ");
            string fullName = Console.ReadLine();

            Console.WriteLine("Digite quantos quartos tem em sua casa: ");
            int bedRooms = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Insira seu último nome, sua idade e altura: ");
            string[] v = Console.ReadLine().Split(' ');
            
            string lastName = v[0];
            string age = v[1];
            double height = double.Parse(v[2], CultureInfo.InvariantCulture);

            Console.WriteLine(fullName);
            Console.WriteLine(bedRooms);
            Console.WriteLine(price.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(lastName);
            Console.WriteLine(age);
            Console.WriteLine(height.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}