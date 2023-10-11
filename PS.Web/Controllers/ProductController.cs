using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PS.Domain;
using PS.Service;

namespace PS.Web.Controllers
{
    public class ProductController : Controller
    {
        public IProductService ProductService { get; set; }
        public ICategoryService CategoryService { get; set; }

        public ProductController()
        {
            ProductService = new ProductService();
            CategoryService = new CategoryService();
        }




        // GET: ProductController
        public ActionResult Index(string filter)
        {
            IEnumerable<Product> products;
            if(filter == "")
                products = ProductService.GetAll();
            //else 
            //products = products.Where()
            products = ProductService.GetAll();
            return View(products);
        }

        // GET:     
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProductController/Create
        public ActionResult Create()
        {
            IEnumerable<Category>
                        //var categories = CategoryService.GetAll();
                        categories = new List<Category>() { new Category { CategoryId = 1, Name = "aa" } };
            ViewBag.CategoryId = new SelectList(categories, "CategoryId", "Name");
            return View();
            
        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection, IFormFile file)
        {
            try
            {
                Product p = new Product();
                if (file != null)
                {
                    p.ImageName = file.FileName;
                    var path = Path.Combine(Directory.GetCurrentDirectory(),
                    "wwwroot", "uploads", file.FileName);
                    using (System.IO.Stream stream = new FileStream(path,FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }
                }



                p.Name = collection["Name"];
                p.Description = collection["Description"];
                p.ImageName = collection["ImageName"];
                p.DateProd = Convert.ToDateTime(collection["DateProd"]);
                p.ProductId = Convert.ToInt32(collection["ProductId"]);
                p.Price = Convert.ToDouble(collection["Price"]);
                p.Quantity = Convert.ToInt32(collection["Quantity"]);
                p.CategoryId = Convert.ToInt32(collection["CategoryId"]);
                p.Category = ((CategoryService)CategoryService).CategoryRepository.GetById(collection["CategoryId"]);


                new ProductService().Add(new Product());

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
