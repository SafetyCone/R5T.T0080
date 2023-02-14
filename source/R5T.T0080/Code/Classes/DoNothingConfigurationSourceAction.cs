using System;

using Microsoft.Extensions.Configuration;


namespace R5T.T0080
{
    /// <summary>
    /// A configuration source action that, when run, does nothing.
    /// This is useful when a <see cref="IConfigurationSourceAction{TConfigurationSource}"/> dependency must be satisified, but the configuration source itself has been added by external code.
    /// </summary>
    public class DoNothingConfigurationSourceAction<TConfigurationSource> : IConfigurationSourceAction<TConfigurationSource>
    {
        public void Run(IConfigurationBuilder configurationBuilder)
        {
            // Do nothing.
        }
    }
}