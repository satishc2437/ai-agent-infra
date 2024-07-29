// --------------------------------------------------------------------------------------------------------------------
// <file="ICoPilotRunner.cs" github repo="ai-agent-infra">
// </file>
// -------------------------------------------------------------------------------------------------------------------

namespace CoPilotRunner.Contracts
{
    using System.Threading.Tasks;

    /// <summary>
    /// Interface for CoPilot Runner
    /// </summary>
    public interface ICoPilotRunner
    {
        /// <summary>
        /// Runs the CoPilot
        /// </summary>
        /// <param name="requestContext"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task RunAsync(ICoPilotRunnerRequestContext requestContext, CancellationToken cancellationToken);
    }
}
