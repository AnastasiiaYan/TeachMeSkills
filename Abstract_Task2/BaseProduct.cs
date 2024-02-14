using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Task2
{
    public abstract class BaseProduct
    {
        public abstract void PrintInfo();
        public abstract bool CheckExpiration() ;
    }
}