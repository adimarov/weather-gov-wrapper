/*
 * weather.gov API
 *
 * weather.gov API
 *
 * The version of the OpenAPI document: 1.11.1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = WeatherGov.Wrapper.Client.OpenAPIDateConverter;
using System.Reflection;

namespace WeatherGov.Wrapper.Model
{
    /// <summary>
    /// High/low temperature for the period, depending on whether the period is day or night. This property as an integer value is deprecated. Future versions will express this value as a quantitative value object. To make use of the future standard format now, set the \&quot;forecast_temperature_qv\&quot; feature flag on the request. 
    /// </summary>
    [JsonConverter(typeof(GridpointForecastPeriodTemperatureJsonConverter))]
    [DataContract(Name = "GridpointForecastPeriod_temperature")]
    public partial class GridpointForecastPeriodTemperature : AbstractOpenAPISchema, IEquatable<GridpointForecastPeriodTemperature>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GridpointForecastPeriodTemperature" /> class
        /// with the <see cref="QuantitativeValue" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of QuantitativeValue.</param>
        public GridpointForecastPeriodTemperature(QuantitativeValue actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GridpointForecastPeriodTemperature" /> class
        /// with the <see cref="int" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of int.</param>
        public GridpointForecastPeriodTemperature(int actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }


        private Object _actualInstance;

        /// <summary>
        /// Gets or Sets ActualInstance
        /// </summary>
        public override Object ActualInstance
        {
            get
            {
                return _actualInstance;
            }
            set
            {
                if (value.GetType() == typeof(QuantitativeValue))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(int))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: QuantitativeValue, int");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `QuantitativeValue`. If the actual instance is not `QuantitativeValue`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of QuantitativeValue</returns>
        public QuantitativeValue GetQuantitativeValue()
        {
            return (QuantitativeValue)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `int`. If the actual instance is not `int`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of int</returns>
        public int GetInt()
        {
            return (int)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GridpointForecastPeriodTemperature {\n");
            sb.Append("  ActualInstance: ").Append(this.ActualInstance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this.ActualInstance, GridpointForecastPeriodTemperature.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of GridpointForecastPeriodTemperature
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of GridpointForecastPeriodTemperature</returns>
        public static GridpointForecastPeriodTemperature FromJson(string jsonString)
        {
            GridpointForecastPeriodTemperature newGridpointForecastPeriodTemperature = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newGridpointForecastPeriodTemperature;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(QuantitativeValue).GetProperty("AdditionalProperties") == null)
                {
                    newGridpointForecastPeriodTemperature = new GridpointForecastPeriodTemperature(JsonConvert.DeserializeObject<QuantitativeValue>(jsonString, GridpointForecastPeriodTemperature.SerializerSettings));
                }
                else
                {
                    newGridpointForecastPeriodTemperature = new GridpointForecastPeriodTemperature(JsonConvert.DeserializeObject<QuantitativeValue>(jsonString, GridpointForecastPeriodTemperature.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("QuantitativeValue");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into QuantitativeValue: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(int).GetProperty("AdditionalProperties") == null)
                {
                    newGridpointForecastPeriodTemperature = new GridpointForecastPeriodTemperature(JsonConvert.DeserializeObject<int>(jsonString, GridpointForecastPeriodTemperature.SerializerSettings));
                }
                else
                {
                    newGridpointForecastPeriodTemperature = new GridpointForecastPeriodTemperature(JsonConvert.DeserializeObject<int>(jsonString, GridpointForecastPeriodTemperature.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("int");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into int: {1}", jsonString, exception.ToString()));
            }

            if (match == 0)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` cannot be deserialized into any schema defined.");
            }
            else if (match > 1)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` incorrectly matches more than one schema (should be exactly one match): " + matchedTypes);
            }

            // deserialization is considered successful at this point if no exception has been thrown.
            return newGridpointForecastPeriodTemperature;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as GridpointForecastPeriodTemperature);
        }

        /// <summary>
        /// Returns true if GridpointForecastPeriodTemperature instances are equal
        /// </summary>
        /// <param name="input">Instance of GridpointForecastPeriodTemperature to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GridpointForecastPeriodTemperature input)
        {
            if (input == null)
                return false;

            return this.ActualInstance.Equals(input.ActualInstance);
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
                if (this.ActualInstance != null)
                    hashCode = hashCode * 59 + this.ActualInstance.GetHashCode();
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

    /// <summary>
    /// Custom JSON converter for GridpointForecastPeriodTemperature
    /// </summary>
    public class GridpointForecastPeriodTemperatureJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(GridpointForecastPeriodTemperature).GetMethod("ToJson").Invoke(value, null)));
        }

        /// <summary>
        /// To convert a JSON string into an object
        /// </summary>
        /// <param name="reader">JSON reader</param>
        /// <param name="objectType">Object type</param>
        /// <param name="existingValue">Existing value</param>
        /// <param name="serializer">JSON Serializer</param>
        /// <returns>The object converted from the JSON string</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if(reader.TokenType != JsonToken.Null)
            {
                return GridpointForecastPeriodTemperature.FromJson(JObject.Load(reader).ToString(Formatting.None));
            }
            return null;
        }

        /// <summary>
        /// Check if the object can be converted
        /// </summary>
        /// <param name="objectType">Object type</param>
        /// <returns>True if the object can be converted</returns>
        public override bool CanConvert(Type objectType)
        {
            return false;
        }
    }

}
