using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM.Backend.DAL.DALO
{
    public class DALObj
    {
           
            protected DALController Controller;
            protected DALObj(DALController controller)
            {
                Controller = controller;
            }

    }
}
