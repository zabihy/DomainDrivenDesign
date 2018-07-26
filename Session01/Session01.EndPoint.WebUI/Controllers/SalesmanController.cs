using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Session01.Domain.Contracts.Customers;
using Session01.Domain.Contracts.Salesmans;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Session01.EndPoint.WebUI.Controllers
{
    public class SalesmanController : Controller
    {
        private readonly IGetAllSalesmanQuery _query;

        public SalesmanController(IGetAllSalesmanQuery query)
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
