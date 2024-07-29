// --------------------------------------------------------------------------------------------------------------------
// <file="IRequestContext.cs" github repo="ai-agent-infra">
// </file>
// -------------------------------------------------------------------------------------------------------------------

namespace Infra.Contracts
{
    using Microsoft.Extensions.Logging;

    /// <summary>
    /// Interface for Request Context
    /// </summary>
    public interface IRequestContext
    {
        /// <summary>
        /// Gets the logger
        /// </summary>
        ILogger Logger { get; }
    }
}
