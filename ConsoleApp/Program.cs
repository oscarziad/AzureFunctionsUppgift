using System;
using Microsoft.Azure.Devices.Client;
using SharedLibraries.Services;

namespace ConsoleApp
{
    class Program
    {
        private static readonly string _conn = "HostName=ec-win20-iothub-oscar.azure-devices.net;DeviceId=consoleapp;SharedAccessKey=PhHHOn69OIQmjjmUQJyyiQEfq1teMYQBAQRBUODJZos=";
        private static readonly DeviceClient deviceClient = DeviceClient.CreateFromConnectionString(_conn, TransportType.Mqtt);
        static void Main(string[] args)
        {
            DeviceService.SendMessageAsync(deviceClient).GetAwaiter();
            DeviceService.ReceiveMessageAsync(deviceClient).GetAwaiter();
            Console.ReadKey();
        }
    }
}
