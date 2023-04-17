# template-cs
A repository template for C# projects.

## Features
- `Core` project that represents the library
- `Tests` project with `xUnit`, `FluentAssertions` and `NSubstitute` installed
- `Benchmarks` project with `BenchmarkDotNet` installed
- `Playground` console project for testing stuff
- `.editorconfig`
- NuGet publish
- GitHub Actions: testing (`test.yml`) and deployment (`deploy.yml`)

## Install
- Make sure [`dotnet-script`](https://github.com/dotnet-script/dotnet-script) tool is installed
- Execute `dotnet script install.csx` at the root of the repository

### Example
```sh
$ dotnet script install.csx
Project name: Test
Project description: Test description.
Repository name (e.g., 'candy-kingdom/summary'): candy-kingdom/test
Installing...
√ [./src/Core/Core.csproj] Replace '<AssemblyName>Project</AssemblyName>' -> '<AssemblyName>Test</AssemblyName>'
√ [./src/Core/Core.csproj] Replace '<RootNamespace>Project</RootNamespace>' -> '<RootNamespace>Test</RootNamespace>'
√ [./src/Core/Core.csproj] Replace '<Title>Project</Title>' -> '<Title>Test</Title>'
√ [./src/Core/Core.csproj] Replace '<Description>The description of a project.</Description>' -> '<Description>Test description.</Description>'
√ [./src/Core/Core.csproj] Replace '<RepositoryUrl>https://github.com/candy-kingdom/project</RepositoryUrl>' -> '<RepositoryUrl>https://github.com/candy-kingdom/test</RepositoryUrl>'
√ [./src/Tests/Tests.csproj] Replace '<AssemblyName>Project.Tests</AssemblyName>' -> '<AssemblyName>Test.Tests</AssemblyName>'
√ [./src/Tests/Tests.csproj] Replace '<RootNamespace>Project.Tests</RootNamespace>' -> '<RootNamespace>Test.Tests</RootNamespace>'
√ [./src/Playground/Playground.csproj] Replace '<AssemblyName>Project.Playground</AssemblyName>' -> '<AssemblyName>Test.Playground</AssemblyName>'
√ [./src/Playground/Playground.csproj] Replace '<RootNamespace>Project.Playground</RootNamespace>' -> '<RootNamespace>Test.Playground</RootNamespace>'
√ [./src/Benchmarks/Benchmarks.csproj] Replace '<AssemblyName>Project.Benchmarks</AssemblyName>' -> '<AssemblyName>Test.Benchmarks</AssemblyName>'
√ [./src/Benchmarks/Benchmarks.csproj] Replace '<RootNamespace>Project.Benchmarks</RootNamespace>' -> '<RootNamespace>Test.Benchmarks</RootNamespace>'
Done!
```
