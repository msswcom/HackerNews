# Hacker News API with local database

## Solution

To improve performance when accessing best stories on Hacker News API, local database is created.

Best stories are read from the local database and remote Hacker News API is accessed and data is stored only for stories that are not already in the database when requested by user.

Additionally, because stories might change, a background job which runs every hour is created which updates best stories and stores stories from the remote API if they are not in the database.

This significantly improves the performance, by the time the user accesses best stories most of them are already in the database. This also ensures the stories in the database are up to date.

Best stories are available on

```
/best-stories/{n}
```

where n is the number of stories to get.

Open API front end is available to try API in development environment.

## Setup

To add database connection string to User Secrets, right click HackerNews.API project in Visual Studio and select Manage User Secrets.

Database connection string should look like the following

```
{
    "HackerNews": "server=secret;database=HackerNews;user id=secret;password=secret;MultipleActiveResultSets=true;TrustServerCertificate=true;"
}
```

To create database, start Package Manager Console from Visual Studio Tools menu NuGet Package Manager, select HackerNews.Database as Default project in Package Manager Console and enter

```
Update-Database
```

This will create local database using the connection string provided.

## Projects

### HackerNews.API

This is the entrance point which routes requests to HackerNews.Orchestration. It also hosts background service to update best stories in the database.

### HackerNews.Database

The project provides database operations to read and write to database using Entity Framework Core.

### HackerNews.Integration

The project provides HTTP operations to get data from remote Hacker News API.

### HackerNews.Models

The project provides models for database and remote API, converters and validations.

### HackerNews.Orchestration

The project orchestrates database and remote API operations.

### Swagger

The project provides Open API front end.