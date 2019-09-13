namespace BenchMediatrApp.Users.Repositories
{
    public interface IUserRepository
    {
         void CreateUser(User user);
         void UpdateUser(User user);
    }
}