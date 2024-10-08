using IngematicaAppTest.Business;
using IngematicaAppTest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngematicaAppTest.Service
{
    public partial class TipoTrayectoService
    {
        public List<TipoTrayectoModel> GetList()
        {
            TipoTrayectoBusiness bs = new TipoTrayectoBusiness();

            return bs.GetList();
        }

        public TipoTrayectoModel GetById(int id)
        {
            TipoTrayectoBusiness bs = new TipoTrayectoBusiness();

            TipoTrayectoModel tipoTransporte = bs.GetById(id);

            return tipoTransporte;
        }
    }
}
