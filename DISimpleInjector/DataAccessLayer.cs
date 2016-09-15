using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DISimpleInjector
{
    public class DataAccessLayer : ICart {
        public string AddToCart() {
            var val = "Simple Injector is fastest DI as compared to other Dependency Injection Tool";
            Console.WriteLine(val);
            return val;
        }
    }
}
