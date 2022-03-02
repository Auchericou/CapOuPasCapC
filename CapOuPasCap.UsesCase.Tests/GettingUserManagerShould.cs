using FluentAssertions;
using CapOuPasCap.UsesCase.CleanArchitecture;
using CapOuPasCap.UsesCase.Entities;
using CapOuPasCap.UsesCase.Ports.Primary;
using CapOuPasCap.UsesCase.Request;
using CapOuPasCap.UsesCase.Tests.UsesCase;
using CapOuPasCap.UsesCase.Tools;
using Xunit;
using CapOuPasCap.UsesCase.Tests.Facts;

namespace CapOuPasCap.UsesCase.Tests
{
    public class GettingUsersManagerShould
    {
        [Fact]
        public void GettingUsers_Should_ClientGetUsersUseCase()
        {
            IPresenter<PaginedData<User>, PaginedData<User>> presenter = new SimplePresenter<PaginedData<User>>();
            var manager = new GettingUsersManager(new UserRepositoryFact(), presenter);
            GetUsersRequest request = new();
            manager.ClientGetUsers(request);
            presenter.GetData().Should().BeEquivalentTo(new PaginedData<User>()
            {
                Data = new[] { new User("user1","pass1") },
                Page = 1,
                PageSize = 20,
            });
        }
    }
}