using App.Infrastructure;
using App.Infrastructure.Repository;
using App.Application.Service;
using App.Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using App.Application.DTO;
using App.Application.Validators;
using FluentValidation;

var builder = WebApplication.CreateBuilder(args);

// MongoDB Configuration
builder.Services.AddSingleton<AppDbContext>();

// MongoDB bind settings
builder.Services.Configure<MongoSettings>(
    builder.Configuration.GetSection("ConnectionStrings"));

// DbContext Configuration
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Register Services
builder.Services.AddScoped<ISignUpService, SignUpService>();
builder.Services.AddScoped<ILoginService, LoginService>();

// Register Repositories
// Register Repositories with Scoped lifetime
builder.Services.AddScoped<ISignUpRepository, SignUpRepository>();
builder.Services.AddScoped<ILoginRepository, LoginRepository>();


// Add other services (e.g., controllers, Swagger, etc.)
builder.Services.AddControllers();
builder.Services.AddSwaggerGen();

//validators 
builder.Services.AddScoped<IValidator<SignUpDTO>, SignUpValidator>();
builder.Services.AddScoped<IValidator<LoginDTO>, LoginValidator>();

// Add CORS policy
builder.Services.AddCors(options =>
{
    options.AddPolicy("MyPolicy", policyBuilder =>
    {
        policyBuilder
            .SetIsOriginAllowed(origin => true)
            .AllowAnyMethod()
            .AllowAnyHeader()
            .AllowCredentials();
    });
});

var app = builder.Build();

// Enable Swagger in development environment
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Middleware for routing, etc.
app.UseRouting();

// Enable CORS globally (if required)
app.UseCors("MyPolicy");

app.MapControllers();

app.Run();
