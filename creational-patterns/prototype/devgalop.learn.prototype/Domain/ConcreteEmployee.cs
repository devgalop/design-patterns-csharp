using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace devgalop.learn.prototype.Domain
{
    public class ConcreteEmployee : IEmployeePrototype
    {
        private readonly string _role;

        public ConcreteEmployee(string role)
        {
            _role = role;
        }

        public IEmployeePrototype Clone()
        {
            return (ConcreteEmployee) this.MemberwiseClone();
        }

        public string GetRole()
        {
            Console.WriteLine("Retorna rol del empleado");
            return _role;
        }
    }
}