# EBay.OAS3v1IV.Models.EvidenceRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EvidenceId** | **string** | Unique identifier of the evidential file set. Potentially, each evidential file set can have more than one file, that is why there is this file set identifier, and then an identifier for each file within this file set. | [optional] 
**EvidenceType** | **string** | This enumeration value shows the type of evidential document provided. For implementation help, refer to &lt;a href&#x3D;&#x27;https://developer.ebay.com/api-docs/sell/fulfillment/types/api:EvidenceTypeEnum&#x27;&gt;eBay API documentation&lt;/a&gt; | [optional] 
**LineItems** | [**List&lt;OrderLineItems&gt;**](OrderLineItems.md) | This array shows one or more order line items associated with the evidential document that has been provided. | [optional] 
**RequestDate** | **string** | The timestamp in this field shows the date/time when eBay requested the evidential document from the seller in response to a payment dispute. &lt;br&gt;&lt;br&gt;The timestamps returned here use the ISO-8601 24-hour date and time format, and the time zone used is Universal Coordinated Time (UTC), also known as Greenwich Mean Time (GMT), or Zulu. The ISO-8601 format looks like this: &lt;em&gt;yyyy-MM-ddThh:mm.ss.sssZ&lt;/em&gt;. An example would be &lt;code&gt;2019-08-04T19:09:02.768Z&lt;/code&gt;. | [optional] 
**RespondByDate** | **string** | The timestamp in this field shows the date/time when the seller is expected to provide a requested evidential document to eBay.  &lt;br&gt;&lt;br&gt;The timestamps returned here use the ISO-8601 24-hour date and time format, and the time zone used is Universal Coordinated Time (UTC), also known as Greenwich Mean Time (GMT), or Zulu. The ISO-8601 format looks like this: &lt;em&gt;yyyy-MM-ddThh:mm.ss.sssZ&lt;/em&gt;. An example would be &lt;code&gt;2019-08-04T19:09:02.768Z&lt;/code&gt;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

