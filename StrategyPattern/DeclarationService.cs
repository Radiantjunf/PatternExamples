using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class DeclarationService
    {
        private IDeclaration _declaration;

        public DeclarationService(IDeclaration declaration)
        {
            _declaration = declaration;
        }

        public void SetDeclaration(IDeclaration declaration)
        {
            _declaration = declaration;
        }

        public bool Validate()
        {
            return _declaration.Validate();
        }
    }
}
