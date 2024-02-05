# EBay.OAS3v1IV.Models.MonetaryTransaction
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Date** | **string** | This timestamp indicates when the monetary transaction occurred. A date is returned for all monetary transactions.&lt;br&gt;&lt;br&gt; The following format is used: &lt;code&gt;YYYY-MM-DDTHH:MM:SS.SSSZ&lt;/code&gt;. For example, &lt;code&gt;2015-08-04T19:09:02.768Z&lt;/code&gt;. | [optional] 
**Type** | **string** | This enumeration value indicates whether the monetary transaction is a charge or a credit to the seller. For implementation help, refer to &lt;a href&#x3D;&#x27;https://developer.ebay.com/api-docs/sell/fulfillment/types/api:MonetaryTransactionTypeEnum&#x27;&gt;eBay API documentation&lt;/a&gt; | [optional] 
**Reason** | **string** | This enumeration value indicates the reason for the monetary transaction. For implementation help, refer to &lt;a href&#x3D;&#x27;https://developer.ebay.com/api-docs/sell/fulfillment/types/api:MonetaryTransactionReasonEnum&#x27;&gt;eBay API documentation&lt;/a&gt; | [optional] 
**Amount** | [**DisputeAmount**](DisputeAmount.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

