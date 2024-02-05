# EBay.OAS3v1IV.Models.InfoFromBuyer
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ContentOnHold** | **bool?** | When the value of this field is &lt;code&gt;true&lt;/code&gt; it indicates that the buyer&#x27;s note regarding the payment dispute (i.e., the &lt;b&gt;buyerProvided.note&lt;/b&gt; field,) is on hold. When this is the case, the &lt;b&gt;buyerProvided.note&lt;/b&gt; field will not be returned.&lt;br&gt;&lt;br&gt;When the value of this field is &lt;code&gt;false&lt;/code&gt;, it is not returned. | [optional] 
**Note** | **string** | This field shows any note that was left by the buyer in regard to the dispute. | [optional] 
**ReturnShipmentTracking** | [**List&lt;TrackingInfo&gt;**](TrackingInfo.md) | This array shows shipment tracking information for one or more shipping packages being returned to the buyer after a payment dispute. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

