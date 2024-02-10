using Prueba.Funcionalidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Agentes
{
    // Agente A: Media Aritmética
    public class AAgenteMediaAritmetica : IMediaStrategy
    {
        public double GetMedia(List<double> numbers) => numbers.Average();
    }

    // Agente B: Media Armónica
    public class BAgenteMediaArmonica : IMediaStrategy
    {
        public double GetMedia(List<double> numbers)
        {
            if (numbers.Count == 0)
                throw new ArgumentException("La lista de números no puede estar vacía.");

            double sum = 0;
            foreach (var num in numbers)
            {
                if (num == 0)
                    throw new ArgumentException("No se puede calcular la media armónica con cero en la lista.");

                sum += 1 / num;
            }

            return numbers.Count / sum;
        }
    }

    // Agente C: Mediana
    public class CAagenteMediana : IMediaStrategy
    {
        public double GetMedia(List<double> numbers)
        {
            if (numbers.Count == 0)
                throw new ArgumentException("La lista de números no puede estar vacía.");

            numbers.Sort();

            int middle = numbers.Count / 2;

            if (numbers.Count % 2 == 0)
            {
                // La cantidad de datos es par, calcular el promedio de los dos valores centrales.
                double median = (numbers[middle - 1] + numbers[middle]) / 2.0;
                return median;
            }
            else
            {
                // La cantidad de datos es impar, devolver el valor central.
                return numbers[middle];
            }
        }
    }

    // Agente A: Escalera Derecha
    public class AAgenteEscaleraDerecha : IStaircaseStrategy
    {
        public string GetStaircase(int n)
        {
            if (n <= 0 || n >= 100)
            {
                throw new ArgumentException("El tamaño de la escalera debe estar en el rango 0 < n < 100.");
            }

            StringBuilder staircase = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                string spaces = new string(' ', n - i - 1);
                string hashes = new string('#', i + 1);

                staircase.AppendLine(spaces + hashes);
            }

            return staircase.ToString();
        }
    }

    // Agente B: Escalera Cima
    public class BAgenteEscaleraCima : IStaircaseStrategy
    {
        public string GetStaircase(int n)
        {
            if (n <= 0 || n >= 100)
            {
                throw new ArgumentException("El tamaño de la escalera debe estar en el rango 0 < n < 100.");
            }

            StringBuilder staircase = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                string spaces = new string(' ', i);
                string hashes = new string('#', n - i);

                staircase.AppendLine(spaces + hashes);
            }

            return staircase.ToString();
        }
    }

    // Agente C: Escalera Centro
    public class CAgenteEscaleraCentro : IStaircaseStrategy
    {
        public string GetStaircase(int n)
        {
            if (n <= 0 || n >= 100)
            {
                throw new ArgumentException("El tamaño de la escalera debe estar en el rango 0 < n < 100.");
            }

            StringBuilder staircase = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                string spaces = new string(' ', (n - (1 + i)));
                string hashes = new string('#', n + (2 * i));
                string line = spaces + hashes;
               
                staircase.AppendLine(line);

            }
            for (int i = n - 1; i > 0; i--)
            {
                string spaces = new string(' ', (n - i));
                string hashes = new string('#', (i + 1) * 2);
                string line = spaces + hashes;

                staircase.AppendLine(line);
            }

            return staircase.ToString();
        }     

    }
}
