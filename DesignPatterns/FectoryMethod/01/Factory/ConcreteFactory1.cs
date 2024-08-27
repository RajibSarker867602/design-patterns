using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FectoryMethod.Factory
{
    internal class ConcreteFactory1 : Creator
    {
        public override IProduct CreateFactory()
        {
            return new ConcreteProduct1();
        }
    }
}
