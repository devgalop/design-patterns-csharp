using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace devgalop.learn.bridge.Domain
{
    public class SupportRole(List<IPermission> permissions) : Role(permissions)
    {
        public override void AssignPermissions()
        {
            Console.WriteLine("Assigning support permissions: ");
            foreach (var permission in _permissions)
            {
                permission.Assign();
            }
        }
    }
}