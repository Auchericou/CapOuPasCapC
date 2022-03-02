using CapOuPasCap.UsesCase.Entities;
using CapOuPasCap.UsesCase.Ports.Secondary;
using CapOuPasCap.UsesCase.Request;
using CapOuPasCap.UsesCase.Tools;


namespace CapOuPasCap.UsesCase.Tests.Facts
{
    public class UserRepositoryFact : IUserRepository
    {
        public PaginedData<User> GetMany(GetUsersRequest getUsersRequest)
        {
            return new PaginedData<User>()
            {
                Data = new[] { new User("user1","pass1") },
                Page = 1,
                PageSize = 20,
            };
        }
    }
}
