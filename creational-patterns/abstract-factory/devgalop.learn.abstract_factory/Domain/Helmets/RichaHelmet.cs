using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace devgalop.learn.abstract_factory.Domain.Helmets
{
    public class RichaHelmet : IHelmet
    {
        public string GetCertification()
        {
            return "ECE";
        }

        public string GetDescription()
        {
            return "Richa Helmet - ECE Certified, Lightweight, and Comfortable.";
        }

        public bool IsAvailable()
        {
            return true;
        }
    }
}