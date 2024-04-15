namespace WebHookDemo
{
    public interface IWebHookRepo
    {
        public Task<int> UpdateTransactionStatus(string root, HttpContext httpContext);//, IHubContext<WebSocketHub> hubContext);
    }
}
