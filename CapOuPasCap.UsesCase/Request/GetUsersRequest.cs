namespace CapOuPasCap.UsesCase.Request
{
    public class GetUsersRequest
    {
        public GetUsersRequest()
        {
        }

        public int PageNumber { get; set; } = 1;

        public int PageSize { get; set; } = 20;
    }
}