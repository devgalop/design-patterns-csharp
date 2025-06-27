using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace devgalop.learn.bridge.Domain
{
    public abstract class Role
    {
        protected List<IPermission> _permissions;

        public Role(List<IPermission> permissions)
        {
            _permissions = permissions;
        }

        public abstract void AssignPermissions();
    }
}