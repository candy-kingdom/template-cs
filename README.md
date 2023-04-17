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
√ Step 1
√ Step 2
√ ...
√ Step N
Done!
```
