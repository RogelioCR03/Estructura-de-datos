using System;

namespace Practica_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string nombre;
            int año;
            int mes;
            int dia;

            Console.Title = "Obtener la edad";

            Console.WriteLine("Ingresa tu nombre completo: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Fecha de nacimiento: ");
            Console.WriteLine("Dia: ");
            dia = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Mes: ");
            mes = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Año: ");
            año = Int32.Parse(Console.ReadLine());

            Console.Clear();

            if (mes <= 02)
            {
                Console.WriteLine(nombre + " tu edad es de: " + (2021 - año));
            }

            if (mes > 2)
            {
                Console.WriteLine(nombre + " tu edad es de: " + (2020 - año));
            }

            /*
            string nombre;
            int dia, mes, año;

            Console.WriteLine("Ingresa tu nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Dia de nacimiento: ");
            dia = int.Parse(Console.ReadLine());
            Console.WriteLine("Mes de nacimiento: ");
            mes = int.Parse(Console.ReadLine());
            Console.WriteLine("Año de nacimiento: ");
            año = int.Parse(Console.ReadLine());

            DateTime nacimiento = new DateTime(año, mes, dia);
            DateTime actual = new DateTime(2021, 02, 25);

            Console.WriteLine(actual - nacimiento);
            */
        }
    }
}
