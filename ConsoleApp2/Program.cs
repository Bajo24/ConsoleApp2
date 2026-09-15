using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
  
            static void Main()
            {
                int N;
                double suma = 0;
                double promedio;
                double maxima;
                double minima;

                Console.Write("Ingrese el número de alumnos: ");
                N = int.Parse(Console.ReadLine());

                double[] notas = new double[N];

                // Ingresar las notas
                for (int i = 0; i < N; i++)
                {
                    Console.Write("Ingrese la nota del alumno " + (i + 1) + ": ");
                    notas[i] = double.Parse(Console.ReadLine());

                    suma += notas[i];
                }

                // Inicializar máxima y mínima
                maxima = notas[0];
                minima = notas[0];

                // Buscar máxima y mínima
                for (int i = 1; i < N; i++)
                {
                    if (notas[i] > maxima)
                    {
                        maxima = notas[i];
                    }

                    if (notas[i] < minima)
                    {
                        minima = notas[i];
                    }
                }

                // Calcular promedio
                promedio = suma / N;

                // Mostrar resultados
                Console.WriteLine("\n--- RESULTADOS ---");
                Console.WriteLine("Promedio de notas: " + promedio);
                Console.WriteLine("Nota máxima: " + maxima);
                Console.WriteLine("Nota mínima: " + minima);
            }
        
    }   
}
