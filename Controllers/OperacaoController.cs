using System.Web.Mvc;

namespace Control_Manager.Controllers
{
    public class OperacaoController : Controller
    {
        // GET
        public ActionResult EntradaEstoque()
        {
            return View();
        }
        public ActionResult SaidaEstoque()
        {
            return View();
        }
        public ActionResult LancPerdaProduto()
        {
            return View();
        }
        public ActionResult Inventario()
        {
            return View();
        }
    }
}