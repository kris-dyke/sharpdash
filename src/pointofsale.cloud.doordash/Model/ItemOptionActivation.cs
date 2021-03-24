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

namespace pointofsale.cloud.doordash.Model
{
    /// <summary>
    /// ItemOptionActivation
    /// </summary>
    [DataContract]
    public class ItemOptionActivation :  IEquatable<ItemOptionActivation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemOptionActivation" /> class.
        /// </summary>
        [JsonConstructor]
        protected ItemOptionActivation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemOptionActivation" /> class.
        /// </summary>
        /// <param name="merchantSuppliedId">merchantSuppliedId (required).</param>
        /// <param name="isActive">isActive (required).</param>
        public ItemOptionActivation(string merchantSuppliedId = default(string), bool? isActive = default(bool?))
        {
            // to ensure "merchantSuppliedId" is required (not null)
            if (merchantSuppliedId == null)
            {
                throw new InvalidDataException("merchantSuppliedId is a required property for ItemOptionActivation and cannot be null");
            }
            else
            {
                MerchantSuppliedId = merchantSuppliedId;
            }
            // to ensure "isActive" is required (not null)
            if (isActive == null)
            {
                throw new InvalidDataException("isActive is a required property for ItemOptionActivation and cannot be null");
            }
            else
            {
                IsActive = isActive;
            }
        }
        
        /// <summary>
        /// Gets or Sets MerchantSuppliedId
        /// </summary>
        [DataMember(Name="merchant_supplied_id", EmitDefaultValue=false)]
        public string MerchantSuppliedId { get; set; }

        /// <summary>
        /// Gets or Sets IsActive
        /// </summary>
        [DataMember(Name="is_active", EmitDefaultValue=false)]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ItemOptionActivation {\n");
            sb.Append("  MerchantSuppliedId: ").Append(MerchantSuppliedId).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
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
            return Equals(input as ItemOptionActivation);
        }

        /// <summary>
        /// Returns true if ItemOptionActivation instances are equal
        /// </summary>
        /// <param name="input">Instance of ItemOptionActivation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItemOptionActivation input)
        {
            if (input == null)
                return false;

            return 
                (
                    MerchantSuppliedId == input.MerchantSuppliedId ||
                    MerchantSuppliedId != null &&
                    MerchantSuppliedId.Equals(input.MerchantSuppliedId)
                ) && 
                (
                    IsActive == input.IsActive ||
                    IsActive != null &&
                    IsActive.Equals(input.IsActive)
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
                if (MerchantSuppliedId != null)
                    hashCode = hashCode * 59 + MerchantSuppliedId.GetHashCode();
                if (IsActive != null)
                    hashCode = hashCode * 59 + IsActive.GetHashCode();
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