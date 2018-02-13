# Studying mocks, fakes, doubles, and stubs with C#.

1. [Install dotnet core](https://www.microsoft.com/net/learn/get-started/macos).
2. `cd mocks-in-csharp/` then run `dotnet build` to build.
3. `cd ClaimsTests` and run `dotnet xunit` to run tests.
    - If this command does not work, try `dotnet restore` then `dotnet xunit`.

#### Other commands
- `dotnet clean` cleans artifacts created from a build (executables and DLLs).
- `dotnet add package xunit` installs the xUnit package from NuGet.  Use it to install any other packages (like `moq`).


### Hints

Tests are written using [xUnit](https://xunit.github.io/docs/getting-started-dotnet-core).

The [Moq4](https://github.com/Moq/moq4/wiki/Quickstart) library is an excellent mocking library in C#.