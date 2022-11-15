/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Chat
 * This is the public Twilio REST API.
 *
 * NOTE: This class is auto generated by OpenAPI Generator.
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Types;


namespace Twilio.Rest.Chat.V1
{
    public class CredentialResource : Resource
    {
    
        [JsonConverter(typeof(StringEnumConverter))]
        public sealed class PushServiceEnum : StringEnum
        {
            private PushServiceEnum(string value) : base(value) {}
            public PushServiceEnum() {}
            public static implicit operator PushServiceEnum(string value)
            {
                return new PushServiceEnum(value);
            }
            public static readonly PushServiceEnum Gcm = new PushServiceEnum("gcm");
            public static readonly PushServiceEnum Apn = new PushServiceEnum("apn");
            public static readonly PushServiceEnum Fcm = new PushServiceEnum("fcm");

        }

        
        private static Request BuildCreateRequest(CreateCredentialOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Credentials";



            return new Request(
                HttpMethod.Post,
                Rest.Domain.Chat,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> create </summary>
        /// <param name="options"> Create Credential parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Credential </returns>
        public static CredentialResource Create(CreateCredentialOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> create </summary>
        /// <param name="options"> Create Credential parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Credential </returns>
        public static async System.Threading.Tasks.Task<CredentialResource> CreateAsync(CreateCredentialOptions options,
        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> create </summary>
        /// <param name="type">  </param>
        /// <param name="friendlyName"> A descriptive string that you create to describe the new resource. It can be up to 64 characters long. </param>
        /// <param name="certificate"> [APN only] The URL encoded representation of the certificate. For example,  `- - - - -BEGIN CERTIFICATE- - - - - MIIFnTCCBIWgAwIBAgIIAjy9H849+E8wDQYJKoZIhvcNAQEFBQAwgZYxCzAJBgNV.....A== - - - - -END CERTIFICATE- - - - -` </param>
        /// <param name="privateKey"> [APN only] The URL encoded representation of the private key. For example, `- - - - -BEGIN RSA PRIVATE KEY- - - - - MIIEpQIBAAKCAQEAuyf/lNrH9ck8DmNyo3fGgvCI1l9s+cmBY3WIz+cUDqmxiieR. - - - - -END RSA PRIVATE KEY- - - - -` </param>
        /// <param name="sandbox"> [APN only] Whether to send the credential to sandbox APNs. Can be `true` to send to sandbox APNs or `false` to send to production. </param>
        /// <param name="apiKey"> [GCM only] The API key for the project that was obtained from the Google Developer console for your GCM Service application credential. </param>
        /// <param name="secret"> [FCM only] The **Server key** of your project from the Firebase console, found under Settings / Cloud messaging. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Credential </returns>
        public static CredentialResource Create(
                                          CredentialResource.PushServiceEnum type,
                                          string friendlyName = null,
                                          string certificate = null,
                                          string privateKey = null,
                                          bool? sandbox = null,
                                          string apiKey = null,
                                          string secret = null,
                                          ITwilioRestClient client = null)
        {
            var options = new CreateCredentialOptions(type){  FriendlyName = friendlyName, Certificate = certificate, PrivateKey = privateKey, Sandbox = sandbox, ApiKey = apiKey, Secret = secret };
            return Create(options, client);
        }

        #if !NET35
        /// <summary> create </summary>
        /// <param name="type">  </param>
        /// <param name="friendlyName"> A descriptive string that you create to describe the new resource. It can be up to 64 characters long. </param>
        /// <param name="certificate"> [APN only] The URL encoded representation of the certificate. For example,  `- - - - -BEGIN CERTIFICATE- - - - - MIIFnTCCBIWgAwIBAgIIAjy9H849+E8wDQYJKoZIhvcNAQEFBQAwgZYxCzAJBgNV.....A== - - - - -END CERTIFICATE- - - - -` </param>
        /// <param name="privateKey"> [APN only] The URL encoded representation of the private key. For example, `- - - - -BEGIN RSA PRIVATE KEY- - - - - MIIEpQIBAAKCAQEAuyf/lNrH9ck8DmNyo3fGgvCI1l9s+cmBY3WIz+cUDqmxiieR. - - - - -END RSA PRIVATE KEY- - - - -` </param>
        /// <param name="sandbox"> [APN only] Whether to send the credential to sandbox APNs. Can be `true` to send to sandbox APNs or `false` to send to production. </param>
        /// <param name="apiKey"> [GCM only] The API key for the project that was obtained from the Google Developer console for your GCM Service application credential. </param>
        /// <param name="secret"> [FCM only] The **Server key** of your project from the Firebase console, found under Settings / Cloud messaging. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Credential </returns>
        public static async System.Threading.Tasks.Task<CredentialResource> CreateAsync(
                                                                                  CredentialResource.PushServiceEnum type,
                                                                                  string friendlyName = null,
                                                                                  string certificate = null,
                                                                                  string privateKey = null,
                                                                                  bool? sandbox = null,
                                                                                  string apiKey = null,
                                                                                  string secret = null,
                                                                                  ITwilioRestClient client = null)
        {
        var options = new CreateCredentialOptions(type){  FriendlyName = friendlyName, Certificate = certificate, PrivateKey = privateKey, Sandbox = sandbox, ApiKey = apiKey, Secret = secret };
            return await CreateAsync(options, client);
        }
        #endif




        
        /// <summary> delete </summary>
        /// <param name="options"> Delete Credential parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Credential </returns>
        private static Request BuildDeleteRequest(DeleteCredentialOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Credentials/{Sid}";

            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);


            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Chat,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> delete </summary>
        /// <param name="options"> Delete Credential parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Credential </returns>
        public static bool Delete(DeleteCredentialOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary> delete </summary>
        /// <param name="options"> Delete Credential parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Credential </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteCredentialOptions options,
                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary> delete </summary>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the Credential resource to delete. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Credential </returns>
        public static bool Delete(string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteCredentialOptions(pathSid)     ;
            return Delete(options, client);
        }

        #if !NET35
        /// <summary> delete </summary>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the Credential resource to delete. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Credential </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteCredentialOptions(pathSid) ;
            return await DeleteAsync(options, client);
        }
        #endif
        
        private static Request BuildFetchRequest(FetchCredentialOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Credentials/{Sid}";

            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);


            return new Request(
                HttpMethod.Get,
                Rest.Domain.Chat,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> fetch </summary>
        /// <param name="options"> Fetch Credential parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Credential </returns>
        public static CredentialResource Fetch(FetchCredentialOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> fetch </summary>
        /// <param name="options"> Fetch Credential parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Credential </returns>
        public static async System.Threading.Tasks.Task<CredentialResource> FetchAsync(FetchCredentialOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
        /// <summary> fetch </summary>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the Credential resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Credential </returns>
        public static CredentialResource Fetch(
                                         string pathSid, 
                                         ITwilioRestClient client = null)
        {
            var options = new FetchCredentialOptions(pathSid){  };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> fetch </summary>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the Credential resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Credential </returns>
        public static async System.Threading.Tasks.Task<CredentialResource> FetchAsync(string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchCredentialOptions(pathSid){  };
            return await FetchAsync(options, client);
        }
        #endif
        
        private static Request BuildReadRequest(ReadCredentialOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Credentials";



            return new Request(
                HttpMethod.Get,
                Rest.Domain.Chat,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> read </summary>
        /// <param name="options"> Read Credential parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Credential </returns>
        public static ResourceSet<CredentialResource> Read(ReadCredentialOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<CredentialResource>.FromJson("credentials", response.Content);
            return new ResourceSet<CredentialResource>(page, options, client);
        }

        #if !NET35
        /// <summary> read </summary>
        /// <param name="options"> Read Credential parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Credential </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<CredentialResource>> ReadAsync(ReadCredentialOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<CredentialResource>.FromJson("credentials", response.Content);
            return new ResourceSet<CredentialResource>(page, options, client);
        }
        #endif
        /// <summary> read </summary>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <param name="limit"> Record limit </param>
        /// <returns> A single instance of Credential </returns>
        public static ResourceSet<CredentialResource> Read(
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     ITwilioRestClient client = null)
        {
            var options = new ReadCredentialOptions(){ PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary> read </summary>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <param name="limit"> Record limit </param>
        /// <returns> Task that resolves to A single instance of Credential </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<CredentialResource>> ReadAsync(
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             ITwilioRestClient client = null)
        {
            var options = new ReadCredentialOptions(){ PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        
        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<CredentialResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<CredentialResource>.FromJson("credentials", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<CredentialResource> NextPage(Page<CredentialResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<CredentialResource>.FromJson("credentials", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<CredentialResource> PreviousPage(Page<CredentialResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<CredentialResource>.FromJson("credentials", response.Content);
        }



        
        private static Request BuildUpdateRequest(UpdateCredentialOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Credentials/{Sid}";

            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);


            return new Request(
                HttpMethod.Post,
                Rest.Domain.Chat,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> update </summary>
        /// <param name="options"> Update Credential parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Credential </returns>
        public static CredentialResource Update(UpdateCredentialOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        /// <summary> update </summary>
        /// <param name="options"> Update Credential parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Credential </returns>
        #if !NET35
        public static async System.Threading.Tasks.Task<CredentialResource> UpdateAsync(UpdateCredentialOptions options,
                                                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> update </summary>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the Credential resource to update. </param>
        /// <param name="friendlyName"> A descriptive string that you create to describe the resource. It can be up to 64 characters long. </param>
        /// <param name="certificate"> [APN only] The URL encoded representation of the certificate. For example,  `- - - - -BEGIN CERTIFICATE- - - - - MIIFnTCCBIWgAwIBAgIIAjy9H849+E8wDQYJKoZIhvcNAQEFBQAwgZYxCzAJBgNV.....A== - - - - -END CERTIFICATE- - - - -` </param>
        /// <param name="privateKey"> [APN only] The URL encoded representation of the private key. For example, `- - - - -BEGIN RSA PRIVATE KEY- - - - - MIIEpQIBAAKCAQEAuyf/lNrH9ck8DmNyo3fGgvCI1l9s+cmBY3WIz+cUDqmxiieR. - - - - -END RSA PRIVATE KEY- - - - -` </param>
        /// <param name="sandbox"> [APN only] Whether to send the credential to sandbox APNs. Can be `true` to send to sandbox APNs or `false` to send to production. </param>
        /// <param name="apiKey"> [GCM only] The API key for the project that was obtained from the Google Developer console for your GCM Service application credential. </param>
        /// <param name="secret"> [FCM only] The **Server key** of your project from the Firebase console, found under Settings / Cloud messaging. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Credential </returns>
        public static CredentialResource Update(
                                          string pathSid,
                                          string friendlyName = null,
                                          string certificate = null,
                                          string privateKey = null,
                                          bool? sandbox = null,
                                          string apiKey = null,
                                          string secret = null,
                                          ITwilioRestClient client = null)
        {
            var options = new UpdateCredentialOptions(pathSid){ FriendlyName = friendlyName, Certificate = certificate, PrivateKey = privateKey, Sandbox = sandbox, ApiKey = apiKey, Secret = secret };
            return Update(options, client);
        }

        #if !NET35
        /// <summary> update </summary>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the Credential resource to update. </param>
        /// <param name="friendlyName"> A descriptive string that you create to describe the resource. It can be up to 64 characters long. </param>
        /// <param name="certificate"> [APN only] The URL encoded representation of the certificate. For example,  `- - - - -BEGIN CERTIFICATE- - - - - MIIFnTCCBIWgAwIBAgIIAjy9H849+E8wDQYJKoZIhvcNAQEFBQAwgZYxCzAJBgNV.....A== - - - - -END CERTIFICATE- - - - -` </param>
        /// <param name="privateKey"> [APN only] The URL encoded representation of the private key. For example, `- - - - -BEGIN RSA PRIVATE KEY- - - - - MIIEpQIBAAKCAQEAuyf/lNrH9ck8DmNyo3fGgvCI1l9s+cmBY3WIz+cUDqmxiieR. - - - - -END RSA PRIVATE KEY- - - - -` </param>
        /// <param name="sandbox"> [APN only] Whether to send the credential to sandbox APNs. Can be `true` to send to sandbox APNs or `false` to send to production. </param>
        /// <param name="apiKey"> [GCM only] The API key for the project that was obtained from the Google Developer console for your GCM Service application credential. </param>
        /// <param name="secret"> [FCM only] The **Server key** of your project from the Firebase console, found under Settings / Cloud messaging. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Credential </returns>
        public static async System.Threading.Tasks.Task<CredentialResource> UpdateAsync(
                                                                              string pathSid,
                                                                              string friendlyName = null,
                                                                              string certificate = null,
                                                                              string privateKey = null,
                                                                              bool? sandbox = null,
                                                                              string apiKey = null,
                                                                              string secret = null,
                                                                              ITwilioRestClient client = null)
        {
            var options = new UpdateCredentialOptions(pathSid){ FriendlyName = friendlyName, Certificate = certificate, PrivateKey = privateKey, Sandbox = sandbox, ApiKey = apiKey, Secret = secret };
            return await UpdateAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a CredentialResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> CredentialResource object represented by the provided JSON </returns>
        public static CredentialResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<CredentialResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

    
        ///<summary> The unique string that identifies the resource </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> The SID of the Account that created the resource </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The string that you assigned to describe the resource </summary> 
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }

        
        [JsonProperty("type")]
        public CredentialResource.PushServiceEnum Type { get; private set; }

        ///<summary> [APN only] Whether to send the credential to sandbox APNs </summary> 
        [JsonProperty("sandbox")]
        public string Sandbox { get; private set; }

        ///<summary> The RFC 2822 date and time in GMT when the resource was created </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The RFC 2822 date and time in GMT when the resource was last updated </summary> 
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }

        ///<summary> The absolute URL of the Credential resource </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }



        private CredentialResource() {

        }
    }
}

