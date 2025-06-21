using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace devgalop.learn.prototype.Domain
{
    public interface IEmployeePrototype
    {
        IEmployeePrototype Clone();
        string GetRole();
    }
}