using System;
using DM.Backend.SL;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Service service = new Service();
            Console.WriteLine(service.Reset().ErrorMessage);
            Console.WriteLine(service.LoadData().ErrorMessage);
            Console.WriteLine(service.Register("Bar Damri", 208915751, "1234").ErrorMessage);
        }
    }
}
