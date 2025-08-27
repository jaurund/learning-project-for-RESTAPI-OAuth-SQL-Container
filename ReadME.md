# Netflix REST API

This is my learning project for exploring REST APIs, SQL Server, and C#, and trying to host it all in a container using Docker desktop. 

---

## What does it do?

Connects to a SQL Server database and exposes the data as a JSON API.  
You can query titles, directors, cast, descriptions—if it's in the table, it's accessible.

---

## How do I use it?

```sh
git clone [URL]
dotnet restore
dotnet run
```

Open your browser at [http://localhost:5174/swagger](http://localhost:5174/swagger) for interactive docs.

---

## Endpoints

- `GET /MyTable` — All data, all at once.
- `GET /MyTable/title?title=Stranger Things` — Find a show by title.
- `GET /MyTable/director?director=John Doe` — Search by director.
- More endpoints? Add them in `MyTableController.cs`.

---

## Requirements

- .NET 9 SDK
- SQL Server with the NetflixDataset table (Will be added to the repository)
- I use VScode as the IDE to build the project. If you are inexperienced, I recommend you using the same if you want to clone the repo.

---
### NuGet Packages

These are automatically restored from the project file, but for reference:

- `Microsoft.AspNetCore.OpenApi`
- `Microsoft.EntityFrameworkCore.SqlServer`
- `Swashbuckle.AspNetCore`

### Recommended VS Code Extensions

- **C# Dev Kit** (for C# language support and debugging)
- **C#** (by Microsoft)
- **SQL Server (mssql)** (for connecting to and managing SQL Server databases)
- **REST Client** (for testing API endpoints directly in VS Code)
- **.NET Install Tool for Extension Authors** (helps with .NET SDK management)

## Contributing

Open a pull request, file an issue, or fork away.  
This API is built to be extended, and not only by me.
I will be very happy if I see forks with comments to help me learn and improve as a developer.

---