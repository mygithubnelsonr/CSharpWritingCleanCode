using System;

namespace CleanCodeNamesExample.PoorMethodSignatures
{
    internal class UserService
    {
        private UserDbContext _dbContext = new UserDbContext();

        public User GetUser(string username)
        {
            /*
            put this login logic into a seperate method
                if(login)
                {
                    // check if there is a user with the given username in the database
                    // if yes, set the last login date
                    // and return the user

                    var user = new User();     // _dbContext.Users.SingleOrDefault(u => u.UserName == username && u.Password == password);

                    if(user != null)
                        user.LastLogin = DateTime.Now;

                    return user;
                }
                else
                {

                }
            */

            /*
             * refactor this part
            if (login)
            {
                return Login(username, password);
            }
            else
            {
                var user = new User();  // _dbContext.Users.SingleOrDefault(u => u.UserName == username);
                return user;
            }
            */

            var user = new User();  // _dbContext.Users.SingleOrDefault(u => u.UserName == username);
            return user;

        }

        public User Login(string username, string password)
        {
            // check if there is a user with the given username in the database
            // if yes, set the last login date
            // and return the user

            var user = new User();     // _dbContext.Users.SingleOrDefault(u => u.UserName == username && u.Password == password);

            if (user != null)
                user.LastLogin = DateTime.Now;

            return user;
        }
    }
}