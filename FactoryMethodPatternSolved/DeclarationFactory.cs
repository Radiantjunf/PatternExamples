using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPatternSolved
{
    public abstract class DeclarationFactory
    {
        public abstract IDeclaration CreateDeclaration();

        public bool Validate()
        {
            IDeclaration declaration = CreateDeclaration();
            return declaration.Validate();      
        }
    }
}
