using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using CapOuPasCap.UsesCase.Builder;
using CapOuPasCap.UsesCase.Entities;
using Xunit;

namespace CapOuPasCap.UsesCase.Tests.Entities
{
    public class UserBuilderShould
    {
        [Fact]
        public void InvalidUser_ShouldNotBeBuild_AndThrowAnException()
        {
            var assert = Assert.Throws<UserBuildException>(() => (new UserBuilder("")).Build());
            assert.Message.Should().Contain("User not set correctly");
        }

        [Fact]
        public void ValidUser_Should_BeBuild()
        {
            var assert = new UserBuilder("user1")
                .Password("pass1")
                .Build();
            assert.Should().BeEquivalentTo(new User("user1", "pass1"));
        }
    }
}
