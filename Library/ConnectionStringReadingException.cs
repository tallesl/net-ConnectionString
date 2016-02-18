namespace ConnectionStringLibrary
{
    using System;

    /// <summary>
    /// Something exceptional happened while reading a connection string.
    /// </summary>
    [Serializable]
    public abstract class ConnectionStringReadingException : Exception
    {
        internal ConnectionStringReadingException(string message) : base(message) { }
    }
}
