// --------------------------------------------------------------------------------------------------------------------
// <file="ICoPilotRunnerRequestContext.cs" github repo="ai-agent-infra">
// </file>
// -------------------------------------------------------------------------------------------------------------------

namespace CoPilotRunner.Contracts
{
    using Infra.Contracts;

    /// <summary>
    /// Interface for CoPilot Runner Request Context
    /// </summary>
    public interface ICoPilotRunnerRequestContext : IRequestContext
    {
        /// <summary>
        /// Gets the CoPilot Request Context
        /// </summary>
        ICoPilotRequestContext CoPilotRequestContext { get; }
    }
}
