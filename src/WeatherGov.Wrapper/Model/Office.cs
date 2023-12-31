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
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace WeatherGov.Wrapper.Model
{
    /// <summary>
    /// Office
    /// </summary>
    [DataContract(Name = "Office")]
    public partial class Office : IEquatable<Office>, IValidatableObject
    {
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum GovernmentOrganization for value: GovernmentOrganization
            /// </summary>
            [EnumMember(Value = "GovernmentOrganization")]
            GovernmentOrganization = 1
        }


        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "@type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Office" /> class.
        /// </summary>
        /// <param name="context">context.</param>
        /// <param name="type">type.</param>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="address">address.</param>
        /// <param name="telephone">telephone.</param>
        /// <param name="faxNumber">faxNumber.</param>
        /// <param name="email">email.</param>
        /// <param name="sameAs">sameAs.</param>
        /// <param name="nwsRegion">nwsRegion.</param>
        /// <param name="parentOrganization">parentOrganization.</param>
        /// <param name="responsibleCounties">responsibleCounties.</param>
        /// <param name="responsibleForecastZones">responsibleForecastZones.</param>
        /// <param name="responsibleFireZones">responsibleFireZones.</param>
        /// <param name="approvedObservationStations">approvedObservationStations.</param>
        public Office(JsonLdContext context = default(JsonLdContext), TypeEnum? type = default(TypeEnum?), string id = default(string), string name = default(string), OfficeAddress address = default(OfficeAddress), string telephone = default(string), string faxNumber = default(string), string email = default(string), string sameAs = default(string), string nwsRegion = default(string), string parentOrganization = default(string), List<string> responsibleCounties = default(List<string>), List<string> responsibleForecastZones = default(List<string>), List<string> responsibleFireZones = default(List<string>), List<string> approvedObservationStations = default(List<string>))
        {
            this.Context = context;
            this.Type = type;
            this.Id = id;
            this.Name = name;
            this.Address = address;
            this.Telephone = telephone;
            this.FaxNumber = faxNumber;
            this.Email = email;
            this.SameAs = sameAs;
            this.NwsRegion = nwsRegion;
            this.ParentOrganization = parentOrganization;
            this.ResponsibleCounties = responsibleCounties;
            this.ResponsibleForecastZones = responsibleForecastZones;
            this.ResponsibleFireZones = responsibleFireZones;
            this.ApprovedObservationStations = approvedObservationStations;
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
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name = "address", EmitDefaultValue = false)]
        public OfficeAddress Address { get; set; }

        /// <summary>
        /// Gets or Sets Telephone
        /// </summary>
        [DataMember(Name = "telephone", EmitDefaultValue = false)]
        public string Telephone { get; set; }

        /// <summary>
        /// Gets or Sets FaxNumber
        /// </summary>
        [DataMember(Name = "faxNumber", EmitDefaultValue = false)]
        public string FaxNumber { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets SameAs
        /// </summary>
        [DataMember(Name = "sameAs", EmitDefaultValue = false)]
        public string SameAs { get; set; }

        /// <summary>
        /// Gets or Sets NwsRegion
        /// </summary>
        [DataMember(Name = "nwsRegion", EmitDefaultValue = false)]
        public string NwsRegion { get; set; }

        /// <summary>
        /// Gets or Sets ParentOrganization
        /// </summary>
        [DataMember(Name = "parentOrganization", EmitDefaultValue = false)]
        public string ParentOrganization { get; set; }

        /// <summary>
        /// Gets or Sets ResponsibleCounties
        /// </summary>
        [DataMember(Name = "responsibleCounties", EmitDefaultValue = false)]
        public List<string> ResponsibleCounties { get; set; }

        /// <summary>
        /// Gets or Sets ResponsibleForecastZones
        /// </summary>
        [DataMember(Name = "responsibleForecastZones", EmitDefaultValue = false)]
        public List<string> ResponsibleForecastZones { get; set; }

        /// <summary>
        /// Gets or Sets ResponsibleFireZones
        /// </summary>
        [DataMember(Name = "responsibleFireZones", EmitDefaultValue = false)]
        public List<string> ResponsibleFireZones { get; set; }

        /// <summary>
        /// Gets or Sets ApprovedObservationStations
        /// </summary>
        [DataMember(Name = "approvedObservationStations", EmitDefaultValue = false)]
        public List<string> ApprovedObservationStations { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Office {\n");
            sb.Append("  Context: ").Append(Context).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Telephone: ").Append(Telephone).Append("\n");
            sb.Append("  FaxNumber: ").Append(FaxNumber).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  SameAs: ").Append(SameAs).Append("\n");
            sb.Append("  NwsRegion: ").Append(NwsRegion).Append("\n");
            sb.Append("  ParentOrganization: ").Append(ParentOrganization).Append("\n");
            sb.Append("  ResponsibleCounties: ").Append(ResponsibleCounties).Append("\n");
            sb.Append("  ResponsibleForecastZones: ").Append(ResponsibleForecastZones).Append("\n");
            sb.Append("  ResponsibleFireZones: ").Append(ResponsibleFireZones).Append("\n");
            sb.Append("  ApprovedObservationStations: ").Append(ApprovedObservationStations).Append("\n");
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
            return this.Equals(input as Office);
        }

        /// <summary>
        /// Returns true if Office instances are equal
        /// </summary>
        /// <param name="input">Instance of Office to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Office input)
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
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.Telephone == input.Telephone ||
                    (this.Telephone != null &&
                    this.Telephone.Equals(input.Telephone))
                ) && 
                (
                    this.FaxNumber == input.FaxNumber ||
                    (this.FaxNumber != null &&
                    this.FaxNumber.Equals(input.FaxNumber))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.SameAs == input.SameAs ||
                    (this.SameAs != null &&
                    this.SameAs.Equals(input.SameAs))
                ) && 
                (
                    this.NwsRegion == input.NwsRegion ||
                    (this.NwsRegion != null &&
                    this.NwsRegion.Equals(input.NwsRegion))
                ) && 
                (
                    this.ParentOrganization == input.ParentOrganization ||
                    (this.ParentOrganization != null &&
                    this.ParentOrganization.Equals(input.ParentOrganization))
                ) && 
                (
                    this.ResponsibleCounties == input.ResponsibleCounties ||
                    this.ResponsibleCounties != null &&
                    input.ResponsibleCounties != null &&
                    this.ResponsibleCounties.SequenceEqual(input.ResponsibleCounties)
                ) && 
                (
                    this.ResponsibleForecastZones == input.ResponsibleForecastZones ||
                    this.ResponsibleForecastZones != null &&
                    input.ResponsibleForecastZones != null &&
                    this.ResponsibleForecastZones.SequenceEqual(input.ResponsibleForecastZones)
                ) && 
                (
                    this.ResponsibleFireZones == input.ResponsibleFireZones ||
                    this.ResponsibleFireZones != null &&
                    input.ResponsibleFireZones != null &&
                    this.ResponsibleFireZones.SequenceEqual(input.ResponsibleFireZones)
                ) && 
                (
                    this.ApprovedObservationStations == input.ApprovedObservationStations ||
                    this.ApprovedObservationStations != null &&
                    input.ApprovedObservationStations != null &&
                    this.ApprovedObservationStations.SequenceEqual(input.ApprovedObservationStations)
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
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Address != null)
                {
                    hashCode = (hashCode * 59) + this.Address.GetHashCode();
                }
                if (this.Telephone != null)
                {
                    hashCode = (hashCode * 59) + this.Telephone.GetHashCode();
                }
                if (this.FaxNumber != null)
                {
                    hashCode = (hashCode * 59) + this.FaxNumber.GetHashCode();
                }
                if (this.Email != null)
                {
                    hashCode = (hashCode * 59) + this.Email.GetHashCode();
                }
                if (this.SameAs != null)
                {
                    hashCode = (hashCode * 59) + this.SameAs.GetHashCode();
                }
                if (this.NwsRegion != null)
                {
                    hashCode = (hashCode * 59) + this.NwsRegion.GetHashCode();
                }
                if (this.ParentOrganization != null)
                {
                    hashCode = (hashCode * 59) + this.ParentOrganization.GetHashCode();
                }
                if (this.ResponsibleCounties != null)
                {
                    hashCode = (hashCode * 59) + this.ResponsibleCounties.GetHashCode();
                }
                if (this.ResponsibleForecastZones != null)
                {
                    hashCode = (hashCode * 59) + this.ResponsibleForecastZones.GetHashCode();
                }
                if (this.ResponsibleFireZones != null)
                {
                    hashCode = (hashCode * 59) + this.ResponsibleFireZones.GetHashCode();
                }
                if (this.ApprovedObservationStations != null)
                {
                    hashCode = (hashCode * 59) + this.ApprovedObservationStations.GetHashCode();
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
