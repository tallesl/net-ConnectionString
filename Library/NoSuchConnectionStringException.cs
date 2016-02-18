namespace ConnectionStringLibrary
{
    using System;
    using System.Globalization;

    /// <summary>
    /// A connection string with the provided name doesn't exist.
    /// </summary>
    [Serializable]
    public class NoSuchConnectionStringException : ConnectionStringReadingException
    {
        internal NoSuchConnectionStringException(string name)
            : base(string.Format(CultureInfo.InvariantCulture, "There's no \"{0}\" connection string.", name)) { }
    }
}
