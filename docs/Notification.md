
# io.github.vrchatapi.Model.Notification

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | 
**SenderUserId** | **string** |  | [readonly] 
**SenderUsername** | **string** |  | 
**Type** | **NotificationType** |  | 
**Message** | **string** |  | 
**Details** | **string** | **NOTICE:** This is not a JSON object, this is a json **encoded** object, meaning you have to json-de-encode to get the NotificationDetail object depending on the NotificationType. | [default to "{}"]
**Seen** | **bool** |  | [default to false]
**CreatedAt** | **DateTime** |  | [readonly] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)
