# PostClassDeterminer

PostClassDeterminer is a Windows Forms application for analyzing Boolean functions and determining their place in Post's classification lattice. The program accepts a binary input string (containing only `0` and `1`) and checks whether it represents a valid Boolean function of size $2^n$, then computes the reduced function and identifies the narrowest Post class to which it belongs.

## What it does

The application:

- Validates that the input consists only of `0` and `1`
- Ensures the input length is a power of two
- Converts the binary sequence into a Boolean function representation
- Reduces redundant variables when possible
- Evaluates classic Post-class properties such as:
  - T0 / T1
  - S
  - L
  - M
- Reports the narrowest class in the Post lattice and execution time

This project is intended for exploring Boolean function classification and theoretical algebraic properties in a simple desktop interface.

## Requirements

- Windows operating system
- .NET 6 SDK
- Visual Studio 2022 or later (recommended)
- .NET desktop development workload

## How to run

### Using Visual Studio

1. Open `PostClassDeterminer.sln`.
2. Restore NuGet packages if prompted.
3. Set the solution configuration to `Debug` or `Release`.
4. Press `F5` to run the application.

### Using the .NET CLI

From the repository root, run:

```bash
dotnet build PostClassDeterminer.sln
```

To run the project directly on Windows:

```bash
dotnet run --project .\PostClassDeterminer\PostClassDeterminer.csproj
```

## Example input

A valid input is any binary string whose length is a power of two, for example:

```text
0101
```

This is a valid length-4 function and will be evaluated for its Post-class properties.

## Project structure

```text
PostClassDeterminer/
├── BooleanFunction.cs        # Core Boolean function classification logic
├── FormPostClassDeterminer.cs # WinForms UI and event handling
├── FuncLib.cs                # Common helper methods
├── PostLattice.cs            # Post lattice implementation
├── Program.cs                # Application entry point
├── PostClassDeterminer.csproj # .NET project definition
├── Properties/               # WinForms resources and generated metadata
├── templatePostLattice.txt   # Reference lattice data
└── bin/ / obj/              # Build output and generated files
```

## Notes

- The project targets `net6.0-windows` and uses Windows Forms, so it is intended for Windows development and execution.
- The application is a research/educational tool rather than a general-purpose Boolean logic library.

## License

This project does not currently include a formal license file. If you plan to reuse or distribute it, confirm the licensing terms with the repository owner before publication or commercial use.
