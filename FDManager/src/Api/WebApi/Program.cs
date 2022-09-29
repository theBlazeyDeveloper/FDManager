using WebApi.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();
builder.Services.AddDataServices(opts => 
{
    var mongoDbConfig = builder.Configuration.GetSection("mongoDB");

    opts.DatabaseName = mongoDbConfig.GetValue<string>("databasename");
    opts.ConnectionString = mongoDbConfig.GetValue<string>("connectionstring");
});

builder.Services.AddBingMaps(opts => 
{
    opts.IsDevelopment = true;
});

builder.Services.AddCors(opts => 
{
    opts.AddPolicy("api", policy => 
    {
        policy
        .AllowAnyHeader()
        .AllowAnyMethod()
        .WithOrigins("https://localhost:7237");
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.CheckDBConnection();

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors("api");

app.MapControllers();

app.Run();