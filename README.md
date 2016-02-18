# ConnectionString

[![][build-img]][build]
[![][nuget-img]][nuget]

[build]:     https://ci.appveyor.com/project/TallesL/net-connectionstring
[build-img]: https://ci.appveyor.com/api/projects/status/github/tallesl/net-connectionstring?svg=true
[nuget]:     https://www.nuget.org/packages/ConnectionString
[nuget-img]: https://badge.fury.io/nu/ConnectionString.svg

Reads a connection string while checking if the connection string [exists], it's [not empty] and [has a provider name].

[exists]:              Library/NoSuchConnectionStringException.cs
[not empty]:           Library/EmptyConnectionStringException.cs
[has a provider name]: Library/EmptyProviderNameException.cs

```cs
using ConnectionStringLibrary;

try
{
    ConnectionStringReader.Read("SomeConnectionStringName");
}
catch (ConnectionStringReadingException)
{
    // configure that thing right dude
}
```
