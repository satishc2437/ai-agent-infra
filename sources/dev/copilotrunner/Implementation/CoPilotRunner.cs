// --------------------------------------------------------------------------------------------------------------------
// <file="CoPilotRunner.cs" github repo="ai-agent-infra">
// </file>
// -------------------------------------------------------------------------------------------------------------------

using CoPilotRunner.Contracts;

namespace CoPilotRunner.Implementation
{
    using System.Threading.Tasks;
    using Infra.Contracts;
    using Microsoft.Extensions.Logging;

    /// <summary>
    /// CoPilot Runner
    /// </summary>
    /// <param name="coPilot">
    /// The CoPilot instance
    /// </param>
    public class CoPilotRunner(ICoPilot coPilot) : ICoPilotRunner
    {
        /// <summary>
        /// Exit command
        /// </summary>
        private const string exisCommand = "exit";

        /// <inheritdoc/>
        public async Task RunAsync(
            ICoPilotRunnerRequestContext requestContext,
            CancellationToken cancellationToken)
        {
            requestContext.Logger.LogInformation("Launching the CoPilot: {CoPilotName}", coPilot.Name);
            requestContext.Logger.LogInformation("Initializing chat experience. Type 'exit' to stop the quit.");

            do
            {
                requestContext.Logger.LogInformation("User:>");
                var input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    continue;
                }

                if (string.Equals(input, exisCommand, StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

                try
                {
                    var response = await coPilot.ProcessUserInput(
                        requestContext.CoPilotRequestContext,
                        input,
                        cancellationToken);

                    requestContext.Logger.LogInformation("{CoPilotName}:>{Response}", coPilot.Name, response);
                }
                catch (Exception ex)
                {
                    requestContext.Logger.LogError(ex, "Error processing the user input.");
                }
            } while (true);
        }
    }
}
