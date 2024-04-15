using System.Data;

namespace WebHookDemo
{
    public class WebHookRepo
    {
        public async Task<int> UpdateTransactionStatus(string root, HttpContext httpContext)//, IHubContext<WebSocketHub> hubContext)
        {
            int result = 0;
            string headerSigningKey = string.Empty;
            string signingKey = string.Empty;

            //This is where you would put your actual business logic for receiving webhooks
            try
            {
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
    }
}
