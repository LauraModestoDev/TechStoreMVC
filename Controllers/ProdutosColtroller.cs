using Microsoft.AspNetCore.Mvc;
using TechStoreMVC.Models;

namespace TechStoreMVC.Controllers
{
    public class ProdutosColtroller : Controller
    {
        // GET: ProdutosColtroller
        public ActionResult Index()
        {
        List<Produto> produtos = new List<Produto>
        {
            
            new Produto(1, " Mousse Gamer", 129.9m, 10),
             new Produto(2, "Teclado mecanico", 249.9m, 5),
              new Produto(3, " Monitor 24 polegadas", 899.9m, 8),
               new Produto(4, " Headset Gamer", 179.9m, 15),
        };
    return View();
    }
  }
}