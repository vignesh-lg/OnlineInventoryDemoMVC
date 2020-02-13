using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineInventory.Entity;

namespace OnlineInventory.DAL
{
    public class Repository
    {
        public static List<User> list = new List<User>();
        static Repository()
        {
            list.Add(new User { UserName = "vignesh.l.g", password = "Vignesh@1" });
        }
        public static IEnumerable<User> GetDetails()
        {
            return list;
        }
    }
}
