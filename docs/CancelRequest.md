# EBay.OAS3v1IV.Models.CancelRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CancelCompletedDate** | **string** | The date and time that the order cancellation was completed, if applicable. This timestamp is in ISO 8601 format, which uses the 24-hour Universal Coordinated Time (UTC) clock. This field is not returned until the cancellation request has actually been approved by the seller.&lt;br&gt;&lt;br&gt;&lt;b&gt;Format:&lt;/b&gt; &lt;code&gt;[YYYY]-[MM]-[DD]T[hh]:[mm]:[ss].[sss]Z&lt;/code&gt; &lt;br&gt;&lt;b&gt;Example:&lt;/b&gt; &lt;code&gt;2015-08-04T19:09:02.768Z&lt;/code&gt; | [optional] 
**CancelInitiator** | **string** | This string value indicates the party who made the initial cancellation request. Typically, either the &#x27;Buyer&#x27; or &#x27;Seller&#x27;. If a cancellation request has been made, this field should be returned. | [optional] 
**CancelReason** | **string** | The reason why the &lt;b&gt;cancelInitiator&lt;/b&gt; initiated the cancellation request. Cancellation reasons for a buyer might include &#x27;order placed by mistake&#x27; or &#x27;order won&#x27;t arrive in time&#x27;. For a seller, a typical cancellation reason is &#x27;out of stock&#x27;. If a cancellation request has been made, this field should be returned. | [optional] 
**CancelRequestedDate** | **string** | The date and time that the order cancellation was requested. This timestamp is in ISO 8601 format, which uses the 24-hour Universal Coordinated Time (UTC) clock. This field is returned for each cancellation request.&lt;br&gt;&lt;br&gt;&lt;b&gt;Format:&lt;/b&gt; &lt;code&gt;[YYYY]-[MM]-[DD]T[hh]:[mm]:[ss].[sss]Z&lt;/code&gt; &lt;br&gt;&lt;b&gt;Example:&lt;/b&gt; &lt;code&gt;2015-08-04T19:09:02.768Z&lt;/code&gt; | [optional] 
**CancelRequestId** | **string** | The unique identifier of the order cancellation request. This field is returned for each cancellation request. | [optional] 
**CancelRequestState** | **string** | The current stage or condition of the cancellation request. This field is returned for each cancellation request. For implementation help, refer to &lt;a href&#x3D;&#x27;https://developer.ebay.com/api-docs/sell/fulfillment/types/sel:CancelRequestStateEnum&#x27;&gt;eBay API documentation&lt;/a&gt; | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

