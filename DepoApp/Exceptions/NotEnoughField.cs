using DepoApp;
using DepoApp.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepoApp.Exceptions
{
    public class NotEnoughField :Exception
    {
        public NotEnoughField(string message) : base(message)    
        {
            
        }
    }
}
