using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SL
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ExaCatalogoProducto" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ExaCatalogoProducto.svc or ExaCatalogoProducto.svc.cs at the Solution Explorer and start debugging.
    public class ExaCatalogoProducto : IExaCatalogoProducto
    {
        public ProyectoENT.Result Add(ProyectoENT.ExaCatalogoProducto exaCatalogoProducto)
        {
            ProyectoENT.Result result = ProyectoBLL.ExaCatalogoProducto.Add(exaCatalogoProducto);

            if (result.Correct)
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        public ProyectoENT.Result GetAll()
        {

            ProyectoENT.Result result = ProyectoBLL.ExaCatalogoProducto.GetAll();
            ProyectoENT.ExaCatalogoProducto exa = new ProyectoENT.ExaCatalogoProducto();
            if (result.Correct)
            {
                exa.Productos = result.Objects;
                return result;
            }
            else
            {
                return null;
            }
        }
    }
}