// See https://aka.ms/new-console-template for more information
using Prueba.Agentes;
using Prueba.Funcionalidades;

class Program
{
    static void Main()
    {
        // Obtener datos del usuario para la funcionalidad de obtener media
        Console.WriteLine("Ingrese números separados por espacios para calcular la media:");
        string inputMedia = Console.ReadLine();

        List<double> numerosMedia = ParseInput(inputMedia);

        IMediaStrategy agenteMedia = SelectMediaAgent(); // Puedes cambiar el agente según tus necesidades
        double media = agenteMedia.GetMedia(numerosMedia);
        Console.WriteLine($"Media: {media}");

        // Obtener datos del usuario para la funcionalidad de escalera
        Console.WriteLine("\nIngrese un número para el tamaño de la escalera:");
        string inputEscalera = Console.ReadLine();

        int nEscalera = ParseInputInt(inputEscalera);

        IStaircaseStrategy agenteEscalera = SelectStaircaseAgent(); // Puedes cambiar el agente según tus necesidades
        string escalera = agenteEscalera.GetStaircase(nEscalera);
        Console.WriteLine("\nEscalera:\n" + escalera);

        Console.ReadLine();
    }

    static List<double> ParseInput(string input)
    {
        string[] numerosString = input.Split(' ');
        List<double> numeros = new List<double>();

        foreach (string numStr in numerosString)
        {
            if (double.TryParse(numStr, out double num))
            {
                numeros.Add(num);
            }
            else
            {
                Console.WriteLine($"Entrada no válida: {numStr}");
            }
        }

        return numeros;
    }

    static int ParseInputInt(string input)
    {
        if (int.TryParse(input, out int result))
        {
            return result;
        }
        else
        {
            Console.WriteLine($"Entrada no válida: {input}. Se utilizará el valor predeterminado.");
            return 0;
        }
    }

    static IMediaStrategy SelectMediaAgent()
    {
        Console.WriteLine("\nSeleccione el agente para calcular la media:");
        Console.WriteLine(" A - Media Aritmética");
        Console.WriteLine(" B - Media Armónica");
        Console.WriteLine(" C - Mediana");

        string input = Console.ReadLine();

        switch (input.ToUpper())
        {
            case "A":
                return new AAgenteMediaAritmetica();
            case "B":
                return new BAgenteMediaArmonica();
            case "C":
                return new CAagenteMediana();
            default:
                Console.WriteLine("Opción no válida. Se utilizará el agente A.");
                return new AAgenteMediaAritmetica();
        }
    }

    static IStaircaseStrategy SelectStaircaseAgent()
    {
        Console.WriteLine("\nSeleccione el agente para construir la escalera:");
        Console.WriteLine(" A - Escalera Derecha");
        Console.WriteLine(" B - Escalera Cima");
        Console.WriteLine(" C - Escalera Centro");

        string input = Console.ReadLine();

        switch (input.ToUpper())
        {
            case "A":
                return new AAgenteEscaleraDerecha();
            case "B":
                return new BAgenteEscaleraCima();
            case "C":
                return new CAgenteEscaleraCentro();
            default:
                Console.WriteLine("Opción no válida. Se utilizará el agente A.");
                return new AAgenteEscaleraDerecha();
        }
    }
}

