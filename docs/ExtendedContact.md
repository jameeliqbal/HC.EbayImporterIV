# EBay.OAS3v1IV.Models.ExtendedContact
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CompanyName** | **string** | The company name associated with the buyer or eBay shipping partner. This field is only returned if defined/applicable to the buyer or eBay shipping partner. | [optional] 
**ContactAddress** | [**Address**](Address.md) |  | [optional] 
**Email** | **string** | This field contains the email address of the buyer. This address will be returned for up to 14 days from order creation. If an order is more than 14 days old, no address is returned.&lt;br&gt;&lt;br&gt;&lt;span class&#x3D;\&quot;tablenote\&quot;&gt; &lt;strong&gt;Note:&lt;/strong&gt; If returned, this field contains the email address of the buyer, even for Global Shipping Program shipments.&lt;br&gt;&lt;br&gt;The &lt;b&gt;email&lt;/b&gt; will not be returned for any order that is more than 90 days old.&lt;/span&gt; | [optional] 
**FullName** | **string** | The full name of the buyer or eBay shipping partner.&lt;br&gt;&lt;br&gt;&lt;span class&#x3D;\&quot;tablenote\&quot;&gt;&lt;strong&gt;Note:&lt;/strong&gt; The &lt;b&gt;fullName&lt;/b&gt; will not be returned for any order that is more than 90 days old.&lt;/span&gt; | [optional] 
**PrimaryPhone** | [**PhoneNumber**](PhoneNumber.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

