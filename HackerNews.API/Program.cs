using HackerNews.API;
using Swagger;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;

services.AddAPI();
services.AddControllers();
services.AddSwagger();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
