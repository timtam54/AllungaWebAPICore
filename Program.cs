using AllungaWebAPI.Data;
using AllungaWebAPI.Endpoints;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "MyPolicy",
                      policy =>
                      {
                          policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
                      });
});
builder.Services.AddDbContext<dbcontext>(options => options.UseSqlServer("Server=tcp:allunga.database.windows.net,1433;Initial Catalog=AllungaDB;Persist Security Info=False;User ID=AllungaDB;Password=ABC1234!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();
app.UseCors("MyPolicy");
app.MapReportsPerDayEndpoints();
app.MapReportsParamEndpoints();
app.MapParmReportsEndpoints();
app.MapSampleParamReportsEndpoints();
app.MapParamSampleReportsEPEndpoints();
app.MapScheduleActualEPEndpoints();
app.MapScheduleProjectedEPEndpoints();
app.Run();

internal record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
