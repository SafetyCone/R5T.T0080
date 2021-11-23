using System;

using Microsoft.Extensions.Configuration;

using R5T.T0080;


namespace System
{
    public static class IConfigurationBuilderExtensions
    {
        /// <summary>
        /// Calls the <see cref="IConfigurationSourceAction{TConfigurationSource}.Run(IConfigurationBuilder)"/> method on the configuration builder.
        /// </summary>
        public static IConfigurationBuilder RunConfigurationBuilderAction<TConfigurationSource>(this IConfigurationBuilder configurationBuilder,
            IConfigurationSourceAction<TConfigurationSource> configurationSourceAction)
        {
            configurationSourceAction.Run(configurationBuilder);

            return configurationBuilder;
        }

        /// <summary>
        /// Quality-of-life overload for <see cref="RunConfigurationBuilderAction{TConfigurationSource}(IConfigurationBuilder, IConfigurationSourceAction{TConfigurationSource})"/>.
        /// </summary>
        public static IConfigurationBuilder Run<TConfigurationSource>(this IConfigurationBuilder configurationBuilder,
            IConfigurationSourceAction<TConfigurationSource> configurationSourceAction)
        {
            configurationBuilder.RunConfigurationBuilderAction(configurationSourceAction);

            return configurationBuilder;
        }
    }
}
