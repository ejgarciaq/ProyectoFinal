using PF.DB.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace PF.UI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string message = "")
        {
            ViewBag.Message = message;
            return View();
        }
        [Authorize]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}

        [HttpPost]
        // Login a la aplicación
        public ActionResult Login(String Correo, string Contrasenna) 
        {
            // Validar Login por cedula Vasia
            if (!string.IsNullOrEmpty(Correo) && !string.IsNullOrEmpty(Contrasenna))
            {
                //Conexion a base de datos
                PF_IS39Entities ContextoBD = new PF_IS39Entities();
                var u = ContextoBD.Usuarios.FirstOrDefault(e => e.Correo == Correo && e.Contrasenna == Contrasenna);
                //Usuario diferente a null
                if (u != null)
                {
                    // Encontramos un usuario con los datos
                    FormsAuthentication.SetAuthCookie(u.Correo, true);
                    return RedirectToAction("About", "Home");
                }
                else 
                {
                    return RedirectToAction("Index", new { message = "no encontramos los datos"});
                }
            }
            else
            {
                return RedirectToAction("Index", new { message = "Llena los campos para iniciar" });
            }

        }
        // cerrar sesión
        public ActionResult Logout() 
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}