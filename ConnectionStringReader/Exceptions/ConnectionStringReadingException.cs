namespace ConnectionStringReading.Exceptions
{
    using System;

    /// <summary>
    /// Something exceptional happened on reading a connection string.
    /// </summary>
    [Serializable]
    public abstract class ConnectionStringReadingException : Exception
    {
        internal ConnectionStringReadingException(string message) : base(message) { }
    }
}
