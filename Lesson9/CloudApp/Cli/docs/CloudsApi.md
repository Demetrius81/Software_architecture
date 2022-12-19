# IO.Swagger.Api.CloudsApi

All URIs are relative to *http://localhost:9669/api/v1/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CencelCloudById**](CloudsApi.md#cencelcloudbyid) | **DELETE** /clouds/{cloud_id} | Метод отмены заказа на облако по ID
[**CreateCloud**](CloudsApi.md#createcloud) | **POST** /clouds | Метод создания заказа на облако
[**GetAllClouds**](CloudsApi.md#getallclouds) | **GET** /clouds | Метод получения списка заказов на облако
[**GetCloudById**](CloudsApi.md#getcloudbyid) | **GET** /clouds/{cloud_id} | Метод получения заказа на облако по ID

<a name="cencelcloudbyid"></a>
# **CencelCloudById**
> void CencelCloudById (string cloudId)

Метод отмены заказа на облако по ID

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CencelCloudByIdExample
    {
        public void main()
        {
            var apiInstance = new CloudsApi();
            var cloudId = cloudId_example;  // string | Идентификатор заказа облака

            try
            {
                // Метод отмены заказа на облако по ID
                apiInstance.CencelCloudById(cloudId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CloudsApi.CencelCloudById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cloudId** | **string**| Идентификатор заказа облака | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: adplication/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createcloud"></a>
# **CreateCloud**
> Cloud CreateCloud (Error body)

Метод создания заказа на облако

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateCloudExample
    {
        public void main()
        {
            var apiInstance = new CloudsApi();
            var body = new Error(); // Error | 

            try
            {
                // Метод создания заказа на облако
                Cloud result = apiInstance.CreateCloud(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CloudsApi.CreateCloud: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Error**](Error.md)|  | 

### Return type

[**Cloud**](Cloud.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: adplication/json
 - **Accept**: adplication/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getallclouds"></a>
# **GetAllClouds**
> Clouds GetAllClouds ()

Метод получения списка заказов на облако

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAllCloudsExample
    {
        public void main()
        {
            var apiInstance = new CloudsApi();

            try
            {
                // Метод получения списка заказов на облако
                Clouds result = apiInstance.GetAllClouds();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CloudsApi.GetAllClouds: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**Clouds**](Clouds.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: adplication/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getcloudbyid"></a>
# **GetCloudById**
> Cloud GetCloudById (string cloudId)

Метод получения заказа на облако по ID

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCloudByIdExample
    {
        public void main()
        {
            var apiInstance = new CloudsApi();
            var cloudId = cloudId_example;  // string | Идентификатор заказа облака

            try
            {
                // Метод получения заказа на облако по ID
                Cloud result = apiInstance.GetCloudById(cloudId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CloudsApi.GetCloudById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cloudId** | **string**| Идентификатор заказа облака | 

### Return type

[**Cloud**](Cloud.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: adplication/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
