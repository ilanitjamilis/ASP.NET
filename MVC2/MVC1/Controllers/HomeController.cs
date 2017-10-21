using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC1.Models;
using MVC1.Models.DataAccess;
using System.Web.UI;
using System.IO;

namespace MVC1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult InfoUsuario()
        {
            return View();
        }
        public ActionResult AgregarNovix()
        {
            return View();
        }

        public ActionResult Registracion(Usuario unUsuario)
        {
            if (ModelState.IsValid)
            {
                string usuario = unUsuario.usuario;

                bool usuarioDisponible = Usuarios.VerificarUsuario(usuario);

                if (usuarioDisponible)
                {
                    if(unUsuario.mail==null)
                    {
                        unUsuario.mail = "-";
                    }
                    
                    bool usuarioGuardado = Usuarios.GuardarUsuario(unUsuario);
                    if (usuarioGuardado)
                    {
                        return View("Index");
                    }
                    else
                    {
                        ViewBag.ErrorLogueo = "Error en la registracion";
                        return View("Registracion");
                    }
                }
                else
                {
                    ViewBag.Titulo = "Usuario no disponible";
                    return View("Registracion", unUsuario);
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
                    ViewBag.ListaNovix = Usuarios.TraerNovixs(unUsuario);
                    ViewBag.Tituliyo = "Información del usuario";
                    return View("InfoUsuario", miUsuario);
                }
                else
                {
                    ViewBag.ErrorLogueo = "Usuario o contraseña incorrectas";
                    return View("Index", unUsuario);
                }
            }
            else
            {
                ViewBag.ErrorLogueo = "Usuario o contraseña incorrectas";
                return View("Index", unUsuario);
            }
        }

        public ActionResult GuardarNovix (Novix unNovix, HttpPostedFileBase file)
        {
            if (file != null)
            {
                if (file.ContentLength > 0)
                {
                    var fileName = Path.GetFileName(file.FileName);
                    var path = Path.Combine(Server.MapPath("~/Content/Imagenes/"), fileName);

                    file.SaveAs(path);

                    unNovix.rutaFoto = "/Content/Imagenes/" + fileName;

                    bool novixGuardado = Novixs.AgregarNovix(unNovix);

                    Usuario miUsuario = Usuarios.ObtenerMiUsuario();

                    if (novixGuardado)
                    {
                        ViewBag.ListaNovix = Usuarios.TraerNovixs(miUsuario);
                        return View("InfoUsuario", miUsuario);
                    }
                    else
                    {
                        ViewBag.ErrorLogueo = "Error en la registracion";
                        return View("AgregarNovix");
                    }
                }
                else
                {
                    ViewBag.ErrorLogueo = "Verifique datos";
                    return View("AgregarNovix");
                }
            }
            ViewBag.ErrorLogueo = "Verifique datos";
            return View("AgregarNovix");
        }
    }
}