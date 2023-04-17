using System;
using System.IO;

var name = Read("project name");
var desc = Read("project description");
var repo = Read("repository name (e.g., 'candy-kingdom/summary')");

// Append '.' character at the end of the description if there is none.
if (!desc.EndsWith("."))
    desc += ".";

Console.WriteLine("Installing...");

// Core.
Replace("./src/Core/Core.csproj", "<AssemblyName>Project</AssemblyName>", $"<AssemblyName>{name}</AssemblyName>");
Replace("./src/Core/Core.csproj", "<RootNamespace>Project</RootNamespace>", $"<RootNamespace>{name}</RootNamespace>");
Replace("./src/Core/Core.csproj", "<Title>Project</Title>", $"<Title>{name}</Title>");
Replace("./src/Core/Core.csproj", "<Description>The description of a project.</Description>", $"<Description>{desc}</Description>");
Replace("./src/Core/Core.csproj", "<RepositoryUrl>https://github.com/candy-kingdom/project</RepositoryUrl>", $"<RepositoryUrl>https://github.com/{repo}</RepositoryUrl>");

// Tests.
Replace("./src/Tests/Tests.csproj", "<AssemblyName>Project.Tests</AssemblyName>", $"<AssemblyName>{name}.Tests</AssemblyName>");
Replace("./src/Tests/Tests.csproj", "<RootNamespace>Project.Tests</RootNamespace>", $"<RootNamespace>{name}.Tests</RootNamespace>");

// Playground.
Replace("./src/Playground/Playground.csproj", "<AssemblyName>Project.Playground</AssemblyName>", $"<AssemblyName>{name}.Playground</AssemblyName>");
Replace("./src/Playground/Playground.csproj", "<RootNamespace>Project.Playground</RootNamespace>", $"<RootNamespace>{name}.Playground</RootNamespace>");

// Benchmarks.
Replace("./src/Benchmarks/Benchmarks.csproj", "<AssemblyName>Project.Benchmarks</AssemblyName>", $"<AssemblyName>{name}.Benchmarks</AssemblyName>");
Replace("./src/Benchmarks/Benchmarks.csproj", "<RootNamespace>Project.Benchmarks</RootNamespace>", $"<RootNamespace>{name}.Benchmarks</RootNamespace>");

// Solution.
File.Move("./src/Project.sln", $"./src/{name}.sln");

// README.
Replace("./README.md", "<i>A batteries-included repository template for C# packages.</i>", $"<i>{desc}.</i>");

Console.WriteLine("Done!");

static string Read(string input)
{
    Console.Write(input[..1].ToUpper() + input[1..] + ": ");
    return Console.ReadLine();
}

static void Replace(string at, string from, string to)
{
    File.WriteAllText(at, File.ReadAllText(at).Replace(from, to));
    Console.WriteLine($"✓ [{at}] Replace '{from}' -> '{to}'");
}