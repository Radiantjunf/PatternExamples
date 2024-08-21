using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPatternSolved
{
    public class DeclarationService
    {
        private readonly DeclarationFactory declarationFactory;

        public DeclarationService(DeclarationFactory factory)
        {
            declarationFactory = factory;
        }

        public bool StartValidation()
        {
            IDeclaration declaration = declarationFactory.CreateDeclaration();
            return declaration.Validate();
        }
    }
}
