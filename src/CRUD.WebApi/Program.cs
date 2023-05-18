using CRUD.Dependency;

// cors policy name
const string corsPolicyName = "CorsPolicy";

// builder
var builder = WebApplication.CreateBuilder(args);

// builder services
var services = builder.Services;

// Add services to the container.

#region Add services

// application services
services.AddApplicationServices();

// auto mapper
services.AddAutoMapper();

// controllers
services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
services.AddEndpointsApiExplorer();

// swagger
services.AddSwaggerGen();

// cors
services.AddCors(options =>
{
    options.AddPolicy(corsPolicyName,
        b => b.AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader());
});

#endregion

// app
var app = builder.Build();

#region App

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// https redirection
app.UseHttpsRedirection();

// authorization
app.UseAuthorization();

// cors
app.UseCors(corsPolicyName);

// map controllers
app.MapControllers();

// run
app.Run();

#endregion


