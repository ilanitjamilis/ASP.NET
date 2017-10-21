using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.OleDb;
using TP_FINAL.Models;

namespace TP_FINAL.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Comentario> miListaComentarios = new List<Comentario>();
            miListaComentarios = Comentario.Traer5Comentarios();
            ViewBag.listaComentarios = miListaComentarios;
            return View();
        }

        public ActionResult Sucursales()
        {
            return View();
        }

        public ActionResult Menu()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
        public ActionResult ABMTODO()
        {
            return View();
        }

        public ActionResult ParaIngresarComentario(int idSucursal)
        {
            Comentario.idSucursalStatic= idSucursal;
            return View("IngresarComentario");
        }

        public ActionResult InsertarComentario(Comentario unComentario)
        {
            if (unComentario.calificacion != 0)
            {
                Comentario miComentario = new Comentario();
                miComentario = unComentario;
                miComentario.aprobado = false;
                bool funciono = Comentario.InsertarComentario(miComentario);
                if (funciono)
                {
                    ViewBag.Mensaje = "Comentario enviado con éxito";
                    return View("IngresarComentario");
                }
                else
                {
                    ViewBag.Mensaje = "Error en el proceso";
                    return View("IngresarComentario");
                }
            }
            else
            {
                ViewBag.Mensaje = "Error en el proceso";
                return View("IngresarComentario");
            }
        }


        [HttpPost]
        public ActionResult Login(Usuario unUsuario)
        {
            if (ModelState.IsValidField("usuario") && ModelState.IsValidField("contraseña"))
            {
                Usuario miUsuario = Usuario.ObtenerUsuario(unUsuario);
                if (miUsuario.mail != null)
                {
                    Usuario.ActualizarLogin();
                    ViewBag.Bienvenida = "Bienvenido al BackOffice " + miUsuario.usuario + "!";
                    //return RedirectToAction("AMBTODO", "BackOffice", new {miUsuario});
                    return View("ABMTODO", miUsuario);
                }
                else
                {
                    ViewBag.ErrorLogueo = "Usuario o contraseña incorrectas";
                    return View(unUsuario);
                }
            }
            else
            {
                ViewBag.ErrorLogueo = "Usuario o contraseña incorrectas";
                return View (unUsuario);
                
            }
        }


        public ActionResult CargarPlatos()
        {
            List<Plato> miListaPlatos = new List<Plato>();
            miListaPlatos = Plato.TraerPlatosParaVista();
            ViewBag.listaPlatos = miListaPlatos;
            return View("Menu");
        }

        public ActionResult CargarSucursales()
        {
            List<Sucursal> miListaSucursales = new List<Sucursal>();
            miListaSucursales = Sucursal.TraerSucursales();
            ViewBag.listaSucursales = miListaSucursales;
            return View("Sucursales");
        }

        public ActionResult MasInfoLocal(int sucursalID)
        {
            Sucursal miSucursal = new Sucursal();
            miSucursal = Sucursal.TraerSucursal(sucursalID);
            List<Comentario> miListaComentarios = new List<Comentario>();
            miListaComentarios = Comentario.Traer3Comentarios(sucursalID);
            ViewBag.listaComentarios = miListaComentarios;
            return View("VerSucursal1", miSucursal);
        }


    }
}