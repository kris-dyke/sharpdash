# IO.Swagger.Model.Order
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [optional] 
**Consumer** | [**Consumer**](Consumer.md) |  | [optional] 
**Store** | [**Store**](Store.md) |  | [optional] 
**Subtotal** | **int?** |  | [optional] 
**Tax** | **int?** |  | [optional] 
**EstimatedPickupTime** | **DateTime?** |  | [optional] 
**IsPickup** | **bool?** |  | [optional] 
**Categories** | [**List&lt;OrderMenuCategory&gt;**](OrderMenuCategory.md) |  | [optional] 
**IsTaxRemittedByDoordash** | **bool?** |  | [optional] 
**TaxAmountRemittedByDoordash** | **int?** |  | [optional] 
**CommissionType** | **string** |  | [optional] 
**DeliveryShortCode** | **string** | short code for dasher to identify an order | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

