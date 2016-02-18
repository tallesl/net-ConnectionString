namespace ConnectionStringLibrary.Exceptions
{
    using System;

    /// <summary>
    /// A connection string with the provided name doesn't exist.
    /// </summary>
    [Serializable]
    public class NoSuchConnectionStringException : ConnectionStringReadingException
    {
        internal NoSuchConnectionStringException(string name)
            : base(string.Format("There's no \"{0}\" connection string.", name)) { }
    }
}
