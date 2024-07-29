// --------------------------------------------------------------------------------------------------------------------
// <file="CoPilotRunnerRequestContext.cs" github repo="ai-agent-infra">
// </file>
// -------------------------------------------------------------------------------------------------------------------

namespace CoPilotRunner.Implementation
{
    using Contracts;
    using Infra.Contracts;
    using Microsoft.Extensions.Logging;

    /// <summary>
    /// Request Context for CoPilot Runner
    /// </summary>
    public record CoPilotRunnerRequestContext : ICoPilotRunnerRequestContext
    {
        /// <summary>
        /// Request Context for CoPilot
        /// </summary>
        public required ICoPilotRequestContext CoPilotRequestContext { get; init;}

        /// <summary>
        /// Logger instance
        /// </summary>
        public required ILogger Logger { get; init; }
    }
}
