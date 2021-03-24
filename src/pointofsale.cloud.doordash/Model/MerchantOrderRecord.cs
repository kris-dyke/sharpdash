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
    /// MerchantOrderRecord
    /// </summary>
    [DataContract]
    public sealed class MerchantOrderRecord :  IEquatable<MerchantOrderRecord>, IValidatableObject
    {
        /// <summary>
        /// Defines OrderStatus
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OrderStatusEnum
        {

            /// <summary>
            /// Enum Success for value: success
            /// </summary>
            [EnumMember(Value = "success")]
            Success = 1,

            /// <summary>
            /// Enum Fail for value: fail
            /// </summary>
            [EnumMember(Value = "fail")]
            Fail = 2
        }

        /// <summary>
        /// Gets or Sets OrderStatus
        /// </summary>
        [DataMember(Name="order_status", EmitDefaultValue=false)]
        public OrderStatusEnum OrderStatus { get; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantOrderRecord" /> class.
        /// </summary>
        [JsonConstructor]
        MerchantOrderRecord() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantOrderRecord" /> class.
        /// </summary>
        /// <param name="merchantSuppliedId">Order ID in your system (required).</param>
        /// <param name="orderStatus">orderStatus (required).</param>
        /// <param name="failureReason">Reason why order can&#39;t be fulfilled. Omit if order_status &#x3D; success.</param>
        /// <param name="prepTime">Estimated time by which order should be ready for pickup. It should be inUTC timezone.</param>
        public MerchantOrderRecord(string merchantSuppliedId = default(string), OrderStatusEnum orderStatus = default(OrderStatusEnum), string failureReason = default(string), DateTime? prepTime = default(DateTime?))
        {
            // to ensure "merchantSuppliedId" is required (not null)
            if (merchantSuppliedId == null)
            {
                throw new InvalidDataException("merchantSuppliedId is a required property for MerchantOrderRecord and cannot be null");
            }
            else
            {
                MerchantSuppliedId = merchantSuppliedId;
            }
            // to ensure "orderStatus" is required (not null)
            OrderStatus = orderStatus;
            FailureReason = failureReason;
            PrepTime = prepTime;
        }

        /// <summary>
        /// Order ID in your system
        /// </summary>
        /// <value>Order ID in your system</value>
        [DataMember(Name="merchant_supplied_id", EmitDefaultValue=false)]
        public string MerchantSuppliedId { get; }


        /// <summary>
        /// Reason why order can&#39;t be fulfilled. Omit if order_status &#x3D; success
        /// </summary>
        /// <value>Reason why order can&#39;t be fulfilled. Omit if order_status &#x3D; success</value>
        [DataMember(Name="failure_reason", EmitDefaultValue=false)]
        public string FailureReason { get; }

        /// <summary>
        /// Estimated time by which order should be ready for pickup. It should be inUTC timezone
        /// </summary>
        /// <value>Estimated time by which order should be ready for pickup. It should be inUTC timezone</value>
        [DataMember(Name="prep_time", EmitDefaultValue=false)]
        public DateTime? PrepTime { get; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MerchantOrderRecord {\n");
            sb.Append("  MerchantSuppliedId: ").Append(MerchantSuppliedId).Append("\n");
            sb.Append("  OrderStatus: ").Append(OrderStatus).Append("\n");
            sb.Append("  FailureReason: ").Append(FailureReason).Append("\n");
            sb.Append("  PrepTime: ").Append(PrepTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return Equals(input as MerchantOrderRecord);
        }

        /// <summary>
        /// Returns true if MerchantOrderRecord instances are equal
        /// </summary>
        /// <param name="input">Instance of MerchantOrderRecord to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MerchantOrderRecord input)
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
                    OrderStatus == input.OrderStatus ||
                    OrderStatus.Equals(input.OrderStatus)
                ) &&
                (
                    FailureReason == input.FailureReason ||
                    FailureReason != null &&
                    FailureReason.Equals(input.FailureReason)
                ) &&
                (
                    PrepTime == input.PrepTime ||
                    PrepTime != null &&
                    PrepTime.Equals(input.PrepTime)
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

                hashCode = hashCode * 59 + OrderStatus.GetHashCode();
                if (FailureReason != null)
                    hashCode = hashCode * 59 + FailureReason.GetHashCode();
                if (PrepTime != null)
                    hashCode = hashCode * 59 + PrepTime.GetHashCode();
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