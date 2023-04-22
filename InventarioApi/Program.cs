using Microsoft.EntityFrameworkCore;
using InventarioApi.Models;
using InventarioApi.Context;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<InventoryContext>(options =>
    options.UseSqlServer(builder.Configuration["ConnectionStrings:InventoryContext"]));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "Invenario API",
        Description = "An ASP.NET Core Web API for managing ToDo items",
        TermsOfService = new Uri("http://54.147.58.168"),
        Contact = new OpenApiContact
        {
            Name = "Producto",
            Url = new Uri("http://54.147.58.168/api/producto")
        },
        License = new OpenApiLicense
        {
            Name = "Example License",
            Url = new Uri("http://54.147.58.168/api/producto")
        }
    });

    
});




var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
    options.RoutePrefix = string.Empty;
});


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

