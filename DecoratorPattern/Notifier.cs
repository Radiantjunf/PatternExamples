using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Notifier
    {
        public void Notify(string menssage)
        {
            Console.WriteLine("A notificar: " + menssage);
        }
    }
}
