# IO.Swagger.Api.Apiv1menusApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PatchMenuDetailView**](Apiv1menusApi.md#patchmenudetailview) | **PATCH** /api/v1/menus/{id} | 
[**PostMenuListView**](Apiv1menusApi.md#postmenulistview) | **POST** /api/v1/menus | 


<a name="patchmenudetailview"></a>
# **PatchMenuDetailView**
> void PatchMenuDetailView (string id, string userAgent = null, string authorization = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PatchMenuDetailViewExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new Apiv1menusApi();
            var id = id_example;  // string | An ID
            var userAgent = userAgent_example;  // string | Your company identity. Format is [name]/[version]. like 'Sicom/1.0' (optional) 
            var authorization = authorization_example;  // string | The access token. Format is [type] [credentials]. like 'Bearer $101$gkeikcha3' (optional) 

            try
            {
                apiInstance.PatchMenuDetailView(id, userAgent, authorization);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Apiv1menusApi.PatchMenuDetailView: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| An ID | 
 **userAgent** | **string**| Your company identity. Format is [name]/[version]. like &#39;Sicom/1.0&#39; | [optional] 
 **authorization** | **string**| The access token. Format is [type] [credentials]. like &#39;Bearer $101$gkeikcha3&#39; | [optional] 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postmenulistview"></a>
# **PostMenuListView**
> void PostMenuListView (StoreMenu payload, string userAgent = null, string authorization = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostMenuListViewExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new Apiv1menusApi();
            var payload = new StoreMenu(); // StoreMenu | 
            var userAgent = userAgent_example;  // string | Your company identity. Format is [name]/[version]. like 'Sicom/1.0' (optional) 
            var authorization = authorization_example;  // string | The access token. Format is [type] [credentials]. like 'Bearer $101$gkeikcha3' (optional) 

            try
            {
                apiInstance.PostMenuListView(payload, userAgent, authorization);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Apiv1menusApi.PostMenuListView: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **payload** | [**StoreMenu**](StoreMenu.md)|  | 
 **userAgent** | **string**| Your company identity. Format is [name]/[version]. like &#39;Sicom/1.0&#39; | [optional] 
 **authorization** | **string**| The access token. Format is [type] [credentials]. like &#39;Bearer $101$gkeikcha3&#39; | [optional] 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

