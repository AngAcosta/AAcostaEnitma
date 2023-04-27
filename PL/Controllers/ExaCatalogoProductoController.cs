using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PL.Controllers
{
    public class ExaCatalogoProductoController : Controller
    {
        // GET: ExaCatalogoProducto
        [HttpGet]
        public ActionResult GetAll()
        {
            ProyectoENT.ExaCatalogoProducto exaCatalogoProducto = new ProyectoENT.ExaCatalogoProducto();
            ProductoServiceReference.ExaCatalogoProductoClient obj = new ProductoServiceReference.ExaCatalogoProductoClient();

            var result = obj.GetAll();

            if (result != null)
            {
                exaCatalogoProducto.Productos = result.Objects;
                return View(exaCatalogoProducto);
            }
            return View();
        }

        public ActionResult Form(ProyectoENT.ExaCatalogoProducto exaCatalogoProducto)
        {
            if (exaCatalogoProducto.IdProducto == 0)
            {
                ProductoServiceReference.ExaCatalogoProductoClient obj = new ProductoServiceReference.ExaCatalogoProductoClient();
                var result = obj.Add(exaCatalogoProducto);
                
                if(result.Correct)
                {
                    ViewBag.Message = "Se Inserto el Resgistro";
                }
                else
                {
                    ViewBag.Message = "No se Inserto el Registro";
                }
            }
            return View("Modal");
        }
    }
}