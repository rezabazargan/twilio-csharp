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



namespace Twilio.Rest.Preview.TrustedComms
{
    public class BrandsInformationResource : Resource
    {
    

        
        private static Request BuildFetchRequest(FetchBrandsInformationOptions options, ITwilioRestClient client)
        {
            
            string path = "/TrustedComms/BrandsInformation";



            return new Request(
                HttpMethod.Get,
                Rest.Domain.Preview,
                path,
                queryParams: options.GetParams(),
                headerParams: options.GetHeaderParams()
            );
        }

        /// <summary> Retrieve the newest available BrandInformation </summary>
        /// <param name="options"> Fetch BrandsInformation parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of BrandsInformation </returns>
        public static BrandsInformationResource Fetch(FetchBrandsInformationOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Retrieve the newest available BrandInformation </summary>
        /// <param name="options"> Fetch BrandsInformation parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of BrandsInformation </returns>
        public static async System.Threading.Tasks.Task<BrandsInformationResource> FetchAsync(FetchBrandsInformationOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
        /// <summary> Retrieve the newest available BrandInformation </summary>
        /// <param name="ifNoneMatch"> Standard `If-None-Match` HTTP header. For more information visit: https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/If-None-Match. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of BrandsInformation </returns>
        public static BrandsInformationResource Fetch(
                                         string ifNoneMatch = null, 
                                         ITwilioRestClient client = null)
        {
            var options = new FetchBrandsInformationOptions(){ IfNoneMatch = ifNoneMatch };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> Retrieve the newest available BrandInformation </summary>
        /// <param name="ifNoneMatch"> Standard `If-None-Match` HTTP header. For more information visit: https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/If-None-Match. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of BrandsInformation </returns>
        public static async System.Threading.Tasks.Task<BrandsInformationResource> FetchAsync(string ifNoneMatch = null, ITwilioRestClient client = null)
        {
            var options = new FetchBrandsInformationOptions(){ IfNoneMatch = ifNoneMatch };
            return await FetchAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a BrandsInformationResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> BrandsInformationResource object represented by the provided JSON </returns>
        public static BrandsInformationResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<BrandsInformationResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

    
        ///<summary> Creation time of the information retrieved </summary> 
        [JsonProperty("update_time")]
        public DateTime? UpdateTime { get; private set; }

        ///<summary> The URL to the brands information </summary> 
        [JsonProperty("file_link")]
        public Uri FileLink { get; private set; }

        ///<summary> How long will be the `file_link` valid </summary> 
        [JsonProperty("file_link_ttl_in_seconds")]
        public string FileLinkTtlInSeconds { get; private set; }

        ///<summary> The URL of this resource </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }



        private BrandsInformationResource() {

        }
    }
}

