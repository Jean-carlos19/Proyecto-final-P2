using MiPrimerAPI.Controllers.Repositories;
using MiPrimerAPI.Controllers.servicio;
using MiPrimerAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddHttpClient<ExternalApiService>();
builder.Services.AddControllers();


builder.Services.AddHttpClient<ExternalApiService>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();


var app = builder.Build();


//builder.Services.AddScoped < IProductRepository<ProductRepository>();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{

    app.UseSwagger();
    app.UseSwaggerUI();

    //Este no di error
    builder.Services.AddScoped<ProductService>();

}

app.UseHttpsRedirection();


app.UseAuthorization();


app.MapControllers();

app.Run();


