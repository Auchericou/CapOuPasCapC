using CapOuPasCap.UsesCase.Entities;
using CapOuPasCap.UsesCase.Request;
using CapOuPasCap.UsesCase.Tools;

namespace CapOuPasCap.UsesCase.Ports.Secondary
{
    public interface IUserRepository
    {
        PaginedData<User> GetMany(GetUsersRequest getUsersRequest);
    }
}