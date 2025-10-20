# UnityInfotech Corporate Training Lab<<<<<<< HEAD

# unityinfotech-STAGE

This is an ASP.NET Core MVC website for the UnityInfotech corporate training lab in Kochi.=======

# unityinfotech kochi — Local site

## Prerequisites

This folder contains a single-file demo website for the corporate training lab.

- .NET 8.0 SDK

- Visual Studio 2022 or VS Code with C# extensionTo open the page locally (Windows PowerShell):



## Project Structure```powershell

Start-Process "index.html"

``````

UnityInfotech.Web/

├── Controllers/         # MVC ControllersOr open your browser and load the file `Unityinfotech/index.html` from this repository.

├── Views/              # Razor Views

│   ├── Home/          # Home controller viewsUpdate contact details, logos, and copy as needed.

│   └── Shared/        # Shared layouts and partials

├── wwwroot/           # Static files (CSS, JS, images)Enjoy!

└── Program.cs         # Application entry point>>>>>>> b055f5bd2788f5abc402f01687110190711dd008

```

## Building and Running

From the repository root:

```powershell
cd UnityInfotech.Web
dotnet build
dotnet run
```

The site will be available at:
- http://localhost:5000
- https://localhost:5001

## Development

To run in watch mode with auto-reload:

```powershell
dotnet watch run
```

## Publishing

To create a production build:

```powershell
dotnet publish -c Release
```

The published files will be in `bin/Release/net8.0/publish/`.