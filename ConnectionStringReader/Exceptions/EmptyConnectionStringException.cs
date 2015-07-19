namespace ConnectionStringReading.Exceptions
{
    using System;
    using System.Configuration;

    /// <summary>
    /// Found an empty connection string.
    /// </summary>
    [Serializable]
    public class EmptyConnectionStringException : ConnectionStringReadingException
    {
        internal EmptyConnectionStringException(ConnectionStringSettings cs)
            : base(string.Format("The connection string \"{0}\" is empty.", cs.Name)) { }
    }
}
