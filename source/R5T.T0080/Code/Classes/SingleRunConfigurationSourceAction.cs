using System;

using Microsoft.Extensions.Configuration;


namespace R5T.T0080
{
    /// <summary>
    /// A service action implementation that ensures it is only run once.
    /// </summary>
    public class SingleRunConfigurationSourceAction<TConfigurationSource> : IConfigurationSourceAction<TConfigurationSource>
    {
        public Action<IConfigurationBuilder> Action { get; }

        private bool HasRun { get; set; } = false;


        public SingleRunConfigurationSourceAction(Action<IConfigurationBuilder> action)
        {
            this.Action = action;
        }

        public void Run(IConfigurationBuilder configurationBuilder)
        {
            if (!this.HasRun)
            {
                this.Action(configurationBuilder);

                this.HasRun = true;
            }
        }
    }
}