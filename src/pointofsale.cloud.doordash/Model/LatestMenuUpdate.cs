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
    /// LatestMenuUpdate
    /// </summary>
    [DataContract]
    public class LatestMenuUpdate :  IEquatable<LatestMenuUpdate>, IValidatableObject
    {
        /// <summary>
        /// Status of latest menu update
        /// </summary>
        /// <value>Status of latest menu update</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum PENDING for value: PENDING
            /// </summary>
            [EnumMember(Value = "PENDING")]
            PENDING = 1,
            
            /// <summary>
            /// Enum SUCCESS for value: SUCCESS
            /// </summary>
            [EnumMember(Value = "SUCCESS")]
            SUCCESS = 2,
            
            /// <summary>
            /// Enum FAILURE for value: FAILURE
            /// </summary>
            [EnumMember(Value = "FAILURE")]
            FAILURE = 3
        }

        /// <summary>
        /// Status of latest menu update
        /// </summary>
        /// <value>Status of latest menu update</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="LatestMenuUpdate" /> class.
        /// </summary>
        /// <param name="createdAt">Time of latest menu update.</param>
        /// <param name="status">Status of latest menu update.</param>
        public LatestMenuUpdate(DateTime? createdAt = default(DateTime?), StatusEnum? status = default(StatusEnum?))
        {
            CreatedAt = createdAt;
            Status = status;
        }
        
        /// <summary>
        /// Time of latest menu update
        /// </summary>
        /// <value>Time of latest menu update</value>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LatestMenuUpdate {\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return Equals(input as LatestMenuUpdate);
        }

        /// <summary>
        /// Returns true if LatestMenuUpdate instances are equal
        /// </summary>
        /// <param name="input">Instance of LatestMenuUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LatestMenuUpdate input)
        {
            if (input == null)
                return false;

            return 
                (
                    CreatedAt == input.CreatedAt ||
                    CreatedAt != null &&
                    CreatedAt.Equals(input.CreatedAt)
                ) && 
                (
                    Status == input.Status ||
                    Status != null &&
                    Status.Equals(input.Status)
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
                if (CreatedAt != null)
                    hashCode = hashCode * 59 + CreatedAt.GetHashCode();
                if (Status != null)
                    hashCode = hashCode * 59 + Status.GetHashCode();
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
