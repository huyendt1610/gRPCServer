using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gRPCServer
{
    public class PopulationService: PopulationProvider.PopulationProviderBase //Grpc.Tools will generate from protobuf to c# code
    {
        public override Task<PopulationResponse> GetPopulation(PopulationRequest request, ServerCallContext context) {
            return Task.FromResult(new PopulationResponse() { Count = "2000" });
        }
    }
}
