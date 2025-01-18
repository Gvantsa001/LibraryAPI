This is a simple RESTful Web API for a bookstore built with ASP.NET Core
. It allows clients to perform CRUD operations on books and authors. The API uses Entity Framework Core for ORM and connects to a SQL Server database.

- **Books Management**: 
  - Add, update, retrieve, and delete books.
  - Each book has a title, year of publication, and author.

- **Authors Management**: 
  - Add, retrieve, and update authors.
  - Each author has a list of books.

- **Swagger Documentation**: The API is well-documented using Swagger, providing interactive API documentation for testing the endpoints.

## Technologies Used

- ASP.NET Core
- Entity Framework Core
- SQL Server
- Swagger UI
- C#


## Setup
1. Clone the repository.
2. Run `dotnet restore`.
3. Configure the connection string in `appsettings.json`.
4. Run `dotnet ef database update`.
5. Start the project: `dotnet run`.appsettings.json
API Endpoints

##Books Endpoints

GET /api/books: Get a list of all books.

GET /api/books/{id}: Get a specific book by ID.

POST /api/books: Create a new book.

PUT /api/books/{id}: Update an existing book.

DELETE /api/books/{id}: Delete a book.

##Authors Endpoints

GET /api/authors/{id}: Get a specific author by ID.

POST /api/authors: Create a new author.

PUT /api/authors/{id}: Update an existing author.
