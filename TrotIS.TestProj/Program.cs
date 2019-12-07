using System;
using System.Linq;
using TrotIS.Shared;

namespace TrotIS.TestProj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Context myContext = new Context();
            var user = myContext.Users.FirstOrDefault(a => a.FirstName == "Catalin");
            user.Address = myContext.Addresses.FirstOrDefault(a => a.City == "Iasi");
            myContext.SaveChanges();
        }
    }
}
