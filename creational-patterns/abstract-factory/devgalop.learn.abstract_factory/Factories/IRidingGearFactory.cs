using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using devgalop.learn.abstract_factory.Domain.Helmets;
using devgalop.learn.abstract_factory.Domain.Jackets;

namespace devgalop.learn.abstract_factory.Factories
{
    public interface IRidingGearFactory
    {
        IHelmet CreateHelmetObj();
        IJacket CreateJacketObj();
    }
}