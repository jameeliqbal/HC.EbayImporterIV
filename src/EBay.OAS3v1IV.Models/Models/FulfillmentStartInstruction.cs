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
    /// This type contains a set of specifications for processing a fulfillment of an order, including the type of fulfillment, shipping carrier and service, addressing details, and estimated delivery window. These instructions are derived from the buyer&#x27;s and seller&#x27;s eBay account preferences, the listing parameters, and the buyer&#x27;s checkout selections. The seller can use them as a starting point for packaging, addressing, and shipping the order.
    /// </summary>
    [DataContract]
        public partial class FulfillmentStartInstruction :  IEquatable<FulfillmentStartInstruction>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FulfillmentStartInstruction" /> class.
        /// </summary>
        /// <param name="ebaySupportedFulfillment">This field is only returned if its value is &lt;code&gt;true&lt;/code&gt; and indicates that the fulfillment will be shipped via eBay&#x27;s Global Shipping Program, eBay International Shipping, or the Authenticity Guarantee service program. &lt;br&gt;&lt;br&gt;For more information, see the &lt;a href&#x3D;\&quot;https://www.ebay.com/help/selling/shipping-items/setting-shipping-options/global-shipping-program?id&#x3D;4646 \&quot; target&#x3D;\&quot;_blank\&quot;&gt;Global Shipping Program&lt;/a&gt; help topic..</param>
        /// <param name="finalDestinationAddress">finalDestinationAddress.</param>
        /// <param name="fulfillmentInstructionsType">The enumeration value returned in this field indicates the method of fulfillment that will be used to deliver this set of line items (this package) to the buyer. This field will have a value of &lt;code&gt;SHIP_TO&lt;/code&gt; if the &lt;b&gt;ebaySupportedFulfillment&lt;/b&gt; field is returned with a value of &lt;code&gt;true&lt;/code&gt;. See the &lt;strong&gt;FulfillmentInstructionsType&lt;/strong&gt; definition for more information about different fulfillment types. For implementation help, refer to &lt;a href&#x3D;&#x27;https://developer.ebay.com/api-docs/sell/fulfillment/types/sel:FulfillmentInstructionsType&#x27;&gt;eBay API documentation&lt;/a&gt;.</param>
        /// <param name="maxEstimatedDeliveryDate">This is the estimated latest date that the fulfillment will be completed. This timestamp is in ISO 8601 format, which uses the 24-hour Universal Coordinated Time (UTC) clock. This field is not returned ifthe value of the &lt;b&gt;fulfillmentInstructionsType&lt;/b&gt; field is &lt;code&gt;DIGITAL&lt;/code&gt; or &lt;code&gt;PREPARE_FOR_PICKUP&lt;/code&gt;.  &lt;br&gt;&lt;br&gt;&lt;b&gt;Format:&lt;/b&gt; &lt;code&gt;[YYYY]-[MM]-[DD]T[hh]:[mm]:[ss].[sss]Z&lt;/code&gt; &lt;br&gt;&lt;b&gt;Example:&lt;/b&gt; &lt;code&gt;2015-08-04T19:09:02.768Z&lt;/code&gt;.</param>
        /// <param name="minEstimatedDeliveryDate">This is the estimated earliest date that the fulfillment will be completed. This timestamp is in ISO 8601 format, which uses the 24-hour Universal Coordinated Time (UTC) clock. This field is not returned if  the value of the &lt;b&gt;fulfillmentInstructionsType&lt;/b&gt; field is &lt;code&gt;DIGITAL&lt;/code&gt; or &lt;code&gt;PREPARE_FOR_PICKUP&lt;/code&gt;.  &lt;br&gt;&lt;br&gt;&lt;b&gt;Format:&lt;/b&gt; &lt;code&gt;[YYYY]-[MM]-[DD]T[hh]:[mm]:[ss].[sss]Z&lt;/code&gt; &lt;br&gt;&lt;b&gt;Example:&lt;/b&gt; &lt;code&gt;2015-08-04T19:09:02.768Z&lt;/code&gt;.</param>
        /// <param name="pickupStep">pickupStep.</param>
        /// <param name="shippingStep">shippingStep.</param>
        public FulfillmentStartInstruction(bool? ebaySupportedFulfillment = default(bool?), Address finalDestinationAddress = default(Address), string fulfillmentInstructionsType = default(string), string maxEstimatedDeliveryDate = default(string), string minEstimatedDeliveryDate = default(string), PickupStep pickupStep = default(PickupStep), ShippingStep shippingStep = default(ShippingStep))
        {
            this.EbaySupportedFulfillment = ebaySupportedFulfillment;
            this.FinalDestinationAddress = finalDestinationAddress;
            this.FulfillmentInstructionsType = fulfillmentInstructionsType;
            this.MaxEstimatedDeliveryDate = maxEstimatedDeliveryDate;
            this.MinEstimatedDeliveryDate = minEstimatedDeliveryDate;
            this.PickupStep = pickupStep;
            this.ShippingStep = shippingStep;
        }
        
        /// <summary>
        /// This field is only returned if its value is &lt;code&gt;true&lt;/code&gt; and indicates that the fulfillment will be shipped via eBay&#x27;s Global Shipping Program, eBay International Shipping, or the Authenticity Guarantee service program. &lt;br&gt;&lt;br&gt;For more information, see the &lt;a href&#x3D;\&quot;https://www.ebay.com/help/selling/shipping-items/setting-shipping-options/global-shipping-program?id&#x3D;4646 \&quot; target&#x3D;\&quot;_blank\&quot;&gt;Global Shipping Program&lt;/a&gt; help topic.
        /// </summary>
        /// <value>This field is only returned if its value is &lt;code&gt;true&lt;/code&gt; and indicates that the fulfillment will be shipped via eBay&#x27;s Global Shipping Program, eBay International Shipping, or the Authenticity Guarantee service program. &lt;br&gt;&lt;br&gt;For more information, see the &lt;a href&#x3D;\&quot;https://www.ebay.com/help/selling/shipping-items/setting-shipping-options/global-shipping-program?id&#x3D;4646 \&quot; target&#x3D;\&quot;_blank\&quot;&gt;Global Shipping Program&lt;/a&gt; help topic.</value>
        [DataMember(Name="ebaySupportedFulfillment", EmitDefaultValue=false)]
        public bool? EbaySupportedFulfillment { get; set; }

        /// <summary>
        /// Gets or Sets FinalDestinationAddress
        /// </summary>
        [DataMember(Name="finalDestinationAddress", EmitDefaultValue=false)]
        public Address FinalDestinationAddress { get; set; }

        /// <summary>
        /// The enumeration value returned in this field indicates the method of fulfillment that will be used to deliver this set of line items (this package) to the buyer. This field will have a value of &lt;code&gt;SHIP_TO&lt;/code&gt; if the &lt;b&gt;ebaySupportedFulfillment&lt;/b&gt; field is returned with a value of &lt;code&gt;true&lt;/code&gt;. See the &lt;strong&gt;FulfillmentInstructionsType&lt;/strong&gt; definition for more information about different fulfillment types. For implementation help, refer to &lt;a href&#x3D;&#x27;https://developer.ebay.com/api-docs/sell/fulfillment/types/sel:FulfillmentInstructionsType&#x27;&gt;eBay API documentation&lt;/a&gt;
        /// </summary>
        /// <value>The enumeration value returned in this field indicates the method of fulfillment that will be used to deliver this set of line items (this package) to the buyer. This field will have a value of &lt;code&gt;SHIP_TO&lt;/code&gt; if the &lt;b&gt;ebaySupportedFulfillment&lt;/b&gt; field is returned with a value of &lt;code&gt;true&lt;/code&gt;. See the &lt;strong&gt;FulfillmentInstructionsType&lt;/strong&gt; definition for more information about different fulfillment types. For implementation help, refer to &lt;a href&#x3D;&#x27;https://developer.ebay.com/api-docs/sell/fulfillment/types/sel:FulfillmentInstructionsType&#x27;&gt;eBay API documentation&lt;/a&gt;</value>
        [DataMember(Name="fulfillmentInstructionsType", EmitDefaultValue=false)]
        public string FulfillmentInstructionsType { get; set; }

        /// <summary>
        /// This is the estimated latest date that the fulfillment will be completed. This timestamp is in ISO 8601 format, which uses the 24-hour Universal Coordinated Time (UTC) clock. This field is not returned ifthe value of the &lt;b&gt;fulfillmentInstructionsType&lt;/b&gt; field is &lt;code&gt;DIGITAL&lt;/code&gt; or &lt;code&gt;PREPARE_FOR_PICKUP&lt;/code&gt;.  &lt;br&gt;&lt;br&gt;&lt;b&gt;Format:&lt;/b&gt; &lt;code&gt;[YYYY]-[MM]-[DD]T[hh]:[mm]:[ss].[sss]Z&lt;/code&gt; &lt;br&gt;&lt;b&gt;Example:&lt;/b&gt; &lt;code&gt;2015-08-04T19:09:02.768Z&lt;/code&gt;
        /// </summary>
        /// <value>This is the estimated latest date that the fulfillment will be completed. This timestamp is in ISO 8601 format, which uses the 24-hour Universal Coordinated Time (UTC) clock. This field is not returned ifthe value of the &lt;b&gt;fulfillmentInstructionsType&lt;/b&gt; field is &lt;code&gt;DIGITAL&lt;/code&gt; or &lt;code&gt;PREPARE_FOR_PICKUP&lt;/code&gt;.  &lt;br&gt;&lt;br&gt;&lt;b&gt;Format:&lt;/b&gt; &lt;code&gt;[YYYY]-[MM]-[DD]T[hh]:[mm]:[ss].[sss]Z&lt;/code&gt; &lt;br&gt;&lt;b&gt;Example:&lt;/b&gt; &lt;code&gt;2015-08-04T19:09:02.768Z&lt;/code&gt;</value>
        [DataMember(Name="maxEstimatedDeliveryDate", EmitDefaultValue=false)]
        public string MaxEstimatedDeliveryDate { get; set; }

        /// <summary>
        /// This is the estimated earliest date that the fulfillment will be completed. This timestamp is in ISO 8601 format, which uses the 24-hour Universal Coordinated Time (UTC) clock. This field is not returned if  the value of the &lt;b&gt;fulfillmentInstructionsType&lt;/b&gt; field is &lt;code&gt;DIGITAL&lt;/code&gt; or &lt;code&gt;PREPARE_FOR_PICKUP&lt;/code&gt;.  &lt;br&gt;&lt;br&gt;&lt;b&gt;Format:&lt;/b&gt; &lt;code&gt;[YYYY]-[MM]-[DD]T[hh]:[mm]:[ss].[sss]Z&lt;/code&gt; &lt;br&gt;&lt;b&gt;Example:&lt;/b&gt; &lt;code&gt;2015-08-04T19:09:02.768Z&lt;/code&gt;
        /// </summary>
        /// <value>This is the estimated earliest date that the fulfillment will be completed. This timestamp is in ISO 8601 format, which uses the 24-hour Universal Coordinated Time (UTC) clock. This field is not returned if  the value of the &lt;b&gt;fulfillmentInstructionsType&lt;/b&gt; field is &lt;code&gt;DIGITAL&lt;/code&gt; or &lt;code&gt;PREPARE_FOR_PICKUP&lt;/code&gt;.  &lt;br&gt;&lt;br&gt;&lt;b&gt;Format:&lt;/b&gt; &lt;code&gt;[YYYY]-[MM]-[DD]T[hh]:[mm]:[ss].[sss]Z&lt;/code&gt; &lt;br&gt;&lt;b&gt;Example:&lt;/b&gt; &lt;code&gt;2015-08-04T19:09:02.768Z&lt;/code&gt;</value>
        [DataMember(Name="minEstimatedDeliveryDate", EmitDefaultValue=false)]
        public string MinEstimatedDeliveryDate { get; set; }

        /// <summary>
        /// Gets or Sets PickupStep
        /// </summary>
        [DataMember(Name="pickupStep", EmitDefaultValue=false)]
        public PickupStep PickupStep { get; set; }

        /// <summary>
        /// Gets or Sets ShippingStep
        /// </summary>
        [DataMember(Name="shippingStep", EmitDefaultValue=false)]
        public ShippingStep ShippingStep { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FulfillmentStartInstruction {\n");
            sb.Append("  EbaySupportedFulfillment: ").Append(EbaySupportedFulfillment).Append("\n");
            sb.Append("  FinalDestinationAddress: ").Append(FinalDestinationAddress).Append("\n");
            sb.Append("  FulfillmentInstructionsType: ").Append(FulfillmentInstructionsType).Append("\n");
            sb.Append("  MaxEstimatedDeliveryDate: ").Append(MaxEstimatedDeliveryDate).Append("\n");
            sb.Append("  MinEstimatedDeliveryDate: ").Append(MinEstimatedDeliveryDate).Append("\n");
            sb.Append("  PickupStep: ").Append(PickupStep).Append("\n");
            sb.Append("  ShippingStep: ").Append(ShippingStep).Append("\n");
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
            return this.Equals(input as FulfillmentStartInstruction);
        }

        /// <summary>
        /// Returns true if FulfillmentStartInstruction instances are equal
        /// </summary>
        /// <param name="input">Instance of FulfillmentStartInstruction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FulfillmentStartInstruction input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EbaySupportedFulfillment == input.EbaySupportedFulfillment ||
                    (this.EbaySupportedFulfillment != null &&
                    this.EbaySupportedFulfillment.Equals(input.EbaySupportedFulfillment))
                ) && 
                (
                    this.FinalDestinationAddress == input.FinalDestinationAddress ||
                    (this.FinalDestinationAddress != null &&
                    this.FinalDestinationAddress.Equals(input.FinalDestinationAddress))
                ) && 
                (
                    this.FulfillmentInstructionsType == input.FulfillmentInstructionsType ||
                    (this.FulfillmentInstructionsType != null &&
                    this.FulfillmentInstructionsType.Equals(input.FulfillmentInstructionsType))
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
                    this.PickupStep == input.PickupStep ||
                    (this.PickupStep != null &&
                    this.PickupStep.Equals(input.PickupStep))
                ) && 
                (
                    this.ShippingStep == input.ShippingStep ||
                    (this.ShippingStep != null &&
                    this.ShippingStep.Equals(input.ShippingStep))
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
                if (this.EbaySupportedFulfillment != null)
                    hashCode = hashCode * 59 + this.EbaySupportedFulfillment.GetHashCode();
                if (this.FinalDestinationAddress != null)
                    hashCode = hashCode * 59 + this.FinalDestinationAddress.GetHashCode();
                if (this.FulfillmentInstructionsType != null)
                    hashCode = hashCode * 59 + this.FulfillmentInstructionsType.GetHashCode();
                if (this.MaxEstimatedDeliveryDate != null)
                    hashCode = hashCode * 59 + this.MaxEstimatedDeliveryDate.GetHashCode();
                if (this.MinEstimatedDeliveryDate != null)
                    hashCode = hashCode * 59 + this.MinEstimatedDeliveryDate.GetHashCode();
                if (this.PickupStep != null)
                    hashCode = hashCode * 59 + this.PickupStep.GetHashCode();
                if (this.ShippingStep != null)
                    hashCode = hashCode * 59 + this.ShippingStep.GetHashCode();
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
