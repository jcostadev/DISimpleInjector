using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DISimpleInjector {
    class BusinessLayer {

        private ICart _objCart;

        //in the Bussinesslayer I am injecting a dependency from the Constructor
        public BusinessLayer(ICart objCart) {
           _objCart = objCart;
        }

        public void InsertToCart() {
            _objCart.AddToCart();
        }
    }
}
