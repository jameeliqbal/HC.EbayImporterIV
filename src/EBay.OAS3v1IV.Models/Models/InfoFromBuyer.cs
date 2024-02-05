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
using SwaggerDateConverter = EBay.OAS3v1IV.Client.SwaggerDateConverter;
namespace EBay.OAS3v1IV.Models
{
    /// <summary>
    /// This container is returned if the buyer is returning one or more line items in an order that is associated with the payment dispute, and that buyer has provided return shipping tracking information and/or a note about the return.
    /// </summary>
    [DataContract]
        public partial class InfoFromBuyer :  IEquatable<InfoFromBuyer>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InfoFromBuyer" /> class.
        /// </summary>
        /// <param name="contentOnHold">When the value of this field is &lt;code&gt;true&lt;/code&gt; it indicates that the buyer&#x27;s note regarding the payment dispute (i.e., the &lt;b&gt;buyerProvided.note&lt;/b&gt; field,) is on hold. When this is the case, the &lt;b&gt;buyerProvided.note&lt;/b&gt; field will not be returned.&lt;br&gt;&lt;br&gt;When the value of this field is &lt;code&gt;false&lt;/code&gt;, it is not returned..</param>
        /// <param name="note">This field shows any note that was left by the buyer in regard to the dispute..</param>
        /// <param name="returnShipmentTracking">This array shows shipment tracking information for one or more shipping packages being returned to the buyer after a payment dispute..</param>
        public InfoFromBuyer(bool? contentOnHold = default(bool?), string note = default(string), List<TrackingInfo> returnShipmentTracking = default(List<TrackingInfo>))
        {
            this.ContentOnHold = contentOnHold;
            this.Note = note;
            this.ReturnShipmentTracking = returnShipmentTracking;
        }
        
        /// <summary>
        /// When the value of this field is &lt;code&gt;true&lt;/code&gt; it indicates that the buyer&#x27;s note regarding the payment dispute (i.e., the &lt;b&gt;buyerProvided.note&lt;/b&gt; field,) is on hold. When this is the case, the &lt;b&gt;buyerProvided.note&lt;/b&gt; field will not be returned.&lt;br&gt;&lt;br&gt;When the value of this field is &lt;code&gt;false&lt;/code&gt;, it is not returned.
        /// </summary>
        /// <value>When the value of this field is &lt;code&gt;true&lt;/code&gt; it indicates that the buyer&#x27;s note regarding the payment dispute (i.e., the &lt;b&gt;buyerProvided.note&lt;/b&gt; field,) is on hold. When this is the case, the &lt;b&gt;buyerProvided.note&lt;/b&gt; field will not be returned.&lt;br&gt;&lt;br&gt;When the value of this field is &lt;code&gt;false&lt;/code&gt;, it is not returned.</value>
        [DataMember(Name="contentOnHold", EmitDefaultValue=false)]
        public bool? ContentOnHold { get; set; }

        /// <summary>
        /// This field shows any note that was left by the buyer in regard to the dispute.
        /// </summary>
        /// <value>This field shows any note that was left by the buyer in regard to the dispute.</value>
        [DataMember(Name="note", EmitDefaultValue=false)]
        public string Note { get; set; }

        /// <summary>
        /// This array shows shipment tracking information for one or more shipping packages being returned to the buyer after a payment dispute.
        /// </summary>
        /// <value>This array shows shipment tracking information for one or more shipping packages being returned to the buyer after a payment dispute.</value>
        [DataMember(Name="returnShipmentTracking", EmitDefaultValue=false)]
        public List<TrackingInfo> ReturnShipmentTracking { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InfoFromBuyer {\n");
            sb.Append("  ContentOnHold: ").Append(ContentOnHold).Append("\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
            sb.Append("  ReturnShipmentTracking: ").Append(ReturnShipmentTracking).Append("\n");
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
            return this.Equals(input as InfoFromBuyer);
        }

        /// <summary>
        /// Returns true if InfoFromBuyer instances are equal
        /// </summary>
        /// <param name="input">Instance of InfoFromBuyer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InfoFromBuyer input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ContentOnHold == input.ContentOnHold ||
                    (this.ContentOnHold != null &&
                    this.ContentOnHold.Equals(input.ContentOnHold))
                ) && 
                (
                    this.Note == input.Note ||
                    (this.Note != null &&
                    this.Note.Equals(input.Note))
                ) && 
                (
                    this.ReturnShipmentTracking == input.ReturnShipmentTracking ||
                    this.ReturnShipmentTracking != null &&
                    input.ReturnShipmentTracking != null &&
                    this.ReturnShipmentTracking.SequenceEqual(input.ReturnShipmentTracking)
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
                if (this.ContentOnHold != null)
                    hashCode = hashCode * 59 + this.ContentOnHold.GetHashCode();
                if (this.Note != null)
                    hashCode = hashCode * 59 + this.Note.GetHashCode();
                if (this.ReturnShipmentTracking != null)
                    hashCode = hashCode * 59 + this.ReturnShipmentTracking.GetHashCode();
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
