/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Trusthub
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



namespace Twilio.Rest.Trusthub.V1.TrustProducts
{
    public class TrustProductsEntityAssignmentsResource : Resource
    {
    

        
        private static Request BuildCreateRequest(CreateTrustProductsEntityAssignmentsOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/TrustProducts/{TrustProductSid}/EntityAssignments";

            string PathTrustProductSid = options.PathTrustProductSid;
            path = path.Replace("{"+"TrustProductSid"+"}", PathTrustProductSid);


            return new Request(
                HttpMethod.Post,
                Rest.Domain.Trusthub,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Create a new Assigned Item. </summary>
        /// <param name="options"> Create TrustProductsEntityAssignments parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of TrustProductsEntityAssignments </returns>
        public static TrustProductsEntityAssignmentsResource Create(CreateTrustProductsEntityAssignmentsOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Create a new Assigned Item. </summary>
        /// <param name="options"> Create TrustProductsEntityAssignments parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of TrustProductsEntityAssignments </returns>
        public static async System.Threading.Tasks.Task<TrustProductsEntityAssignmentsResource> CreateAsync(CreateTrustProductsEntityAssignmentsOptions options,
        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> Create a new Assigned Item. </summary>
        /// <param name="pathTrustProductSid"> The unique string that we created to identify the TrustProduct resource. </param>
        /// <param name="objectSid"> The SID of an object bag that holds information of the different items. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of TrustProductsEntityAssignments </returns>
        public static TrustProductsEntityAssignmentsResource Create(
                                          string pathTrustProductSid,
                                          string objectSid,
                                          ITwilioRestClient client = null)
        {
            var options = new CreateTrustProductsEntityAssignmentsOptions(pathTrustProductSid, objectSid){  };
            return Create(options, client);
        }

        #if !NET35
        /// <summary> Create a new Assigned Item. </summary>
        /// <param name="pathTrustProductSid"> The unique string that we created to identify the TrustProduct resource. </param>
        /// <param name="objectSid"> The SID of an object bag that holds information of the different items. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of TrustProductsEntityAssignments </returns>
        public static async System.Threading.Tasks.Task<TrustProductsEntityAssignmentsResource> CreateAsync(
                                                                                  string pathTrustProductSid,
                                                                                  string objectSid,
                                                                                  ITwilioRestClient client = null)
        {
        var options = new CreateTrustProductsEntityAssignmentsOptions(pathTrustProductSid, objectSid){  };
            return await CreateAsync(options, client);
        }
        #endif




        
        /// <summary> Remove an Assignment Item Instance. </summary>
        /// <param name="options"> Delete TrustProductsEntityAssignments parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of TrustProductsEntityAssignments </returns>
        private static Request BuildDeleteRequest(DeleteTrustProductsEntityAssignmentsOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/TrustProducts/{TrustProductSid}/EntityAssignments/{Sid}";

            string PathTrustProductSid = options.PathTrustProductSid;
            path = path.Replace("{"+"TrustProductSid"+"}", PathTrustProductSid);
            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);


            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Trusthub,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Remove an Assignment Item Instance. </summary>
        /// <param name="options"> Delete TrustProductsEntityAssignments parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of TrustProductsEntityAssignments </returns>
        public static bool Delete(DeleteTrustProductsEntityAssignmentsOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary> Remove an Assignment Item Instance. </summary>
        /// <param name="options"> Delete TrustProductsEntityAssignments parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of TrustProductsEntityAssignments </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteTrustProductsEntityAssignmentsOptions options,
                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary> Remove an Assignment Item Instance. </summary>
        /// <param name="pathTrustProductSid"> The unique string that we created to identify the TrustProduct resource. </param>
        /// <param name="pathSid"> The unique string that we created to identify the Identity resource. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of TrustProductsEntityAssignments </returns>
        public static bool Delete(string pathTrustProductSid, string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteTrustProductsEntityAssignmentsOptions(pathTrustProductSid, pathSid)        ;
            return Delete(options, client);
        }

        #if !NET35
        /// <summary> Remove an Assignment Item Instance. </summary>
        /// <param name="pathTrustProductSid"> The unique string that we created to identify the TrustProduct resource. </param>
        /// <param name="pathSid"> The unique string that we created to identify the Identity resource. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of TrustProductsEntityAssignments </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathTrustProductSid, string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteTrustProductsEntityAssignmentsOptions(pathTrustProductSid, pathSid) ;
            return await DeleteAsync(options, client);
        }
        #endif
        
        private static Request BuildFetchRequest(FetchTrustProductsEntityAssignmentsOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/TrustProducts/{TrustProductSid}/EntityAssignments/{Sid}";

            string PathTrustProductSid = options.PathTrustProductSid;
            path = path.Replace("{"+"TrustProductSid"+"}", PathTrustProductSid);
            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);


            return new Request(
                HttpMethod.Get,
                Rest.Domain.Trusthub,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Fetch specific Assigned Item Instance. </summary>
        /// <param name="options"> Fetch TrustProductsEntityAssignments parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of TrustProductsEntityAssignments </returns>
        public static TrustProductsEntityAssignmentsResource Fetch(FetchTrustProductsEntityAssignmentsOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Fetch specific Assigned Item Instance. </summary>
        /// <param name="options"> Fetch TrustProductsEntityAssignments parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of TrustProductsEntityAssignments </returns>
        public static async System.Threading.Tasks.Task<TrustProductsEntityAssignmentsResource> FetchAsync(FetchTrustProductsEntityAssignmentsOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
        /// <summary> Fetch specific Assigned Item Instance. </summary>
        /// <param name="pathTrustProductSid"> The unique string that we created to identify the TrustProduct resource. </param>
        /// <param name="pathSid"> The unique string that we created to identify the Identity resource. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of TrustProductsEntityAssignments </returns>
        public static TrustProductsEntityAssignmentsResource Fetch(
                                         string pathTrustProductSid, 
                                         string pathSid, 
                                         ITwilioRestClient client = null)
        {
            var options = new FetchTrustProductsEntityAssignmentsOptions(pathTrustProductSid, pathSid){  };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> Fetch specific Assigned Item Instance. </summary>
        /// <param name="pathTrustProductSid"> The unique string that we created to identify the TrustProduct resource. </param>
        /// <param name="pathSid"> The unique string that we created to identify the Identity resource. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of TrustProductsEntityAssignments </returns>
        public static async System.Threading.Tasks.Task<TrustProductsEntityAssignmentsResource> FetchAsync(string pathTrustProductSid, string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchTrustProductsEntityAssignmentsOptions(pathTrustProductSid, pathSid){  };
            return await FetchAsync(options, client);
        }
        #endif
        
        private static Request BuildReadRequest(ReadTrustProductsEntityAssignmentsOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/TrustProducts/{TrustProductSid}/EntityAssignments";

            string PathTrustProductSid = options.PathTrustProductSid;
            path = path.Replace("{"+"TrustProductSid"+"}", PathTrustProductSid);


            return new Request(
                HttpMethod.Get,
                Rest.Domain.Trusthub,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> Retrieve a list of all Assigned Items for an account. </summary>
        /// <param name="options"> Read TrustProductsEntityAssignments parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of TrustProductsEntityAssignments </returns>
        public static ResourceSet<TrustProductsEntityAssignmentsResource> Read(ReadTrustProductsEntityAssignmentsOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<TrustProductsEntityAssignmentsResource>.FromJson("results", response.Content);
            return new ResourceSet<TrustProductsEntityAssignmentsResource>(page, options, client);
        }

        #if !NET35
        /// <summary> Retrieve a list of all Assigned Items for an account. </summary>
        /// <param name="options"> Read TrustProductsEntityAssignments parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of TrustProductsEntityAssignments </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<TrustProductsEntityAssignmentsResource>> ReadAsync(ReadTrustProductsEntityAssignmentsOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<TrustProductsEntityAssignmentsResource>.FromJson("results", response.Content);
            return new ResourceSet<TrustProductsEntityAssignmentsResource>(page, options, client);
        }
        #endif
        /// <summary> Retrieve a list of all Assigned Items for an account. </summary>
        /// <param name="pathTrustProductSid"> The unique string that we created to identify the TrustProduct resource. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <param name="limit"> Record limit </param>
        /// <returns> A single instance of TrustProductsEntityAssignments </returns>
        public static ResourceSet<TrustProductsEntityAssignmentsResource> Read(
                                                     string pathTrustProductSid,
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     ITwilioRestClient client = null)
        {
            var options = new ReadTrustProductsEntityAssignmentsOptions(pathTrustProductSid){ PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary> Retrieve a list of all Assigned Items for an account. </summary>
        /// <param name="pathTrustProductSid"> The unique string that we created to identify the TrustProduct resource. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <param name="limit"> Record limit </param>
        /// <returns> Task that resolves to A single instance of TrustProductsEntityAssignments </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<TrustProductsEntityAssignmentsResource>> ReadAsync(
                                                                                             string pathTrustProductSid,
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             ITwilioRestClient client = null)
        {
            var options = new ReadTrustProductsEntityAssignmentsOptions(pathTrustProductSid){ PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        
        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<TrustProductsEntityAssignmentsResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<TrustProductsEntityAssignmentsResource>.FromJson("results", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<TrustProductsEntityAssignmentsResource> NextPage(Page<TrustProductsEntityAssignmentsResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<TrustProductsEntityAssignmentsResource>.FromJson("results", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<TrustProductsEntityAssignmentsResource> PreviousPage(Page<TrustProductsEntityAssignmentsResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<TrustProductsEntityAssignmentsResource>.FromJson("results", response.Content);
        }



    
        /// <summary>
        /// Converts a JSON string into a TrustProductsEntityAssignmentsResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> TrustProductsEntityAssignmentsResource object represented by the provided JSON </returns>
        public static TrustProductsEntityAssignmentsResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<TrustProductsEntityAssignmentsResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

    
        ///<summary> The unique string that identifies the resource </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> The unique string that identifies the TrustProduct resource. </summary> 
        [JsonProperty("trust_product_sid")]
        public string TrustProductSid { get; private set; }

        ///<summary> The SID of the Account that created the resource </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The sid of an object bag </summary> 
        [JsonProperty("object_sid")]
        public string ObjectSid { get; private set; }

        ///<summary> The ISO 8601 date and time in GMT when the resource was created </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The absolute URL of the Identity resource </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }



        private TrustProductsEntityAssignmentsResource() {

        }
    }
}

