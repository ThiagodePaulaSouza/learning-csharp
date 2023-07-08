using Microsoft.EntityFrameworkCore;
using minimal_api_desenvolvedor_io.Data;
using minimal_api_desenvolvedor_io.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(x => x.EnableAnnotations());

builder.Services.AddDbContext<MinimalContextDb>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
);

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();

app.MapGet("/fornecedores", async (MinimalContextDb context) =>
    await context.Fornecedores.ToListAsync()
)
.WithName("GetTodosFornecedores")
.WithTags("Fornecedor");

app.MapGet("/fornecedores/{id}", async (Guid id, MinimalContextDb context) =>
    await context.Fornecedores.FindAsync(id)
        is Fornecedor fornecedor
            ? Results.Ok(fornecedor)
            : Results.NotFound()
)
.Produces<Fornecedor>(StatusCodes.Status200OK)
.Produces(StatusCodes.Status404NotFound)
.WithName("GetFornecedoresPorId")
.WithTags("Fornecedor");

app.MapPost("/fornecedores", async (MinimalContextDb context, Fornecedor fornecedor) =>
{
    // Fazer validações do fornecedor
    context.Fornecedores.Add(fornecedor);
    var result = await context.SaveChangesAsync();

    return result > 0
        ? Results.Created($"/fornecedor/{fornecedor.Id}", fornecedor)
        : Results.BadRequest();
}
)
.Produces<Fornecedor>(StatusCodes.Status201Created)
.Produces(StatusCodes.Status400BadRequest)
.WithName("PostFornecedor")
.WithTags("Fornecedor");

app.Run();
