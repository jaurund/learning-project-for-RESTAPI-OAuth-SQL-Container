# Netflix REST API

This is my learning project for exploring REST APIs, SQL Server, and C#, and trying to host it all in a container using Docker desktop.

---

## What does it do?

Connects to a SQL Server database and exposes the data as a JSON API. The current code uses the provided .csv and .sql script with the database hosted locally by an SQL manager, but the code can easily be changed to run with other databases.
You can query titles, directors, cast, descriptions and so on through the frontend — if it's in the table and has a controller, it's accessible.

---

## How do I use it?

```sh
git clone [URL]
dotnet restore
dotnet run
```

Open your browser at [http://localhost:5174/swagger](http://localhost:5174/swagger) for interactive docs.

---

## Setting up the Database

1. **Create the database:**
   - Open SSMS (or your preferred SQL client).
   - Right-click "Databases" > "New Database..." and name it `csvNetflixDB`.
   - Click OK to create the database.

2. **Create the table:**
   - Select the new `csvNetflixDB` database.
   - Open the provided `CreateTable.sql` script in the `Database/SQLscripts/` folder.
   - Run the script to create the `NetflixDataset` table.

3. **Import the CSV data:**
   - In SSMS, right-click the `csvNetflixDB` database and choose "Tasks" > "Import Data".
   - Select the `Netflix Dataset.csv` file as the source from the `Database/` folder in this project.
   - Map columns as needed and complete the wizard.

   *Alternatively, use a `BULK INSERT` command:*
   ```sql
   BULK INSERT dbo.NetflixDataset
   FROM 'C:\Path\To\Netflix Dataset.csv'
   WITH (
       FIRSTROW = 2,
       FIELDTERMINATOR = ',',
       ROWTERMINATOR = '\n',
       TEXTQUALIFIER = '"'
   );
   ```
> **Note:** If your SQL Server instance name or authentication differs, update the connection string in `appsettings.json` accordingly.

---

## Using the Frontend

Start the backend API by running:
```sh
dotnet run
```
in the integrated terminal.

Then, open `frontend/index.html` in your browser.

Use the search forms to query the database by title, director, or cast.  
Results will be displayed on the page in JSON format.

> Make sure the backend is running before using the frontend.

---

## Endpoints

- `GET /MyTable` — All data, all at once.
- `GET /MyTable/title?title=Stranger Things` — Find a show by title.
- `GET /MyTable/director?director=John Doe` — Search by director.
- More endpoints? Add them in `src/Controllers/MyTableController.cs`.

---

## Requirements

- .NET 9 SDK
- The database itself (.csv and .sql-script to import it is included in the repository)
- A program to host the SQL DataBase locally, like Microsoft SQL Server Management Studio (SSMS) or PostgreSQL
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



