using Grpc.Net.Client;
using System;

namespace gRPCClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001/");
            var client = new PopulationProvider.PopulationProviderClient(channel);

            Console.WriteLine(client.GetPopulation( new PopulationRequest { State = "NY"}));
            Console.ReadLine();
        }
    }
}
