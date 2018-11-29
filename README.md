# Introduction

This LibraryApp demo application is based upon [ASP.NET Boilerplate](https://aspnetboilerplate.com/Pages/Documents)

Steps:

1. ..\LibraryApp\src\LibraryApp.Web.Host> `npm install`
2. Set connectionstring in appsettings.json file (add Database to Server Instance)
3. Run LibraryApp.Migrator project to update database
4. Add Models Folder to LibraryApp.Application project
5. Add Class Book/Author/Category (inherit FullAuditedEntity)
6. ..\LibraryApp\src\LibraryApp.EntityFrameworkCore> `dotnet ef migrations add book-author-category`
7. ..\LibraryApp\src\LibraryApp.EntityFrameworkCore> `dotnet ef database update`
