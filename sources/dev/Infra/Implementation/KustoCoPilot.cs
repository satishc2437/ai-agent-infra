// --------------------------------------------------------------------------------------------------------------------
// <file="KustoCoPilot.cs" github repo="ai-agent-infra">
// </file>
// -------------------------------------------------------------------------------------------------------------------

namespace Infra.Implementation
{
    using System.Threading.Tasks;
    using AutoGen.Core;
    using Infra.Contracts;

    /// <summary>
    /// Kusto CoPilot
    /// </summary>
    public class KustoCoPilot(IAgent adminAgent, IAgent groupChatManager) : ICoPilot
    {
        /// <inheritdoc />
        public string Name => "Kusto CoPilot";

        /// <inheritdoc />
        public async Task<string> ProcessUserInput(
            ICoPilotRequestContext requestContext,
            string userInput,
            CancellationToken cancellationToken)
        {
            var conversationHistory = await adminAgent.InitiateChatAsync(
                receiver: groupChatManager,
                message: userInput,
                ct: cancellationToken);
            return conversationHistory.Last().FormatMessage();
        }
    }
}
