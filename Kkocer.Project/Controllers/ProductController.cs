using Kkkocer.Project.Business.Abstract;
using Kkocer.Project.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Kkocer.Project.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService productService;

        public ProductController(IProductService productService)
        {
                this.productService = productService;   
        }

        public ViewResult Index()
        {
            return View();
        }

        public ViewResult GetAll()
        {
            var result = productService.GetAll();

            return View(result);
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]  
        public ActionResult Add(Product product)
        {
            productService.Add(product);

            return RedirectToAction("GetAll");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var product = productService.GetById(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        [HttpPost]
        public ActionResult Update(Product product)
        {
            if (ModelState.IsValid)
            {
                productService.Update(product);
                return RedirectToAction("GetAll");
            }
            return View(product);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var product = productService.GetById(id);
            if (product == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                productService.Delete(product);
            }
            return RedirectToAction("GetAll");
        }
    }
}
