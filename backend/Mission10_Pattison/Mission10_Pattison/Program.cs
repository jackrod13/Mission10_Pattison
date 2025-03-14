using Mission10_Pattison.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// ✅ Register the database context
builder.Services.AddDbContext<BowlerDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("BowlingConnection"))
);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// ✅ Set CORS to allow requests from React frontend (localhost:3000)
app.UseCors(x => x.WithOrigins("http://localhost:3000").AllowAnyMethod().AllowAnyHeader());

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
