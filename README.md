# ConnectionStringReader

[![][build-img]][build]
[![][nuget-img]][nuget]

[build]:     https://ci.appveyor.com/project/TallesL/ConnectionStringReader
[build-img]: https://ci.appveyor.com/api/projects/status/github/tallesl/ConnectionStringReader

[nuget]:     http://badge.fury.io/nu/ConnectionStringReader
[nuget-img]: https://badge.fury.io/nu/ConnectionStringReader.png

Reads a connection string while checking if the connection string [exists], it's [not empty] and [has a provider name].

[exists]:              ConnectionStringReader/Exceptions/NoSuchConnectionStringException.cs
[not empty]:           ConnectionStringReader/Exceptions/EmptyConnectionStringException.cs
[has a provider name]: ConnectionStringReader/Exceptions/EmptyProviderNameException.cs

```cs
using ConnectionStringReading;

try
{
    ConnectionStringReader.Read("SomeConnectionStringName");
}
catch (ConnectionStringReadingException)
{
    // configure that thing right dude
}
```
