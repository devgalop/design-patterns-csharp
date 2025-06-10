using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using devgalop.learn.abstract_factory.Domain.Helmets;
using devgalop.learn.abstract_factory.Domain.Jackets;

namespace devgalop.learn.abstract_factory.Factories
{
    public class FPRidingGearFactory : IRidingGearFactory
    {
        public IHelmet CreateHelmetObj()
        {
            Console.WriteLine("Creating FP Helmet...");
            return new FPHelmet();
        }

        public IJacket CreateJacketObj()
        {
            Console.WriteLine("Creating FP Jacket...");
            return new FPJacket();
        }
    }
}