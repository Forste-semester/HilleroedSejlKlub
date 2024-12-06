
namespace HillerødSejlKlub.Services
{
    [Serializable]
    internal class KeyImplementedException : Exception
    {
        public KeyImplementedException()
        {
        }

        public KeyImplementedException(string? message) : base(message)
        {
        }

        public KeyImplementedException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}