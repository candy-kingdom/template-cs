<div align="center">
    <img src="./res/icon.png" alt="Logo" width="128" height="128"></img>
</div>

<h1 align="center">template-cs</h1>

<p align="center">
    <i>A batteries-included repository template for C# packages.</i>
</p>

<p align="center">
    <img alt="Nuget" src="https://img.shields.io/nuget/v/Project">
</p>

## Features
- `Core` project that represents the library
- `Tests` project with `xUnit`, `FluentAssertions` and `NSubstitute` installed
- `Benchmarks` project with `BenchmarkDotNet` installed
- `Playground` project for playing with stuff in the console
- `.editorconfig` (fully configured)
- NuGet publish for `Core` project
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
