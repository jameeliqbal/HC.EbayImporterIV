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
    /// This type is used by the response payload of the &lt;strong&gt;addEvidence&lt;/strong&gt; method. Its only field is an unique identifier of an evidence set.
    /// </summary>
    [DataContract]
        public partial class AddEvidencePaymentDisputeResponse :  IEquatable<AddEvidencePaymentDisputeResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddEvidencePaymentDisputeResponse" /> class.
        /// </summary>
        /// <param name="evidenceId">The value returned in this field is the unique identifier of the newly-created evidence set. Upon a successful call, this value is automatically genererated. This new evidence set for the payment dispute includes the evidence file(s) that were passed in to the &lt;strong&gt;fileId&lt;/strong&gt; array in the request payload. The &lt;strong&gt;evidenceId&lt;/strong&gt; value will be needed if the seller wishes to add to the evidence set by using the &lt;strong&gt;updateEvidence&lt;/strong&gt; method, or if they want to retrieve a specific evidence file within the evidence set by using the &lt;strong&gt;fetchEvidenceContent&lt;/strong&gt; method..</param>
        public AddEvidencePaymentDisputeResponse(string evidenceId = default(string))
        {
            this.EvidenceId = evidenceId;
        }
        
        /// <summary>
        /// The value returned in this field is the unique identifier of the newly-created evidence set. Upon a successful call, this value is automatically genererated. This new evidence set for the payment dispute includes the evidence file(s) that were passed in to the &lt;strong&gt;fileId&lt;/strong&gt; array in the request payload. The &lt;strong&gt;evidenceId&lt;/strong&gt; value will be needed if the seller wishes to add to the evidence set by using the &lt;strong&gt;updateEvidence&lt;/strong&gt; method, or if they want to retrieve a specific evidence file within the evidence set by using the &lt;strong&gt;fetchEvidenceContent&lt;/strong&gt; method.
        /// </summary>
        /// <value>The value returned in this field is the unique identifier of the newly-created evidence set. Upon a successful call, this value is automatically genererated. This new evidence set for the payment dispute includes the evidence file(s) that were passed in to the &lt;strong&gt;fileId&lt;/strong&gt; array in the request payload. The &lt;strong&gt;evidenceId&lt;/strong&gt; value will be needed if the seller wishes to add to the evidence set by using the &lt;strong&gt;updateEvidence&lt;/strong&gt; method, or if they want to retrieve a specific evidence file within the evidence set by using the &lt;strong&gt;fetchEvidenceContent&lt;/strong&gt; method.</value>
        [DataMember(Name="evidenceId", EmitDefaultValue=false)]
        public string EvidenceId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddEvidencePaymentDisputeResponse {\n");
            sb.Append("  EvidenceId: ").Append(EvidenceId).Append("\n");
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
            return this.Equals(input as AddEvidencePaymentDisputeResponse);
        }

        /// <summary>
        /// Returns true if AddEvidencePaymentDisputeResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of AddEvidencePaymentDisputeResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddEvidencePaymentDisputeResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EvidenceId == input.EvidenceId ||
                    (this.EvidenceId != null &&
                    this.EvidenceId.Equals(input.EvidenceId))
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
