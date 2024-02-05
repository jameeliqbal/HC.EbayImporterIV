# EBay.OAS3v1IV.Models.LinkedOrderLineItem
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LineItemAspects** | [**List&lt;NameValuePair&gt;**](NameValuePair.md) | This array contains the complete set of items aspects for the linked line item. For example:&lt;br&gt;&lt;pre&gt;\&quot;lineItemAspects\&quot;: [&lt;br&gt;    {&lt;br&gt;        \&quot;name\&quot;: \&quot;Tire Type\&quot;,&lt;br&gt;        \&quot;value\&quot;: \&quot;All Season\&quot;&lt;br&gt;    },&lt;br&gt;&lt;br&gt;    ...&lt;br&gt; &lt;br&gt;    {&lt;br&gt;        \&quot;name\&quot;: \&quot;Car Type\&quot;,&lt;br&gt;        \&quot;value\&quot;: \&quot;Performance\&quot;&lt;br&gt;    }&lt;br&gt;]&lt;/pre&gt;&lt;span class&#x3D;\&quot;tablenote\&quot;&gt;&lt;strong&gt;Note:&lt;/strong&gt; All item specifics for the listing are returned. The name/value pairs returned are in the language of the linked line item&#x27;s listing site, which may vary from the seller&#x27;s language.&lt;/span&gt; | [optional] 
**LineItemId** | **string** | The unique identifier of the linked order line item. | [optional] 
**MaxEstimatedDeliveryDate** | **string** | The end of the date range in which the linked line item is expected to be delivered to the shipping address. | [optional] 
**MinEstimatedDeliveryDate** | **string** | The beginning of the date range in which the linked line item is expected to be delivered to the shipping address. | [optional] 
**OrderId** | **string** | The unique identifier of the order to which the linked line item belongs. | [optional] 
**SellerId** | **string** | The eBay user ID of the seller who sold the linked line item. For example, the user ID of the tire seller. | [optional] 
**Shipments** | [**List&lt;TrackingInfo&gt;**](TrackingInfo.md) | An array containing any shipment tracking information available for the linked line item. | [optional] 
**Title** | **string** | The listing title of the linked line item.&lt;br&gt;&lt;br&gt;&lt;span class&#x3D;\&quot;tablenote\&quot;&gt;&lt;b&gt;Note:&lt;/b&gt; The Item ID value for the listing will be returned in this field instead of the actual title if this particular listing is on-hold due to an eBay policy violation.&lt;/span&gt; | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

