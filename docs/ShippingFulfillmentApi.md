# EBay.OAS3v1IV.Apis.ShippingFulfillmentApi

All URIs are relative to *https://api.ebay.com{basePath}*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateShippingFulfillment**](ShippingFulfillmentApi.md#createshippingfulfillment) | **POST** /order/{orderId}/shipping_fulfillment | 
[**GetShippingFulfillment**](ShippingFulfillmentApi.md#getshippingfulfillment) | **GET** /order/{orderId}/shipping_fulfillment/{fulfillmentId} | 
[**GetShippingFulfillments**](ShippingFulfillmentApi.md#getshippingfulfillments) | **GET** /order/{orderId}/shipping_fulfillment | 

<a name="createshippingfulfillment"></a>
# **CreateShippingFulfillment**
> Object CreateShippingFulfillment (ShippingFulfillmentDetails body, string contentType, string orderId)



When you group an order's line items into one or more packages, each package requires a corresponding plan for handling, addressing, and shipping; this is a <i>shipping fulfillment</i>. For each package, execute this call once to generate a shipping fulfillment associated with that package. <br><br> <span class=\"tablenote\"><strong>Note:</strong> A single line item in an order can consist of multiple units of a purchased item, and one unit can consist of multiple parts or components. Although these components might be provided by the manufacturer in separate packaging, the seller must include all components of a given line item in the same package.</span> <br><br>Before using this call for a given package, you must determine which line items are in the package. If the package has been shipped, you should provide the date of shipment in the request. If not provided, it will default to the current date and time.

### Example
```csharp
using System;
using System.Diagnostics;
using EBay.OAS3v1IV.Apis;
using EBay.OAS3v1IV.Client;
using EBay.OAS3v1IV.Models;

namespace Example
{
    public class CreateShippingFulfillmentExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: api_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ShippingFulfillmentApi();
            var body = new ShippingFulfillmentDetails(); // ShippingFulfillmentDetails | fulfillment payload
            var contentType = contentType_example;  // string | This header indicates the format of the request body provided by the client. Its value should be set to <b>application/json</b>. <br><br> For more information, refer to <a href=\"/api-docs/static/rest-request-components.html#HTTP\" target=\"_blank \">HTTP request headers</a>.
            var orderId = orderId_example;  // string | This path parameter is used to specify the unique identifier of the order associated with the shipping fulfillment being created.<br><br> Use the <a href=\"/api-docs/sell/fulfillment/resources/order/methods/getOrders\" target=\"_blank \">getOrders</a> method to retrieve order IDs.

            try
            {
                Object result = apiInstance.CreateShippingFulfillment(body, contentType, orderId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShippingFulfillmentApi.CreateShippingFulfillment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ShippingFulfillmentDetails**](ShippingFulfillmentDetails.md)| fulfillment payload | 
 **contentType** | **string**| This header indicates the format of the request body provided by the client. Its value should be set to &lt;b&gt;application/json&lt;/b&gt;. &lt;br&gt;&lt;br&gt; For more information, refer to &lt;a href&#x3D;\&quot;/api-docs/static/rest-request-components.html#HTTP\&quot; target&#x3D;\&quot;_blank \&quot;&gt;HTTP request headers&lt;/a&gt;. | 
 **orderId** | **string**| This path parameter is used to specify the unique identifier of the order associated with the shipping fulfillment being created.&lt;br&gt;&lt;br&gt; Use the &lt;a href&#x3D;\&quot;/api-docs/sell/fulfillment/resources/order/methods/getOrders\&quot; target&#x3D;\&quot;_blank \&quot;&gt;getOrders&lt;/a&gt; method to retrieve order IDs. | 

### Return type

**Object**

### Authorization

[api_auth](../README.md#api_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getshippingfulfillment"></a>
# **GetShippingFulfillment**
> ShippingFulfillment GetShippingFulfillment (string fulfillmentId, string orderId)



Use this call to retrieve the contents of a fulfillment based on its unique identifier, <b>fulfillmentId</b> (combined with the associated order's <b>orderId</b>). The <b>fulfillmentId</b> value was originally generated by the <b>createShippingFulfillment</b> call, and is returned by the <b>getShippingFulfillments</b> call in the <b>members.fulfillmentId</b> field.

### Example
```csharp
using System;
using System.Diagnostics;
using EBay.OAS3v1IV.Apis;
using EBay.OAS3v1IV.Client;
using EBay.OAS3v1IV.Models;

namespace Example
{
    public class GetShippingFulfillmentExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: api_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ShippingFulfillmentApi();
            var fulfillmentId = fulfillmentId_example;  // string | This path parameter is used to specify the unique identifier of the shipping fulfillment being retrieved.<br><br>Use the <a href=\"/api-docs/sell/fulfillment/resources/order/shipping_fulfillment/methods/getShippingFulfillments\" target=\"_blank \">getShippingFulfillments</a> method to retrieved fulfillment IDs.
            var orderId = orderId_example;  // string | This path parameter is used to specify the unique identifier of the order associated with the shipping fulfillment being retrieved.<br><br> Use the <a href=\"/api-docs/sell/fulfillment/resources/order/methods/getOrders\" target=\"_blank \">getOrders</a> method to retrieve order IDs. Order ID values are also shown in My eBay/Seller Hub.

            try
            {
                ShippingFulfillment result = apiInstance.GetShippingFulfillment(fulfillmentId, orderId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShippingFulfillmentApi.GetShippingFulfillment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fulfillmentId** | **string**| This path parameter is used to specify the unique identifier of the shipping fulfillment being retrieved.&lt;br&gt;&lt;br&gt;Use the &lt;a href&#x3D;\&quot;/api-docs/sell/fulfillment/resources/order/shipping_fulfillment/methods/getShippingFulfillments\&quot; target&#x3D;\&quot;_blank \&quot;&gt;getShippingFulfillments&lt;/a&gt; method to retrieved fulfillment IDs. | 
 **orderId** | **string**| This path parameter is used to specify the unique identifier of the order associated with the shipping fulfillment being retrieved.&lt;br&gt;&lt;br&gt; Use the &lt;a href&#x3D;\&quot;/api-docs/sell/fulfillment/resources/order/methods/getOrders\&quot; target&#x3D;\&quot;_blank \&quot;&gt;getOrders&lt;/a&gt; method to retrieve order IDs. Order ID values are also shown in My eBay/Seller Hub. | 

### Return type

[**ShippingFulfillment**](ShippingFulfillment.md)

### Authorization

[api_auth](../README.md#api_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getshippingfulfillments"></a>
# **GetShippingFulfillments**
> ShippingFulfillmentPagedCollection GetShippingFulfillments (string orderId)



Use this call to retrieve the contents of all fulfillments currently defined for a specified order based on the order's unique identifier, <b>orderId</b>. This value is returned in the <b>getOrders</b> call's <b>members.orderId</b> field when you search for orders by creation date or shipment status.

### Example
```csharp
using System;
using System.Diagnostics;
using EBay.OAS3v1IV.Apis;
using EBay.OAS3v1IV.Client;
using EBay.OAS3v1IV.Models;

namespace Example
{
    public class GetShippingFulfillmentsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: api_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ShippingFulfillmentApi();
            var orderId = orderId_example;  // string | This path parameter is used to specify the unique identifier of the order associated with the shipping fulfillments being retrieved.<br><br>Use the <a href=\"/api-docs/sell/fulfillment/resources/order/methods/getOrders\" target=\"_blank \">getOrders</a> method to retrieve order IDs. Order ID values are also shown in My eBay/Seller Hub.

            try
            {
                ShippingFulfillmentPagedCollection result = apiInstance.GetShippingFulfillments(orderId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShippingFulfillmentApi.GetShippingFulfillments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderId** | **string**| This path parameter is used to specify the unique identifier of the order associated with the shipping fulfillments being retrieved.&lt;br&gt;&lt;br&gt;Use the &lt;a href&#x3D;\&quot;/api-docs/sell/fulfillment/resources/order/methods/getOrders\&quot; target&#x3D;\&quot;_blank \&quot;&gt;getOrders&lt;/a&gt; method to retrieve order IDs. Order ID values are also shown in My eBay/Seller Hub. | 

### Return type

[**ShippingFulfillmentPagedCollection**](ShippingFulfillmentPagedCollection.md)

### Authorization

[api_auth](../README.md#api_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
