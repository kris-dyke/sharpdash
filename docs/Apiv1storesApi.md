# IO.Swagger.Api.Apiv1storesApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetStoreInfo**](Apiv1storesApi.md#getstoreinfo) | **GET** /api/v1/stores/{merchant_supplied_id} | 
[**GetStoreMenuInfo**](Apiv1storesApi.md#getstoremenuinfo) | **GET** /api/v1/stores/{merchant_supplied_id}/menu_details | 
[**PatchItemBatchUpdate**](Apiv1storesApi.md#patchitembatchupdate) | **PATCH** /api/v1/stores/{merchant_supplied_id}/items | 
[**PutItemActivationStatus**](Apiv1storesApi.md#putitemactivationstatus) | **PUT** /api/v1/stores/{merchant_supplied_id}/item/activation-status | 
[**PutItemOptionActivationStatus**](Apiv1storesApi.md#putitemoptionactivationstatus) | **PUT** /api/v1/stores/{merchant_supplied_id}/item_option/activation-status | 
[**PutStoreActivationStatus**](Apiv1storesApi.md#putstoreactivationstatus) | **PUT** /api/v1/stores/{merchant_supplied_id}/activation-status | 


<a name="getstoreinfo"></a>
# **GetStoreInfo**
> StoreInfo GetStoreInfo (string merchantSuppliedId)



Get live store details providing a new level of visibility

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetStoreInfoExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new Apiv1storesApi();
            var merchantSuppliedId = merchantSuppliedId_example;  // string | External id of store

            try
            {
                StoreInfo result = apiInstance.GetStoreInfo(merchantSuppliedId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Apiv1storesApi.GetStoreInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **merchantSuppliedId** | **string**| External id of store | 

### Return type

[**StoreInfo**](StoreInfo.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstoremenuinfo"></a>
# **GetStoreMenuInfo**
> StoreMenuInfo GetStoreMenuInfo (string merchantSuppliedId)



Get live store menu details providing a new level of visibility

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetStoreMenuInfoExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new Apiv1storesApi();
            var merchantSuppliedId = merchantSuppliedId_example;  // string | External id of store

            try
            {
                StoreMenuInfo result = apiInstance.GetStoreMenuInfo(merchantSuppliedId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Apiv1storesApi.GetStoreMenuInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **merchantSuppliedId** | **string**| External id of store | 

### Return type

[**StoreMenuInfo**](StoreMenuInfo.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchitembatchupdate"></a>
# **PatchItemBatchUpdate**
> void PatchItemBatchUpdate (string merchantSuppliedId, List<UpdateItem> payload)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PatchItemBatchUpdateExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new Apiv1storesApi();
            var merchantSuppliedId = merchantSuppliedId_example;  // string | External ID of Store
            var payload = new List<UpdateItem>(); // List<UpdateItem> | 

            try
            {
                apiInstance.PatchItemBatchUpdate(merchantSuppliedId, payload);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Apiv1storesApi.PatchItemBatchUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **merchantSuppliedId** | **string**| External ID of Store | 
 **payload** | [**List&lt;UpdateItem&gt;**](UpdateItem.md)|  | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putitemactivationstatus"></a>
# **PutItemActivationStatus**
> void PutItemActivationStatus (string merchantSuppliedId, List<ItemActivation> payload)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PutItemActivationStatusExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new Apiv1storesApi();
            var merchantSuppliedId = merchantSuppliedId_example;  // string | External ID of Store
            var payload = new List<ItemActivation>(); // List<ItemActivation> | 

            try
            {
                apiInstance.PutItemActivationStatus(merchantSuppliedId, payload);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Apiv1storesApi.PutItemActivationStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **merchantSuppliedId** | **string**| External ID of Store | 
 **payload** | [**List&lt;ItemActivation&gt;**](ItemActivation.md)|  | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putitemoptionactivationstatus"></a>
# **PutItemOptionActivationStatus**
> void PutItemOptionActivationStatus (string merchantSuppliedId, List<ItemOptionActivation> payload)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PutItemOptionActivationStatusExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new Apiv1storesApi();
            var merchantSuppliedId = merchantSuppliedId_example;  // string | External ID of Store
            var payload = new List<ItemOptionActivation>(); // List<ItemOptionActivation> | 

            try
            {
                apiInstance.PutItemOptionActivationStatus(merchantSuppliedId, payload);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Apiv1storesApi.PutItemOptionActivationStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **merchantSuppliedId** | **string**| External ID of Store | 
 **payload** | [**List&lt;ItemOptionActivation&gt;**](ItemOptionActivation.md)|  | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putstoreactivationstatus"></a>
# **PutStoreActivationStatus**
> void PutStoreActivationStatus (string merchantSuppliedId, StoreActivationStatus payload, string reason = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PutStoreActivationStatusExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new Apiv1storesApi();
            var merchantSuppliedId = merchantSuppliedId_example;  // string | External id of store
            var payload = new StoreActivationStatus(); // StoreActivationStatus | 
            var reason = reason_example;  // string | ['out_of_business', 'delete_store', 'payment_issue', 'operational_issues', 'store_self_disabled_in_their_POS_portal', 'store_pos_connectivity_issues'] (optional) 

            try
            {
                apiInstance.PutStoreActivationStatus(merchantSuppliedId, payload, reason);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Apiv1storesApi.PutStoreActivationStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **merchantSuppliedId** | **string**| External id of store | 
 **payload** | [**StoreActivationStatus**](StoreActivationStatus.md)|  | 
 **reason** | **string**| [&#39;out_of_business&#39;, &#39;delete_store&#39;, &#39;payment_issue&#39;, &#39;operational_issues&#39;, &#39;store_self_disabled_in_their_POS_portal&#39;, &#39;store_pos_connectivity_issues&#39;] | [optional] 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

