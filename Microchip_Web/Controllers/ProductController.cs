using Microchip_Web.Helpers;
using Microchip_Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace Microchip_Web.Controllers
{
    public class ProductController : Controller
    {
        private MicrochipHttpClient client = new MicrochipHttpClient();

        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetProducts(DataTable datatableRequest)
        {
            DataTableResult<Product> resp = client.Get<DataTableResult<Product>>("products/Pages/1/10");
            return new JsonResult() { Data = resp, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }
    }
}