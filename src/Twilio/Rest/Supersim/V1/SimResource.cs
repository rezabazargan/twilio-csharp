/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Supersim
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


namespace Twilio.Rest.Supersim.V1
{
    public class SimResource : Resource
    {
    
        [JsonConverter(typeof(StringEnumConverter))]
        public sealed class StatusEnum : StringEnum
        {
            private StatusEnum(string value) : base(value) {}
            public StatusEnum() {}
            public static implicit operator StatusEnum(string value)
            {
                return new StatusEnum(value);
            }
            public static readonly StatusEnum New = new StatusEnum("new");
            public static readonly StatusEnum Ready = new StatusEnum("ready");
            public static readonly StatusEnum Active = new StatusEnum("active");
            public static readonly StatusEnum Inactive = new StatusEnum("inactive");
            public static readonly StatusEnum Scheduled = new StatusEnum("scheduled");

        }
        public sealed class StatusUpdateEnum : StringEnum
        {
            private StatusUpdateEnum(string value) : base(value) {}
            public StatusUpdateEnum() {}
            public static implicit operator StatusUpdateEnum(string value)
            {
                return new StatusUpdateEnum(value);
            }
            public static readonly StatusUpdateEnum Ready = new StatusUpdateEnum("ready");
            public static readonly StatusUpdateEnum Active = new StatusUpdateEnum("active");
            public static readonly StatusUpdateEnum Inactive = new StatusUpdateEnum("inactive");

        }

        
        private static Request BuildCreateRequest(CreateSimOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Sims";



            return new Request(
                HttpMethod.Post,
                Rest.Domain.Supersim,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Register a Super SIM to your Account </summary>
        /// <param name="options"> Create Sim parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Sim </returns>
        public static SimResource Create(CreateSimOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Register a Super SIM to your Account </summary>
        /// <param name="options"> Create Sim parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Sim </returns>
        public static async System.Threading.Tasks.Task<SimResource> CreateAsync(CreateSimOptions options,
        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> Register a Super SIM to your Account </summary>
        /// <param name="iccid"> The [ICCID](https://en.wikipedia.org/wiki/Subscriber_identity_module#ICCID) of the Super SIM to be added to your Account. </param>
        /// <param name="registrationCode"> The 10-digit code required to claim the Super SIM for your Account. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Sim </returns>
        public static SimResource Create(
                                          string iccid,
                                          string registrationCode,
                                          ITwilioRestClient client = null)
        {
            var options = new CreateSimOptions(iccid, registrationCode){  };
            return Create(options, client);
        }

        #if !NET35
        /// <summary> Register a Super SIM to your Account </summary>
        /// <param name="iccid"> The [ICCID](https://en.wikipedia.org/wiki/Subscriber_identity_module#ICCID) of the Super SIM to be added to your Account. </param>
        /// <param name="registrationCode"> The 10-digit code required to claim the Super SIM for your Account. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Sim </returns>
        public static async System.Threading.Tasks.Task<SimResource> CreateAsync(
                                                                                  string iccid,
                                                                                  string registrationCode,
                                                                                  ITwilioRestClient client = null)
        {
        var options = new CreateSimOptions(iccid, registrationCode){  };
            return await CreateAsync(options, client);
        }
        #endif




        
        private static Request BuildFetchRequest(FetchSimOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Sims/{Sid}";

            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);


            return new Request(
                HttpMethod.Get,
                Rest.Domain.Supersim,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Fetch a Super SIM instance from your account. </summary>
        /// <param name="options"> Fetch Sim parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Sim </returns>
        public static SimResource Fetch(FetchSimOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Fetch a Super SIM instance from your account. </summary>
        /// <param name="options"> Fetch Sim parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Sim </returns>
        public static async System.Threading.Tasks.Task<SimResource> FetchAsync(FetchSimOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
        /// <summary> Fetch a Super SIM instance from your account. </summary>
        /// <param name="pathSid"> The SID of the Sim resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Sim </returns>
        public static SimResource Fetch(
                                         string pathSid, 
                                         ITwilioRestClient client = null)
        {
            var options = new FetchSimOptions(pathSid){  };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> Fetch a Super SIM instance from your account. </summary>
        /// <param name="pathSid"> The SID of the Sim resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Sim </returns>
        public static async System.Threading.Tasks.Task<SimResource> FetchAsync(string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchSimOptions(pathSid){  };
            return await FetchAsync(options, client);
        }
        #endif
        
        private static Request BuildReadRequest(ReadSimOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Sims";



            return new Request(
                HttpMethod.Get,
                Rest.Domain.Supersim,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> Retrieve a list of Super SIMs from your account. </summary>
        /// <param name="options"> Read Sim parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Sim </returns>
        public static ResourceSet<SimResource> Read(ReadSimOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<SimResource>.FromJson("sims", response.Content);
            return new ResourceSet<SimResource>(page, options, client);
        }

        #if !NET35
        /// <summary> Retrieve a list of Super SIMs from your account. </summary>
        /// <param name="options"> Read Sim parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Sim </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<SimResource>> ReadAsync(ReadSimOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<SimResource>.FromJson("sims", response.Content);
            return new ResourceSet<SimResource>(page, options, client);
        }
        #endif
        /// <summary> Retrieve a list of Super SIMs from your account. </summary>
        /// <param name="status"> The status of the Sim resources to read. Can be `new`, `ready`, `active`, `inactive`, or `scheduled`. </param>
        /// <param name="fleet"> The SID or unique name of the Fleet to which a list of Sims are assigned. </param>
        /// <param name="iccid"> The [ICCID](https://en.wikipedia.org/wiki/Subscriber_identity_module#ICCID) associated with a Super SIM to filter the list by. Passing this parameter will always return a list containing zero or one SIMs. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <param name="limit"> Record limit </param>
        /// <returns> A single instance of Sim </returns>
        public static ResourceSet<SimResource> Read(
                                                     SimResource.StatusEnum status = null,
                                                     string fleet = null,
                                                     string iccid = null,
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     ITwilioRestClient client = null)
        {
            var options = new ReadSimOptions(){ Status = status, Fleet = fleet, Iccid = iccid, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary> Retrieve a list of Super SIMs from your account. </summary>
        /// <param name="status"> The status of the Sim resources to read. Can be `new`, `ready`, `active`, `inactive`, or `scheduled`. </param>
        /// <param name="fleet"> The SID or unique name of the Fleet to which a list of Sims are assigned. </param>
        /// <param name="iccid"> The [ICCID](https://en.wikipedia.org/wiki/Subscriber_identity_module#ICCID) associated with a Super SIM to filter the list by. Passing this parameter will always return a list containing zero or one SIMs. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <param name="limit"> Record limit </param>
        /// <returns> Task that resolves to A single instance of Sim </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<SimResource>> ReadAsync(
                                                                                             SimResource.StatusEnum status = null,
                                                                                             string fleet = null,
                                                                                             string iccid = null,
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             ITwilioRestClient client = null)
        {
            var options = new ReadSimOptions(){ Status = status, Fleet = fleet, Iccid = iccid, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        
        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<SimResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<SimResource>.FromJson("sims", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<SimResource> NextPage(Page<SimResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<SimResource>.FromJson("sims", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<SimResource> PreviousPage(Page<SimResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<SimResource>.FromJson("sims", response.Content);
        }



        
        private static Request BuildUpdateRequest(UpdateSimOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Sims/{Sid}";

            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);


            return new Request(
                HttpMethod.Post,
                Rest.Domain.Supersim,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Updates the given properties of a Super SIM instance from your account. </summary>
        /// <param name="options"> Update Sim parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Sim </returns>
        public static SimResource Update(UpdateSimOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        /// <summary> Updates the given properties of a Super SIM instance from your account. </summary>
        /// <param name="options"> Update Sim parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Sim </returns>
        #if !NET35
        public static async System.Threading.Tasks.Task<SimResource> UpdateAsync(UpdateSimOptions options,
                                                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> Updates the given properties of a Super SIM instance from your account. </summary>
        /// <param name="pathSid"> The SID of the Sim resource to update. </param>
        /// <param name="uniqueName"> An application-defined string that uniquely identifies the resource. It can be used in place of the resource's `sid` in the URL to address the resource. </param>
        /// <param name="status">  </param>
        /// <param name="fleet"> The SID or unique name of the Fleet to which the SIM resource should be assigned. </param>
        /// <param name="callbackUrl"> The URL we should call using the `callback_method` after an asynchronous update has finished. </param>
        /// <param name="callbackMethod"> The HTTP method we should use to call `callback_url`. Can be: `GET` or `POST` and the default is POST. </param>
        /// <param name="accountSid"> The SID of the Account to which the Sim resource should belong. The Account SID can only be that of the requesting Account or that of a Subaccount of the requesting Account. Only valid when the Sim resource's status is new. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Sim </returns>
        public static SimResource Update(
                                          string pathSid,
                                          string uniqueName = null,
                                          SimResource.StatusUpdateEnum status = null,
                                          string fleet = null,
                                          Uri callbackUrl = null,
                                          Twilio.Http.HttpMethod callbackMethod = null,
                                          string accountSid = null,
                                          ITwilioRestClient client = null)
        {
            var options = new UpdateSimOptions(pathSid){ UniqueName = uniqueName, Status = status, Fleet = fleet, CallbackUrl = callbackUrl, CallbackMethod = callbackMethod, AccountSid = accountSid };
            return Update(options, client);
        }

        #if !NET35
        /// <summary> Updates the given properties of a Super SIM instance from your account. </summary>
        /// <param name="pathSid"> The SID of the Sim resource to update. </param>
        /// <param name="uniqueName"> An application-defined string that uniquely identifies the resource. It can be used in place of the resource's `sid` in the URL to address the resource. </param>
        /// <param name="status">  </param>
        /// <param name="fleet"> The SID or unique name of the Fleet to which the SIM resource should be assigned. </param>
        /// <param name="callbackUrl"> The URL we should call using the `callback_method` after an asynchronous update has finished. </param>
        /// <param name="callbackMethod"> The HTTP method we should use to call `callback_url`. Can be: `GET` or `POST` and the default is POST. </param>
        /// <param name="accountSid"> The SID of the Account to which the Sim resource should belong. The Account SID can only be that of the requesting Account or that of a Subaccount of the requesting Account. Only valid when the Sim resource's status is new. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Sim </returns>
        public static async System.Threading.Tasks.Task<SimResource> UpdateAsync(
                                                                              string pathSid,
                                                                              string uniqueName = null,
                                                                              SimResource.StatusUpdateEnum status = null,
                                                                              string fleet = null,
                                                                              Uri callbackUrl = null,
                                                                              Twilio.Http.HttpMethod callbackMethod = null,
                                                                              string accountSid = null,
                                                                              ITwilioRestClient client = null)
        {
            var options = new UpdateSimOptions(pathSid){ UniqueName = uniqueName, Status = status, Fleet = fleet, CallbackUrl = callbackUrl, CallbackMethod = callbackMethod, AccountSid = accountSid };
            return await UpdateAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a SimResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> SimResource object represented by the provided JSON </returns>
        public static SimResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<SimResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

    
        ///<summary> The unique string that identifies the resource </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> An application-defined string that uniquely identifies the resource </summary> 
        [JsonProperty("unique_name")]
        public string UniqueName { get; private set; }

        ///<summary> The SID of the Account that the Super SIM belongs to </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The ICCID associated with the SIM </summary> 
        [JsonProperty("iccid")]
        public string Iccid { get; private set; }

        
        [JsonProperty("status")]
        public SimResource.StatusEnum Status { get; private set; }

        ///<summary> The unique ID of the Fleet configured for this SIM </summary> 
        [JsonProperty("fleet_sid")]
        public string FleetSid { get; private set; }

        ///<summary> The ISO 8601 date and time in GMT when the resource was created </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The ISO 8601 date and time in GMT when the resource was last updated </summary> 
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }

        ///<summary> The absolute URL of the Sim Resource </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        ///<summary> The links </summary> 
        [JsonProperty("links")]
        public Dictionary<string, string> Links { get; private set; }



        private SimResource() {

        }
    }
}

