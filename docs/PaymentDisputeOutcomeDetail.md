# EBay.OAS3v1IV.Models.PaymentDisputeOutcomeDetail
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Fees** | [**SimpleAmount**](SimpleAmount.md) |  | [optional] 
**ProtectedAmount** | [**SimpleAmount**](SimpleAmount.md) |  | [optional] 
**ProtectionStatus** | **string** | This enumeration value indicates if the seller is fully protected, partially protected, or not protected by eBay for the payment dispute. This field is always returned once the payment dispute is resolved. For implementation help, refer to &lt;a href&#x3D;&#x27;https://developer.ebay.com/api-docs/sell/fulfillment/types/api:ProtectionStatusEnum&#x27;&gt;eBay API documentation&lt;/a&gt; | [optional] 
**ReasonForClosure** | **string** | The enumeration value returned in this field indicates the outcome of the payment dispute for the seller. This field is always returned once the payment dispute is resolved. For implementation help, refer to &lt;a href&#x3D;&#x27;https://developer.ebay.com/api-docs/sell/fulfillment/types/api:OutcomeEnum&#x27;&gt;eBay API documentation&lt;/a&gt; | [optional] 
**RecoupAmount** | [**SimpleAmount**](SimpleAmount.md) |  | [optional] 
**TotalFeeCredit** | [**SimpleAmount**](SimpleAmount.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

