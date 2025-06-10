using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using devgalop.learn.abstract_factory.Domain.Helmets;
using devgalop.learn.abstract_factory.Domain.Jackets;

namespace devgalop.learn.abstract_factory.Factories
{
    public class RichaRidingGearFactory : IRidingGearFactory
    {
        public IHelmet CreateHelmetObj()
        {
            Console.WriteLine("Creating Richa Helmet...");
            return new RichaHelmet();
        }

        public IJacket CreateJacketObj()
        {
            Console.WriteLine("Creating Richa Jacket...");
            return new RichaJacket();
        }
    }
}