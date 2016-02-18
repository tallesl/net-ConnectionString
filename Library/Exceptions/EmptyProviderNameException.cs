namespace ConnectionStringLibrary.Exceptions
{
    using System;
    using System.Configuration;

    /// <summary>
    /// Found an empty provider name.
    /// </summary>
    [Serializable]
    public class EmptyProviderNameException : ConnectionStringReadingException
    {
        internal EmptyProviderNameException(ConnectionStringSettings cs)
            : base(string.Format("The provider name of the connection string \"{0}\" is empty.", cs.Name)) { }
    }
}
