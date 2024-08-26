using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class Iva : IDeclaration
    {
        public bool Validate()
        {
            Console.WriteLine("A validar o iva");
            return true;
        }
    }
}
