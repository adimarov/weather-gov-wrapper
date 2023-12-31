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

namespace WeatherGov.Wrapper.Model
{
    /// <summary>
    /// An object containing forecast information for a specific time period (generally 12-hour or 1-hour). 
    /// </summary>
    [DataContract(Name = "GridpointForecastPeriod")]
    public partial class GridpointForecastPeriod : IEquatable<GridpointForecastPeriod>, IValidatableObject
    {
        /// <summary>
        /// The unit of the temperature value (Fahrenheit or Celsius). This property is deprecated. Future versions will indicate the unit within the quantitative value object for the temperature property. To make use of the future standard format now, set the \&quot;forecast_temperature_qv\&quot; feature flag on the request. 
        /// </summary>
        /// <value>The unit of the temperature value (Fahrenheit or Celsius). This property is deprecated. Future versions will indicate the unit within the quantitative value object for the temperature property. To make use of the future standard format now, set the \&quot;forecast_temperature_qv\&quot; feature flag on the request. </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TemperatureUnitEnum
        {
            /// <summary>
            /// Enum F for value: F
            /// </summary>
            [EnumMember(Value = "F")]
            F = 1,

            /// <summary>
            /// Enum C for value: C
            /// </summary>
            [EnumMember(Value = "C")]
            C = 2
        }


        /// <summary>
        /// The unit of the temperature value (Fahrenheit or Celsius). This property is deprecated. Future versions will indicate the unit within the quantitative value object for the temperature property. To make use of the future standard format now, set the \&quot;forecast_temperature_qv\&quot; feature flag on the request. 
        /// </summary>
        /// <value>The unit of the temperature value (Fahrenheit or Celsius). This property is deprecated. Future versions will indicate the unit within the quantitative value object for the temperature property. To make use of the future standard format now, set the \&quot;forecast_temperature_qv\&quot; feature flag on the request. </value>
        [DataMember(Name = "temperatureUnit", EmitDefaultValue = false)]
        [Obsolete]
        public TemperatureUnitEnum? TemperatureUnit { get; set; }
        /// <summary>
        /// If not null, indicates a non-diurnal temperature trend for the period (either rising temperature overnight, or falling temperature during the day) 
        /// </summary>
        /// <value>If not null, indicates a non-diurnal temperature trend for the period (either rising temperature overnight, or falling temperature during the day) </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TemperatureTrendEnum
        {
            /// <summary>
            /// Enum Rising for value: rising
            /// </summary>
            [EnumMember(Value = "rising")]
            Rising = 1,

            /// <summary>
            /// Enum Falling for value: falling
            /// </summary>
            [EnumMember(Value = "falling")]
            Falling = 2
        }


        /// <summary>
        /// If not null, indicates a non-diurnal temperature trend for the period (either rising temperature overnight, or falling temperature during the day) 
        /// </summary>
        /// <value>If not null, indicates a non-diurnal temperature trend for the period (either rising temperature overnight, or falling temperature during the day) </value>
        [DataMember(Name = "temperatureTrend", EmitDefaultValue = true)]
        public TemperatureTrendEnum? TemperatureTrend { get; set; }
        /// <summary>
        /// The prevailing direction of the wind for the period, using a 16-point compass.
        /// </summary>
        /// <value>The prevailing direction of the wind for the period, using a 16-point compass.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum WindDirectionEnum
        {
            /// <summary>
            /// Enum N for value: N
            /// </summary>
            [EnumMember(Value = "N")]
            N = 1,

            /// <summary>
            /// Enum NNE for value: NNE
            /// </summary>
            [EnumMember(Value = "NNE")]
            NNE = 2,

            /// <summary>
            /// Enum NE for value: NE
            /// </summary>
            [EnumMember(Value = "NE")]
            NE = 3,

            /// <summary>
            /// Enum ENE for value: ENE
            /// </summary>
            [EnumMember(Value = "ENE")]
            ENE = 4,

            /// <summary>
            /// Enum E for value: E
            /// </summary>
            [EnumMember(Value = "E")]
            E = 5,

            /// <summary>
            /// Enum ESE for value: ESE
            /// </summary>
            [EnumMember(Value = "ESE")]
            ESE = 6,

            /// <summary>
            /// Enum SE for value: SE
            /// </summary>
            [EnumMember(Value = "SE")]
            SE = 7,

            /// <summary>
            /// Enum SSE for value: SSE
            /// </summary>
            [EnumMember(Value = "SSE")]
            SSE = 8,

            /// <summary>
            /// Enum S for value: S
            /// </summary>
            [EnumMember(Value = "S")]
            S = 9,

            /// <summary>
            /// Enum SSW for value: SSW
            /// </summary>
            [EnumMember(Value = "SSW")]
            SSW = 10,

            /// <summary>
            /// Enum SW for value: SW
            /// </summary>
            [EnumMember(Value = "SW")]
            SW = 11,

            /// <summary>
            /// Enum WSW for value: WSW
            /// </summary>
            [EnumMember(Value = "WSW")]
            WSW = 12,

            /// <summary>
            /// Enum W for value: W
            /// </summary>
            [EnumMember(Value = "W")]
            W = 13,

            /// <summary>
            /// Enum WNW for value: WNW
            /// </summary>
            [EnumMember(Value = "WNW")]
            WNW = 14,

            /// <summary>
            /// Enum NW for value: NW
            /// </summary>
            [EnumMember(Value = "NW")]
            NW = 15,

            /// <summary>
            /// Enum NNW for value: NNW
            /// </summary>
            [EnumMember(Value = "NNW")]
            NNW = 16
        }


        /// <summary>
        /// The prevailing direction of the wind for the period, using a 16-point compass.
        /// </summary>
        /// <value>The prevailing direction of the wind for the period, using a 16-point compass.</value>
        [DataMember(Name = "windDirection", EmitDefaultValue = false)]
        public WindDirectionEnum? WindDirection { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GridpointForecastPeriod" /> class.
        /// </summary>
        /// <param name="number">Sequential period number..</param>
        /// <param name="name">A textual identifier for the period. This value will not be present for hourly forecasts. .</param>
        /// <param name="startTime">The starting time that this forecast period is valid for..</param>
        /// <param name="endTime">The ending time that this forecast period is valid for..</param>
        /// <param name="isDaytime">Indicates whether this period is daytime or nighttime..</param>
        /// <param name="temperature">temperature.</param>
        /// <param name="temperatureUnit">The unit of the temperature value (Fahrenheit or Celsius). This property is deprecated. Future versions will indicate the unit within the quantitative value object for the temperature property. To make use of the future standard format now, set the \&quot;forecast_temperature_qv\&quot; feature flag on the request. .</param>
        /// <param name="temperatureTrend">If not null, indicates a non-diurnal temperature trend for the period (either rising temperature overnight, or falling temperature during the day) .</param>
        /// <param name="probabilityOfPrecipitation">probabilityOfPrecipitation.</param>
        /// <param name="dewpoint">dewpoint.</param>
        /// <param name="relativeHumidity">relativeHumidity.</param>
        /// <param name="windSpeed">windSpeed.</param>
        /// <param name="windGust">windGust.</param>
        /// <param name="windDirection">The prevailing direction of the wind for the period, using a 16-point compass..</param>
        /// <param name="icon">A link to an icon representing the forecast summary..</param>
        /// <param name="shortForecast">A brief textual forecast summary for the period..</param>
        /// <param name="detailedForecast">A detailed textual forecast for the period..</param>
        public GridpointForecastPeriod(int number = default(int), string name = default(string), DateTime startTime = default(DateTime), DateTime endTime = default(DateTime), bool isDaytime = default(bool), float temperature = default(float), TemperatureUnitEnum? temperatureUnit = default(TemperatureUnitEnum?), TemperatureTrendEnum? temperatureTrend = default(TemperatureTrendEnum?), QuantitativeValue probabilityOfPrecipitation = default(QuantitativeValue), QuantitativeValue dewpoint = default(QuantitativeValue), QuantitativeValue relativeHumidity = default(QuantitativeValue), string windSpeed = default(string), GridpointForecastPeriodWindGust windGust = default(GridpointForecastPeriodWindGust), WindDirectionEnum? windDirection = default(WindDirectionEnum?), string icon = default(string), string shortForecast = default(string), string detailedForecast = default(string))
        {
            this.Number = number;
            this.Name = name;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.IsDaytime = isDaytime;
            this.Temperature = temperature;
            this.TemperatureUnit = temperatureUnit;
            this.TemperatureTrend = temperatureTrend;
            this.ProbabilityOfPrecipitation = probabilityOfPrecipitation;
            this.Dewpoint = dewpoint;
            this.RelativeHumidity = relativeHumidity;
            this.WindSpeed = windSpeed;
            this.WindGust = windGust;
            this.WindDirection = windDirection;
            this.Icon = icon;
            this.ShortForecast = shortForecast;
            this.DetailedForecast = detailedForecast;
        }

        /// <summary>
        /// Sequential period number.
        /// </summary>
        /// <value>Sequential period number.</value>
        [DataMember(Name = "number", EmitDefaultValue = false)]
        public int Number { get; set; }

        /// <summary>
        /// A textual identifier for the period. This value will not be present for hourly forecasts. 
        /// </summary>
        /// <value>A textual identifier for the period. This value will not be present for hourly forecasts. </value>
        /// <example>Tuesday Night</example>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The starting time that this forecast period is valid for.
        /// </summary>
        /// <value>The starting time that this forecast period is valid for.</value>
        [DataMember(Name = "startTime", EmitDefaultValue = false)]
        public DateTime StartTime { get; set; }

        /// <summary>
        /// The ending time that this forecast period is valid for.
        /// </summary>
        /// <value>The ending time that this forecast period is valid for.</value>
        [DataMember(Name = "endTime", EmitDefaultValue = false)]
        public DateTime EndTime { get; set; }

        /// <summary>
        /// Indicates whether this period is daytime or nighttime.
        /// </summary>
        /// <value>Indicates whether this period is daytime or nighttime.</value>
        [DataMember(Name = "isDaytime", EmitDefaultValue = true)]
        public bool IsDaytime { get; set; }

        /// <summary>
        /// Gets or Sets Temperature
        /// </summary>
        [DataMember(Name = "temperature", EmitDefaultValue = false)]
        public float Temperature { get; set; }

        /// <summary>
        /// Gets or Sets ProbabilityOfPrecipitation
        /// </summary>
        [DataMember(Name = "probabilityOfPrecipitation", EmitDefaultValue = false)]
        public QuantitativeValue ProbabilityOfPrecipitation { get; set; }

        /// <summary>
        /// Gets or Sets Dewpoint
        /// </summary>
        [DataMember(Name = "dewpoint", EmitDefaultValue = false)]
        public QuantitativeValue Dewpoint { get; set; }

        /// <summary>
        /// Gets or Sets RelativeHumidity
        /// </summary>
        [DataMember(Name = "relativeHumidity", EmitDefaultValue = false)]
        public QuantitativeValue RelativeHumidity { get; set; }

        /// <summary>
        /// Gets or Sets WindSpeed
        /// </summary>
        [DataMember(Name = "windSpeed", EmitDefaultValue = false)]
        public string WindSpeed { get; set; }

        /// <summary>
        /// Gets or Sets WindGust
        /// </summary>
        [DataMember(Name = "windGust", EmitDefaultValue = true)]
        public GridpointForecastPeriodWindGust WindGust { get; set; }

        /// <summary>
        /// A link to an icon representing the forecast summary.
        /// </summary>
        /// <value>A link to an icon representing the forecast summary.</value>
        [DataMember(Name = "icon", EmitDefaultValue = false)]
        [Obsolete]
        public string Icon { get; set; }

        /// <summary>
        /// A brief textual forecast summary for the period.
        /// </summary>
        /// <value>A brief textual forecast summary for the period.</value>
        [DataMember(Name = "shortForecast", EmitDefaultValue = false)]
        public string ShortForecast { get; set; }

        /// <summary>
        /// A detailed textual forecast for the period.
        /// </summary>
        /// <value>A detailed textual forecast for the period.</value>
        [DataMember(Name = "detailedForecast", EmitDefaultValue = false)]
        public string DetailedForecast { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GridpointForecastPeriod {\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  IsDaytime: ").Append(IsDaytime).Append("\n");
            sb.Append("  Temperature: ").Append(Temperature).Append("\n");
            sb.Append("  TemperatureUnit: ").Append(TemperatureUnit).Append("\n");
            sb.Append("  TemperatureTrend: ").Append(TemperatureTrend).Append("\n");
            sb.Append("  ProbabilityOfPrecipitation: ").Append(ProbabilityOfPrecipitation).Append("\n");
            sb.Append("  Dewpoint: ").Append(Dewpoint).Append("\n");
            sb.Append("  RelativeHumidity: ").Append(RelativeHumidity).Append("\n");
            sb.Append("  WindSpeed: ").Append(WindSpeed).Append("\n");
            sb.Append("  WindGust: ").Append(WindGust).Append("\n");
            sb.Append("  WindDirection: ").Append(WindDirection).Append("\n");
            sb.Append("  Icon: ").Append(Icon).Append("\n");
            sb.Append("  ShortForecast: ").Append(ShortForecast).Append("\n");
            sb.Append("  DetailedForecast: ").Append(DetailedForecast).Append("\n");
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
            return this.Equals(input as GridpointForecastPeriod);
        }

        /// <summary>
        /// Returns true if GridpointForecastPeriod instances are equal
        /// </summary>
        /// <param name="input">Instance of GridpointForecastPeriod to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GridpointForecastPeriod input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Number == input.Number ||
                    this.Number.Equals(input.Number)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.IsDaytime == input.IsDaytime ||
                    this.IsDaytime.Equals(input.IsDaytime)
                ) && 
                (
                    this.Temperature == input.Temperature ||
                    (this.Temperature != null &&
                    this.Temperature.Equals(input.Temperature))
                ) && 
                (
                    this.TemperatureUnit == input.TemperatureUnit ||
                    this.TemperatureUnit.Equals(input.TemperatureUnit)
                ) && 
                (
                    this.TemperatureTrend == input.TemperatureTrend ||
                    this.TemperatureTrend.Equals(input.TemperatureTrend)
                ) && 
                (
                    this.ProbabilityOfPrecipitation == input.ProbabilityOfPrecipitation ||
                    (this.ProbabilityOfPrecipitation != null &&
                    this.ProbabilityOfPrecipitation.Equals(input.ProbabilityOfPrecipitation))
                ) && 
                (
                    this.Dewpoint == input.Dewpoint ||
                    (this.Dewpoint != null &&
                    this.Dewpoint.Equals(input.Dewpoint))
                ) && 
                (
                    this.RelativeHumidity == input.RelativeHumidity ||
                    (this.RelativeHumidity != null &&
                    this.RelativeHumidity.Equals(input.RelativeHumidity))
                ) && 
                (
                    this.WindSpeed == input.WindSpeed ||
                    (this.WindSpeed != null &&
                    this.WindSpeed.Equals(input.WindSpeed))
                ) && 
                (
                    this.WindGust == input.WindGust ||
                    (this.WindGust != null &&
                    this.WindGust.Equals(input.WindGust))
                ) && 
                (
                    this.WindDirection == input.WindDirection ||
                    this.WindDirection.Equals(input.WindDirection)
                ) && 
                (
                    this.Icon == input.Icon ||
                    (this.Icon != null &&
                    this.Icon.Equals(input.Icon))
                ) && 
                (
                    this.ShortForecast == input.ShortForecast ||
                    (this.ShortForecast != null &&
                    this.ShortForecast.Equals(input.ShortForecast))
                ) && 
                (
                    this.DetailedForecast == input.DetailedForecast ||
                    (this.DetailedForecast != null &&
                    this.DetailedForecast.Equals(input.DetailedForecast))
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
                hashCode = (hashCode * 59) + this.Number.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.StartTime != null)
                {
                    hashCode = (hashCode * 59) + this.StartTime.GetHashCode();
                }
                if (this.EndTime != null)
                {
                    hashCode = (hashCode * 59) + this.EndTime.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsDaytime.GetHashCode();
                if (this.Temperature != null)
                {
                    hashCode = (hashCode * 59) + this.Temperature.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TemperatureUnit.GetHashCode();
                hashCode = (hashCode * 59) + this.TemperatureTrend.GetHashCode();
                if (this.ProbabilityOfPrecipitation != null)
                {
                    hashCode = (hashCode * 59) + this.ProbabilityOfPrecipitation.GetHashCode();
                }
                if (this.Dewpoint != null)
                {
                    hashCode = (hashCode * 59) + this.Dewpoint.GetHashCode();
                }
                if (this.RelativeHumidity != null)
                {
                    hashCode = (hashCode * 59) + this.RelativeHumidity.GetHashCode();
                }
                if (this.WindSpeed != null)
                {
                    hashCode = (hashCode * 59) + this.WindSpeed.GetHashCode();
                }
                if (this.WindGust != null)
                {
                    hashCode = (hashCode * 59) + this.WindGust.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.WindDirection.GetHashCode();
                if (this.Icon != null)
                {
                    hashCode = (hashCode * 59) + this.Icon.GetHashCode();
                }
                if (this.ShortForecast != null)
                {
                    hashCode = (hashCode * 59) + this.ShortForecast.GetHashCode();
                }
                if (this.DetailedForecast != null)
                {
                    hashCode = (hashCode * 59) + this.DetailedForecast.GetHashCode();
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
            // Number (int) minimum
            if (this.Number < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Number, must be a value greater than or equal to 1.", new [] { "Number" });
            }

            yield break;
        }
    }

}
