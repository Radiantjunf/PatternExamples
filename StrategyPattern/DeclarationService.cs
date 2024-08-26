using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    public class DeclarationService
    {
        public void Validate(string declaration)
        {
            if (declaration == "dmr")
            {
                Dmr dmr = new Dmr();
                dmr.Validate();
            }
            else if (declaration == "iva")
            {
                Iva iva = new Iva();
                iva.Validate();
            }
            else
            {
                Console.WriteLine("Declaração invalida.");
            }
        }


    }
}
