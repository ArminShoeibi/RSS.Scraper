using RSS.Scraper.API.BackgroundServices;
using RSS.Scraper.API.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<RssFeedsService>();

builder.Services.AddHostedService<RssUpdaterBackgroundService>();
var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();
app.UseAuthorization();

app.MapControllers();

await app.RunAsync();
