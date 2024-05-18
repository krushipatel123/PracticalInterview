using ApplicationForm;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
var myAllowSpecificOrigins = "_myAllowSpecificOrigins";


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var startup = new Startup(builder.Configuration);
startup.ConfigureServices(builder.Services);


builder.Services.AddCors(options =>
options.AddPolicy(name: myAllowSpecificOrigins, builder =>
builder.WithOrigins("http://localhost:4200").AllowAnyMethod().AllowAnyHeader()
)
);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
  
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseCors(myAllowSpecificOrigins);
app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
