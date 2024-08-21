using FactoryMethodPatternSolved;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPatternSolved
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
