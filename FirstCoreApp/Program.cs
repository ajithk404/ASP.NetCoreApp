var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", async (HttpContext context) =>
//{
//    context.Response.StatusCode = StatusCodes.Status200OK;
//    await context.Response.WriteAsync("You are in Home page");
//});

app.Run( async (HttpContext context) =>
{
    string path = context.Request.Path;
    if(path == "/Home")
    {
        context.Response.StatusCode = StatusCodes.Status200OK;
        await context.Response.WriteAsync("You are in Home Page");
    }
    else if(path == "/Contact")
    {
        context.Response.StatusCode = StatusCodes.Status200OK;
        await context.Response.WriteAsync("You are in Contact Page");
    }
    else
    {
        context.Response.StatusCode = StatusCodes.Status404NotFound;
        await context.Response.WriteAsync("This page is not found");
    }

});

app.Run();
