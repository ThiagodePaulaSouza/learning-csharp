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

// FIXME: System.InvalidOperationException: The instance of entity type 'Fornecedor' cannot be tracked because another instance with the same key value for {'Id'} is already being tracked. When attaching existing entities, ensure that only one entity instance with a given key value is attached. Consider using 'DbContextOptionsBuilder.EnableSensitiveDataLogging' to see the conflicting key values.
app.MapPut("fornecedor/{fornecedorId}", async (Guid fornecedorId, MinimalContextDb context, Fornecedor fornecedor) =>
{
    var target = await context.Fornecedores.FindAsync(fornecedorId);
    if (target == null) return Results.NotFound();

    // Fazer validações do fornecedor
    context.Fornecedores.Update(fornecedor);
    var result = await context.SaveChangesAsync();

    return result > 0
        ? Results.NoContent()
        : Results.BadRequest();
}
)
.Produces<Fornecedor>(StatusCodes.Status204NoContent)
.Produces(StatusCodes.Status400BadRequest)
.WithName("PutFornecedor")
.WithTags("Fornecedor");

app.MapDelete("fornecedor/{fornecedorId}", async (Guid fornecedorId, MinimalContextDb context) =>
{
    var target = await context.Fornecedores.FindAsync(fornecedorId);
    if (target == null) return Results.NotFound();

    // Fazer validações do fornecedor
    context.Fornecedores.Remove(target);
    var result = await context.SaveChangesAsync();

    return result > 0
        ? Results.NoContent()
        : Results.BadRequest();
}
)
.Produces<Fornecedor>(StatusCodes.Status204NoContent)
.Produces(StatusCodes.Status400BadRequest)
.WithName("DeleteFornecedor")
.WithTags("Fornecedor");

app.Run();
