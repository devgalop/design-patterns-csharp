using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace devgalop.learn.abstract_factory.Domain.Jackets
{
    public class RichaJacket : IJacket
    {
        public string GetDescription()
        {
            return "Richa Jacket - High-quality leather, waterproof, and stylish.";
        }

        public string GetSize()
        {
            return "Large";
        }

        public bool IsAvailable()
        {
            return true;
        }
    }
}