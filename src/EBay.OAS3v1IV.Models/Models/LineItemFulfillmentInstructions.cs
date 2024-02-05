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
    /// This type contains the specifications for processing the fulfillment of a line item, including the handling window and the delivery window. These fields provide guidance for &lt;i&gt;eBay Guaranteed Delivery&lt;/i&gt; as well as for non-guaranteed delivery.
    /// </summary>
    [DataContract]
        public partial class LineItemFulfillmentInstructions :  IEquatable<LineItemFulfillmentInstructions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LineItemFulfillmentInstructions" /> class.
        /// </summary>
        /// <param name="guaranteedDelivery">Although this field is still returned, it can be ignored since eBay Guaranteed Delivery is no longer a supported feature on any marketplace. This field may get removed from the schema in the future..</param>
        /// <param name="maxEstimatedDeliveryDate">The estimated latest date and time that the buyer can expect to receive the line item based on the seller&#x27;s stated handling time and the transit times of the available shipping service options. The seller must pay extra attention to this date, as a failure to deliver by this date/time can result in a &#x27;Late shipment&#x27; seller defect, and can affect seller level and Top-Rated Seller status. In addition to the seller defect, buyers will be eligible for a shipping cost refund, and will also be eligible to return the item for a full refund (with no return shipping charge) if they choose. &lt;br&gt;&lt;br&gt;&lt;span class&#x3D;\&quot;tablenote\&quot;&gt;&lt;strong&gt;Note:&lt;/strong&gt; This timestamp is in ISO 8601 format, which uses the 24-hour Universal Coordinated Time (UTC) clock. &lt;br&gt;&lt;br&gt;&lt;b&gt;Format:&lt;/b&gt; &lt;code&gt;[YYYY]-[MM]-[DD]T[hh]:[mm]:[ss].[sss]Z&lt;/code&gt; &lt;br&gt;&lt;b&gt;Example:&lt;/b&gt; &lt;code&gt;2015-08-04T19:09:02.768Z&lt;/code&gt;&lt;/span&gt;.</param>
        /// <param name="minEstimatedDeliveryDate">The estimated earliest date and time that the buyer can expect to receive the line item based on the seller&#x27;s stated handling time and the transit times of the available shipping service options.&lt;br&gt;&lt;br&gt;&lt;span class&#x3D;\&quot;tablenote\&quot;&gt;&lt;strong&gt;Note:&lt;/strong&gt; This timestamp is in ISO 8601 format, which uses the 24-hour Universal Coordinated Time (UTC) clock. &lt;br&gt;&lt;br&gt;&lt;b&gt;Format:&lt;/b&gt; &lt;code&gt;[YYYY]-[MM]-[DD]T[hh]:[mm]:[ss].[sss]Z&lt;/code&gt; &lt;br&gt;&lt;b&gt;Example:&lt;/b&gt; &lt;code&gt;2015-08-04T19:09:02.768Z&lt;/code&gt;&lt;/span&gt;.</param>
        /// <param name="shipByDate">The latest date and time by which the seller should ship line item in order to meet the expected delivery window. This timestamp will be set by eBay based on time of purchase and the seller&#x27;s stated handling time. The seller must pay extra attention to this date, as a failure to physically ship the line item by this date/time can result in a &#x27;Late shipment&#x27; seller defect, and can affect seller level and Top-Rated Seller status. In addition to the seller defect, buyers will be eligible for a shipping cost refund, and will also be eligible to return the item for a full refund (with no return shipping charge) if they choose. &lt;br&gt;&lt;br&gt;&lt;span class&#x3D;\&quot;tablenote\&quot;&gt;&lt;strong&gt;Note:&lt;/strong&gt; This timestamp is in ISO 8601 format, which uses the 24-hour Universal Coordinated Time (UTC) clock. &lt;br&gt;&lt;br&gt;&lt;b&gt;Format:&lt;/b&gt; &lt;code&gt;[YYYY]-[MM]-[DD]T[hh]:[mm]:[ss].[sss]Z&lt;/code&gt; &lt;br&gt;&lt;b&gt;Example:&lt;/b&gt; &lt;code&gt;2015-08-04T19:09:02.768Z&lt;/code&gt;&lt;/span&gt;.</param>
        public LineItemFulfillmentInstructions(bool? guaranteedDelivery = default(bool?), string maxEstimatedDeliveryDate = default(string), string minEstimatedDeliveryDate = default(string), string shipByDate = default(string))
        {
            this.GuaranteedDelivery = guaranteedDelivery;
            this.MaxEstimatedDeliveryDate = maxEstimatedDeliveryDate;
            this.MinEstimatedDeliveryDate = minEstimatedDeliveryDate;
            this.ShipByDate = shipByDate;
        }
        
        /// <summary>
        /// Although this field is still returned, it can be ignored since eBay Guaranteed Delivery is no longer a supported feature on any marketplace. This field may get removed from the schema in the future.
        /// </summary>
        /// <value>Although this field is still returned, it can be ignored since eBay Guaranteed Delivery is no longer a supported feature on any marketplace. This field may get removed from the schema in the future.</value>
        [DataMember(Name="guaranteedDelivery", EmitDefaultValue=false)]
        public bool? GuaranteedDelivery { get; set; }

        /// <summary>
        /// The estimated latest date and time that the buyer can expect to receive the line item based on the seller&#x27;s stated handling time and the transit times of the available shipping service options. The seller must pay extra attention to this date, as a failure to deliver by this date/time can result in a &#x27;Late shipment&#x27; seller defect, and can affect seller level and Top-Rated Seller status. In addition to the seller defect, buyers will be eligible for a shipping cost refund, and will also be eligible to return the item for a full refund (with no return shipping charge) if they choose. &lt;br&gt;&lt;br&gt;&lt;span class&#x3D;\&quot;tablenote\&quot;&gt;&lt;strong&gt;Note:&lt;/strong&gt; This timestamp is in ISO 8601 format, which uses the 24-hour Universal Coordinated Time (UTC) clock. &lt;br&gt;&lt;br&gt;&lt;b&gt;Format:&lt;/b&gt; &lt;code&gt;[YYYY]-[MM]-[DD]T[hh]:[mm]:[ss].[sss]Z&lt;/code&gt; &lt;br&gt;&lt;b&gt;Example:&lt;/b&gt; &lt;code&gt;2015-08-04T19:09:02.768Z&lt;/code&gt;&lt;/span&gt;
        /// </summary>
        /// <value>The estimated latest date and time that the buyer can expect to receive the line item based on the seller&#x27;s stated handling time and the transit times of the available shipping service options. The seller must pay extra attention to this date, as a failure to deliver by this date/time can result in a &#x27;Late shipment&#x27; seller defect, and can affect seller level and Top-Rated Seller status. In addition to the seller defect, buyers will be eligible for a shipping cost refund, and will also be eligible to return the item for a full refund (with no return shipping charge) if they choose. &lt;br&gt;&lt;br&gt;&lt;span class&#x3D;\&quot;tablenote\&quot;&gt;&lt;strong&gt;Note:&lt;/strong&gt; This timestamp is in ISO 8601 format, which uses the 24-hour Universal Coordinated Time (UTC) clock. &lt;br&gt;&lt;br&gt;&lt;b&gt;Format:&lt;/b&gt; &lt;code&gt;[YYYY]-[MM]-[DD]T[hh]:[mm]:[ss].[sss]Z&lt;/code&gt; &lt;br&gt;&lt;b&gt;Example:&lt;/b&gt; &lt;code&gt;2015-08-04T19:09:02.768Z&lt;/code&gt;&lt;/span&gt;</value>
        [DataMember(Name="maxEstimatedDeliveryDate", EmitDefaultValue=false)]
        public string MaxEstimatedDeliveryDate { get; set; }

        /// <summary>
        /// The estimated earliest date and time that the buyer can expect to receive the line item based on the seller&#x27;s stated handling time and the transit times of the available shipping service options.&lt;br&gt;&lt;br&gt;&lt;span class&#x3D;\&quot;tablenote\&quot;&gt;&lt;strong&gt;Note:&lt;/strong&gt; This timestamp is in ISO 8601 format, which uses the 24-hour Universal Coordinated Time (UTC) clock. &lt;br&gt;&lt;br&gt;&lt;b&gt;Format:&lt;/b&gt; &lt;code&gt;[YYYY]-[MM]-[DD]T[hh]:[mm]:[ss].[sss]Z&lt;/code&gt; &lt;br&gt;&lt;b&gt;Example:&lt;/b&gt; &lt;code&gt;2015-08-04T19:09:02.768Z&lt;/code&gt;&lt;/span&gt;
        /// </summary>
        /// <value>The estimated earliest date and time that the buyer can expect to receive the line item based on the seller&#x27;s stated handling time and the transit times of the available shipping service options.&lt;br&gt;&lt;br&gt;&lt;span class&#x3D;\&quot;tablenote\&quot;&gt;&lt;strong&gt;Note:&lt;/strong&gt; This timestamp is in ISO 8601 format, which uses the 24-hour Universal Coordinated Time (UTC) clock. &lt;br&gt;&lt;br&gt;&lt;b&gt;Format:&lt;/b&gt; &lt;code&gt;[YYYY]-[MM]-[DD]T[hh]:[mm]:[ss].[sss]Z&lt;/code&gt; &lt;br&gt;&lt;b&gt;Example:&lt;/b&gt; &lt;code&gt;2015-08-04T19:09:02.768Z&lt;/code&gt;&lt;/span&gt;</value>
        [DataMember(Name="minEstimatedDeliveryDate", EmitDefaultValue=false)]
        public string MinEstimatedDeliveryDate { get; set; }

        /// <summary>
        /// The latest date and time by which the seller should ship line item in order to meet the expected delivery window. This timestamp will be set by eBay based on time of purchase and the seller&#x27;s stated handling time. The seller must pay extra attention to this date, as a failure to physically ship the line item by this date/time can result in a &#x27;Late shipment&#x27; seller defect, and can affect seller level and Top-Rated Seller status. In addition to the seller defect, buyers will be eligible for a shipping cost refund, and will also be eligible to return the item for a full refund (with no return shipping charge) if they choose. &lt;br&gt;&lt;br&gt;&lt;span class&#x3D;\&quot;tablenote\&quot;&gt;&lt;strong&gt;Note:&lt;/strong&gt; This timestamp is in ISO 8601 format, which uses the 24-hour Universal Coordinated Time (UTC) clock. &lt;br&gt;&lt;br&gt;&lt;b&gt;Format:&lt;/b&gt; &lt;code&gt;[YYYY]-[MM]-[DD]T[hh]:[mm]:[ss].[sss]Z&lt;/code&gt; &lt;br&gt;&lt;b&gt;Example:&lt;/b&gt; &lt;code&gt;2015-08-04T19:09:02.768Z&lt;/code&gt;&lt;/span&gt;
        /// </summary>
        /// <value>The latest date and time by which the seller should ship line item in order to meet the expected delivery window. This timestamp will be set by eBay based on time of purchase and the seller&#x27;s stated handling time. The seller must pay extra attention to this date, as a failure to physically ship the line item by this date/time can result in a &#x27;Late shipment&#x27; seller defect, and can affect seller level and Top-Rated Seller status. In addition to the seller defect, buyers will be eligible for a shipping cost refund, and will also be eligible to return the item for a full refund (with no return shipping charge) if they choose. &lt;br&gt;&lt;br&gt;&lt;span class&#x3D;\&quot;tablenote\&quot;&gt;&lt;strong&gt;Note:&lt;/strong&gt; This timestamp is in ISO 8601 format, which uses the 24-hour Universal Coordinated Time (UTC) clock. &lt;br&gt;&lt;br&gt;&lt;b&gt;Format:&lt;/b&gt; &lt;code&gt;[YYYY]-[MM]-[DD]T[hh]:[mm]:[ss].[sss]Z&lt;/code&gt; &lt;br&gt;&lt;b&gt;Example:&lt;/b&gt; &lt;code&gt;2015-08-04T19:09:02.768Z&lt;/code&gt;&lt;/span&gt;</value>
        [DataMember(Name="shipByDate", EmitDefaultValue=false)]
        public string ShipByDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LineItemFulfillmentInstructions {\n");
            sb.Append("  GuaranteedDelivery: ").Append(GuaranteedDelivery).Append("\n");
            sb.Append("  MaxEstimatedDeliveryDate: ").Append(MaxEstimatedDeliveryDate).Append("\n");
            sb.Append("  MinEstimatedDeliveryDate: ").Append(MinEstimatedDeliveryDate).Append("\n");
            sb.Append("  ShipByDate: ").Append(ShipByDate).Append("\n");
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
            return this.Equals(input as LineItemFulfillmentInstructions);
        }

        /// <summary>
        /// Returns true if LineItemFulfillmentInstructions instances are equal
        /// </summary>
        /// <param name="input">Instance of LineItemFulfillmentInstructions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LineItemFulfillmentInstructions input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GuaranteedDelivery == input.GuaranteedDelivery ||
                    (this.GuaranteedDelivery != null &&
                    this.GuaranteedDelivery.Equals(input.GuaranteedDelivery))
                ) && 
                (
                    this.MaxEstimatedDeliveryDate == input.MaxEstimatedDeliveryDate ||
                    (this.MaxEstimatedDeliveryDate != null &&
                    this.MaxEstimatedDeliveryDate.Equals(input.MaxEstimatedDeliveryDate))
                ) && 
                (
                    this.MinEstimatedDeliveryDate == input.MinEstimatedDeliveryDate ||
                    (this.MinEstimatedDeliveryDate != null &&
                    this.MinEstimatedDeliveryDate.Equals(input.MinEstimatedDeliveryDate))
                ) && 
                (
                    this.ShipByDate == input.ShipByDate ||
                    (this.ShipByDate != null &&
                    this.ShipByDate.Equals(input.ShipByDate))
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
                if (this.GuaranteedDelivery != null)
                    hashCode = hashCode * 59 + this.GuaranteedDelivery.GetHashCode();
                if (this.MaxEstimatedDeliveryDate != null)
                    hashCode = hashCode * 59 + this.MaxEstimatedDeliveryDate.GetHashCode();
                if (this.MinEstimatedDeliveryDate != null)
                    hashCode = hashCode * 59 + this.MinEstimatedDeliveryDate.GetHashCode();
                if (this.ShipByDate != null)
                    hashCode = hashCode * 59 + this.ShipByDate.GetHashCode();
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
