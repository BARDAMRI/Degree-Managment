using System;
using DM.Backend.SL;
using DM.Backend.BL;

namespace MainProj
{
    class Program
    {
        static void Main(string[] args)
        {
            Service service = new Service();
            Console.WriteLine( service.Register("Bar Damri",208915751,"1234"));
        }
    }
}
