
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Serilog;
using SportNewspaper_Infra.ReposImplemantation;
using SportNewspaper_Infra.ServiceImplemantation;
using SportNewspeper_core.Context;
using SportNewspeper_core.IRepo;
using SportNewspeper_core.IService;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "Sport Newspaper",
        Contact = new OpenApiContact
        {
            Name = "Hamza Alabsi",
            Email = "hamzaalabsi@gmail.com",
          

        },
    }) ;

   
    var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
});

builder.Services.AddDbContext<SportNewspaperDbContext>(x=>x.UseSqlServer(builder.Configuration.GetValue<string>("ConnectionStrings")));
builder.Services.AddScoped<ISharedReposInterface, SharedRepos>();
builder.Services.AddScoped<ISharedServiceInterface, SharedService>();
builder.Services.AddScoped<IAdminReposInterface, AdminRepos>();
builder.Services.AddScoped<IAdminServiceInterface, AdminService>();
builder.Services.AddScoped<IUserReposInterface, UserRepos>();
builder.Services.AddScoped<IUserServiceInterface, UserService>();
Log.Logger = new LoggerConfiguration()
    .WriteTo.File("C:\\Users\\HAMZA\\Desktop\\dd\\loging.txt")
    .CreateLogger();

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
