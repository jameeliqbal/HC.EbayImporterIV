# EBay.OAS3v1IV.Models.EbayCollectAndRemitTax
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Amount** | [**Amount**](Amount.md) |  | [optional] 
**EbayReference** | [**EbayTaxReference**](EbayTaxReference.md) |  | [optional] 
**TaxType** | **string** | The type of tax and fees that eBay will collect and remit to the taxing or fee authority. See the &lt;strong&gt;TaxTypeEnum&lt;/strong&gt; type definition for more information about each tax or fee type. For implementation help, refer to &lt;a href&#x3D;&#x27;https://developer.ebay.com/api-docs/sell/fulfillment/types/sel:TaxTypeEnum&#x27;&gt;eBay API documentation&lt;/a&gt; | [optional] 
**CollectionMethod** | **string** | This field indicates the collection method used to collect the &#x27;Collect and Remit&#x27; tax for the order. This field is always returned for orders subject to &#x27;Collect and Remit&#x27; tax, and its value is always &lt;code&gt;NET&lt;/code&gt;.&lt;br&gt;&lt;br&gt;&lt;span class&#x3D;\&quot;tablenote\&quot;&gt;&lt;strong&gt;Note:&lt;/strong&gt; Although the &lt;strong&gt;collectionMethod&lt;/strong&gt; field is returned for all orders subject to &#x27;Collect and Remit&#x27; tax, the &lt;strong&gt;collectionMethod&lt;/strong&gt; field and the &lt;strong&gt;CollectionMethodEnum&lt;/strong&gt; type are not currently of any practical use, although this field may have use in the future. If and when the logic of this field is changed, this note will be updated and a note will also be added to the Release Notes.&lt;/span&gt; For implementation help, refer to &lt;a href&#x3D;&#x27;https://developer.ebay.com/api-docs/sell/fulfillment/types/sel:CollectionMethodEnum&#x27;&gt;eBay API documentation&lt;/a&gt; | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

