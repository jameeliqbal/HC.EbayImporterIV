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
    /// This type is used by the base response of the &lt;strong&gt;getActivities&lt;/strong&gt; method, and includes a log of all activities of a payment dispute, from creation to resolution.
    /// </summary>
    [DataContract]
        public partial class PaymentDisputeActivityHistory :  IEquatable<PaymentDisputeActivityHistory>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentDisputeActivityHistory" /> class.
        /// </summary>
        /// <param name="activity">This array holds all activities of a payment dispute, from creation to resolution. For each activity, the activity type, the actor, and a timestamp is shown. The &lt;strong&gt;getActivities&lt;/strong&gt; response is dynamic, and grows with each recorded activity..</param>
        public PaymentDisputeActivityHistory(List<PaymentDisputeActivity> activity = default(List<PaymentDisputeActivity>))
        {
            this.Activity = activity;
        }
        
        /// <summary>
        /// This array holds all activities of a payment dispute, from creation to resolution. For each activity, the activity type, the actor, and a timestamp is shown. The &lt;strong&gt;getActivities&lt;/strong&gt; response is dynamic, and grows with each recorded activity.
        /// </summary>
        /// <value>This array holds all activities of a payment dispute, from creation to resolution. For each activity, the activity type, the actor, and a timestamp is shown. The &lt;strong&gt;getActivities&lt;/strong&gt; response is dynamic, and grows with each recorded activity.</value>
        [DataMember(Name="activity", EmitDefaultValue=false)]
        public List<PaymentDisputeActivity> Activity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentDisputeActivityHistory {\n");
            sb.Append("  Activity: ").Append(Activity).Append("\n");
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
            return this.Equals(input as PaymentDisputeActivityHistory);
        }

        /// <summary>
        /// Returns true if PaymentDisputeActivityHistory instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentDisputeActivityHistory to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentDisputeActivityHistory input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Activity == input.Activity ||
                    this.Activity != null &&
                    input.Activity != null &&
                    this.Activity.SequenceEqual(input.Activity)
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
                if (this.Activity != null)
                    hashCode = hashCode * 59 + this.Activity.GetHashCode();
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
