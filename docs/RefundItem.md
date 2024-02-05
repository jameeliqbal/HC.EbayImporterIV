# EBay.OAS3v1IV.Models.RefundItem
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RefundAmount** | [**SimpleAmount**](SimpleAmount.md) |  | [optional] 
**LineItemId** | **string** | The unique identifier of an order line item. This identifier is created once a buyer purchases a &#x27;Buy It Now&#x27; item or if an auction listing ends with a winning bidder.&lt;br&gt;&lt;br&gt;Either this field or the &lt;b&gt;legacyReference&lt;/b&gt; container is needed to identify an individual order line item that will receive a refund.&lt;br&gt;&lt;br&gt; This value is returned using the &lt;a href&#x3D;\&quot;/api-docs/sell/fulfillment/resources/order/methods/getOrders\&quot; target&#x3D;\&quot;_blank \&quot;&gt;getOrders&lt;/a&gt; method. | [optional] 
**LegacyReference** | [**LegacyReference**](LegacyReference.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

