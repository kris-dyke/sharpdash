# IO.Swagger.Model.Item
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | the given name of this instance | 
**Description** | **string** |  | [optional] 
**MerchantSuppliedId** | **string** | ID as it&#39;s stored in your system | 
**Active** | **bool?** |  | [optional] [default to true]
**IsAlcohol** | **bool?** |  | [optional] 
**IsBikeFriendly** | **bool?** |  | [optional] 
**SortId** | **int?** |  | [optional] 
**Price** | **int?** |  | 
**BasePrice** | **int?** |  | [optional] 
**Extras** | [**List&lt;ItemExtra&gt;**](ItemExtra.md) |  | [optional] 
**TaxRate** | **string** |  | [optional] 
**OriginalImageUrl** | **string** | Item image URL in JPG|JPEG|PNG format, min resolution (1600w x 800h), aspect ratio 16:9 and max size 2MB. Initial image ingestion will go through approval process | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

