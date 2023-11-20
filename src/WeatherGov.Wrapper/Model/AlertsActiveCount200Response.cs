/*
 * weather.gov API
 *
 * weather.gov API
 *
 * The version of the OpenAPI document: 1.11.1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace WeatherGov.Wrapper.Model
{
    /// <summary>
    /// AlertsActiveCount200Response
    /// </summary>
    [DataContract(Name = "alerts_active_count_200_response")]
    public partial class AlertsActiveCount200Response : IEquatable<AlertsActiveCount200Response>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlertsActiveCount200Response" /> class.
        /// </summary>
        /// <param name="total">The total number of active alerts.</param>
        /// <param name="land">The total number of active alerts affecting land zones.</param>
        /// <param name="marine">The total number of active alerts affecting marine zones.</param>
        /// <param name="regions">Active alerts by marine region.</param>
        /// <param name="areas">Active alerts by area (state/territory).</param>
        /// <param name="zones">Active alerts by NWS public zone or county code.</param>
        public AlertsActiveCount200Response(int total = default(int), int land = default(int), int marine = default(int), Dictionary<string, int> regions = default(Dictionary<string, int>), Dictionary<string, int> areas = default(Dictionary<string, int>), Dictionary<string, int> zones = default(Dictionary<string, int>))
        {
            this.Total = total;
            this.Land = land;
            this.Marine = marine;
            this.Regions = regions;
            this.Areas = areas;
            this.Zones = zones;
        }

        /// <summary>
        /// The total number of active alerts
        /// </summary>
        /// <value>The total number of active alerts</value>
        [DataMember(Name = "total", EmitDefaultValue = false)]
        public int Total { get; set; }

        /// <summary>
        /// The total number of active alerts affecting land zones
        /// </summary>
        /// <value>The total number of active alerts affecting land zones</value>
        [DataMember(Name = "land", EmitDefaultValue = false)]
        public int Land { get; set; }

        /// <summary>
        /// The total number of active alerts affecting marine zones
        /// </summary>
        /// <value>The total number of active alerts affecting marine zones</value>
        [DataMember(Name = "marine", EmitDefaultValue = false)]
        public int Marine { get; set; }

        /// <summary>
        /// Active alerts by marine region
        /// </summary>
        /// <value>Active alerts by marine region</value>
        [DataMember(Name = "regions", EmitDefaultValue = false)]
        public Dictionary<string, int> Regions { get; set; }

        /// <summary>
        /// Active alerts by area (state/territory)
        /// </summary>
        /// <value>Active alerts by area (state/territory)</value>
        [DataMember(Name = "areas", EmitDefaultValue = false)]
        public Dictionary<string, int> Areas { get; set; }

        /// <summary>
        /// Active alerts by NWS public zone or county code
        /// </summary>
        /// <value>Active alerts by NWS public zone or county code</value>
        [DataMember(Name = "zones", EmitDefaultValue = false)]
        public Dictionary<string, int> Zones { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlertsActiveCount200Response {\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  Land: ").Append(Land).Append("\n");
            sb.Append("  Marine: ").Append(Marine).Append("\n");
            sb.Append("  Regions: ").Append(Regions).Append("\n");
            sb.Append("  Areas: ").Append(Areas).Append("\n");
            sb.Append("  Zones: ").Append(Zones).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AlertsActiveCount200Response);
        }

        /// <summary>
        /// Returns true if AlertsActiveCount200Response instances are equal
        /// </summary>
        /// <param name="input">Instance of AlertsActiveCount200Response to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlertsActiveCount200Response input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Total == input.Total ||
                    this.Total.Equals(input.Total)
                ) && 
                (
                    this.Land == input.Land ||
                    this.Land.Equals(input.Land)
                ) && 
                (
                    this.Marine == input.Marine ||
                    this.Marine.Equals(input.Marine)
                ) && 
                (
                    this.Regions == input.Regions ||
                    this.Regions != null &&
                    input.Regions != null &&
                    this.Regions.SequenceEqual(input.Regions)
                ) && 
                (
                    this.Areas == input.Areas ||
                    this.Areas != null &&
                    input.Areas != null &&
                    this.Areas.SequenceEqual(input.Areas)
                ) && 
                (
                    this.Zones == input.Zones ||
                    this.Zones != null &&
                    input.Zones != null &&
                    this.Zones.SequenceEqual(input.Zones)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                hashCode = (hashCode * 59) + this.Total.GetHashCode();
                hashCode = (hashCode * 59) + this.Land.GetHashCode();
                hashCode = (hashCode * 59) + this.Marine.GetHashCode();
                if (this.Regions != null)
                {
                    hashCode = (hashCode * 59) + this.Regions.GetHashCode();
                }
                if (this.Areas != null)
                {
                    hashCode = (hashCode * 59) + this.Areas.GetHashCode();
                }
                if (this.Zones != null)
                {
                    hashCode = (hashCode * 59) + this.Zones.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // Total (int) minimum
            if (this.Total < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Total, must be a value greater than or equal to 0.", new [] { "Total" });
            }

            // Land (int) minimum
            if (this.Land < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Land, must be a value greater than or equal to 0.", new [] { "Land" });
            }

            // Marine (int) minimum
            if (this.Marine < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Marine, must be a value greater than or equal to 0.", new [] { "Marine" });
            }

            yield break;
        }
    }

}
