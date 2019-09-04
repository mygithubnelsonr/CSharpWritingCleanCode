using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeNamesExample.PoorMethodSignatures
{
    public class PoorMethodSignatures
    {
        public void Run()
        {
            var userService = new UserService();

            // old
            // var user = userService.GetUser("username", "password", true);
            
            // new
            var user = userService.Login("username", "password");
            var anotherUser = userService.GetUser("username");
        }
    }
}
