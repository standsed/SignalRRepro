using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;

namespace TestService
{
    public class TestHub: Hub
    {
        private readonly ILogger _logger;

        public TestHub(ILogger<TestHub> logger)
        {
            _logger = logger;
        }

        public override Task OnConnectedAsync()
        {
            _logger.Log(LogLevel.Information, "Connected");
            return Task.CompletedTask;
        }
    }
}