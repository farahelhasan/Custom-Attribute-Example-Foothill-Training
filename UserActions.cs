using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttributeExample
{
    class UserActions
    {
        [IsAdmin(true)]
        public void DeleteUser()
        {
            Console.WriteLine("User deleted successfully.");
        }
    }
}
