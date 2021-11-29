using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiczbyTrojkatne
{
    class Triangle
    {
        public int triangle(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return (n + triangle(n - 1));
            }
        }
    }
}


