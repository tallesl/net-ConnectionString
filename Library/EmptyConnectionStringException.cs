namespace ConnectionStringLibrary
{
    using System;
    using System.Configuration;
    using System.Globalization;

    /// <summary>
    /// Found an empty connection string.
    /// </summary>
    [Serializable]
    public class EmptyConnectionStringException : ConnectionStringReadingException
    {
        internal EmptyConnectionStringException(ConnectionStringSettings cs)
            : base(string.Format(CultureInfo.InvariantCulture, "The connection string \"{0}\" is empty.", cs.Name)) { }
    }
}
