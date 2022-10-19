/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Autopilot
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



namespace Twilio.Rest.Autopilot.V1
{
    public class AssistantResource : Resource
    {
    

        
        private static Request BuildCreateRequest(CreateAssistantOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Assistants";



            return new Request(
                HttpMethod.Post,
                Rest.Domain.Autopilot,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> create </summary>
        /// <param name="options"> Create Assistant parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Assistant </returns>
        public static AssistantResource Create(CreateAssistantOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> create </summary>
        /// <param name="options"> Create Assistant parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Assistant </returns>
        public static async System.Threading.Tasks.Task<AssistantResource> CreateAsync(CreateAssistantOptions options,
        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> create </summary>
        /// <param name="friendlyName"> A descriptive string that you create to describe the new resource. It is not unique and can be up to 255 characters long. </param>
        /// <param name="logQueries"> Whether queries should be logged and kept after training. Can be: `true` or `false` and defaults to `true`. If `true`, queries are stored for 30 days, and then deleted. If `false`, no queries are stored. </param>
        /// <param name="uniqueName"> An application-defined string that uniquely identifies the new resource. It can be used as an alternative to the `sid` in the URL path to address the resource. The first 64 characters must be unique. </param>
        /// <param name="callbackUrl"> Reserved. </param>
        /// <param name="callbackEvents"> Reserved. </param>
        /// <param name="styleSheet"> The JSON string that defines the Assistant's [style sheet](https://www.twilio.com/docs/autopilot/api/assistant/stylesheet) </param>
        /// <param name="defaults"> A JSON object that defines the Assistant's [default tasks](https://www.twilio.com/docs/autopilot/api/assistant/defaults) for various scenarios, including initiation actions and fallback tasks. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Assistant </returns>
        public static AssistantResource Create(
                                          string friendlyName = null,
                                          bool? logQueries = null,
                                          string uniqueName = null,
                                          Uri callbackUrl = null,
                                          string callbackEvents = null,
                                          object styleSheet = null,
                                          object defaults = null,
                                          ITwilioRestClient client = null)
        {
            var options = new CreateAssistantOptions(){  FriendlyName = friendlyName, LogQueries = logQueries, UniqueName = uniqueName, CallbackUrl = callbackUrl, CallbackEvents = callbackEvents, StyleSheet = styleSheet, Defaults = defaults };
            return Create(options, client);
        }

        #if !NET35
        /// <summary> create </summary>
        /// <param name="friendlyName"> A descriptive string that you create to describe the new resource. It is not unique and can be up to 255 characters long. </param>
        /// <param name="logQueries"> Whether queries should be logged and kept after training. Can be: `true` or `false` and defaults to `true`. If `true`, queries are stored for 30 days, and then deleted. If `false`, no queries are stored. </param>
        /// <param name="uniqueName"> An application-defined string that uniquely identifies the new resource. It can be used as an alternative to the `sid` in the URL path to address the resource. The first 64 characters must be unique. </param>
        /// <param name="callbackUrl"> Reserved. </param>
        /// <param name="callbackEvents"> Reserved. </param>
        /// <param name="styleSheet"> The JSON string that defines the Assistant's [style sheet](https://www.twilio.com/docs/autopilot/api/assistant/stylesheet) </param>
        /// <param name="defaults"> A JSON object that defines the Assistant's [default tasks](https://www.twilio.com/docs/autopilot/api/assistant/defaults) for various scenarios, including initiation actions and fallback tasks. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Assistant </returns>
        public static async System.Threading.Tasks.Task<AssistantResource> CreateAsync(
                                                                                  string friendlyName = null,
                                                                                  bool? logQueries = null,
                                                                                  string uniqueName = null,
                                                                                  Uri callbackUrl = null,
                                                                                  string callbackEvents = null,
                                                                                  object styleSheet = null,
                                                                                  object defaults = null,
                                                                                  ITwilioRestClient client = null)
        {
        var options = new CreateAssistantOptions(){  FriendlyName = friendlyName, LogQueries = logQueries, UniqueName = uniqueName, CallbackUrl = callbackUrl, CallbackEvents = callbackEvents, StyleSheet = styleSheet, Defaults = defaults };
            return await CreateAsync(options, client);
        }
        #endif




        
        /// <summary> delete </summary>
        /// <param name="options"> Delete Assistant parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Assistant </returns>
        private static Request BuildDeleteRequest(DeleteAssistantOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Assistants/{Sid}";

            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);


            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Autopilot,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> delete </summary>
        /// <param name="options"> Delete Assistant parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Assistant </returns>
        public static bool Delete(DeleteAssistantOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary> delete </summary>
        /// <param name="options"> Delete Assistant parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Assistant </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteAssistantOptions options,
                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary> delete </summary>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the Assistant resource to delete. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Assistant </returns>
        public static bool Delete(string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteAssistantOptions(pathSid)     ;
            return Delete(options, client);
        }

        #if !NET35
        /// <summary> delete </summary>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the Assistant resource to delete. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Assistant </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteAssistantOptions(pathSid) ;
            return await DeleteAsync(options, client);
        }
        #endif
        
        private static Request BuildFetchRequest(FetchAssistantOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Assistants/{Sid}";

            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);


            return new Request(
                HttpMethod.Get,
                Rest.Domain.Autopilot,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> fetch </summary>
        /// <param name="options"> Fetch Assistant parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Assistant </returns>
        public static AssistantResource Fetch(FetchAssistantOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> fetch </summary>
        /// <param name="options"> Fetch Assistant parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Assistant </returns>
        public static async System.Threading.Tasks.Task<AssistantResource> FetchAsync(FetchAssistantOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
        /// <summary> fetch </summary>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the Assistant resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Assistant </returns>
        public static AssistantResource Fetch(
                                         string pathSid, 
                                         ITwilioRestClient client = null)
        {
            var options = new FetchAssistantOptions(pathSid){  };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> fetch </summary>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the Assistant resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Assistant </returns>
        public static async System.Threading.Tasks.Task<AssistantResource> FetchAsync(string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchAssistantOptions(pathSid){  };
            return await FetchAsync(options, client);
        }
        #endif
        
        private static Request BuildReadRequest(ReadAssistantOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Assistants";



            return new Request(
                HttpMethod.Get,
                Rest.Domain.Autopilot,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> read </summary>
        /// <param name="options"> Read Assistant parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Assistant </returns>
        public static ResourceSet<AssistantResource> Read(ReadAssistantOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<AssistantResource>.FromJson("assistants", response.Content);
            return new ResourceSet<AssistantResource>(page, options, client);
        }

        #if !NET35
        /// <summary> read </summary>
        /// <param name="options"> Read Assistant parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Assistant </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<AssistantResource>> ReadAsync(ReadAssistantOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<AssistantResource>.FromJson("assistants", response.Content);
            return new ResourceSet<AssistantResource>(page, options, client);
        }
        #endif
        /// <summary> read </summary>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <param name="limit"> Record limit </param>
        /// <returns> A single instance of Assistant </returns>
        public static ResourceSet<AssistantResource> Read(
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     ITwilioRestClient client = null)
        {
            var options = new ReadAssistantOptions(){ PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary> read </summary>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <param name="limit"> Record limit </param>
        /// <returns> Task that resolves to A single instance of Assistant </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<AssistantResource>> ReadAsync(
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             ITwilioRestClient client = null)
        {
            var options = new ReadAssistantOptions(){ PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        
        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<AssistantResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<AssistantResource>.FromJson("assistants", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<AssistantResource> NextPage(Page<AssistantResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<AssistantResource>.FromJson("assistants", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<AssistantResource> PreviousPage(Page<AssistantResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<AssistantResource>.FromJson("assistants", response.Content);
        }



        
        private static Request BuildUpdateRequest(UpdateAssistantOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Assistants/{Sid}";

            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);


            return new Request(
                HttpMethod.Post,
                Rest.Domain.Autopilot,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> update </summary>
        /// <param name="options"> Update Assistant parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Assistant </returns>
        public static AssistantResource Update(UpdateAssistantOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        /// <summary> update </summary>
        /// <param name="options"> Update Assistant parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Assistant </returns>
        #if !NET35
        public static async System.Threading.Tasks.Task<AssistantResource> UpdateAsync(UpdateAssistantOptions options,
                                                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> update </summary>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the Assistant resource to update. </param>
        /// <param name="friendlyName"> A descriptive string that you create to describe the resource. It is not unique and can be up to 255 characters long. </param>
        /// <param name="logQueries"> Whether queries should be logged and kept after training. Can be: `true` or `false` and defaults to `true`. If `true`, queries are stored for 30 days, and then deleted. If `false`, no queries are stored. </param>
        /// <param name="uniqueName"> An application-defined string that uniquely identifies the resource. It can be used as an alternative to the `sid` in the URL path to address the resource. The first 64 characters must be unique. </param>
        /// <param name="callbackUrl"> Reserved. </param>
        /// <param name="callbackEvents"> Reserved. </param>
        /// <param name="styleSheet"> The JSON string that defines the Assistant's [style sheet](https://www.twilio.com/docs/autopilot/api/assistant/stylesheet) </param>
        /// <param name="defaults"> A JSON object that defines the Assistant's [default tasks](https://www.twilio.com/docs/autopilot/api/assistant/defaults) for various scenarios, including initiation actions and fallback tasks. </param>
        /// <param name="developmentStage"> A string describing the state of the assistant. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Assistant </returns>
        public static AssistantResource Update(
                                          string pathSid,
                                          string friendlyName = null,
                                          bool? logQueries = null,
                                          string uniqueName = null,
                                          Uri callbackUrl = null,
                                          string callbackEvents = null,
                                          object styleSheet = null,
                                          object defaults = null,
                                          string developmentStage = null,
                                          ITwilioRestClient client = null)
        {
            var options = new UpdateAssistantOptions(pathSid){ FriendlyName = friendlyName, LogQueries = logQueries, UniqueName = uniqueName, CallbackUrl = callbackUrl, CallbackEvents = callbackEvents, StyleSheet = styleSheet, Defaults = defaults, DevelopmentStage = developmentStage };
            return Update(options, client);
        }

        #if !NET35
        /// <summary> update </summary>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the Assistant resource to update. </param>
        /// <param name="friendlyName"> A descriptive string that you create to describe the resource. It is not unique and can be up to 255 characters long. </param>
        /// <param name="logQueries"> Whether queries should be logged and kept after training. Can be: `true` or `false` and defaults to `true`. If `true`, queries are stored for 30 days, and then deleted. If `false`, no queries are stored. </param>
        /// <param name="uniqueName"> An application-defined string that uniquely identifies the resource. It can be used as an alternative to the `sid` in the URL path to address the resource. The first 64 characters must be unique. </param>
        /// <param name="callbackUrl"> Reserved. </param>
        /// <param name="callbackEvents"> Reserved. </param>
        /// <param name="styleSheet"> The JSON string that defines the Assistant's [style sheet](https://www.twilio.com/docs/autopilot/api/assistant/stylesheet) </param>
        /// <param name="defaults"> A JSON object that defines the Assistant's [default tasks](https://www.twilio.com/docs/autopilot/api/assistant/defaults) for various scenarios, including initiation actions and fallback tasks. </param>
        /// <param name="developmentStage"> A string describing the state of the assistant. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Assistant </returns>
        public static async System.Threading.Tasks.Task<AssistantResource> UpdateAsync(
                                                                              string pathSid,
                                                                              string friendlyName = null,
                                                                              bool? logQueries = null,
                                                                              string uniqueName = null,
                                                                              Uri callbackUrl = null,
                                                                              string callbackEvents = null,
                                                                              object styleSheet = null,
                                                                              object defaults = null,
                                                                              string developmentStage = null,
                                                                              ITwilioRestClient client = null)
        {
            var options = new UpdateAssistantOptions(pathSid){ FriendlyName = friendlyName, LogQueries = logQueries, UniqueName = uniqueName, CallbackUrl = callbackUrl, CallbackEvents = callbackEvents, StyleSheet = styleSheet, Defaults = defaults, DevelopmentStage = developmentStage };
            return await UpdateAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a AssistantResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> AssistantResource object represented by the provided JSON </returns>
        public static AssistantResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<AssistantResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

    
        ///<summary> The SID of the Account that created the resource </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The RFC 2822 date and time in GMT when the resource was created </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The RFC 2822 date and time in GMT when the resource was last updated </summary> 
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }

        ///<summary> The string that you assigned to describe the resource </summary> 
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }

        ///<summary> Reserved </summary> 
        [JsonProperty("latest_model_build_sid")]
        public string LatestModelBuildSid { get; private set; }

        ///<summary> A list of the URLs of the Assistant's related resources </summary> 
        [JsonProperty("links")]
        public Dictionary<string, string> Links { get; private set; }

        ///<summary> Whether queries should be logged and kept after training </summary> 
        [JsonProperty("log_queries")]
        public bool? LogQueries { get; private set; }

        ///<summary> A string describing the state of the assistant. </summary> 
        [JsonProperty("development_stage")]
        public string DevelopmentStage { get; private set; }

        ///<summary> Whether model needs to be rebuilt </summary> 
        [JsonProperty("needs_model_build")]
        public bool? NeedsModelBuild { get; private set; }

        ///<summary> The unique string that identifies the resource </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> An application-defined string that uniquely identifies the resource </summary> 
        [JsonProperty("unique_name")]
        public string UniqueName { get; private set; }

        ///<summary> The absolute URL of the Assistant resource </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        ///<summary> Reserved </summary> 
        [JsonProperty("callback_url")]
        public Uri CallbackUrl { get; private set; }

        ///<summary> Reserved </summary> 
        [JsonProperty("callback_events")]
        public string CallbackEvents { get; private set; }



        private AssistantResource() {

        }
    }
}

