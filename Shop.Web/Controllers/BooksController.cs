using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shop.Web.Controllers
{
    public class BooksController : ShopControllerBase
    {
        [HttpGet]
        public ActionResult GetAll()
        {
            return View();
        }
    }
}