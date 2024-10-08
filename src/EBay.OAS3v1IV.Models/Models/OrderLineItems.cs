/* 
 * Fulfillment API
 *
 * Use the Fulfillment API to complete the process of packaging, addressing, handling, and shipping each order on behalf of the seller, in accordance with the payment method and timing specified at checkout.
 *
 * OpenAPI spec version: v1.20.3
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
//using SwaggerDateConverter = EBay.OAS3v1IV.Client.SwaggerDateConverter;
namespace eBay.OAS3v1IV.Models
{
    /// <summary>
    /// This type is used by the &lt;strong&gt;lineItems&lt;/strong&gt; array that is used to identify one or more line items in the order with the payment dispute.
    /// </summary>
    [DataContract]
        public partial class OrderLineItems :  IEquatable<OrderLineItems>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderLineItems" /> class.
        /// </summary>
        /// <param name="itemId">The unique identifier of the eBay listing associated with the order..</param>
        /// <param name="lineItemId">The unique identifier of the line item within the order..</param>
        public OrderLineItems(string itemId = default(string), string lineItemId = default(string))
        {
            this.ItemId = itemId;
            this.LineItemId = lineItemId;
        }
        
        /// <summary>
        /// The unique identifier of the eBay listing associated with the order.
        /// </summary>
        /// <value>The unique identifier of the eBay listing associated with the order.</value>
        [DataMember(Name="itemId", EmitDefaultValue=false)]
        public string ItemId { get; set; }

        /// <summary>
        /// The unique identifier of the line item within the order.
        /// </summary>
        /// <value>The unique identifier of the line item within the order.</value>
        [DataMember(Name="lineItemId", EmitDefaultValue=false)]
        public string LineItemId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderLineItems {\n");
            sb.Append("  ItemId: ").Append(ItemId).Append("\n");
            sb.Append("  LineItemId: ").Append(LineItemId).Append("\n");
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
            return this.Equals(input as OrderLineItems);
        }

        /// <summary>
        /// Returns true if OrderLineItems instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderLineItems to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderLineItems input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ItemId == input.ItemId ||
                    (this.ItemId != null &&
                    this.ItemId.Equals(input.ItemId))
                ) && 
                (
                    this.LineItemId == input.LineItemId ||
                    (this.LineItemId != null &&
                    this.LineItemId.Equals(input.LineItemId))
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
                if (this.ItemId != null)
                    hashCode = hashCode * 59 + this.ItemId.GetHashCode();
                if (this.LineItemId != null)
                    hashCode = hashCode * 59 + this.LineItemId.GetHashCode();
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
