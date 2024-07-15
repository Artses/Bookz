using Crud.Api.Context;
using Crud.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Crud.Api.Books
{
    public static class BooksRoutes
    {
        public static void AddBooks(this WebApplication app)
        {
        //Create
            var routesBooks = app.MapGroup("Books");

            routesBooks.MapPost("", ([FromBody] AddBookRequest request, CrudContext context) =>
            {
                var newBook = new Book(request.Title, request.Desc, request.Author);
                context.Books.Add(newBook);
                context.SaveChanges();
            });
        }
        //Select
        public static void SelectBooks(this WebApplication app) 
        {
            var routesBooks = app.MapGroup("Books");

            routesBooks.MapGet("", () =>
            {
                CrudContext context = new CrudContext();
                var books = context.Books.ToList();
                return books;
            });
        }
        //Update
        public static void UpdateBooks(this WebApplication app) 
        {
            var routesBooks = app.MapGroup("Books");

            routesBooks.MapPut("{id}", (Guid id ,[FromBody] UpdateBookRequest request, CrudContext context) => 
            {
                var updateBooks = context.Books.SingleOrDefault(book => book.Id == id);

                if(updateBooks == null)
                    return Results.NotFound();
                
                updateBooks.UpdateBook(request.Title,request.Desc, request.Author);
                context.SaveChanges();
                return Results.Ok(updateBooks);
            });
        }
        //Delete
        public static void DeleteBooks(this WebApplication app)
        {
            var routesBooks = app.MapGroup("Books");

            routesBooks.MapDelete("{id}", (Guid id,CrudContext context) =>
            {
                var deleteBooks = context.Books.SingleOrDefault(book => book.Id == id);

                if (deleteBooks == null)
                    return Results.NotFound();

                var books = context.Books.Remove(deleteBooks);
                context.SaveChanges();
                return Results.Ok(books);
            });
        }
    }
}
