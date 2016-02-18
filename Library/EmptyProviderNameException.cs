namespace ConnectionStringLibrary
{
    using System;
    using System.Configuration;
    using System.Globalization;

    /// <summary>
    /// Found an empty provider name.
    /// </summary>
    [Serializable]
    public class EmptyProviderNameException : ConnectionStringReadingException
    {
        internal EmptyProviderNameException(ConnectionStringSettings cs)
            : base(string.Format(CultureInfo.InvariantCulture,
            "The provider name of the connection string \"{0}\" is empty.", cs.Name)) { }
    }
}
