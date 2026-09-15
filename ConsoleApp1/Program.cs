using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    using System;

    class Program
    {
        static void Main()
        {
            int N;
            int cantidadCeros = 0;
            int cantidadVeintes = 0;
            int aprobados = 0;
            int desaprobados = 0;

            Console.Write("Ingrese el número de alumnos (máximo 10): ");
            N = int.Parse(Console.ReadLine());

            double[] notas = new double[N];

            // Ingresar las notas
            for (int i = 0; i < N; i++)
            {
                Console.Write("Ingrese la nota del alumno " + (i + 1) + ": ");
                notas[i] = double.Parse(Console.ReadLine());
            }

            // Analizar las notas
            for (int i = 0; i < N; i++)
            {
                if (notas[i] == 0)
                {
                    cantidadCeros++;
                }

                if (notas[i] == 20)
                {
                    cantidadVeintes++;
                }

                if (notas[i] >= 13)
                {
                    aprobados++;
                }
                else
                {
                    desaprobados++;
                }
            }

            // Mostrar resultados
            Console.WriteLine("\n--- RESULTADOS ---");
            Console.WriteLine("Cantidad de personas que obtuvieron 00: " + cantidadCeros);
            Console.WriteLine("Cantidad de personas que obtuvieron 20: " + cantidadVeintes);
            Console.WriteLine("Cantidad de personas aprobadas: " + aprobados);
            Console.WriteLine("Cantidad de personas desaprobadas: " + desaprobados);
        }
    }
}