# Configuration of .NET Analyzers

This repository contains configuration files for analyzers used to check the style of C# code in students' homework. See the files [in the configs folder](/configs).

The following analyzers are jointly used for checking:
- Code analysis tools built in Visual Studio / [link to documentation](https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/overview)
- StyleCop.Analyzers / [repository link](https://github.com/DotNetAnalyzers/StyleCopAnalyzers)

The analyzers are configured in such a way that building a project will fail if the basic rules are violated.

The process of installing and configuring the analyzers is described in detail [in this tutorial](https://docs.google.com/document/d/1UAUMETJWpd27NFB7dnPzHaE_3NM6spj2hQUz9xT8Dcs/edit?usp=sharing) (in Russian).
