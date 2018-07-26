using Session01.Domain.Contracts.Salesmans;
using Session01.Domain.Entities.Salesmans;
using System;
using System.Collections.Generic;
using System.Text;

namespace Session01.Domain.ApplicationServices.Customers.Query
{
    public class GetAllSalesmanQuery : IGetAllSalesmanQuery
    {
        private readonly ISalesmanRepository _repo;

        public GetAllSalesmanQuery(ISalesmanRepository repo)
        {
            _repo = repo;
        }
        public List<Salesman> Execute()
        {
            return _repo.Salesmen();
        }
    }
}
