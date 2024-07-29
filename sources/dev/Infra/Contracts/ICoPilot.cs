// --------------------------------------------------------------------------------------------------------------------
// <file="AcceptMeetingAction.cs" github repo="ai-agent-infra">
// </file>
// -------------------------------------------------------------------------------------------------------------------

namespace Infra.Contracts
{
    /// <summary>
    /// Interface for the CoPilot
    /// </summary>
    public interface ICoPilot
    {
        /// <summary>
        /// Name of the CoPilot
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Processes the user input
        /// </summary>
        /// <param name="requestContext">Request context for the CoPilot instance</param>
        /// <param name="userInput">Input string from the User</param>
        /// <returns>CoPilot response</returns>
        Task<string> ProcessUserInput(ICoPilotRequestContext requestContext, string userInput, CancellationToken cancellationToken);
    }
}
