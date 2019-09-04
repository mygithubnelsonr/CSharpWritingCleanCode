using System;

namespace CleanCodeNamesExample.PoorMethodSignatures
{
    public class User
    {
        private DateTime _lastLogin;

        public DateTime LastLogin { get => _lastLogin; set => _lastLogin = value; }

    }
}