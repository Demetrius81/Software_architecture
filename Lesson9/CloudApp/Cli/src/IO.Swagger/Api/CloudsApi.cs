/* 
 * Заказ на ресурсы облака
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 0.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public interface ICloudsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Метод отмены заказа на облако по ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cloudId">Идентификатор заказа облака</param>
        /// <returns></returns>
        void CencelCloudById (string cloudId);

        /// <summary>
        /// Метод отмены заказа на облако по ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cloudId">Идентификатор заказа облака</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> CencelCloudByIdWithHttpInfo (string cloudId);
        /// <summary>
        /// Метод создания заказа на облако
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Cloud</returns>
        Cloud CreateCloud (Error body);

        /// <summary>
        /// Метод создания заказа на облако
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Cloud</returns>
        ApiResponse<Cloud> CreateCloudWithHttpInfo (Error body);
        /// <summary>
        /// Метод получения списка заказов на облако
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Clouds</returns>
        Clouds GetAllClouds ();

        /// <summary>
        /// Метод получения списка заказов на облако
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Clouds</returns>
        ApiResponse<Clouds> GetAllCloudsWithHttpInfo ();
        /// <summary>
        /// Метод получения заказа на облако по ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cloudId">Идентификатор заказа облака</param>
        /// <returns>Cloud</returns>
        Cloud GetCloudById (string cloudId);

        /// <summary>
        /// Метод получения заказа на облако по ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cloudId">Идентификатор заказа облака</param>
        /// <returns>ApiResponse of Cloud</returns>
        ApiResponse<Cloud> GetCloudByIdWithHttpInfo (string cloudId);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Метод отмены заказа на облако по ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cloudId">Идентификатор заказа облака</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task CencelCloudByIdAsync (string cloudId);

        /// <summary>
        /// Метод отмены заказа на облако по ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cloudId">Идентификатор заказа облака</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> CencelCloudByIdAsyncWithHttpInfo (string cloudId);
        /// <summary>
        /// Метод создания заказа на облако
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of Cloud</returns>
        System.Threading.Tasks.Task<Cloud> CreateCloudAsync (Error body);

        /// <summary>
        /// Метод создания заказа на облако
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Cloud)</returns>
        System.Threading.Tasks.Task<ApiResponse<Cloud>> CreateCloudAsyncWithHttpInfo (Error body);
        /// <summary>
        /// Метод получения списка заказов на облако
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Clouds</returns>
        System.Threading.Tasks.Task<Clouds> GetAllCloudsAsync ();

        /// <summary>
        /// Метод получения списка заказов на облако
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (Clouds)</returns>
        System.Threading.Tasks.Task<ApiResponse<Clouds>> GetAllCloudsAsyncWithHttpInfo ();
        /// <summary>
        /// Метод получения заказа на облако по ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cloudId">Идентификатор заказа облака</param>
        /// <returns>Task of Cloud</returns>
        System.Threading.Tasks.Task<Cloud> GetCloudByIdAsync (string cloudId);

        /// <summary>
        /// Метод получения заказа на облако по ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cloudId">Идентификатор заказа облака</param>
        /// <returns>Task of ApiResponse (Cloud)</returns>
        System.Threading.Tasks.Task<ApiResponse<Cloud>> GetCloudByIdAsyncWithHttpInfo (string cloudId);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public partial class CloudsApi : ICloudsApi
    {
        private IO.Swagger.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="CloudsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CloudsApi(String basePath)
        {
            this.Configuration = new IO.Swagger.Client.Configuration { BasePath = basePath };

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CloudsApi"/> class
        /// </summary>
        /// <returns></returns>
        public CloudsApi()
        {
            this.Configuration = IO.Swagger.Client.Configuration.Default;

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CloudsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CloudsApi(IO.Swagger.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = IO.Swagger.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public IO.Swagger.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public IO.Swagger.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Метод отмены заказа на облако по ID 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cloudId">Идентификатор заказа облака</param>
        /// <returns></returns>
        public void CencelCloudById (string cloudId)
        {
             CencelCloudByIdWithHttpInfo(cloudId);
        }

        /// <summary>
        /// Метод отмены заказа на облако по ID 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cloudId">Идентификатор заказа облака</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> CencelCloudByIdWithHttpInfo (string cloudId)
        {
            // verify the required parameter 'cloudId' is set
            if (cloudId == null)
                throw new ApiException(400, "Missing required parameter 'cloudId' when calling CloudsApi->CencelCloudById");

            var localVarPath = "/clouds/{cloud_id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "adplication/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (cloudId != null) localVarPathParams.Add("cloud_id", this.Configuration.ApiClient.ParameterToString(cloudId)); // path parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CencelCloudById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// Метод отмены заказа на облако по ID 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cloudId">Идентификатор заказа облака</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task CencelCloudByIdAsync (string cloudId)
        {
             await CencelCloudByIdAsyncWithHttpInfo(cloudId);

        }

        /// <summary>
        /// Метод отмены заказа на облако по ID 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cloudId">Идентификатор заказа облака</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> CencelCloudByIdAsyncWithHttpInfo (string cloudId)
        {
            // verify the required parameter 'cloudId' is set
            if (cloudId == null)
                throw new ApiException(400, "Missing required parameter 'cloudId' when calling CloudsApi->CencelCloudById");

            var localVarPath = "/clouds/{cloud_id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "adplication/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (cloudId != null) localVarPathParams.Add("cloud_id", this.Configuration.ApiClient.ParameterToString(cloudId)); // path parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CencelCloudById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// Метод создания заказа на облако 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Cloud</returns>
        public Cloud CreateCloud (Error body)
        {
             ApiResponse<Cloud> localVarResponse = CreateCloudWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Метод создания заказа на облако 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>ApiResponse of Cloud</returns>
        public ApiResponse< Cloud > CreateCloudWithHttpInfo (Error body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling CloudsApi->CreateCloud");

            var localVarPath = "/clouds";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "adplication/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "adplication/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateCloud", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Cloud>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Cloud) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Cloud)));
        }

        /// <summary>
        /// Метод создания заказа на облако 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of Cloud</returns>
        public async System.Threading.Tasks.Task<Cloud> CreateCloudAsync (Error body)
        {
             ApiResponse<Cloud> localVarResponse = await CreateCloudAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Метод создания заказа на облако 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (Cloud)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Cloud>> CreateCloudAsyncWithHttpInfo (Error body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling CloudsApi->CreateCloud");

            var localVarPath = "/clouds";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "adplication/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "adplication/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateCloud", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Cloud>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Cloud) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Cloud)));
        }

        /// <summary>
        /// Метод получения списка заказов на облако 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Clouds</returns>
        public Clouds GetAllClouds ()
        {
             ApiResponse<Clouds> localVarResponse = GetAllCloudsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Метод получения списка заказов на облако 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Clouds</returns>
        public ApiResponse< Clouds > GetAllCloudsWithHttpInfo ()
        {

            var localVarPath = "/clouds";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "adplication/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetAllClouds", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Clouds>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Clouds) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Clouds)));
        }

        /// <summary>
        /// Метод получения списка заказов на облако 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Clouds</returns>
        public async System.Threading.Tasks.Task<Clouds> GetAllCloudsAsync ()
        {
             ApiResponse<Clouds> localVarResponse = await GetAllCloudsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Метод получения списка заказов на облако 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (Clouds)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Clouds>> GetAllCloudsAsyncWithHttpInfo ()
        {

            var localVarPath = "/clouds";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "adplication/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetAllClouds", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Clouds>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Clouds) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Clouds)));
        }

        /// <summary>
        /// Метод получения заказа на облако по ID 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cloudId">Идентификатор заказа облака</param>
        /// <returns>Cloud</returns>
        public Cloud GetCloudById (string cloudId)
        {
             ApiResponse<Cloud> localVarResponse = GetCloudByIdWithHttpInfo(cloudId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Метод получения заказа на облако по ID 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cloudId">Идентификатор заказа облака</param>
        /// <returns>ApiResponse of Cloud</returns>
        public ApiResponse< Cloud > GetCloudByIdWithHttpInfo (string cloudId)
        {
            // verify the required parameter 'cloudId' is set
            if (cloudId == null)
                throw new ApiException(400, "Missing required parameter 'cloudId' when calling CloudsApi->GetCloudById");

            var localVarPath = "/clouds/{cloud_id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "adplication/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (cloudId != null) localVarPathParams.Add("cloud_id", this.Configuration.ApiClient.ParameterToString(cloudId)); // path parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetCloudById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Cloud>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Cloud) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Cloud)));
        }

        /// <summary>
        /// Метод получения заказа на облако по ID 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cloudId">Идентификатор заказа облака</param>
        /// <returns>Task of Cloud</returns>
        public async System.Threading.Tasks.Task<Cloud> GetCloudByIdAsync (string cloudId)
        {
             ApiResponse<Cloud> localVarResponse = await GetCloudByIdAsyncWithHttpInfo(cloudId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Метод получения заказа на облако по ID 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cloudId">Идентификатор заказа облака</param>
        /// <returns>Task of ApiResponse (Cloud)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Cloud>> GetCloudByIdAsyncWithHttpInfo (string cloudId)
        {
            // verify the required parameter 'cloudId' is set
            if (cloudId == null)
                throw new ApiException(400, "Missing required parameter 'cloudId' when calling CloudsApi->GetCloudById");

            var localVarPath = "/clouds/{cloud_id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "adplication/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (cloudId != null) localVarPathParams.Add("cloud_id", this.Configuration.ApiClient.ParameterToString(cloudId)); // path parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetCloudById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Cloud>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Cloud) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Cloud)));
        }

    }
}
