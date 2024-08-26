using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class Dmr : IDeclaration
    {
        public bool Validate()
        {
            Console.WriteLine("A validar o dmr");
            return true;
        }
    }
}
