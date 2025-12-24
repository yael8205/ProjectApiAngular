using System.Text.Json.Serialization;
using lotteryApi.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<LotteryDBContext>(options =>
options.UseSqlServer("Server=DESKTOP-PKVNNGR;Database=LotteryDB;Integrated Security=SSPI;Persist Security Info=False;TrustServerCertificate=True;"));

//options.UseSqlServer("Server=Srv2\\pupils;Database=LotteryDB;Integrated Security=SSPI;Persist Security Info=False;TrustServerCertificate=True;"));

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
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
