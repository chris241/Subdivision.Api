using Microsoft.EntityFrameworkCore;
using Subdivision.Api.Middlewares;
using Subdivision.Api.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers(o =>
{
    o.Conventions.Add(
        new C_Route(
                "version",
                c => c.ControllerType.Namespace != null ?
                                    c.ControllerType.Namespace?.Split('.').Length >= 4 ? c.ControllerType.Namespace?.Split('.')[3] + c.ControllerType.Namespace?.Split('.')[4]
                                    : c.ControllerType.Namespace?.Split('.').Last()
                                    : "_0_0"
            )
        );
    o.Conventions.Add(
        new C_Route(
                "feature",
                c => c.ControllerType.Namespace != null ?
                                    c.ControllerType.Namespace?.Split('.').Length >= 5 ? c.ControllerType.Namespace?.Split('.')[5]
                                    : c.ControllerType.Namespace?.Split('.').Last()
                : "_undefined"
    )
        );
}).AddJsonOptions(options =>
{
    options.JsonSerializerOptions.PropertyNamingPolicy = null;
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<SubdivisionDbContext>(options =>
{
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
