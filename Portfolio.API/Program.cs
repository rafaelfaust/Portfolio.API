using Microsoft.EntityFrameworkCore;
using Portfolio.API;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSqlServer<PortfolioContext>(builder.Configuration.GetConnectionString("ServerConnection"));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors();

var app = builder.Build();


app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();
app.UseCors( p => p
    .AllowAnyHeader()
    .AllowAnyOrigin()
    .AllowAnyMethod());

app.MapPost("/contacts", async (PortfolioContext context, Contact contact) =>
{
    await context.Contacts.AddAsync(contact);
    await context.SaveChangesAsync();

    return Results.Ok(contact);
})
.WithOpenApi();

app.MapGet("/contacts", async (PortfolioContext context) =>
{
    var contacts = await context.Contacts.ToListAsync();

    return Results.Ok(contacts);
})
.WithOpenApi();

app.Run();

public class Contact
{
    public Guid Id { get; set; } 
    public string name { get; set; }
    public string Email { get; set; }
    public string Subject { get; set; }
    public string Message { get; set; }

    public DateTime Date { get; set; }
}
