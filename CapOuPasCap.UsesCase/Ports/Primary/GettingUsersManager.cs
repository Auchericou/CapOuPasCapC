using CapOuPasCap.UsesCase.CleanArchitecture;
using CapOuPasCap.UsesCase.Entities;
using CapOuPasCap.UsesCase.Ports.Secondary;
using CapOuPasCap.UsesCase.Request;
using CapOuPasCap.UsesCase.Tools;
using CapOuPasCap.UsesCase.UsesCase;

namespace CapOuPasCap.UsesCase.Ports.Primary
{
    public class GettingUsersManager
    {
        private readonly IInPresenter<PaginedData<User>> _UserPresenter;

        private readonly IUserRepository _UserRepository;

        public GettingUsersManager(IUserRepository userRepo, IInPresenter<PaginedData<User>> userPresenter)
        {
            _UserRepository = userRepo;
            _UserPresenter = userPresenter;
        }

        public void ClientGetUsers(GetUsersRequest getUsersRequest)
        {
            var usecase = new ClientGetUsersUseCase(_UserRepository);
            usecase.Execute(getUsersRequest, _UserPresenter);
        }
    }
}
