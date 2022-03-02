using Xunit;
using FluentAssertions;
using CapOuPasCap.UsesCase.Entities;

namespace CapOuPasCap.UsesCase.Tests.Entities
{

    public class UserShould
    {
            [Fact]
            public void Debile_Test()
            {
                false.Should().BeFalse();
            }

        [Fact]

        public void User_Should_Have_Username()
        {
            var user = new User("user1", "pass1");
            user._username.Should().Be("user1");
        }

        [Fact]
        public void User_Should_Have_Password()
        {
            var user = new User("user1", "pass1");
            user._password.Should().Be("pass1");
        }

        [Fact]
        public void User_IsValid_Should_Have_Username()
        {
            var user = new User(string.Empty, "pass1");
            user.IsValid().Should().BeFalse(); 
        }
    }
}