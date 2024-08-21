using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPatternSolved
{
    public class DmrFactory : DeclarationFactory
    {
        public override IDeclaration CreateDeclaration()
        {
            return new Dmr();
        }
    }
}
