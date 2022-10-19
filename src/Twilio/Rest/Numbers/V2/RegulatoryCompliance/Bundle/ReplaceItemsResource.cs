/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Numbers
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


namespace Twilio.Rest.Numbers.V2.RegulatoryCompliance.Bundle
{
    public class ReplaceItemsResource : Resource
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
            public static readonly StatusEnum Draft = new StatusEnum("draft");
            public static readonly StatusEnum PendingReview = new StatusEnum("pending-review");
            public static readonly StatusEnum InReview = new StatusEnum("in-review");
            public static readonly StatusEnum TwilioRejected = new StatusEnum("twilio-rejected");
            public static readonly StatusEnum TwilioApproved = new StatusEnum("twilio-approved");
            public static readonly StatusEnum ProvisionallyApproved = new StatusEnum("provisionally-approved");

        }

        
        private static Request BuildCreateRequest(CreateReplaceItemsOptions options, ITwilioRestClient client)
        {
            
            string path = "/v2/RegulatoryCompliance/Bundles/{BundleSid}/ReplaceItems";

            string PathBundleSid = options.PathBundleSid;
            path = path.Replace("{"+"BundleSid"+"}", PathBundleSid);


            return new Request(
                HttpMethod.Post,
                Rest.Domain.Numbers,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Replaces all bundle items in the target bundle (specified in the path) with all the bundle items of the source bundle (specified by the from_bundle_sid body param) </summary>
        /// <param name="options"> Create ReplaceItems parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of ReplaceItems </returns>
        public static ReplaceItemsResource Create(CreateReplaceItemsOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Replaces all bundle items in the target bundle (specified in the path) with all the bundle items of the source bundle (specified by the from_bundle_sid body param) </summary>
        /// <param name="options"> Create ReplaceItems parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of ReplaceItems </returns>
        public static async System.Threading.Tasks.Task<ReplaceItemsResource> CreateAsync(CreateReplaceItemsOptions options,
        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> Replaces all bundle items in the target bundle (specified in the path) with all the bundle items of the source bundle (specified by the from_bundle_sid body param) </summary>
        /// <param name="pathBundleSid"> The unique string that identifies the Bundle where the item assignments are going to be replaced. </param>
        /// <param name="fromBundleSid"> The source bundle sid to copy the item assignments from. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of ReplaceItems </returns>
        public static ReplaceItemsResource Create(
                                          string pathBundleSid,
                                          string fromBundleSid,
                                          ITwilioRestClient client = null)
        {
            var options = new CreateReplaceItemsOptions(pathBundleSid, fromBundleSid){  };
            return Create(options, client);
        }

        #if !NET35
        /// <summary> Replaces all bundle items in the target bundle (specified in the path) with all the bundle items of the source bundle (specified by the from_bundle_sid body param) </summary>
        /// <param name="pathBundleSid"> The unique string that identifies the Bundle where the item assignments are going to be replaced. </param>
        /// <param name="fromBundleSid"> The source bundle sid to copy the item assignments from. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of ReplaceItems </returns>
        public static async System.Threading.Tasks.Task<ReplaceItemsResource> CreateAsync(
                                                                                  string pathBundleSid,
                                                                                  string fromBundleSid,
                                                                                  ITwilioRestClient client = null)
        {
        var options = new CreateReplaceItemsOptions(pathBundleSid, fromBundleSid){  };
            return await CreateAsync(options, client);
        }
        #endif




    
        /// <summary>
        /// Converts a JSON string into a ReplaceItemsResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> ReplaceItemsResource object represented by the provided JSON </returns>
        public static ReplaceItemsResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<ReplaceItemsResource>(json);
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

        ///<summary> The unique string of a regulation </summary> 
        [JsonProperty("regulation_sid")]
        public string RegulationSid { get; private set; }

        ///<summary> The string that you assigned to describe the resource </summary> 
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }

        
        [JsonProperty("status")]
        public ReplaceItemsResource.StatusEnum Status { get; private set; }

        ///<summary> The ISO 8601 date and time in GMT when the resource will be valid until </summary> 
        [JsonProperty("valid_until")]
        public DateTime? ValidUntil { get; private set; }

        ///<summary> The email address </summary> 
        [JsonProperty("email")]
        public string Email { get; private set; }

        ///<summary> The URL we call to inform your application of status changes </summary> 
        [JsonProperty("status_callback")]
        public Uri StatusCallback { get; private set; }

        ///<summary> The ISO 8601 date and time in GMT when the resource was created </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The ISO 8601 date and time in GMT when the resource was last updated </summary> 
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }



        private ReplaceItemsResource() {

        }
    }
}

