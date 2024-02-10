using Prueba.Funcionalidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Aplicacion
{
    public class AplicacionService
    {
        private readonly IMediaStrategy mediaStrategy;
        private readonly IStaircaseStrategy staircaseStrategy;

        public AplicacionService(IMediaStrategy mediaStrategy, IStaircaseStrategy staircaseStrategy)
        {
            this.mediaStrategy = mediaStrategy;
            this.staircaseStrategy = staircaseStrategy;
        }

        public double ObtenerMedia(List<double> numbers) => mediaStrategy.GetMedia(numbers);

        public string ImprimirEscalera(int n) => staircaseStrategy.GetStaircase(n);
    }
}
