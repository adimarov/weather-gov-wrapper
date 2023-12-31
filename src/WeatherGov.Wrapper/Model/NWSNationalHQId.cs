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
    /// Three-letter identifier for NWS National HQ.
    /// </summary>
    /// <value>Three-letter identifier for NWS National HQ.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum NWSNationalHQId
    {
        /// <summary>
        /// Enum NWS for value: NWS
        /// </summary>
        [EnumMember(Value = "NWS")]
        NWS = 1
    }

}
