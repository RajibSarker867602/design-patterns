﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FectoryMethod
{
    internal class ConcreteProduct1 : IProduct
    {
        public string Operation()
        {
            return "Result of 'ConcreteProduct1'";
        }
    }
}
