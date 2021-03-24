/* 
 * API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace pointofsale.cloud.doordash.Model
{
    /// <summary>
    /// StoreOpenHour
    /// </summary>
    [DataContract]
    public class StoreOpenHour :  IEquatable<StoreOpenHour>, IValidatableObject
    {
        /// <summary>
        /// Defines DayIndex
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DayIndexEnum
        {
            
            /// <summary>
            /// Enum MON for value: MON
            /// </summary>
            [EnumMember(Value = "MON")]
            MON = 1,
            
            /// <summary>
            /// Enum TUE for value: TUE
            /// </summary>
            [EnumMember(Value = "TUE")]
            TUE = 2,
            
            /// <summary>
            /// Enum WED for value: WED
            /// </summary>
            [EnumMember(Value = "WED")]
            WED = 3,
            
            /// <summary>
            /// Enum THU for value: THU
            /// </summary>
            [EnumMember(Value = "THU")]
            THU = 4,
            
            /// <summary>
            /// Enum FRI for value: FRI
            /// </summary>
            [EnumMember(Value = "FRI")]
            FRI = 5,
            
            /// <summary>
            /// Enum SAT for value: SAT
            /// </summary>
            [EnumMember(Value = "SAT")]
            SAT = 6,
            
            /// <summary>
            /// Enum SUN for value: SUN
            /// </summary>
            [EnumMember(Value = "SUN")]
            SUN = 7
        }

        /// <summary>
        /// Gets or Sets DayIndex
        /// </summary>
        [DataMember(Name="day_index", EmitDefaultValue=false)]
        public DayIndexEnum? DayIndex { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="StoreOpenHour" /> class.
        /// </summary>
        /// <param name="dayIndex">dayIndex.</param>
        /// <param name="startTime">Start time in format HH:MM:SS.</param>
        /// <param name="endTime">End time in format HH:MM:SS.</param>
        public StoreOpenHour(DayIndexEnum? dayIndex = default(DayIndexEnum?), string startTime = default(string), string endTime = default(string))
        {
            DayIndex = dayIndex;
            StartTime = startTime;
            EndTime = endTime;
        }
        

        /// <summary>
        /// Start time in format HH:MM:SS
        /// </summary>
        /// <value>Start time in format HH:MM:SS</value>
        [DataMember(Name="start_time", EmitDefaultValue=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// End time in format HH:MM:SS
        /// </summary>
        /// <value>End time in format HH:MM:SS</value>
        [DataMember(Name="end_time", EmitDefaultValue=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StoreOpenHour {\n");
            sb.Append("  DayIndex: ").Append(DayIndex).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return Equals(input as StoreOpenHour);
        }

        /// <summary>
        /// Returns true if StoreOpenHour instances are equal
        /// </summary>
        /// <param name="input">Instance of StoreOpenHour to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StoreOpenHour input)
        {
            if (input == null)
                return false;

            return 
                (
                    DayIndex == input.DayIndex ||
                    DayIndex != null &&
                    DayIndex.Equals(input.DayIndex)
                ) && 
                (
                    StartTime == input.StartTime ||
                    StartTime != null &&
                    StartTime.Equals(input.StartTime)
                ) && 
                (
                    EndTime == input.EndTime ||
                    EndTime != null &&
                    EndTime.Equals(input.EndTime)
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
                if (DayIndex != null)
                    hashCode = hashCode * 59 + DayIndex.GetHashCode();
                if (StartTime != null)
                    hashCode = hashCode * 59 + StartTime.GetHashCode();
                if (EndTime != null)
                    hashCode = hashCode * 59 + EndTime.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}