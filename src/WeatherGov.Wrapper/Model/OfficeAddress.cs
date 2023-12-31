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
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace WeatherGov.Wrapper.Model
{
    /// <summary>
    /// OfficeAddress
    /// </summary>
    [DataContract(Name = "Office_address")]
    public partial class OfficeAddress : IEquatable<OfficeAddress>, IValidatableObject
    {
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum PostalAddress for value: PostalAddress
            /// </summary>
            [EnumMember(Value = "PostalAddress")]
            PostalAddress = 1
        }


        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "@type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OfficeAddress" /> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="streetAddress">streetAddress.</param>
        /// <param name="addressLocality">addressLocality.</param>
        /// <param name="addressRegion">addressRegion.</param>
        /// <param name="postalCode">postalCode.</param>
        public OfficeAddress(TypeEnum? type = default(TypeEnum?), string streetAddress = default(string), string addressLocality = default(string), string addressRegion = default(string), string postalCode = default(string))
        {
            this.Type = type;
            this.StreetAddress = streetAddress;
            this.AddressLocality = addressLocality;
            this.AddressRegion = addressRegion;
            this.PostalCode = postalCode;
        }

        /// <summary>
        /// Gets or Sets StreetAddress
        /// </summary>
        [DataMember(Name = "streetAddress", EmitDefaultValue = false)]
        public string StreetAddress { get; set; }

        /// <summary>
        /// Gets or Sets AddressLocality
        /// </summary>
        [DataMember(Name = "addressLocality", EmitDefaultValue = false)]
        public string AddressLocality { get; set; }

        /// <summary>
        /// Gets or Sets AddressRegion
        /// </summary>
        [DataMember(Name = "addressRegion", EmitDefaultValue = false)]
        public string AddressRegion { get; set; }

        /// <summary>
        /// Gets or Sets PostalCode
        /// </summary>
        [DataMember(Name = "postalCode", EmitDefaultValue = false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OfficeAddress {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  StreetAddress: ").Append(StreetAddress).Append("\n");
            sb.Append("  AddressLocality: ").Append(AddressLocality).Append("\n");
            sb.Append("  AddressRegion: ").Append(AddressRegion).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
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
            return this.Equals(input as OfficeAddress);
        }

        /// <summary>
        /// Returns true if OfficeAddress instances are equal
        /// </summary>
        /// <param name="input">Instance of OfficeAddress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OfficeAddress input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.StreetAddress == input.StreetAddress ||
                    (this.StreetAddress != null &&
                    this.StreetAddress.Equals(input.StreetAddress))
                ) && 
                (
                    this.AddressLocality == input.AddressLocality ||
                    (this.AddressLocality != null &&
                    this.AddressLocality.Equals(input.AddressLocality))
                ) && 
                (
                    this.AddressRegion == input.AddressRegion ||
                    (this.AddressRegion != null &&
                    this.AddressRegion.Equals(input.AddressRegion))
                ) && 
                (
                    this.PostalCode == input.PostalCode ||
                    (this.PostalCode != null &&
                    this.PostalCode.Equals(input.PostalCode))
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
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.StreetAddress != null)
                {
                    hashCode = (hashCode * 59) + this.StreetAddress.GetHashCode();
                }
                if (this.AddressLocality != null)
                {
                    hashCode = (hashCode * 59) + this.AddressLocality.GetHashCode();
                }
                if (this.AddressRegion != null)
                {
                    hashCode = (hashCode * 59) + this.AddressRegion.GetHashCode();
                }
                if (this.PostalCode != null)
                {
                    hashCode = (hashCode * 59) + this.PostalCode.GetHashCode();
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
