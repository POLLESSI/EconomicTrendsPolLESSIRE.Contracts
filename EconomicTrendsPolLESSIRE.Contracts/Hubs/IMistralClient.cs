using EconomicTrendsPolLESSIRE.Contracts.DTOs;
using System.Threading.Tasks;

namespace EconomicTrendsPolLESSIRE.Contracts.Hubs
{
    public interface IMistralClient
    {
        Task ReceiveMistralResponseStarted(MistralResponseStartedDto dto);
        Task ReceiveMistralResponseChunk(MistralResponseChunkDto dto);
        Task ReceiveMistralResponseStatus(MistralResponseStatusDto dto);

        // Optional but very useful for resynchronizing the final state
        Task ReceiveMistralResponseCompleted(MistralInteractionCompletedDto dto);
    }
}
