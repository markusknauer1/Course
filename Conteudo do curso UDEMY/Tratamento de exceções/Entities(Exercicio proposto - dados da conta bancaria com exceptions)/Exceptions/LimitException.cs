

namespace Course.Entities.Exceptions
{
    internal class LimitException : ApplicationException
    {
        public LimitException(string message) : base(message)
        {

        }
    }
}
