using System;


namespace R5T.T0080
{
    /// <summary>
    /// Marks an interface as being a configuration source action aggregation definition.
    /// Also allows specifying that an interface is *not* a configuration source action aggregation. This is useful for decorating extraneous interface declarations that also happen to be in a configuration source action aggregation definition file, or in a file in the configuration source action aggregation definitions directory.
    /// </summary>
    [AttributeUsage(AttributeTargets.Interface, Inherited = false, AllowMultiple = false)]
    public class ConfigurationSourceActionAggregationMarkerAttribute : Attribute
    {
        private readonly bool zIsConfigurationSourceActionAggregation;
        public bool IsConfigurationSourceActionAggregation
        {
            get
            {
                return this.zIsConfigurationSourceActionAggregation;
            }
        }


        public ConfigurationSourceActionAggregationMarkerAttribute(
            bool isConfigurationSourceActionAggregation = true)
        {
            this.zIsConfigurationSourceActionAggregation = isConfigurationSourceActionAggregation;
        }
    }
}
