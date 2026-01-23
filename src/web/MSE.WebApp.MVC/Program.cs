using MSE.WebApp.MVC.Configuration;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddIdentityConfiguration(builder.Configuration);
builder.Services.AddMvcConfiguration(builder.Configuration);
builder.Services.RegisterServices();

var app = builder.Build();

app.UseMvcConfiguration(app.Environment);
app.Run();
