using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBLL
{
    public class ExaCatalogoProducto
    {
        public static ProyectoENT.Result Add(ProyectoENT.ExaCatalogoProducto exaCatalogoProducto)
        {
            ProyectoENT.Result result = new ProyectoENT.Result();

            try
            {
                using (ProyectoDAL.AAcostaEnitmaEntities context = new ProyectoDAL.AAcostaEnitmaEntities())
                {
                    var query = context.sp_InsCatalogoProd(exaCatalogoProducto.Descripcion);

                    if (query >= 1)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct=false;
                        result.Message = "No se inserto el registro";
                    }
                }
            }catch (Exception ex)
            {
                result.Correct = false;
                result.Exception = ex;
            }
            return result;
        }

        public static ProyectoENT.Result GetAll()
        {
            ProyectoENT.Result result = new ProyectoENT.Result();

            try
            {
                using (ProyectoDAL.AAcostaEnitmaEntities context = new ProyectoDAL.AAcostaEnitmaEntities())
                {
                    var query = context.sp_GetAllCatalogoProd().ToList();

                    if (query != null)
                    {
                        result.Objects = new List<object>();
                        foreach (var obj in query)
                        {
                            ProyectoENT.ExaCatalogoProducto exaCatalogoProducto = new ProyectoENT.ExaCatalogoProducto();

                            exaCatalogoProducto.IdProducto = obj.IdProducto;
                            exaCatalogoProducto.Descripcion = obj.Descripción;
                            exaCatalogoProducto.IdUsuario = obj.IdUsuario.Value;
                            exaCatalogoProducto.FechaCreacion = obj.FechaCreacion.Value.ToString();

                            result.Objects.Add(exaCatalogoProducto);
                        }
                    }
                    result.Correct = true;
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.Exception = ex;
            }
            return result;
        }
    }
}