using FluentAssertions;
using CapOuPasCap.UsesCase.CleanArchitecture;
using CapOuPasCap.UsesCase.Entities;
using CapOuPasCap.UsesCase.Request;
using CapOuPasCap.UsesCase.Tools;
using CapOuPasCap.UsesCase.UsesCase;
using Xunit;
using CapOuPasCap.UsesCase.Tests.Facts;

namespace CapOuPasCap.UsesCase.Tests.UsesCase
{
    public class ArticlesHomePrintUseCaseShould
    {
        private IPresenter<PaginedData<User>, PaginedData<User>> _Presenter;

        public ArticlesHomePrintUseCaseShould()
        {
            _Presenter = new SimplePresenter<PaginedData<User>>();
        }

        [Fact]
        public void GivenClient_WhenIGetBokks_ShouldReturn20ByDEfault()
        {
            var assert = new ClientGetUsersUseCase(new UserRepositoryFact());
            assert.Execute(new GetUsersRequest(), _Presenter);
            _Presenter.GetData().Should().BeEquivalentTo(new PaginedData<User>()
            {
                Data = new[] { new User("user1","pass1") },
                Page = 1,
                PageSize = 20,
            });
        }
    }
}