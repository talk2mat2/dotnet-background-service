
using Microsoft.Extensions.Hosting;
namespace backgroundapp;

class MynackgroundTask:BackgroundService
{

 protected override Task ExecuteAsync(CancellationToken stoppingToken)
{
    Console.WriteLine("from my background");
    return Task.CompletedTask;
//  throw new NotImplementedException();
}

}