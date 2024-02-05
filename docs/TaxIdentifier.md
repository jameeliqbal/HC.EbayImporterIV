# EBay.OAS3v1IV.Models.TaxIdentifier
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TaxpayerId** | **string** | This value is the unique tax ID associated with the buyer. The type of tax identification is shown in the &lt;strong&gt;taxIdentifierType&lt;/strong&gt; field. | [optional] 
**TaxIdentifierType** | **string** | This enumeration value indicates the type of tax identification being used for the buyer. The different tax types are defined in the &lt;strong&gt;TaxIdentifierTypeEnum&lt;/strong&gt; type. For implementation help, refer to &lt;a href&#x3D;&#x27;https://developer.ebay.com/api-docs/sell/fulfillment/types/sel:TaxIdentifierTypeEnum&#x27;&gt;eBay API documentation&lt;/a&gt; | [optional] 
**IssuingCountry** | **string** | This two-letter code indicates the country that issued the buyer&#x27;s tax ID. The country that the two-letter code represents can be found in the &lt;strong&gt;CountryCodeEnum&lt;/strong&gt; type, or in the  &lt;a href&#x3D;\&quot;https://www.iso.org/iso-3166-country-codes.html \&quot;&gt;ISO 3166&lt;/a&gt; standard. For implementation help, refer to &lt;a href&#x3D;&#x27;https://developer.ebay.com/api-docs/sell/fulfillment/types/ba:CountryCodeEnum&#x27;&gt;eBay API documentation&lt;/a&gt; | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

