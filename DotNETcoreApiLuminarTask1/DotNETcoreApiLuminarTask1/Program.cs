//var builder = WebApplication.CreateBuilder(args);
//// Add services to the container.
//builder.Services.AddControllers();

//var MyAllowSpecificOrgins = "_myAllowSpecificOrigins";

//builder.Services.AddCors(options =>
//{
//    options.AddPolicy(name: MyAllowSpecificOrgins,
//        builder =>
//        {
//            builder.WithOrigins("http://localhost:5132", "*", "*");
//        });

//});



//// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

//var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

//app.UseAuthorization();

//app.MapControllers();

//app.Run();






//---------------------------------------------Test------------------------------------------------


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

// Configure CORS properly
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
        policy =>
        {
            policy.WithOrigins("http://localhost:5132")
                  .AllowAnyHeader()
                  .AllowAnyMethod();
        });
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Use Swagger in development
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Use CORS - this was missing
app.UseCors(MyAllowSpecificOrigins);

app.UseAuthorization();

app.MapControllers();

app.Run();
