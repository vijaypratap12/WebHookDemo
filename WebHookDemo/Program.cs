using WebHookDemo;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

//Listen for POST webhooks
app.MapPost("/webhook", async (HttpContext context, IWebHookRepo receiveWebook) =>//, IHubContext<WebSocketHub> hubContext) =>
{
    using StreamReader stream = new StreamReader(context.Request.Body);
    return await receiveWebook.UpdateTransactionStatus(await stream.ReadToEndAsync(), context);//, hubContext);
});


app.Run();
