using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FectoryMethod.Factory
{
    internal abstract class Creator
    {
        public abstract IProduct CreateFactory();

        // do others work
        public string DoSomething()
        {
            IProduct product = CreateFactory();
            string result = "Creator: The same creators class result with: "
                + product.Operation();
            return result;
        }
    }
}
