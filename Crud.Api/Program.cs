using Crud.Api.Books;
using Crud.Api.Context;
using System.Text.Json.Serialization;


var builder = WebApplication.CreateBuilder(args);



// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();                                    
builder.Services.AddScoped<CrudContext>();
builder.Services.Configure<Microsoft.AspNetCore.Http.Json.JsonOptions>(options => options.SerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();

//add
app.AddBooks();
//select
app.SelectBooks();
//update
app.UpdateBooks();
//delete
app.DeleteBooks();

app.Run();
