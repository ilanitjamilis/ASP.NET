using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC1.Models;
using MVC1.Models.DataAccess;

namespace MVC1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Registracion(Usuario unUsuario)
        {
            if (ModelState.IsValid)
            {
                bool usuarioGuardado = Usuarios.GuardarUsuario(unUsuario);
                if (usuarioGuardado)
                {
                    return View("InfoUsuario", unUsuario);
                }
                else
                {
                    ViewBag.ErrorLogueo = "Error en la registracion";
                    return View("Registracion");
                }
            }
            else
            {
                ViewBag.Titulo = "Intente nuevamente";
                return View("Registracion", unUsuario);
            }
        }

        public ActionResult LoguearUsuario(Usuario unUsuario)
        {
            if (ModelState.IsValidField("usuario") && ModelState.IsValidField("contraseña"))
            {
                Usuario miUsuario = Usuarios.ObtenerUsuario(unUsuario);
                if (miUsuario.nombre!=null)
                {
                    return View("InfoUsuario", miUsuario);
                }
                else
                {
                    ViewBag.ErrorLogeo = "Usuario o contraseña incorrectas";
                    return View("Index");
                }
            }
            else
            {
                ViewBag.Titulo = "Intente nuevamente";
                return View("Index", unUsuario);
            }
        }
    }
}