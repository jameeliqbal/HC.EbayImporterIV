# EBay.OAS3v1IV.Models.OrderRefund
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Amount** | [**Amount**](Amount.md) |  | [optional] 
**RefundDate** | **string** | The date and time that the refund was issued. This timestamp is in ISO 8601 format, which uses the 24-hour Universal Coordinated Time (UTC) clock. This field is not returned until the refund has been issued. &lt;br&gt;&lt;br&gt;&lt;b&gt;Format:&lt;/b&gt; &lt;code&gt;[YYYY]-[MM]-[DD]T[hh]:[mm]:[ss].[sss]Z&lt;/code&gt; &lt;br&gt;&lt;b&gt;Example:&lt;/b&gt; &lt;code&gt;2015-08-04T19:09:02.768Z&lt;/code&gt; | [optional] 
**RefundId** | **string** | Unique identifier of a refund that was initiated for an order through the &lt;b&gt;issueRefund&lt;/b&gt; method. If the &lt;b&gt;issueRefund&lt;/b&gt; method was used to issue one or more refunds at the line item level, these refund identifiers are returned at the line item level instead (&lt;b&gt;lineItems.refunds.refundId&lt;/b&gt; field).&lt;br&gt;&lt;br&gt; A &lt;b&gt;refundId&lt;/b&gt; value is returned in the response of the &lt;b&gt;issueRefund&lt;/b&gt; method, and this same value will be returned in the &lt;b&gt;getOrders&lt;/b&gt; and &lt;b&gt;getOrders&lt;/b&gt; responses for pending and completed refunds. For other refunds, see the &lt;b&gt;refundReferenceId&lt;/b&gt; field. | [optional] 
**RefundReferenceId** | **string** | The eBay-generated unique identifier for the refund. This field is not returned until the refund has been issued. | [optional] 
**RefundStatus** | **string** | This enumeration value indicates the current status of the refund to the buyer. This container is always returned for each refund. For implementation help, refer to &lt;a href&#x3D;&#x27;https://developer.ebay.com/api-docs/sell/fulfillment/types/sel:RefundStatusEnum&#x27;&gt;eBay API documentation&lt;/a&gt; | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

