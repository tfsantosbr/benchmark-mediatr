using BenchMediatrApp.Shared.Commands;
using BenchMediatrApp.Shared.Handlers;
using BenchMediatrApp.Users.Commands;
using BenchMediatrApp.Users.Repositories;

namespace BenchMediatrApp.Users.Handlers
{
    public class UserCommandsHandler :
        IHandler<CreateUser>,
        IHandler<UpdateUser>
    {
        private IUserRepository _userRepository;

        public UserCommandsHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public ICommandResult Handle(CreateUser command)
        {
            _userRepository.CreateUser(new User());

            return new CommandResult("User created");
        }


        public ICommandResult Handle(UpdateUser command)
        {
            _userRepository.UpdateUser(new User());

            return new CommandResult("User updated");
        }
    }
}