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



namespace Twilio.Rest.Trusthub.V1.CustomerProfiles
{
    public class CustomerProfilesEntityAssignmentsResource : Resource
    {
    

        
        private static Request BuildCreateRequest(CreateCustomerProfilesEntityAssignmentsOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/CustomerProfiles/{CustomerProfileSid}/EntityAssignments";

            string PathCustomerProfileSid = options.PathCustomerProfileSid;
            path = path.Replace("{"+"CustomerProfileSid"+"}", PathCustomerProfileSid);


            return new Request(
                HttpMethod.Post,
                Rest.Domain.Trusthub,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Create a new Assigned Item. </summary>
        /// <param name="options"> Create CustomerProfilesEntityAssignments parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of CustomerProfilesEntityAssignments </returns>
        public static CustomerProfilesEntityAssignmentsResource Create(CreateCustomerProfilesEntityAssignmentsOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Create a new Assigned Item. </summary>
        /// <param name="options"> Create CustomerProfilesEntityAssignments parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of CustomerProfilesEntityAssignments </returns>
        public static async System.Threading.Tasks.Task<CustomerProfilesEntityAssignmentsResource> CreateAsync(CreateCustomerProfilesEntityAssignmentsOptions options,
        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> Create a new Assigned Item. </summary>
        /// <param name="pathCustomerProfileSid"> The unique string that we created to identify the CustomerProfile resource. </param>
        /// <param name="objectSid"> The SID of an object bag that holds information of the different items. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of CustomerProfilesEntityAssignments </returns>
        public static CustomerProfilesEntityAssignmentsResource Create(
                                          string pathCustomerProfileSid,
                                          string objectSid,
                                          ITwilioRestClient client = null)
        {
            var options = new CreateCustomerProfilesEntityAssignmentsOptions(pathCustomerProfileSid, objectSid){  };
            return Create(options, client);
        }

        #if !NET35
        /// <summary> Create a new Assigned Item. </summary>
        /// <param name="pathCustomerProfileSid"> The unique string that we created to identify the CustomerProfile resource. </param>
        /// <param name="objectSid"> The SID of an object bag that holds information of the different items. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of CustomerProfilesEntityAssignments </returns>
        public static async System.Threading.Tasks.Task<CustomerProfilesEntityAssignmentsResource> CreateAsync(
                                                                                  string pathCustomerProfileSid,
                                                                                  string objectSid,
                                                                                  ITwilioRestClient client = null)
        {
        var options = new CreateCustomerProfilesEntityAssignmentsOptions(pathCustomerProfileSid, objectSid){  };
            return await CreateAsync(options, client);
        }
        #endif




        
        /// <summary> Remove an Assignment Item Instance. </summary>
        /// <param name="options"> Delete CustomerProfilesEntityAssignments parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of CustomerProfilesEntityAssignments </returns>
        private static Request BuildDeleteRequest(DeleteCustomerProfilesEntityAssignmentsOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/CustomerProfiles/{CustomerProfileSid}/EntityAssignments/{Sid}";

            string PathCustomerProfileSid = options.PathCustomerProfileSid;
            path = path.Replace("{"+"CustomerProfileSid"+"}", PathCustomerProfileSid);
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
        /// <param name="options"> Delete CustomerProfilesEntityAssignments parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of CustomerProfilesEntityAssignments </returns>
        public static bool Delete(DeleteCustomerProfilesEntityAssignmentsOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary> Remove an Assignment Item Instance. </summary>
        /// <param name="options"> Delete CustomerProfilesEntityAssignments parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of CustomerProfilesEntityAssignments </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteCustomerProfilesEntityAssignmentsOptions options,
                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary> Remove an Assignment Item Instance. </summary>
        /// <param name="pathCustomerProfileSid"> The unique string that we created to identify the CustomerProfile resource. </param>
        /// <param name="pathSid"> The unique string that we created to identify the Identity resource. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of CustomerProfilesEntityAssignments </returns>
        public static bool Delete(string pathCustomerProfileSid, string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteCustomerProfilesEntityAssignmentsOptions(pathCustomerProfileSid, pathSid)        ;
            return Delete(options, client);
        }

        #if !NET35
        /// <summary> Remove an Assignment Item Instance. </summary>
        /// <param name="pathCustomerProfileSid"> The unique string that we created to identify the CustomerProfile resource. </param>
        /// <param name="pathSid"> The unique string that we created to identify the Identity resource. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of CustomerProfilesEntityAssignments </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathCustomerProfileSid, string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteCustomerProfilesEntityAssignmentsOptions(pathCustomerProfileSid, pathSid) ;
            return await DeleteAsync(options, client);
        }
        #endif
        
        private static Request BuildFetchRequest(FetchCustomerProfilesEntityAssignmentsOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/CustomerProfiles/{CustomerProfileSid}/EntityAssignments/{Sid}";

            string PathCustomerProfileSid = options.PathCustomerProfileSid;
            path = path.Replace("{"+"CustomerProfileSid"+"}", PathCustomerProfileSid);
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
        /// <param name="options"> Fetch CustomerProfilesEntityAssignments parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of CustomerProfilesEntityAssignments </returns>
        public static CustomerProfilesEntityAssignmentsResource Fetch(FetchCustomerProfilesEntityAssignmentsOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Fetch specific Assigned Item Instance. </summary>
        /// <param name="options"> Fetch CustomerProfilesEntityAssignments parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of CustomerProfilesEntityAssignments </returns>
        public static async System.Threading.Tasks.Task<CustomerProfilesEntityAssignmentsResource> FetchAsync(FetchCustomerProfilesEntityAssignmentsOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
        /// <summary> Fetch specific Assigned Item Instance. </summary>
        /// <param name="pathCustomerProfileSid"> The unique string that we created to identify the CustomerProfile resource. </param>
        /// <param name="pathSid"> The unique string that we created to identify the Identity resource. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of CustomerProfilesEntityAssignments </returns>
        public static CustomerProfilesEntityAssignmentsResource Fetch(
                                         string pathCustomerProfileSid, 
                                         string pathSid, 
                                         ITwilioRestClient client = null)
        {
            var options = new FetchCustomerProfilesEntityAssignmentsOptions(pathCustomerProfileSid, pathSid){  };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> Fetch specific Assigned Item Instance. </summary>
        /// <param name="pathCustomerProfileSid"> The unique string that we created to identify the CustomerProfile resource. </param>
        /// <param name="pathSid"> The unique string that we created to identify the Identity resource. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of CustomerProfilesEntityAssignments </returns>
        public static async System.Threading.Tasks.Task<CustomerProfilesEntityAssignmentsResource> FetchAsync(string pathCustomerProfileSid, string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchCustomerProfilesEntityAssignmentsOptions(pathCustomerProfileSid, pathSid){  };
            return await FetchAsync(options, client);
        }
        #endif
        
        private static Request BuildReadRequest(ReadCustomerProfilesEntityAssignmentsOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/CustomerProfiles/{CustomerProfileSid}/EntityAssignments";

            string PathCustomerProfileSid = options.PathCustomerProfileSid;
            path = path.Replace("{"+"CustomerProfileSid"+"}", PathCustomerProfileSid);


            return new Request(
                HttpMethod.Get,
                Rest.Domain.Trusthub,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> Retrieve a list of all Assigned Items for an account. </summary>
        /// <param name="options"> Read CustomerProfilesEntityAssignments parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of CustomerProfilesEntityAssignments </returns>
        public static ResourceSet<CustomerProfilesEntityAssignmentsResource> Read(ReadCustomerProfilesEntityAssignmentsOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<CustomerProfilesEntityAssignmentsResource>.FromJson("results", response.Content);
            return new ResourceSet<CustomerProfilesEntityAssignmentsResource>(page, options, client);
        }

        #if !NET35
        /// <summary> Retrieve a list of all Assigned Items for an account. </summary>
        /// <param name="options"> Read CustomerProfilesEntityAssignments parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of CustomerProfilesEntityAssignments </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<CustomerProfilesEntityAssignmentsResource>> ReadAsync(ReadCustomerProfilesEntityAssignmentsOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<CustomerProfilesEntityAssignmentsResource>.FromJson("results", response.Content);
            return new ResourceSet<CustomerProfilesEntityAssignmentsResource>(page, options, client);
        }
        #endif
        /// <summary> Retrieve a list of all Assigned Items for an account. </summary>
        /// <param name="pathCustomerProfileSid"> The unique string that we created to identify the CustomerProfile resource. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <param name="limit"> Record limit </param>
        /// <returns> A single instance of CustomerProfilesEntityAssignments </returns>
        public static ResourceSet<CustomerProfilesEntityAssignmentsResource> Read(
                                                     string pathCustomerProfileSid,
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     ITwilioRestClient client = null)
        {
            var options = new ReadCustomerProfilesEntityAssignmentsOptions(pathCustomerProfileSid){ PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary> Retrieve a list of all Assigned Items for an account. </summary>
        /// <param name="pathCustomerProfileSid"> The unique string that we created to identify the CustomerProfile resource. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <param name="limit"> Record limit </param>
        /// <returns> Task that resolves to A single instance of CustomerProfilesEntityAssignments </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<CustomerProfilesEntityAssignmentsResource>> ReadAsync(
                                                                                             string pathCustomerProfileSid,
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             ITwilioRestClient client = null)
        {
            var options = new ReadCustomerProfilesEntityAssignmentsOptions(pathCustomerProfileSid){ PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        
        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<CustomerProfilesEntityAssignmentsResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<CustomerProfilesEntityAssignmentsResource>.FromJson("results", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<CustomerProfilesEntityAssignmentsResource> NextPage(Page<CustomerProfilesEntityAssignmentsResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<CustomerProfilesEntityAssignmentsResource>.FromJson("results", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<CustomerProfilesEntityAssignmentsResource> PreviousPage(Page<CustomerProfilesEntityAssignmentsResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<CustomerProfilesEntityAssignmentsResource>.FromJson("results", response.Content);
        }



    
        /// <summary>
        /// Converts a JSON string into a CustomerProfilesEntityAssignmentsResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> CustomerProfilesEntityAssignmentsResource object represented by the provided JSON </returns>
        public static CustomerProfilesEntityAssignmentsResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<CustomerProfilesEntityAssignmentsResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

    
        ///<summary> The unique string that identifies the resource </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> The unique string that identifies the CustomerProfile resource. </summary> 
        [JsonProperty("customer_profile_sid")]
        public string CustomerProfileSid { get; private set; }

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



        private CustomerProfilesEntityAssignmentsResource() {

        }
    }
}

