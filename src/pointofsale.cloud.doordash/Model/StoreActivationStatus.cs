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
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace pointofsale.cloud.doordash.Model
{
    /// <summary>
    /// StoreActivationStatus
    /// </summary>
    [DataContract]
    public class StoreActivationStatus :  IEquatable<StoreActivationStatus>, IValidatableObject
    {
        /// <summary>
        /// Defines Reason
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ReasonEnum
        {
            
            /// <summary>
            /// Enum Outofbusiness for value: out_of_business
            /// </summary>
            [EnumMember(Value = "out_of_business")]
            Outofbusiness = 1,
            
            /// <summary>
            /// Enum Deletestore for value: delete_store
            /// </summary>
            [EnumMember(Value = "delete_store")]
            Deletestore = 2,
            
            /// <summary>
            /// Enum Paymentissue for value: payment_issue
            /// </summary>
            [EnumMember(Value = "payment_issue")]
            Paymentissue = 3,
            
            /// <summary>
            /// Enum Operationalissues for value: operational_issues
            /// </summary>
            [EnumMember(Value = "operational_issues")]
            Operationalissues = 4,
            
            /// <summary>
            /// Enum StoreselfdisabledintheirPOSportal for value: store_self_disabled_in_their_POS_portal
            /// </summary>
            [EnumMember(Value = "store_self_disabled_in_their_POS_portal")]
            StoreselfdisabledintheirPOSportal = 5,
            
            /// <summary>
            /// Enum Storeposconnectivityissues for value: store_pos_connectivity_issues
            /// </summary>
            [EnumMember(Value = "store_pos_connectivity_issues")]
            Storeposconnectivityissues = 6
        }

        /// <summary>
        /// Gets or Sets Reason
        /// </summary>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public ReasonEnum? Reason { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="StoreActivationStatus" /> class.
        /// </summary>
        [JsonConstructor]
        protected StoreActivationStatus() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StoreActivationStatus" /> class.
        /// </summary>
        /// <param name="isActive">Should store be deactivated/activated (required).</param>
        /// <param name="reason">reason.</param>
        /// <param name="notes">notes.</param>
        /// <param name="shouldSendEmail">Should send email or not for store deactivation.</param>
        public StoreActivationStatus(bool? isActive = default(bool?), ReasonEnum? reason = default(ReasonEnum?), string notes = default(string), bool? shouldSendEmail = default(bool?))
        {
            // to ensure "isActive" is required (not null)
            if (isActive == null)
            {
                throw new InvalidDataException("isActive is a required property for StoreActivationStatus and cannot be null");
            }
            else
            {
                IsActive = isActive;
            }
            Reason = reason;
            Notes = notes;
            ShouldSendEmail = shouldSendEmail;
        }
        
        /// <summary>
        /// Should store be deactivated/activated
        /// </summary>
        /// <value>Should store be deactivated/activated</value>
        [DataMember(Name="is_active", EmitDefaultValue=false)]
        public bool? IsActive { get; set; }


        /// <summary>
        /// Gets or Sets Notes
        /// </summary>
        [DataMember(Name="notes", EmitDefaultValue=false)]
        public string Notes { get; set; }

        /// <summary>
        /// Should send email or not for store deactivation
        /// </summary>
        /// <value>Should send email or not for store deactivation</value>
        [DataMember(Name="should_send_email", EmitDefaultValue=false)]
        public bool? ShouldSendEmail { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StoreActivationStatus {\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  ShouldSendEmail: ").Append(ShouldSendEmail).Append("\n");
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
            return Equals(input as StoreActivationStatus);
        }

        /// <summary>
        /// Returns true if StoreActivationStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of StoreActivationStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StoreActivationStatus input)
        {
            if (input == null)
                return false;

            return 
                (
                    IsActive == input.IsActive ||
                    IsActive != null &&
                    IsActive.Equals(input.IsActive)
                ) && 
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
                    ShouldSendEmail == input.ShouldSendEmail ||
                    ShouldSendEmail != null &&
                    ShouldSendEmail.Equals(input.ShouldSendEmail)
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
                if (IsActive != null)
                    hashCode = hashCode * 59 + IsActive.GetHashCode();
                if (Reason != null)
                    hashCode = hashCode * 59 + Reason.GetHashCode();
                if (Notes != null)
                    hashCode = hashCode * 59 + Notes.GetHashCode();
                if (ShouldSendEmail != null)
                    hashCode = hashCode * 59 + ShouldSendEmail.GetHashCode();
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
