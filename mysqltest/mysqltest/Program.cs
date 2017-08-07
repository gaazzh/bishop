using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mysqltest
{
    class Program
    {
        static void Main(string[] args)
        {
            using (UserContext db = new UserContext())
            {
                User u0 = new User() { Name = "John Doe", Age = 30 };
                User u1 = new User() { Name = "Mary Key", Age = 25 };
                db.Users.AddRange(new User[] { u0, u1 });
                db.SaveChanges();
            }
            Console.WriteLine("bitti, press any key to exit");
            Console.ReadKey();
        }
    }
}
