using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Session01.Domain.Contracts.Customers;
using Session01.Domain.Contracts.Goods;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Session01.EndPoint.WebUI.Controllers
{
    public class GoodController : Controller
    {
        private readonly IGetAllGoodQuery _query;

        public GoodController(IGetAllGoodQuery query)
        {
            this._query = query;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            var items = _query.Execute();
            return View(items);
        }
    }
}
