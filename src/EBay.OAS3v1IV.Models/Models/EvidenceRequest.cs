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
    /// This type is used by the &lt;strong&gt;evidenceRequests&lt;/strong&gt; array that is returned in the &lt;strong&gt;getPaymentDispute&lt;/strong&gt; response if one or more evidential documents are being requested to help resolve the payment dispute.
    /// </summary>
    [DataContract]
        public partial class EvidenceRequest :  IEquatable<EvidenceRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EvidenceRequest" /> class.
        /// </summary>
        /// <param name="evidenceId">Unique identifier of the evidential file set. Potentially, each evidential file set can have more than one file, that is why there is this file set identifier, and then an identifier for each file within this file set..</param>
        /// <param name="evidenceType">This enumeration value shows the type of evidential document provided. For implementation help, refer to &lt;a href&#x3D;&#x27;https://developer.ebay.com/api-docs/sell/fulfillment/types/api:EvidenceTypeEnum&#x27;&gt;eBay API documentation&lt;/a&gt;.</param>
        /// <param name="lineItems">This array shows one or more order line items associated with the evidential document that has been provided..</param>
        /// <param name="requestDate">The timestamp in this field shows the date/time when eBay requested the evidential document from the seller in response to a payment dispute. &lt;br&gt;&lt;br&gt;The timestamps returned here use the ISO-8601 24-hour date and time format, and the time zone used is Universal Coordinated Time (UTC), also known as Greenwich Mean Time (GMT), or Zulu. The ISO-8601 format looks like this: &lt;em&gt;yyyy-MM-ddThh:mm.ss.sssZ&lt;/em&gt;. An example would be &lt;code&gt;2019-08-04T19:09:02.768Z&lt;/code&gt;..</param>
        /// <param name="respondByDate">The timestamp in this field shows the date/time when the seller is expected to provide a requested evidential document to eBay.  &lt;br&gt;&lt;br&gt;The timestamps returned here use the ISO-8601 24-hour date and time format, and the time zone used is Universal Coordinated Time (UTC), also known as Greenwich Mean Time (GMT), or Zulu. The ISO-8601 format looks like this: &lt;em&gt;yyyy-MM-ddThh:mm.ss.sssZ&lt;/em&gt;. An example would be &lt;code&gt;2019-08-04T19:09:02.768Z&lt;/code&gt;..</param>
        public EvidenceRequest(string evidenceId = default(string), string evidenceType = default(string), List<OrderLineItems> lineItems = default(List<OrderLineItems>), string requestDate = default(string), string respondByDate = default(string))
        {
            this.EvidenceId = evidenceId;
            this.EvidenceType = evidenceType;
            this.LineItems = lineItems;
            this.RequestDate = requestDate;
            this.RespondByDate = respondByDate;
        }
        
        /// <summary>
        /// Unique identifier of the evidential file set. Potentially, each evidential file set can have more than one file, that is why there is this file set identifier, and then an identifier for each file within this file set.
        /// </summary>
        /// <value>Unique identifier of the evidential file set. Potentially, each evidential file set can have more than one file, that is why there is this file set identifier, and then an identifier for each file within this file set.</value>
        [DataMember(Name="evidenceId", EmitDefaultValue=false)]
        public string EvidenceId { get; set; }

        /// <summary>
        /// This enumeration value shows the type of evidential document provided. For implementation help, refer to &lt;a href&#x3D;&#x27;https://developer.ebay.com/api-docs/sell/fulfillment/types/api:EvidenceTypeEnum&#x27;&gt;eBay API documentation&lt;/a&gt;
        /// </summary>
        /// <value>This enumeration value shows the type of evidential document provided. For implementation help, refer to &lt;a href&#x3D;&#x27;https://developer.ebay.com/api-docs/sell/fulfillment/types/api:EvidenceTypeEnum&#x27;&gt;eBay API documentation&lt;/a&gt;</value>
        [DataMember(Name="evidenceType", EmitDefaultValue=false)]
        public string EvidenceType { get; set; }

        /// <summary>
        /// This array shows one or more order line items associated with the evidential document that has been provided.
        /// </summary>
        /// <value>This array shows one or more order line items associated with the evidential document that has been provided.</value>
        [DataMember(Name="lineItems", EmitDefaultValue=false)]
        public List<OrderLineItems> LineItems { get; set; }

        /// <summary>
        /// The timestamp in this field shows the date/time when eBay requested the evidential document from the seller in response to a payment dispute. &lt;br&gt;&lt;br&gt;The timestamps returned here use the ISO-8601 24-hour date and time format, and the time zone used is Universal Coordinated Time (UTC), also known as Greenwich Mean Time (GMT), or Zulu. The ISO-8601 format looks like this: &lt;em&gt;yyyy-MM-ddThh:mm.ss.sssZ&lt;/em&gt;. An example would be &lt;code&gt;2019-08-04T19:09:02.768Z&lt;/code&gt;.
        /// </summary>
        /// <value>The timestamp in this field shows the date/time when eBay requested the evidential document from the seller in response to a payment dispute. &lt;br&gt;&lt;br&gt;The timestamps returned here use the ISO-8601 24-hour date and time format, and the time zone used is Universal Coordinated Time (UTC), also known as Greenwich Mean Time (GMT), or Zulu. The ISO-8601 format looks like this: &lt;em&gt;yyyy-MM-ddThh:mm.ss.sssZ&lt;/em&gt;. An example would be &lt;code&gt;2019-08-04T19:09:02.768Z&lt;/code&gt;.</value>
        [DataMember(Name="requestDate", EmitDefaultValue=false)]
        public string RequestDate { get; set; }

        /// <summary>
        /// The timestamp in this field shows the date/time when the seller is expected to provide a requested evidential document to eBay.  &lt;br&gt;&lt;br&gt;The timestamps returned here use the ISO-8601 24-hour date and time format, and the time zone used is Universal Coordinated Time (UTC), also known as Greenwich Mean Time (GMT), or Zulu. The ISO-8601 format looks like this: &lt;em&gt;yyyy-MM-ddThh:mm.ss.sssZ&lt;/em&gt;. An example would be &lt;code&gt;2019-08-04T19:09:02.768Z&lt;/code&gt;.
        /// </summary>
        /// <value>The timestamp in this field shows the date/time when the seller is expected to provide a requested evidential document to eBay.  &lt;br&gt;&lt;br&gt;The timestamps returned here use the ISO-8601 24-hour date and time format, and the time zone used is Universal Coordinated Time (UTC), also known as Greenwich Mean Time (GMT), or Zulu. The ISO-8601 format looks like this: &lt;em&gt;yyyy-MM-ddThh:mm.ss.sssZ&lt;/em&gt;. An example would be &lt;code&gt;2019-08-04T19:09:02.768Z&lt;/code&gt;.</value>
        [DataMember(Name="respondByDate", EmitDefaultValue=false)]
        public string RespondByDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EvidenceRequest {\n");
            sb.Append("  EvidenceId: ").Append(EvidenceId).Append("\n");
            sb.Append("  EvidenceType: ").Append(EvidenceType).Append("\n");
            sb.Append("  LineItems: ").Append(LineItems).Append("\n");
            sb.Append("  RequestDate: ").Append(RequestDate).Append("\n");
            sb.Append("  RespondByDate: ").Append(RespondByDate).Append("\n");
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
            return this.Equals(input as EvidenceRequest);
        }

        /// <summary>
        /// Returns true if EvidenceRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of EvidenceRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EvidenceRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EvidenceId == input.EvidenceId ||
                    (this.EvidenceId != null &&
                    this.EvidenceId.Equals(input.EvidenceId))
                ) && 
                (
                    this.EvidenceType == input.EvidenceType ||
                    (this.EvidenceType != null &&
                    this.EvidenceType.Equals(input.EvidenceType))
                ) && 
                (
                    this.LineItems == input.LineItems ||
                    this.LineItems != null &&
                    input.LineItems != null &&
                    this.LineItems.SequenceEqual(input.LineItems)
                ) && 
                (
                    this.RequestDate == input.RequestDate ||
                    (this.RequestDate != null &&
                    this.RequestDate.Equals(input.RequestDate))
                ) && 
                (
                    this.RespondByDate == input.RespondByDate ||
                    (this.RespondByDate != null &&
                    this.RespondByDate.Equals(input.RespondByDate))
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
                if (this.EvidenceId != null)
                    hashCode = hashCode * 59 + this.EvidenceId.GetHashCode();
                if (this.EvidenceType != null)
                    hashCode = hashCode * 59 + this.EvidenceType.GetHashCode();
                if (this.LineItems != null)
                    hashCode = hashCode * 59 + this.LineItems.GetHashCode();
                if (this.RequestDate != null)
                    hashCode = hashCode * 59 + this.RequestDate.GetHashCode();
                if (this.RespondByDate != null)
                    hashCode = hashCode * 59 + this.RespondByDate.GetHashCode();
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
