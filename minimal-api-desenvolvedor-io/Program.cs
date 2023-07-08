using Microsoft.EntityFrameworkCore;
using minimal_api_desenvolvedor_io.Data;

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

app.MapGet("/", async (MinimalContextDb context) =>
    await context.Fornecedores.ToListAsync()
)
.WithName("GetTodosFornecedores")
.WithTags("Fornecedor");

app.Run();
