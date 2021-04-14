using System;
using System.Drawing;
using DependencyInjection;
using Xunit;
using Xunit.Abstractions;

namespace UnitTests.DependencyInjection
{
    public class Tests
    {

        [Fact]
        public void TestTransient()
        {
            // Arrange
            var services = new ServicesCollection()
                .AddTransient<IMyService, MyService>()
                .AddTransient<IMyRepository, MyRepository>();
            var diContainer = services.Build();
            
            // Act
            var myService1 = diContainer.GetRequiredService<IMyService>();
            var myService2 = diContainer.GetRequiredService<IMyService>();
            
            // Assert
            Assert.Equal(1, myService1.SayCoucou());
            Assert.Equal(1, myService2.SayCoucou());
        }

        [Fact]
        public void TestSingleton()
        {
            // Arrange
            var services = new ServicesCollection()
                .AddTransient<IMyService, MyService>()
                .AddSingleton<IMyRepository, MyRepository>();
            var diContainer = services.Build();
            
            // Act
            var myService1 = diContainer.GetRequiredService<IMyService>();
            var myService2 = diContainer.GetRequiredService<IMyService>();
            
            // Assert
            Assert.Equal(1, myService1.SayCoucou());
            Assert.Equal(2, myService2.SayCoucou());
        }
        
        private interface IMyService
        {
            public int SayCoucou();
        }

        private class MyService : IMyService
        {
            private readonly IMyRepository _repository;
            public MyService(IMyRepository repository)
            {
                _repository = repository;
            }

            public int SayCoucou()
            {
                _repository.ModifyState();
                return _repository.GetCoucou();
            }
        }

        private interface IMyRepository
        {
            public int GetCoucou();

            void ModifyState();
        }

        private class MyRepository : IMyRepository
        {
            private int _state = 0;
            public MyRepository()
            {
            }

            public int GetCoucou()
            {
                return _state;
            }

            public void ModifyState()
            {
                _state++;
            }
        }
    }


}