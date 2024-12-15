var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// GET -> return Hello World 
app.MapGet("/helloworld", () => "Hello World!");

app.Run();
