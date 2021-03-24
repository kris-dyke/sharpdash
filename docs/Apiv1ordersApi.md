# IO.Swagger.Api.Apiv1ordersApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PatchOrderDetailView**](Apiv1ordersApi.md#patchorderdetailview) | **PATCH** /api/v1/orders/{id} | 


<a name="patchorderdetailview"></a>
# **PatchOrderDetailView**
> void PatchOrderDetailView (string id, MerchantOrderRecord payload)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PatchOrderDetailViewExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new Apiv1ordersApi();
            var id = id_example;  // string | An order ID
            var payload = new MerchantOrderRecord(); // MerchantOrderRecord | 

            try
            {
                apiInstance.PatchOrderDetailView(id, payload);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Apiv1ordersApi.PatchOrderDetailView: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| An order ID | 
 **payload** | [**MerchantOrderRecord**](MerchantOrderRecord.md)|  | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

