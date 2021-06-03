This project requires uses paket for dependencies.

```
dotnet new tool-manifest
dotnet tool install paket
dotnet tool restore
```

To install dependencies:

```
dotnet paket install
```

*TODO: Move this into a script ^*

Build and run the CLI (using PowerShell 7):
```
./.build/build.ps1
dotnet $createapp
```