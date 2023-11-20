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
    /// IconsSummary200ResponseIconsValue
    /// </summary>
    [DataContract(Name = "icons_summary_200_response_icons_value")]
    public partial class IconsSummary200ResponseIconsValue : IEquatable<IconsSummary200ResponseIconsValue>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IconsSummary200ResponseIconsValue" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IconsSummary200ResponseIconsValue() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IconsSummary200ResponseIconsValue" /> class.
        /// </summary>
        /// <param name="description">description (required).</param>
        public IconsSummary200ResponseIconsValue(string description = default(string))
        {
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new ArgumentNullException("description is a required property for IconsSummary200ResponseIconsValue and cannot be null");
            }
            this.Description = description;
        }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IconsSummary200ResponseIconsValue {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            return this.Equals(input as IconsSummary200ResponseIconsValue);
        }

        /// <summary>
        /// Returns true if IconsSummary200ResponseIconsValue instances are equal
        /// </summary>
        /// <param name="input">Instance of IconsSummary200ResponseIconsValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IconsSummary200ResponseIconsValue input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
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
