using System;

using Microsoft.Extensions.Configuration;


namespace R5T.T0080
{
    /// <summary>
    /// Encapsulates the addition of a configuration source <typeparamref name="TConfigurationSource"/> to an <see cref="IConfigurationBuilder"/> instance.
    /// The action must be run to actually add the configuration source.
    /// Useful in communicating configuration source dependency relationships while configuring options.
    /// </summary>
    /// <typeparam name="TConfigurationSource">A typat that *exactly* describes the configuration source. Specified as 'out' (covariant) to allow functions requiring an IConfigurationSourceAction{Base} instance to accept an IConfigurationSourceAction{Dervived} instance.</typeparam>
    public interface IConfigurationSourceAction<out TConfigurationSource>
    {
        void Run(IConfigurationBuilder configurationBuilder);
    }
}