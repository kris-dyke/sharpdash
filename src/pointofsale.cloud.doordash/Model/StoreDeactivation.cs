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

namespace pointofsale.cloud.doordash.Model
{
    /// <summary>
    /// StoreDeactivation
    /// </summary>
    [DataContract]
    public class StoreDeactivation :  IEquatable<StoreDeactivation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StoreDeactivation" /> class.
        /// </summary>
        /// <param name="reason">Reason why the Store was deactivated.</param>
        /// <param name="notes">Notes about the Store deactivation.</param>
        /// <param name="createdAt">Time of store deactivation request.</param>
        /// <param name="endTime">End time for a temporal deactivation.</param>
        public StoreDeactivation(string reason = default(string), string notes = default(string), DateTime? createdAt = default(DateTime?), DateTime? endTime = default(DateTime?))
        {
            Reason = reason;
            Notes = notes;
            CreatedAt = createdAt;
            EndTime = endTime;
        }
        
        /// <summary>
        /// Reason why the Store was deactivated
        /// </summary>
        /// <value>Reason why the Store was deactivated</value>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public string Reason { get; set; }

        /// <summary>
        /// Notes about the Store deactivation
        /// </summary>
        /// <value>Notes about the Store deactivation</value>
        [DataMember(Name="notes", EmitDefaultValue=false)]
        public string Notes { get; set; }

        /// <summary>
        /// Time of store deactivation request
        /// </summary>
        /// <value>Time of store deactivation request</value>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// End time for a temporal deactivation
        /// </summary>
        /// <value>End time for a temporal deactivation</value>
        [DataMember(Name="end_time", EmitDefaultValue=false)]
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StoreDeactivation {\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
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
            return Equals(input as StoreDeactivation);
        }

        /// <summary>
        /// Returns true if StoreDeactivation instances are equal
        /// </summary>
        /// <param name="input">Instance of StoreDeactivation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StoreDeactivation input)
        {
            if (input == null)
                return false;

            return 
                (
                    Reason == input.Reason ||
                    Reason != null &&
                    Reason.Equals(input.Reason)
                ) && 
                (
                    Notes == input.Notes ||
                    Notes != null &&
                    Notes.Equals(input.Notes)
                ) && 
                (
                    CreatedAt == input.CreatedAt ||
                    CreatedAt != null &&
                    CreatedAt.Equals(input.CreatedAt)
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
                if (Reason != null)
                    hashCode = hashCode * 59 + Reason.GetHashCode();
                if (Notes != null)
                    hashCode = hashCode * 59 + Notes.GetHashCode();
                if (CreatedAt != null)
                    hashCode = hashCode * 59 + CreatedAt.GetHashCode();
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
