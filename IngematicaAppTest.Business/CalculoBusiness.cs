using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IngematicaAppTest.Model;

namespace IngematicaAppTest.Business
{
    public partial class CalculoBusiness
    {
        private readonly LocalidadBusiness _localidadBusiness;
        private readonly TipoTransporteBusiness _transporteBusiness;
        private readonly TipoTrayectoBusiness _trayectoBusiness;

        public CalculoBusiness(LocalidadBusiness localidadBusiness, TipoTransporteBusiness transporteBusiness, TipoTrayectoBusiness trayectoBusiness)
        {
            _localidadBusiness = localidadBusiness;
            _transporteBusiness = transporteBusiness;
            _trayectoBusiness = trayectoBusiness;
        }

        public ResultadoModel Calcular(DateTime fechaInicial, int localidadId, int tipoTransporteId, int tipoTrayectoId)
        {
            LocalidadModel localidad = _localidadBusiness.GetById(localidadId);
            TipoTransporteModel tipoTransporte = _transporteBusiness.GetById(tipoTransporteId);
            TipoTrayectoModel tipoTrayecto = _trayectoBusiness.GetById(tipoTrayectoId);
            DateTime fechaFinal = fechaInicial;

            // Redondeo el valor total, si el trayecto es RUTA ademas del CoeficienteDemora se le suma el 10%
            int diasDemora = (int)Math.Ceiling(tipoTrayecto.Nombre == "RUTA"
                ? localidad.DiasDemora * tipoTransporte.CoeficineteDemora * 1.1m
                : localidad.DiasDemora * tipoTransporte.CoeficineteDemora);


            for (int i = 0; i < diasDemora; i++) {

                fechaFinal = fechaFinal.AddDays(1);

                // Si es sabado o domingo no contar ese dia
                while (fechaFinal.DayOfWeek == DayOfWeek.Saturday || fechaFinal.DayOfWeek == DayOfWeek.Sunday)
                {
                    fechaFinal = fechaFinal.AddDays(1);
                }

            }
            // retorno la clase con los dos valores pedidos
            return new ResultadoModel
            {
                DiasDemora = diasDemora,
                FechaLlegada = fechaFinal
            };
        }


    }
}
