using System;
using System.Collections.Generic;
using System.Text;

namespace FirstApp
{
    class Cyrcle
    {
        public string Name { get; set; }
        public const decimal Pi = 3.14M;

        public decimal CalcArea(decimal r)
        {
            return Pi * r * r;
        }
        public decimal CalcLenght(decimal r)
        {
            return 2 * Pi * r;
        }
    }
}
