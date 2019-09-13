using System;
using BenchmarkDotNet.Attributes;
using BenchMediatrApp.Users.Commands;
using BenchMediatrApp.Users.Handlers;

namespace BenchMediatrApp
{
    [MemoryDiagnoser, KeepBenchmarkFiles]
    public class App
    {
        private readonly UserCommandsHandler _userCommandsHandler;

        public App(UserCommandsHandler userCommandsHandler)
        {
            _userCommandsHandler = userCommandsHandler;
        }

        [Benchmark]
        public void StandardCreateUser()
        {
            var createUser = new CreateUser();
            var createResult = _userCommandsHandler.Handle(createUser);

            Console.WriteLine(createResult.Message);
        }

        [Benchmark]
        public void StandardUpdateUser()
        {
            var updateUser = new UpdateUser();
            var updateResult = _userCommandsHandler.Handle(updateUser);

            Console.WriteLine(updateResult.Message);
        }
    }
}