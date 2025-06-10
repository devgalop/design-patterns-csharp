using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace devgalop.learn.abstract_factory.Domain
{
    public interface IProduct
    {
        bool IsAvailable();
        string GetDescription();
    }
}