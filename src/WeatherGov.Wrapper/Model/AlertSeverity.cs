/*
 * weather.gov API
 *
 * weather.gov API
 *
 * The version of the OpenAPI document: 1.11.1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace WeatherGov.Wrapper.Model
{
    /// <summary>
    /// Defines AlertSeverity
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AlertSeverity
    {
        /// <summary>
        /// Enum Extreme for value: Extreme
        /// </summary>
        [EnumMember(Value = "Extreme")]
        Extreme = 1,

        /// <summary>
        /// Enum Severe for value: Severe
        /// </summary>
        [EnumMember(Value = "Severe")]
        Severe = 2,

        /// <summary>
        /// Enum Moderate for value: Moderate
        /// </summary>
        [EnumMember(Value = "Moderate")]
        Moderate = 3,

        /// <summary>
        /// Enum Minor for value: Minor
        /// </summary>
        [EnumMember(Value = "Minor")]
        Minor = 4,

        /// <summary>
        /// Enum Unknown for value: Unknown
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown = 5
    }

}