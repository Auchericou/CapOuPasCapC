using CapOuPasCap.UsesCase.CleanArchitecture;
using CapOuPasCap.UsesCase.Entities;
using CapOuPasCap.UsesCase.Ports.Secondary;
using CapOuPasCap.UsesCase.Request;
using CapOuPasCap.UsesCase.Tools;

namespace CapOuPasCap.UsesCase.UsesCase
{
    public class ClientGetUsersUseCase
    {
        private readonly IUserRepository UsersRepository;

        public ClientGetUsersUseCase(IUserRepository repository)
        {
            this.UsersRepository = repository;
        }

        public void Execute(GetUsersRequest getUsersRequest, IInPresenter<PaginedData<User>> presenter)
        {
            var users = this.UsersRepository.GetMany(getUsersRequest);
            presenter.Present(users);
        }
    }
}
