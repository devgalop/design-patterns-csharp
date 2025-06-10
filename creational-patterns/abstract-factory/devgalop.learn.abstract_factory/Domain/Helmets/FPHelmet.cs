using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace devgalop.learn.abstract_factory.Domain.Helmets
{
    public class FPHelmet : IHelmet
    {
        public string GetCertification()
        {
            return "ECE";
        }

        public string GetDescription()
        {
            return "FP Helmet - ECE Certified, Sport, and Comfortable.";
        }

        public bool IsAvailable()
        {
            return false;
        }
    }
}