using System;


namespace R5T.T0080
{
    /// <summary>
    /// Marks a class as being a configuration source action aggregation implementation.
    /// Also allows specifying that a class is *not* a configuration source action aggregation implementation. This is useful for decorating extraneous interface declarations that also happen to be in a configuration source action aggregation implementation file, or in a file in the configuration source action aggregation implementation definitions directory.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    public class ConfigurationSourceActionAggregationImplementationMarkerAttribute : Attribute
    {
        private readonly bool zIsConfigurationSourceActionAggregationImplementation;
        public bool IsConfigurationSourceActionAggregationImplementation
        {
            get
            {
                return this.zIsConfigurationSourceActionAggregationImplementation;
            }
        }


        public ConfigurationSourceActionAggregationImplementationMarkerAttribute(
            bool isConfigurationSourceActionAggregationImplementation = true)
        {
            this.zIsConfigurationSourceActionAggregationImplementation = isConfigurationSourceActionAggregationImplementation;
        }
    }
}
