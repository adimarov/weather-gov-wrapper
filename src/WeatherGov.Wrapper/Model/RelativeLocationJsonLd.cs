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
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace WeatherGov.Wrapper.Model
{
    /// <summary>
    /// RelativeLocationJsonLd
    /// </summary>
    [DataContract(Name = "RelativeLocationJsonLd")]
    public partial class RelativeLocationJsonLd : IEquatable<RelativeLocationJsonLd>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RelativeLocationJsonLd" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RelativeLocationJsonLd() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RelativeLocationJsonLd" /> class.
        /// </summary>
        /// <param name="city">city.</param>
        /// <param name="state">state.</param>
        /// <param name="distance">distance.</param>
        /// <param name="bearing">bearing.</param>
        /// <param name="geometry">A geometry represented in Well-Known Text (WKT) format. (required).</param>
        public RelativeLocationJsonLd(string city = default(string), string state = default(string), QuantitativeValue distance = default(QuantitativeValue), QuantitativeValue bearing = default(QuantitativeValue), string geometry = default(string))
        {
            // to ensure "geometry" is required (not null)
            if (geometry == null)
            {
                throw new ArgumentNullException("geometry is a required property for RelativeLocationJsonLd and cannot be null");
            }
            this.Geometry = geometry;
            this.City = city;
            this.State = state;
            this.Distance = distance;
            this.Bearing = bearing;
        }

        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name = "city", EmitDefaultValue = false)]
        public string City { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public string State { get; set; }

        /// <summary>
        /// Gets or Sets Distance
        /// </summary>
        [DataMember(Name = "distance", EmitDefaultValue = false)]
        public QuantitativeValue Distance { get; set; }

        /// <summary>
        /// Gets or Sets Bearing
        /// </summary>
        [DataMember(Name = "bearing", EmitDefaultValue = false)]
        public QuantitativeValue Bearing { get; set; }

        /// <summary>
        /// A geometry represented in Well-Known Text (WKT) format.
        /// </summary>
        /// <value>A geometry represented in Well-Known Text (WKT) format.</value>
        [DataMember(Name = "geometry", IsRequired = true, EmitDefaultValue = true)]
        public string Geometry { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RelativeLocationJsonLd {\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Distance: ").Append(Distance).Append("\n");
            sb.Append("  Bearing: ").Append(Bearing).Append("\n");
            sb.Append("  Geometry: ").Append(Geometry).Append("\n");
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
            return this.Equals(input as RelativeLocationJsonLd);
        }

        /// <summary>
        /// Returns true if RelativeLocationJsonLd instances are equal
        /// </summary>
        /// <param name="input">Instance of RelativeLocationJsonLd to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RelativeLocationJsonLd input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.Distance == input.Distance ||
                    (this.Distance != null &&
                    this.Distance.Equals(input.Distance))
                ) && 
                (
                    this.Bearing == input.Bearing ||
                    (this.Bearing != null &&
                    this.Bearing.Equals(input.Bearing))
                ) && 
                (
                    this.Geometry == input.Geometry ||
                    (this.Geometry != null &&
                    this.Geometry.Equals(input.Geometry))
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
                if (this.City != null)
                {
                    hashCode = (hashCode * 59) + this.City.GetHashCode();
                }
                if (this.State != null)
                {
                    hashCode = (hashCode * 59) + this.State.GetHashCode();
                }
                if (this.Distance != null)
                {
                    hashCode = (hashCode * 59) + this.Distance.GetHashCode();
                }
                if (this.Bearing != null)
                {
                    hashCode = (hashCode * 59) + this.Bearing.GetHashCode();
                }
                if (this.Geometry != null)
                {
                    hashCode = (hashCode * 59) + this.Geometry.GetHashCode();
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
            yield break;
        }
    }

}