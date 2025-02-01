using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlite("Data Source=produtos.db"));
var app = builder.Build();

app.UseExceptionHandler("/error");

app.MapGet("/produtos", async (AppDbContext db) => await db.Produtos.ToListAsync());

app.MapPost("/produtos", async (AppDbContext db, Produto produto) =>
{
    if (produto == null) return Results.BadRequest();

    await db.Produtos.AddAsync(produto);
    await db.SaveChangesAsync();
    return Results.Created($"/produtos/{produto.Id}", produto);
});

app.MapPut("/produtos/{id}", async (AppDbContext db, int id, Produto produtoAtualizado) =>
{
    var produto = await db.Produtos.FindAsync(id);
    if (produto == null) return Results.NotFound();

    produto.Nome = produtoAtualizado.Nome;
    produto.Preco = produtoAtualizado.Preco;
    await db.SaveChangesAsync();
    return Results.Ok(produto);
});

app.MapDelete("/produtos/{id}", async (AppDbContext db, int id) =>
{
    var produto = await db.Produtos.FindAsync(id);
    if (produto == null) return Results.NotFound();

    db.Produtos.Remove(produto);
    await db.SaveChangesAsync();
    return Results.NoContent();
});

app.Run();

public class Produto 
{ 
    public int Id { get; set; } 
    public string Nome { get; set; } 
    public decimal Preco { get; set; } 
}

public class AppDbContext : DbContext 
{ 
    public DbSet<Produto> Produtos { get; set; } 
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { } 
}
