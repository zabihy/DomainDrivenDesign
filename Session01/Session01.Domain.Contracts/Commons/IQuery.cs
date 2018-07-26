using System;
using System.Collections.Generic;
using System.Text;

namespace Session01.Domain.Contracts.Commons
{
    public interface IQuery<T> where T:class
    {
        List<T> Execute();
    }
}
