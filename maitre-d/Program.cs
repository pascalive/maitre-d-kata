using maitre_d.service;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IMaitreDService, MaitreDService>();
builder.Services.AddMvc();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapDefaultControllerRoute();
});

app.Run();
