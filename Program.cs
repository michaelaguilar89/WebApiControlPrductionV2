using Microsoft.EntityFrameworkCore;
using WebApi_Control_Production.Connection;
using WebApi_Control_Production.Repository_s;

var builder = WebApplication.CreateBuilder(args);

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
builder.Services.AddCors(options =>
{
	options.AddPolicy(MyAllowSpecificOrigins,
						  policy =>
						  {
							  policy.WithOrigins("*")
												  .AllowAnyHeader()
												  .AllowAnyMethod();
						  });
});


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IProductionRepositorio, ProductionRepository>();
//esta linea me permite utilizar Interface y Repository


builder.Services.AddDbContext <ApplicationDbContext>(options =>{//we use dependecy injection
																//i reference to defaultConnection string

	options.UseSqlServer(
		builder.Configuration.GetConnectionString("defaultConnection"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors(MyAllowSpecificOrigins);
app.UseAuthorization();

app.MapControllers();

app.Run();
