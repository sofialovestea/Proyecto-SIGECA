using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FrontEnd.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }




   public class SharedController : Controller
    {
    
        public ActionResult Calendario ()
        {

            return View();
        }

     

        public ActionResult AgendaHorario()
        {
          return View();
        }

        public ActionResult AgendarCita()
        {
            return View();
        }
        public ActionResult CitaNueva()
        {
            return View();
        }
        public ActionResult Seguimiento()
        {
            return View();
        }

      
        public ActionResult ActivarInactivarExpediente()
        {
            return View();
        }
        public ActionResult ConsultarExpediente()
        {
            return View();
        }
        public ActionResult CrearExpediente()
        {
            return View();
        }
        public ActionResult EditarExpediente()
        {
            return View();
        }

        public ActionResult Expedientes()
        {
            return View();
        }
        
        public ActionResult MenuPsicologa()
        {
            return View();
        }

        public ActionResult EditarCita()
        {
            return View();
        }







    }

}