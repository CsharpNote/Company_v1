using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class Director : Manager
    {
        public Director(String name, int salaryPerMonth)
            : base(name, salaryPerMonth, 20000)
        {
        }
    }
}
