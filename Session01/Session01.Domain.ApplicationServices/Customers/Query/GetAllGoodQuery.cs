using Session01.Domain.Contracts.Goods;
using Session01.Domain.Entities.Goods;
using System;
using System.Collections.Generic;
using System.Text;

namespace Session01.Domain.ApplicationServices.Customers.Query
{
    public class GetAllGoodQuery : IGetAllGoodQuery
    {
        private readonly IGoodRepository _repo;

        public GetAllGoodQuery(IGoodRepository repo)
        {
            _repo = repo;
        }
        public List<Good> Execute()
        {
            return _repo.Goods();
        }
    }
}
