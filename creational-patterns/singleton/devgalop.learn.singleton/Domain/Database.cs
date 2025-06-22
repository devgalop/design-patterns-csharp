using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace devgalop.learn.singleton.Domain
{
    public class Database
    {
        private static Database? _instance;

        private static readonly Lock _lock = new();

        private Database()
        {
            InstanceId = Guid.NewGuid().ToString();
        }
        
        public string InstanceId { get; set; }

        public static Database GetInstance()
        {
            if (_instance is null)
            {
                lock (_lock)
                {
                    _instance ??= new();
                    _instance.InstanceId = Guid.NewGuid().ToString();
                }
            }

            return _instance;
        }
    }
}