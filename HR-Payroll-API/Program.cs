using dotNetWithMySqlAPI.MappingProfiles;
using HR_Payroll_API.Entities;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<HrPayrollContext>(opt => 
                                        opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

//Automapper 
builder.Services.AddAutoMapper(typeof(MappingProfile));

// enable cors
builder.Services.AddCors(p=>p.AddPolicy("corspolicy", build=>
{
    build.WithOrigins("http://localhost:5173").AllowAnyMethod().AllowAnyHeader();
}));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// enable cors
app.UseCors("corspolicy");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
