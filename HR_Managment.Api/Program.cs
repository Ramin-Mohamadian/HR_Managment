using HR_Management.Application;
using HR_Managment.Infrastructure;
using HR_Managment.Persistence;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


#region Config Registration
builder.Services.ConfigureApplicationService();
builder.Services.ConfigureInfrastructureService(builder.Configuration);
builder.Services.ConfigurationPersistenceService(builder.Configuration);
#endregion


builder.Services.AddCors(o =>
{
    o.AddPolicy("corsepolicy", b =>
        b.AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader());
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
app.UseCors("corsepolicy");
app.MapControllers();

app.Run();
