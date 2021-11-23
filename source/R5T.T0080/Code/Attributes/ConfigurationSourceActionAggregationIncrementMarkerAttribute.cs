using System;


namespace R5T.T0080
{
    /// <summary>
    /// Marks an interface as being a configuration source action aggregation increment definition.
    /// Also allows specifying that an interface is *not* a configuration source action aggregation increment. This is useful for decorating extraneous interface declarations that also happen to be in a configuration source action aggregation increment definition file, or in a file in the configuration source action aggregation increment definitions directory.
    /// </summary>
    [AttributeUsage(AttributeTargets.Interface, Inherited = false, AllowMultiple = false)]
    public class ConfigurationSourceActionAggregationIncrementMarkerAttribute : Attribute
    {
        private readonly bool zIsConfigurationSourceActionAggregationIncrement;
        public bool IsConfigurationSourceActionAggregationIncrement
        {
            get
            {
                return this.zIsConfigurationSourceActionAggregationIncrement;
            }
        }


        public ConfigurationSourceActionAggregationIncrementMarkerAttribute(
            bool isConfigurationSourceActionAggregationIncrement = true)
        {
            this.zIsConfigurationSourceActionAggregationIncrement = isConfigurationSourceActionAggregationIncrement;
        }
    }
}
