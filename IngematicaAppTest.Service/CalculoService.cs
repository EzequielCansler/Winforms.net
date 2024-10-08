using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IngematicaAppTest.Model;
using IngematicaAppTest.Business;


namespace IngematicaAppTest.Service
{
    public partial class CalculoService
    {
        private readonly CalculoBusiness _calculoBusiness;

        public CalculoService(CalculoBusiness calculoBusiness)
        {
            _calculoBusiness = calculoBusiness;
        }

        public ResultadoModel Calcular(DateTime fechaInicial, int localidadId, int tipoTransporteId, int tipoTrayectoId)
        {
            return _calculoBusiness.Calcular(fechaInicial, localidadId, tipoTransporteId, tipoTrayectoId);
        }

      
    }
}
