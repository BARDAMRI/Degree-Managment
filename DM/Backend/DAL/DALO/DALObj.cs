using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM.Backend.DAL.DALO
{
    class DALObj
    {
            public const string IDColumnName = "Id";
            protected DALController Controller;
            public virtual int Id
            { get; set; } = -1;
            protected DALObj(DALController controller)
            {
                Controller = controller;
            }

    }
}
