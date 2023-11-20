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
using System.ComponentModel.DataAnnotations;

namespace WeatherGov.Wrapper.Model
{
    /// <summary>
    /// TextProduct
    /// </summary>
    [DataContract(Name = "TextProduct")]
    public partial class TextProduct : IEquatable<TextProduct>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TextProduct" /> class.
        /// </summary>
        /// <param name="context">context.</param>
        /// <param name="id">id.</param>
        /// <param name="wmoCollectiveId">wmoCollectiveId.</param>
        /// <param name="issuingOffice">issuingOffice.</param>
        /// <param name="issuanceTime">issuanceTime.</param>
        /// <param name="productCode">productCode.</param>
        /// <param name="productName">productName.</param>
        /// <param name="productText">productText.</param>
        public TextProduct(JsonLdContext context = default(JsonLdContext), string id = default(string), string wmoCollectiveId = default(string), string issuingOffice = default(string), DateTime issuanceTime = default(DateTime), string productCode = default(string), string productName = default(string), string productText = default(string))
        {
            this.Context = context;
            this.Id = id;
            this.WmoCollectiveId = wmoCollectiveId;
            this.IssuingOffice = issuingOffice;
            this.IssuanceTime = issuanceTime;
            this.ProductCode = productCode;
            this.ProductName = productName;
            this.ProductText = productText;
        }

        /// <summary>
        /// Gets or Sets Context
        /// </summary>
        [DataMember(Name = "@context", EmitDefaultValue = false)]
        public JsonLdContext Context { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets WmoCollectiveId
        /// </summary>
        [DataMember(Name = "wmoCollectiveId", EmitDefaultValue = false)]
        public string WmoCollectiveId { get; set; }

        /// <summary>
        /// Gets or Sets IssuingOffice
        /// </summary>
        [DataMember(Name = "issuingOffice", EmitDefaultValue = false)]
        public string IssuingOffice { get; set; }

        /// <summary>
        /// Gets or Sets IssuanceTime
        /// </summary>
        [DataMember(Name = "issuanceTime", EmitDefaultValue = false)]
        public DateTime IssuanceTime { get; set; }

        /// <summary>
        /// Gets or Sets ProductCode
        /// </summary>
        [DataMember(Name = "productCode", EmitDefaultValue = false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// Gets or Sets ProductName
        /// </summary>
        [DataMember(Name = "productName", EmitDefaultValue = false)]
        public string ProductName { get; set; }

        /// <summary>
        /// Gets or Sets ProductText
        /// </summary>
        [DataMember(Name = "productText", EmitDefaultValue = false)]
        public string ProductText { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TextProduct {\n");
            sb.Append("  Context: ").Append(Context).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  WmoCollectiveId: ").Append(WmoCollectiveId).Append("\n");
            sb.Append("  IssuingOffice: ").Append(IssuingOffice).Append("\n");
            sb.Append("  IssuanceTime: ").Append(IssuanceTime).Append("\n");
            sb.Append("  ProductCode: ").Append(ProductCode).Append("\n");
            sb.Append("  ProductName: ").Append(ProductName).Append("\n");
            sb.Append("  ProductText: ").Append(ProductText).Append("\n");
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
            return this.Equals(input as TextProduct);
        }

        /// <summary>
        /// Returns true if TextProduct instances are equal
        /// </summary>
        /// <param name="input">Instance of TextProduct to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TextProduct input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Context == input.Context ||
                    (this.Context != null &&
                    this.Context.Equals(input.Context))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.WmoCollectiveId == input.WmoCollectiveId ||
                    (this.WmoCollectiveId != null &&
                    this.WmoCollectiveId.Equals(input.WmoCollectiveId))
                ) && 
                (
                    this.IssuingOffice == input.IssuingOffice ||
                    (this.IssuingOffice != null &&
                    this.IssuingOffice.Equals(input.IssuingOffice))
                ) && 
                (
                    this.IssuanceTime.Equals(input.IssuanceTime)
                ) && 
                (
                    this.ProductCode == input.ProductCode ||
                    (this.ProductCode != null &&
                    this.ProductCode.Equals(input.ProductCode))
                ) && 
                (
                    this.ProductName == input.ProductName ||
                    (this.ProductName != null &&
                    this.ProductName.Equals(input.ProductName))
                ) && 
                (
                    this.ProductText == input.ProductText ||
                    (this.ProductText != null &&
                    this.ProductText.Equals(input.ProductText))
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
                if (this.Context != null)
                {
                    hashCode = (hashCode * 59) + this.Context.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.WmoCollectiveId != null)
                {
                    hashCode = (hashCode * 59) + this.WmoCollectiveId.GetHashCode();
                }
                if (this.IssuingOffice != null)
                {
                    hashCode = (hashCode * 59) + this.IssuingOffice.GetHashCode();
                }

                    hashCode = (hashCode * 59) + this.IssuanceTime.GetHashCode();

                if (this.ProductCode != null)
                {
                    hashCode = (hashCode * 59) + this.ProductCode.GetHashCode();
                }
                if (this.ProductName != null)
                {
                    hashCode = (hashCode * 59) + this.ProductName.GetHashCode();
                }
                if (this.ProductText != null)
                {
                    hashCode = (hashCode * 59) + this.ProductText.GetHashCode();
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