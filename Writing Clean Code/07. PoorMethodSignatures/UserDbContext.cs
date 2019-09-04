namespace CleanCode.PoorMethodSignatures
{
    internal class UserDbContext
    {
        public UserDbContext()
        {
        }

        public object Users { get; internal set; }
    }
}