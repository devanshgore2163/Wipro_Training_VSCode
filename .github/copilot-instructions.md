<!-- Brief, focused instructions for AI coding assistants working on this repo -->
# Copilot / Agent Instructions

Purpose
- Help an AI coding assistant become productive quickly in this small C# training repository.

Big picture
- This workspace contains several small, independent console projects grouped under training folders (e.g., `Day1_Training`, `Day4_Training`). Each project is a standalone C# console app with its own `.csproj` file.
- Top-level solution-like files exist (e.g., `Calulator.slnx`, `Program.slnx`, `Static_class.slnx`, `Sum_of_nums.slnx`) but are nonstandard extension `.slnx` — treat them as informational; prefer building the individual `.csproj` files.

Important files and locations (examples)
- `Day1_Training/Calulator/Calulator.csproj` and `Day1_Training/Calulator/Calculator.cs` — simple calculator console app.
- `Day1_Training/Sum_of_nums/Sum_of_nums.csproj` and `Day1_Training/Sum_of_nums/Sum_of_nums.cs` — sums numbers; example of produce-and-run workflow (an executable `Sum_of_nums.exe` is expected in output).
- `Day4_Training/Static_class/Static_class.csproj` and `Day4_Training/Static_class/Static_class.cs` — demonstrates use of a static class pattern.

Build & run (practical commands)
- Build a single project: `dotnet build Day1_Training/Sum_of_nums/Sum_of_nums.csproj`
- Run a project: `dotnet run --project Day1_Training/Calulator/Calulator.csproj`
- If you see `.exe` outputs from prior runs, prefer `dotnet run` for reproducibility.

Project-specific conventions and patterns
- Projects are minimal console apps used for training exercises; expect single-file `Program`-style implementations with `Main()` entry points.
- Naming is inconsistent (e.g., `Calulator` vs `Calculator`) — be conservative when refactoring; preserve existing filenames and casing unless instructed.
- Some projects use static helper classes (see `Static_class/Static_class.cs`); prefer minimal, explicit changes when modifying these.

Testing & CI
- There are no automated tests or test projects in the repo. Do not invent test harnesses unless the user requests adding tests.

Common agent tasks and guidance
- When asked to implement or fix behavior, locate the single `.cs` file inside the appropriate folder under `Day*_Training` and edit there — projects are intentionally small.
- Avoid changing top-level `.slnx` files; they are informational and may be non-standard.
- Keep edits minimal and focused: change the `.cs` file and, if needed, the corresponding `.csproj` only when adding package references.
- If adding or changing code that affects runtime behavior, include exact `dotnet build` and `dotnet run --project <path>` commands to reproduce.

Integration & dependencies
- No external web services or packages are present by default. If adding NuGet dependencies, update the `.csproj` and show the `dotnet add package <pkg>` command used.

Examples to reference in PRs or suggestions
- To fix a console output bug in the sum example, modify `Day1_Training/Sum_of_nums/Sum_of_nums.cs` and demonstrate with:

```powershell
dotnet build Day1_Training/Sum_of_nums/Sum_of_nums.csproj
dotnet run --project Day1_Training/Sum_of_nums/Sum_of_nums.csproj
```

When to ask for clarification
- If a requested change spans multiple projects or renames files, ask the user before large refactors (naming inconsistencies are common).
- If a build fails due to environment (missing SDK, Windows vs non-Windows specifics), report the error and request permission to modify project files or add instructions.

If anything here is unclear or you'd like more examples (e.g., a preferred PR template or stricter coding conventions), tell me which area to expand.
