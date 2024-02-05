# EBay.OAS3v1IV.Models.DisputeAmount
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ConvertedFromCurrency** | **string** | The three-letter &lt;a href&#x3D;\&quot;https://www.iso.org/iso-4217-currency-codes.html \&quot; target&#x3D;\&quot;_blank\&quot;&gt;ISO 4217&lt;/a&gt; code representing the currency of the amount in the &lt;b&gt; convertedFromValue&lt;/b&gt; field. This value is the pre-conversion currency.&lt;br&gt;&lt;br&gt;This field is only returned if/when currency conversion was applied by eBay. For implementation help, refer to &lt;a href&#x3D;&#x27;https://developer.ebay.com/api-docs/sell/fulfillment/types/ba:CurrencyCodeEnum&#x27;&gt;eBay API documentation&lt;/a&gt; | [optional] 
**ConvertedFromValue** | **string** | The monetary amount before any conversion is performed, in the currency specified by the &lt;b&gt; convertedFromCurrency&lt;/b&gt; field. This value is the pre-conversion amount. The &lt;b&gt; value&lt;/b&gt; field contains the converted amount of this value, in the currency specified by the &lt;b&gt; currency&lt;/b&gt; field.&lt;br&gt;&lt;br&gt;This field is only returned if/when currency conversion was applied by eBay. | [optional] 
**Currency** | **string** | A three-letter ISO 4217 code that indicates the currency of the amount in the &lt;b&gt;value&lt;/b&gt; field. This field is always returned with any container using &lt;b&gt;Amount&lt;/b&gt; type. &lt;br&gt;&lt;br&gt;&lt;b&gt;Default&lt;/b&gt;: The currency of the authenticated user&#x27;s country. For implementation help, refer to &lt;a href&#x3D;&#x27;https://developer.ebay.com/api-docs/sell/fulfillment/types/ba:CurrencyCodeEnum&#x27;&gt;eBay API documentation&lt;/a&gt; | [optional] 
**ExchangeRate** | **string** | The exchange rate used for the monetary conversion. This field shows the exchange rate used to convert the dollar value in the &lt;b&gt;value&lt;/b&gt; field from the dollar value in the &lt;b&gt;convertedFromValue&lt;/b&gt; field.&lt;br&gt;&lt;br&gt;This field is only returned if/when currency conversion was applied by eBay. | [optional] 
**Value** | **string** | The monetary amount, in the currency specified by the &lt;b&gt;currency&lt;/b&gt; field. This field is always returned with any container using &lt;b&gt;Amount&lt;/b&gt; type. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

