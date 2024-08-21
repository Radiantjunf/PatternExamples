using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternSolved
{
    public  class EmailNotifier : INotifier
    {
        public void Notify(string menssage)
        {
            Console.WriteLine("A enviar email: " + menssage);
        }
    }
}
