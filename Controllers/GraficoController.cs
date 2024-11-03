using System.Web.Mvc;

namespace Control_Manager.Controllers
{
    public class GraficoController : Controller
    {
        // GET
        public ActionResult PerdaMes()
        {
            return View();
        }
        public ActionResult EntradasSaidaMes()
        {
            return View();
        }
    }
}