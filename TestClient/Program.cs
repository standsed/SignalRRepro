using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.Connections;
using Microsoft.AspNetCore.SignalR.Client;

namespace TestClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var connection = new HubConnectionBuilder()
                .WithUrl("http://localhost:8080/test", options =>
                {
                    options.Transports = HttpTransportType.WebSockets;
                })
                .Build();
            await connection.StartAsync();
            Console.WriteLine("Connected");
            Console.ReadKey();
            await connection.DisposeAsync();
        }
    }
}