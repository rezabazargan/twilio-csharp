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



namespace Twilio.Rest.Preview.Wireless.Sim
{
    public class UsageResource : Resource
    {
    

        
        private static Request BuildFetchRequest(FetchUsageOptions options, ITwilioRestClient client)
        {
            
            string path = "/wireless/Sims/{SimSid}/Usage";

            string PathSimSid = options.PathSimSid;
            path = path.Replace("{"+"SimSid"+"}", PathSimSid);


            return new Request(
                HttpMethod.Get,
                Rest.Domain.Preview,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> fetch </summary>
        /// <param name="options"> Fetch Usage parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Usage </returns>
        public static UsageResource Fetch(FetchUsageOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> fetch </summary>
        /// <param name="options"> Fetch Usage parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Usage </returns>
        public static async System.Threading.Tasks.Task<UsageResource> FetchAsync(FetchUsageOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
        /// <summary> fetch </summary>
        /// <param name="pathSimSid">  </param>
        /// <param name="end">  </param>
        /// <param name="start">  </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Usage </returns>
        public static UsageResource Fetch(
                                         string pathSimSid, 
                                         string end = null, 
                                         string start = null, 
                                         ITwilioRestClient client = null)
        {
            var options = new FetchUsageOptions(pathSimSid){ End = end,Start = start };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> fetch </summary>
        /// <param name="pathSimSid">  </param>
        /// <param name="end">  </param>
        /// <param name="start">  </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Usage </returns>
        public static async System.Threading.Tasks.Task<UsageResource> FetchAsync(string pathSimSid, string end = null, string start = null, ITwilioRestClient client = null)
        {
            var options = new FetchUsageOptions(pathSimSid){ End = end,Start = start };
            return await FetchAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a UsageResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> UsageResource object represented by the provided JSON </returns>
        public static UsageResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<UsageResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

    
        ///<summary> The sim_sid </summary> 
        [JsonProperty("sim_sid")]
        public string SimSid { get; private set; }

        ///<summary> The sim_unique_name </summary> 
        [JsonProperty("sim_unique_name")]
        public string SimUniqueName { get; private set; }

        ///<summary> The account_sid </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The period </summary> 
        [JsonProperty("period")]
        public object Period { get; private set; }

        ///<summary> The commands_usage </summary> 
        [JsonProperty("commands_usage")]
        public object CommandsUsage { get; private set; }

        ///<summary> The commands_costs </summary> 
        [JsonProperty("commands_costs")]
        public object CommandsCosts { get; private set; }

        ///<summary> The data_usage </summary> 
        [JsonProperty("data_usage")]
        public object DataUsage { get; private set; }

        ///<summary> The data_costs </summary> 
        [JsonProperty("data_costs")]
        public object DataCosts { get; private set; }

        ///<summary> The url </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }



        private UsageResource() {

        }
    }
}

