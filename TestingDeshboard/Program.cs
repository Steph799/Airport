using System;
using System.Linq;
using System.Threading;
using FinalProjectServer.Models;
using Microsoft.AspNetCore.SignalR.Client;

namespace TestingDeshboard
{
    class Program
    {
        static void Main(string[] args)
        {
            var connection = new HubConnectionBuilder().WithUrl("http://localhost:27397/notifications")
                .WithAutomaticReconnect(Enumerable.Repeat(TimeSpan.FromSeconds(5), 4)
                .ToArray()).Build();

            connection.On<AirportImage>("ReceiveAirportImage", a => {
                Console.Clear();
                ConsoleTables.ConsoleTable.From(a.Processes).Write();
                Console.WriteLine($"\t\t\t{a.ImageTime}");//
            });
            connection.StartAsync();
            while (true)
            {
                if(connection.State!= HubConnectionState.Connected)
                {
                    Console.Clear();
                    Console.WriteLine("not connected");
                }                 
            }
        }
    }
}
