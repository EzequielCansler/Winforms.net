using IngematicaAppTest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngematicaAppTest.Business
{
    public partial class TipoTrayectoBusiness
    {
        public List<TipoTrayectoModel> GetList()
        {
            List<TipoTrayectoModel> lista = SetList();

            return lista;
        }

        public TipoTrayectoModel GetById(int id)
        {
            List<TipoTrayectoModel> lista = SetList();

            TipoTrayectoModel tipoTrayecto = lista.Where(x => x.IdTipoTrayecto == id).FirstOrDefault();

            return tipoTrayecto;
        }

        private static List<TipoTrayectoModel> SetList()
        {
            List<TipoTrayectoModel> lista = new List<TipoTrayectoModel>();

            lista.Add(new TipoTrayectoModel { IdTipoTrayecto = 1, Nombre = "RUTA" });
            lista.Add(new TipoTrayectoModel { IdTipoTrayecto = 2, Nombre = "AUTOPISTA" });       
            return lista;
        }
    }
}
