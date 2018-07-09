using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Session01.Domain.Contracts.Customers;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Session01.EndPoint.WebUI.Controllers
{
    public class CustomerController : Controller
    {
        private readonly IGetAllCustomerQuery getAllCustomerQuery;

        public CustomerController(IGetAllCustomerQuery getAllCustomerQuery)
        {
            this.getAllCustomerQuery = getAllCustomerQuery;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            var items = getAllCustomerQuery.Execute();
            return View(items);
        }
    }
}
