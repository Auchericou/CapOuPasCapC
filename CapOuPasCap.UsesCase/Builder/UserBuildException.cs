using System.Runtime.Serialization;

namespace CapOuPasCap.UsesCase.Builder;

[Serializable]
public class UserBuildException : Exception
{
    public UserBuildException()
    {
    }

    public UserBuildException(string? message) : base(message)
    {
    }

    public UserBuildException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected UserBuildException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}