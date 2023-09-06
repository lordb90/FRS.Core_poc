using FRS.Core.Application.Services;
using FRS.Core.Domain.Interfaces;
using FRS.Core.Infrastructure.DataAccess;
using FRS.Core.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<IEnterpriseDbContext, FrsEnterpriseContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Enterprise")));

builder.Services.AddControllers();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddScoped<ILpmasterService, LpmasterService>();
builder.Services.AddScoped<ILpmasterRepository, LpmasterRepository>();

builder.WebHost.UseIISIntegration();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c => 
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title ="FRS Enterprise Api", Version = "v1"});
});

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
    app.UseSwagger();
    app.UseSwaggerUI();
//}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
