using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Funcionalidades
{
    // Funcionalidad 1: Obtener media
    public interface IMediaStrategy
    {
        double GetMedia(List<double> numbers);
    }

    // Funcionalidad 2: Escalera
    public interface IStaircaseStrategy
    {
        string GetStaircase(int n);
    }
}
