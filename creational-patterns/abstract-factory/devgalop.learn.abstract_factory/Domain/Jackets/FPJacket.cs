using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace devgalop.learn.abstract_factory.Domain.Jackets
{
    public class FPJacket : IJacket
    {
        public string GetDescription()
        {
            return "FP Jacket - waterproof 100%";
        }

        public string GetSize()
        {
            return "Medium";
        }

        public bool IsAvailable()
        {
            return true;
        }
    }
}