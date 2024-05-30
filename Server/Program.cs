using RL.Application.Implements;
using RL.Application.Interfaces;
using RL.Data.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers(option => option.SuppressImplicitRequiredAttributeForNonNullableReferenceTypes = true);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));

builder.Services.AddTransient<IUserServerService, UserServerService>();
builder.Services.AddTransient<ILotteryServerService, LotteryServerService>();

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
