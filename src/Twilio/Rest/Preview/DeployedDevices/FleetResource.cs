/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Preview
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



namespace Twilio.Rest.Preview.DeployedDevices
{
    public class FleetResource : Resource
    {
    

        
        private static Request BuildCreateRequest(CreateFleetOptions options, ITwilioRestClient client)
        {
            
            string path = "/DeployedDevices/Fleets";



            return new Request(
                HttpMethod.Post,
                Rest.Domain.Preview,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Create a new Fleet for scoping of deployed devices within your account. </summary>
        /// <param name="options"> Create Fleet parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Fleet </returns>
        public static FleetResource Create(CreateFleetOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Create a new Fleet for scoping of deployed devices within your account. </summary>
        /// <param name="options"> Create Fleet parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Fleet </returns>
        public static async System.Threading.Tasks.Task<FleetResource> CreateAsync(CreateFleetOptions options,
        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> Create a new Fleet for scoping of deployed devices within your account. </summary>
        /// <param name="friendlyName"> Provides a human readable descriptive text for this Fleet, up to 256 characters long. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Fleet </returns>
        public static FleetResource Create(
                                          string friendlyName = null,
                                          ITwilioRestClient client = null)
        {
            var options = new CreateFleetOptions(){  FriendlyName = friendlyName };
            return Create(options, client);
        }

        #if !NET35
        /// <summary> Create a new Fleet for scoping of deployed devices within your account. </summary>
        /// <param name="friendlyName"> Provides a human readable descriptive text for this Fleet, up to 256 characters long. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Fleet </returns>
        public static async System.Threading.Tasks.Task<FleetResource> CreateAsync(
                                                                                  string friendlyName = null,
                                                                                  ITwilioRestClient client = null)
        {
        var options = new CreateFleetOptions(){  FriendlyName = friendlyName };
            return await CreateAsync(options, client);
        }
        #endif




        
        /// <summary> Delete a specific Fleet from your account, also destroys all nested resources: Devices, Deployments, Certificates, Keys. </summary>
        /// <param name="options"> Delete Fleet parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Fleet </returns>
        private static Request BuildDeleteRequest(DeleteFleetOptions options, ITwilioRestClient client)
        {
            
            string path = "/DeployedDevices/Fleets/{Sid}";

            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);


            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Preview,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Delete a specific Fleet from your account, also destroys all nested resources: Devices, Deployments, Certificates, Keys. </summary>
        /// <param name="options"> Delete Fleet parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Fleet </returns>
        public static bool Delete(DeleteFleetOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary> Delete a specific Fleet from your account, also destroys all nested resources: Devices, Deployments, Certificates, Keys. </summary>
        /// <param name="options"> Delete Fleet parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Fleet </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteFleetOptions options,
                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary> Delete a specific Fleet from your account, also destroys all nested resources: Devices, Deployments, Certificates, Keys. </summary>
        /// <param name="pathSid"> Provides a 34 character string that uniquely identifies the requested Fleet resource. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Fleet </returns>
        public static bool Delete(string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteFleetOptions(pathSid)     ;
            return Delete(options, client);
        }

        #if !NET35
        /// <summary> Delete a specific Fleet from your account, also destroys all nested resources: Devices, Deployments, Certificates, Keys. </summary>
        /// <param name="pathSid"> Provides a 34 character string that uniquely identifies the requested Fleet resource. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Fleet </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteFleetOptions(pathSid) ;
            return await DeleteAsync(options, client);
        }
        #endif
        
        private static Request BuildFetchRequest(FetchFleetOptions options, ITwilioRestClient client)
        {
            
            string path = "/DeployedDevices/Fleets/{Sid}";

            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);


            return new Request(
                HttpMethod.Get,
                Rest.Domain.Preview,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Fetch information about a specific Fleet in your account. </summary>
        /// <param name="options"> Fetch Fleet parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Fleet </returns>
        public static FleetResource Fetch(FetchFleetOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Fetch information about a specific Fleet in your account. </summary>
        /// <param name="options"> Fetch Fleet parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Fleet </returns>
        public static async System.Threading.Tasks.Task<FleetResource> FetchAsync(FetchFleetOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
        /// <summary> Fetch information about a specific Fleet in your account. </summary>
        /// <param name="pathSid"> Provides a 34 character string that uniquely identifies the requested Fleet resource. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Fleet </returns>
        public static FleetResource Fetch(
                                         string pathSid, 
                                         ITwilioRestClient client = null)
        {
            var options = new FetchFleetOptions(pathSid){  };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> Fetch information about a specific Fleet in your account. </summary>
        /// <param name="pathSid"> Provides a 34 character string that uniquely identifies the requested Fleet resource. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Fleet </returns>
        public static async System.Threading.Tasks.Task<FleetResource> FetchAsync(string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchFleetOptions(pathSid){  };
            return await FetchAsync(options, client);
        }
        #endif
        
        private static Request BuildReadRequest(ReadFleetOptions options, ITwilioRestClient client)
        {
            
            string path = "/DeployedDevices/Fleets";



            return new Request(
                HttpMethod.Get,
                Rest.Domain.Preview,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> Retrieve a list of all Fleets belonging to your account. </summary>
        /// <param name="options"> Read Fleet parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Fleet </returns>
        public static ResourceSet<FleetResource> Read(ReadFleetOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<FleetResource>.FromJson("fleets", response.Content);
            return new ResourceSet<FleetResource>(page, options, client);
        }

        #if !NET35
        /// <summary> Retrieve a list of all Fleets belonging to your account. </summary>
        /// <param name="options"> Read Fleet parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Fleet </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<FleetResource>> ReadAsync(ReadFleetOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<FleetResource>.FromJson("fleets", response.Content);
            return new ResourceSet<FleetResource>(page, options, client);
        }
        #endif
        /// <summary> Retrieve a list of all Fleets belonging to your account. </summary>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <param name="limit"> Record limit </param>
        /// <returns> A single instance of Fleet </returns>
        public static ResourceSet<FleetResource> Read(
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     ITwilioRestClient client = null)
        {
            var options = new ReadFleetOptions(){ PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary> Retrieve a list of all Fleets belonging to your account. </summary>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <param name="limit"> Record limit </param>
        /// <returns> Task that resolves to A single instance of Fleet </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<FleetResource>> ReadAsync(
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             ITwilioRestClient client = null)
        {
            var options = new ReadFleetOptions(){ PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        
        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<FleetResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<FleetResource>.FromJson("fleets", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<FleetResource> NextPage(Page<FleetResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<FleetResource>.FromJson("fleets", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<FleetResource> PreviousPage(Page<FleetResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<FleetResource>.FromJson("fleets", response.Content);
        }



        
        private static Request BuildUpdateRequest(UpdateFleetOptions options, ITwilioRestClient client)
        {
            
            string path = "/DeployedDevices/Fleets/{Sid}";

            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);


            return new Request(
                HttpMethod.Post,
                Rest.Domain.Preview,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Update the friendly name property of a specific Fleet in your account. </summary>
        /// <param name="options"> Update Fleet parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Fleet </returns>
        public static FleetResource Update(UpdateFleetOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        /// <summary> Update the friendly name property of a specific Fleet in your account. </summary>
        /// <param name="options"> Update Fleet parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Fleet </returns>
        #if !NET35
        public static async System.Threading.Tasks.Task<FleetResource> UpdateAsync(UpdateFleetOptions options,
                                                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> Update the friendly name property of a specific Fleet in your account. </summary>
        /// <param name="pathSid"> Provides a 34 character string that uniquely identifies the requested Fleet resource. </param>
        /// <param name="friendlyName"> Provides a human readable descriptive text for this Fleet, up to 256 characters long. </param>
        /// <param name="defaultDeploymentSid"> Provides a string identifier of a Deployment that is going to be used as a default one for this Fleet. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Fleet </returns>
        public static FleetResource Update(
                                          string pathSid,
                                          string friendlyName = null,
                                          string defaultDeploymentSid = null,
                                          ITwilioRestClient client = null)
        {
            var options = new UpdateFleetOptions(pathSid){ FriendlyName = friendlyName, DefaultDeploymentSid = defaultDeploymentSid };
            return Update(options, client);
        }

        #if !NET35
        /// <summary> Update the friendly name property of a specific Fleet in your account. </summary>
        /// <param name="pathSid"> Provides a 34 character string that uniquely identifies the requested Fleet resource. </param>
        /// <param name="friendlyName"> Provides a human readable descriptive text for this Fleet, up to 256 characters long. </param>
        /// <param name="defaultDeploymentSid"> Provides a string identifier of a Deployment that is going to be used as a default one for this Fleet. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Fleet </returns>
        public static async System.Threading.Tasks.Task<FleetResource> UpdateAsync(
                                                                              string pathSid,
                                                                              string friendlyName = null,
                                                                              string defaultDeploymentSid = null,
                                                                              ITwilioRestClient client = null)
        {
            var options = new UpdateFleetOptions(pathSid){ FriendlyName = friendlyName, DefaultDeploymentSid = defaultDeploymentSid };
            return await UpdateAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a FleetResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> FleetResource object represented by the provided JSON </returns>
        public static FleetResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<FleetResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

    
        ///<summary> A string that uniquely identifies this Fleet. </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> URL of this Fleet. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        ///<summary> A unique, addressable name of this Fleet. </summary> 
        [JsonProperty("unique_name")]
        public string UniqueName { get; private set; }

        ///<summary> A human readable description for this Fleet. </summary> 
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }

        ///<summary> The unique SID that identifies this Account. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The unique SID that identifies this Fleet's default Deployment. </summary> 
        [JsonProperty("default_deployment_sid")]
        public string DefaultDeploymentSid { get; private set; }

        ///<summary> The date this Fleet was created. </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The date this Fleet was updated. </summary> 
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }

        ///<summary> Nested resource URLs. </summary> 
        [JsonProperty("links")]
        public Dictionary<string, string> Links { get; private set; }



        private FleetResource() {

        }
    }
}

