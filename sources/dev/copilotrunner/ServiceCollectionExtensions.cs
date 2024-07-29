// --------------------------------------------------------------------------------------------------------------------
// <file="ServiceCollectionExtensions.cs" github repo="ai-agent-infra">
// </file>
// -------------------------------------------------------------------------------------------------------------------

namespace CoPilotRunner
{
    using CoPilotRunner.Contracts;
    using CoPilotRunner.Implementation;
    using Infra.Contracts;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Logging;

    /// <summary>
    /// Extension methods for IServiceCollection
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddCoPilots(this IServiceCollection services)
        {
            services.AddScoped<ICoPilotRunner, CoPilotRunner>();


            services.AddScoped<ICoPilotRunnerRequestContext>(sp =>
                new CoPilotRunnerRequestContext
                {
                    Logger = sp.GetRequiredService<ILogger<CoPilotRunnerRequestContext>>(),
                    CoPilotRequestContext = sp.GetRequiredService<ICoPilotRequestContext>(),
                });

            return services;
        }
    }
}
