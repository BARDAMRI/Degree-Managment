using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DM.Backend.BL
{
    class DException: Exception 
    {
        public DException()
        {

        }
        public DException(string message)
            : base(message)
        {
        }
        public DException(string message, Exception inner)
            : base(message, inner)
        { }
    }
}
