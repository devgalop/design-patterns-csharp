using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace devgalop.learn.bridge.Domain
{
    public class LandingPermission : IPermission
    {
        public void Assign()
        {
            Console.WriteLine("Landing permission granted.");
        }
    }
}