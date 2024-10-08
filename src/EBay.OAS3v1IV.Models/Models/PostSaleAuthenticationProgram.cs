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
    /// This type is used to provide the status and outcome of an order line item going through the Authenticity Guarantee verification process.
    /// </summary>
    [DataContract]
        public partial class PostSaleAuthenticationProgram :  IEquatable<PostSaleAuthenticationProgram>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostSaleAuthenticationProgram" /> class.
        /// </summary>
        /// <param name="outcomeReason">This field indicates the result of the authenticity verification inspection on an order line item. This field is not returned when the status value of the order line item is &lt;code&gt;PENDING&lt;/code&gt; or &lt;code&gt;PASSED&lt;/code&gt;. The possible values returned here are &lt;code&gt;NOT_AUTHENTIC&lt;/code&gt;, &lt;code&gt;NOT_AS_DESCRIBED&lt;/code&gt;, &lt;code&gt;CUSTOMIZED&lt;/code&gt;, &lt;code&gt;MISCATEGORIZED&lt;/code&gt;, or &lt;code&gt;NOT_AUTHENTIC_NO_RETURN&lt;/code&gt;. For implementation help, refer to &lt;a href&#x3D;&#x27;https://developer.ebay.com/api-docs/sell/fulfillment/types/sel:AuthenticityVerificationReasonEnum&#x27;&gt;eBay API documentation&lt;/a&gt;.</param>
        /// <param name="status">The value in this field indicates whether the order line item has passed or failed the authenticity verification inspection, or if the inspection and/or results are still pending. The possible values returned here are &lt;code&gt;PENDING&lt;/code&gt;, &lt;code&gt;PASSED&lt;/code&gt;, &lt;code&gt;FAILED&lt;/code&gt;, or &lt;code&gt;PASSED_WITH_EXCEPTION&lt;/code&gt;. For implementation help, refer to &lt;a href&#x3D;&#x27;https://developer.ebay.com/api-docs/sell/fulfillment/types/sel:AuthenticityVerificationStatusEnum&#x27;&gt;eBay API documentation&lt;/a&gt;.</param>
        public PostSaleAuthenticationProgram(string outcomeReason = default(string), string status = default(string))
        {
            this.OutcomeReason = outcomeReason;
            this.Status = status;
        }
        
        /// <summary>
        /// This field indicates the result of the authenticity verification inspection on an order line item. This field is not returned when the status value of the order line item is &lt;code&gt;PENDING&lt;/code&gt; or &lt;code&gt;PASSED&lt;/code&gt;. The possible values returned here are &lt;code&gt;NOT_AUTHENTIC&lt;/code&gt;, &lt;code&gt;NOT_AS_DESCRIBED&lt;/code&gt;, &lt;code&gt;CUSTOMIZED&lt;/code&gt;, &lt;code&gt;MISCATEGORIZED&lt;/code&gt;, or &lt;code&gt;NOT_AUTHENTIC_NO_RETURN&lt;/code&gt;. For implementation help, refer to &lt;a href&#x3D;&#x27;https://developer.ebay.com/api-docs/sell/fulfillment/types/sel:AuthenticityVerificationReasonEnum&#x27;&gt;eBay API documentation&lt;/a&gt;
        /// </summary>
        /// <value>This field indicates the result of the authenticity verification inspection on an order line item. This field is not returned when the status value of the order line item is &lt;code&gt;PENDING&lt;/code&gt; or &lt;code&gt;PASSED&lt;/code&gt;. The possible values returned here are &lt;code&gt;NOT_AUTHENTIC&lt;/code&gt;, &lt;code&gt;NOT_AS_DESCRIBED&lt;/code&gt;, &lt;code&gt;CUSTOMIZED&lt;/code&gt;, &lt;code&gt;MISCATEGORIZED&lt;/code&gt;, or &lt;code&gt;NOT_AUTHENTIC_NO_RETURN&lt;/code&gt;. For implementation help, refer to &lt;a href&#x3D;&#x27;https://developer.ebay.com/api-docs/sell/fulfillment/types/sel:AuthenticityVerificationReasonEnum&#x27;&gt;eBay API documentation&lt;/a&gt;</value>
        [DataMember(Name="outcomeReason", EmitDefaultValue=false)]
        public string OutcomeReason { get; set; }

        /// <summary>
        /// The value in this field indicates whether the order line item has passed or failed the authenticity verification inspection, or if the inspection and/or results are still pending. The possible values returned here are &lt;code&gt;PENDING&lt;/code&gt;, &lt;code&gt;PASSED&lt;/code&gt;, &lt;code&gt;FAILED&lt;/code&gt;, or &lt;code&gt;PASSED_WITH_EXCEPTION&lt;/code&gt;. For implementation help, refer to &lt;a href&#x3D;&#x27;https://developer.ebay.com/api-docs/sell/fulfillment/types/sel:AuthenticityVerificationStatusEnum&#x27;&gt;eBay API documentation&lt;/a&gt;
        /// </summary>
        /// <value>The value in this field indicates whether the order line item has passed or failed the authenticity verification inspection, or if the inspection and/or results are still pending. The possible values returned here are &lt;code&gt;PENDING&lt;/code&gt;, &lt;code&gt;PASSED&lt;/code&gt;, &lt;code&gt;FAILED&lt;/code&gt;, or &lt;code&gt;PASSED_WITH_EXCEPTION&lt;/code&gt;. For implementation help, refer to &lt;a href&#x3D;&#x27;https://developer.ebay.com/api-docs/sell/fulfillment/types/sel:AuthenticityVerificationStatusEnum&#x27;&gt;eBay API documentation&lt;/a&gt;</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PostSaleAuthenticationProgram {\n");
            sb.Append("  OutcomeReason: ").Append(OutcomeReason).Append("\n");
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
            return this.Equals(input as PostSaleAuthenticationProgram);
        }

        /// <summary>
        /// Returns true if PostSaleAuthenticationProgram instances are equal
        /// </summary>
        /// <param name="input">Instance of PostSaleAuthenticationProgram to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PostSaleAuthenticationProgram input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OutcomeReason == input.OutcomeReason ||
                    (this.OutcomeReason != null &&
                    this.OutcomeReason.Equals(input.OutcomeReason))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.OutcomeReason != null)
                    hashCode = hashCode * 59 + this.OutcomeReason.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
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
