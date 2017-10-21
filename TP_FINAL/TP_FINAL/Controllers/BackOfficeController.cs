using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.OleDb;
using TP_FINAL.Models;
using System.IO;

namespace TP_FINAL.Controllers
{
    public class BackOfficeController : Controller
    {
        // GET: BackOffice

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ABMSucursales()
        {
            return View();
        }

        public ActionResult ABMMenu()
        {
            return View();
        }

        public ActionResult ABMTODO()
        {
            return View();
        }

        public ActionResult ModerarComentarios()
        {
            return View();
        }

        public ActionResult AgregarNuevaComida()
        {
            return View();
        }

        public ActionResult BuscarParaNuevaComida()
        {
            List<TiposComida> lista = new List<TiposComida>();
            lista = TiposComida.CargarTiposComida();
            ViewBag.listaTiposComidas = lista;
            ViewBag.Accion = "GuardarNuevaComida";
            return View("AgregarNuevaComida");
        }

        public ActionResult BuscarParaNuevaSucursal()
        {
            List<Provincias> lista = new List<Provincias>();
            lista = Provincias.CargarProvincias();
            ViewBag.listaProvincias = lista;
            ViewBag.Accion = "GuardarNuevaSucursal";
            return View("AgregarNuevaSucursal");
        }

        public ActionResult CargarPlatos()
        {
            List<Plato> miListaPlatos = new List<Plato>();
            miListaPlatos = Plato.TraerPlatos();
            ViewBag.listaPlatos = miListaPlatos;
            return View("ABMMenu");
        }

        public ActionResult VerDatosPlato(int platoID)
        {
            Plato miPlato= new Plato();
            miPlato = Plato.TraerPlato(platoID);
            return View("VerPlato", miPlato);
        }

        public ActionResult VerDatosSucursal(int sucursalID)
        {
            Sucursal miSucursal = new Sucursal();
            miSucursal = Sucursal.TraerSucursal(sucursalID);
            ViewBag.back = "si";
            return View("VerSucursal", miSucursal);
        }

        public ActionResult TraerInfoParaSucursales()
        {
            List<Sucursal> miLista = new List<Sucursal>();
            miLista = Sucursal.TraerSucursales();
            ViewBag.misSucursales = miLista;
            return View("ABMSucursales");
        }

        public ActionResult TraerInfoParaModerarSuc()
        {
            List<Comentario> miLista = new List<Comentario>();
            miLista = Comentario.TraerComentariosNoAprobados();
            ViewBag.misComentarios = miLista;
            return View("ModerarComentarios");
        }

        public ActionResult ParaModificar(int platoID)
        {
            Plato miPlato = new Plato();
            miPlato = Plato.TraerPlato(platoID);
            Plato.idStatic = miPlato.ID;
            ViewBag.Accion = "ModificarComidaExistente";
            List<TiposComida> lista = new List<TiposComida>();
            lista = TiposComida.CargarTiposComida();
            ViewBag.listaTiposComidas = lista;
            return View("AgregarNuevaComida", miPlato);
        }

        public ActionResult ParaModificarSucursal(int sucursalID)
        {
            Sucursal miSucursal = new Sucursal();
            miSucursal = Sucursal.TraerSucursal(sucursalID);
            Sucursal.idStatic = miSucursal.ID;
            ViewBag.Accion = "ModificarSucursalExistente";
            List<Provincias> lista = new List<Provincias>();
            lista = Provincias.CargarProvincias();
            ViewBag.listaProvincias = lista;
            return View("AgregarNuevaSucursal", miSucursal);
        }

        public ActionResult EliminarPlato(int platoID)
        {
            bool platoEliminado = Plato.EliminarPlato(platoID);
            List<Plato> miListaPlatos = new List<Plato>();
            miListaPlatos = Plato.TraerPlatos();
            ViewBag.listaPlatos = miListaPlatos;
            return View("ABMMenu");
        }

        public ActionResult EliminarSucursal(int sucursalID)
        {
            bool comentariosSucursalEliminados = Sucursal.EliminarComentariosSucursal(sucursalID);
            bool sucursalEliminada = Sucursal.EliminarSucursal(sucursalID);
            List<Sucursal> miListaSucursales = new List<Sucursal>();
            miListaSucursales = Sucursal.TraerSucursales();
            ViewBag.misSucursales = miListaSucursales;
            return View("ABMSucursales");
        }

        [HttpPost]
        public ActionResult ModificarComidaExistente(Plato unPlato, HttpPostedFileBase file)
        {
            List<TiposComida> lista = new List<TiposComida>();
            bool platoActualizado;
            if (file != null)
            {
                if (file.ContentLength > 0)
                {
                    var fileName = Path.GetFileName(file.FileName);
                    var path = Path.Combine(Server.MapPath("~/Content/Imagenes/"), fileName);
                    
                    file.SaveAs(path);

                    unPlato.rutaFoto = "/Content/Imagenes/" + fileName;

                    platoActualizado = Plato.ActualizarPlato(unPlato);

                    if (platoActualizado)
                    {
                        Plato miPlatoCompleto = Plato.TraerPlato(Plato.idStatic);
                        return View("VerPlato", miPlatoCompleto);
                    }
                    else
                    {
                        ViewBag.ErrorLogueo = "Error en el proceso";
                    
                        lista = TiposComida.CargarTiposComida();
                        ViewBag.listaTiposComidas = lista;
                        return View("AgregarNuevaComida");
                    }
                }
                else
                {
                    ViewBag.ErrorLogueo = "Error en el proceso";
                    
                    lista = TiposComida.CargarTiposComida();
                    ViewBag.listaTiposComidas = lista;

                    return View("AgregarNuevaComida");
                }
            }
            platoActualizado = Plato.ActualizarPlatoNoFoto(unPlato);

            if (platoActualizado)
            {
                Plato miPlatoCompleto = Plato.TraerPlato(Plato.idStatic);
                return View("VerPlato", miPlatoCompleto);
            }
            else
            {
                ViewBag.ErrorLogueo = "Error en el proceso";

                lista = TiposComida.CargarTiposComida();
                ViewBag.listaTiposComidas = lista;
                return View("AgregarNuevaComida");
            }
        }

        [HttpPost]
        public ActionResult ModificarSucursalExistente(Sucursal unaSucursal, HttpPostedFileBase file)
        {
            List<Provincias> lista = new List<Provincias>();
            bool sucursalActualizada;
            if (file != null)
            {
                if (file.ContentLength > 0)
                {
                    var fileName = Path.GetFileName(file.FileName);
                    var path = Path.Combine(Server.MapPath("~/Content/Imagenes/"), fileName);

                    file.SaveAs(path);

                    unaSucursal.rutaFoto = "/Content/Imagenes/" + fileName;

                    sucursalActualizada = Sucursal.ActualizarSucursal(unaSucursal);

                    if (sucursalActualizada)
                    {
                        Sucursal miSucursalCompleta = Sucursal.TraerSucursal(Sucursal.idStatic);
                        return View("VerSucursal", miSucursalCompleta);
                    }
                    else
                    {
                        ViewBag.ErrorLogueo = "Error en el proceso";

                        lista = Provincias.CargarProvincias();
                        ViewBag.listaProvincias = lista;
                        return View("AgregarNuevaSucursal");
                    }
                }
                else
                {
                    ViewBag.ErrorLogueo = "Error en el proceso";

                    lista = Provincias.CargarProvincias();
                    ViewBag.listaProvincias = lista;
                    return View("AgregarNuevaSucursal");
                }
            }
            sucursalActualizada = Sucursal.ActualizarSucursalNoFoto(unaSucursal);

            if (sucursalActualizada)
            {
                Sucursal miSucursalCompleta = Sucursal.TraerSucursal(Sucursal.idStatic);
                return View("VerSucursal", miSucursalCompleta);
            }
            else
            {
                ViewBag.ErrorLogueo = "Error en el proceso";

                lista = Provincias.CargarProvincias();
                ViewBag.listaProvincias = lista;
                return View("AgregarNuevaSucursal");
            }
        }


        [HttpPost]
        public ActionResult GuardarNuevaComida(Plato unPlato, HttpPostedFileBase file)
        {
            if (file != null)
            {
                if (file.ContentLength > 0)
                {
                    var fileName = Path.GetFileName(file.FileName);
                    var path = Path.Combine(Server.MapPath("~/Content/Imagenes/"), fileName);

                    file.SaveAs(path);

                    unPlato.rutaFoto = "/Content/Imagenes/" + fileName;

                    bool platoGuardado = Plato.GuardarNuevaComida(unPlato);

                    if (platoGuardado)
                    {
                        Plato miPlatoCompleto = Plato.TraerPlato2(unPlato.nombre);
                        return View("VerPlato", miPlatoCompleto);
                    }
                    else
                    {
                        ViewBag.ErrorLogueo = "Error en el proceso";
                        return View("AgregarNuevaComida");
                    }
                }
                else
                {
                    ViewBag.ErrorLogueo = "Error en el proceso";
                    return View("AgregarNuevaComida");
                }
            }
            ViewBag.ErrorLogueo = "Error en el proceso";
            return View("AgregarNuevaComida");
        }


        [HttpPost]
        public ActionResult GuardarNuevaSucursal(Sucursal unaSucursal, HttpPostedFileBase file)
        {
            if (file != null)
            {
                if (file.ContentLength > 0)
                {
                    var fileName = Path.GetFileName(file.FileName);
                    var path = Path.Combine(Server.MapPath("~/Content/Imagenes/"), fileName);

                    file.SaveAs(path);

                    unaSucursal.rutaFoto = "/Content/Imagenes/" + fileName;

                    bool sucursalGuardada = Sucursal.GuardarNuevaSucursal(unaSucursal);

                    if (sucursalGuardada)
                    {
                        Sucursal miSucursalCompleta = Sucursal.TraerSucursal2(unaSucursal.nombre);
                        return View("VerSucursal", miSucursalCompleta);
                    }
                    else
                    {
                        ViewBag.ErrorLogueo = "Error en el proceso";
                        return View("AgregarNuevaSucursal");
                    }
                }
                else
                {
                    ViewBag.ErrorLogueo = "Error en el proceso";
                    return View("AgregarNuevaSucursal");
                }
            }
            ViewBag.ErrorLogueo = "Error en el proceso";
            return View("AgregarNuevaSucursal");
        }

        public ActionResult AceptarComentario(int comentarioID)
        {
            bool funciono = Comentario.AprobarComentario(comentarioID);
            List<Comentario> miLista = new List<Comentario>();
            miLista = Comentario.TraerComentariosNoAprobados();
            ViewBag.misComentarios = miLista;
            return View("ModerarComentarios");
        }

        public ActionResult EliminarComentario(int comentarioID)
        {
            bool funciono = Comentario.EliminarComentario(comentarioID);
            List<Comentario> miLista = new List<Comentario>();
            miLista = Comentario.TraerComentariosNoAprobados();
            ViewBag.misComentarios = miLista;
            return View("ModerarComentarios");
        }
    }
}