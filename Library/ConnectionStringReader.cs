namespace ConnectionStringLibrary
{
    using ConnectionStringLibrary.Exceptions;
    using System;
    using System.Configuration;

    /// <summary>
    /// Reads and checks connection strings.
    /// </summary>
    public static class ConnectionStringReader
    {
        /// <summary>
        /// Reads a connection string.
        /// </summary>
        /// <param name="connectionStringName">Name of the connection string to read</param>
        /// <returns>The read connection string settings</returns>
        /// <exception cref="ArgumentNullException">An null connectionStringName was given</exception>
        /// <exception cref="NoSuchConnectionStringException">
        /// A connection string with the provided name doesn't exist
        /// </exception>
        /// <exception cref="EmptyConnectionStringException">Found an empty connection string</exception>
        /// <exception cref="EmptyProviderNameException">Found an empty provider name</exception>
        public static ConnectionStringSettings Read(string connectionStringName)
        {
            if (connectionStringName == null)
                throw new ArgumentNullException("connectionStringName");

            var cs = ConfigurationManager.ConnectionStrings[connectionStringName];
            if (cs == null)
                throw new NoSuchConnectionStringException(connectionStringName);

            Check(cs);
            return cs;
        }

        /// <summary>
        /// Checks if the connection string and the data provider are not empty.
        /// </summary>
        /// <param name="cs">Connection string settings to check</param>
        /// <exception cref="EmptyConnectionStringException">Found an empty connection string</exception>
        /// <exception cref="EmptyProviderNameException">Found an empty provider name</exception>
        public static void Check(ConnectionStringSettings cs)
        {
            if (string.IsNullOrWhiteSpace(cs.ConnectionString))
                throw new EmptyConnectionStringException(cs);

            if (string.IsNullOrWhiteSpace(cs.ProviderName))
                throw new EmptyProviderNameException(cs);
        }
    }
}
