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
    /// Land region code. These correspond to the six NWS regional headquarters: * AR: Alaska Region * CR: Central Region * ER: Eastern Region * PR: Pacific Region * SR: Southern Region * WR: Western Region 
    /// </summary>
    /// <value>Land region code. These correspond to the six NWS regional headquarters: * AR: Alaska Region * CR: Central Region * ER: Eastern Region * PR: Pacific Region * SR: Southern Region * WR: Western Region </value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LandRegionCode
    {
        /// <summary>
        /// Enum AR for value: AR
        /// </summary>
        [EnumMember(Value = "AR")]
        AR = 1,

        /// <summary>
        /// Enum CR for value: CR
        /// </summary>
        [EnumMember(Value = "CR")]
        CR = 2,

        /// <summary>
        /// Enum ER for value: ER
        /// </summary>
        [EnumMember(Value = "ER")]
        ER = 3,

        /// <summary>
        /// Enum PR for value: PR
        /// </summary>
        [EnumMember(Value = "PR")]
        PR = 4,

        /// <summary>
        /// Enum SR for value: SR
        /// </summary>
        [EnumMember(Value = "SR")]
        SR = 5,

        /// <summary>
        /// Enum WR for value: WR
        /// </summary>
        [EnumMember(Value = "WR")]
        WR = 6
    }

}