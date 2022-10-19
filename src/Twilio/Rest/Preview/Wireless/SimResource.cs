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



namespace Twilio.Rest.Preview.Wireless
{
    public class SimResource : Resource
    {
    

        
        private static Request BuildFetchRequest(FetchSimOptions options, ITwilioRestClient client)
        {
            
            string path = "/wireless/Sims/{Sid}";

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

        /// <summary> fetch </summary>
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
        /// <summary> fetch </summary>
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
        /// <summary> fetch </summary>
        /// <param name="pathSid">  </param>
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
        /// <summary> fetch </summary>
        /// <param name="pathSid">  </param>
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
            
            string path = "/wireless/Sims";



            return new Request(
                HttpMethod.Get,
                Rest.Domain.Preview,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> read </summary>
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
        /// <summary> read </summary>
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
        /// <summary> read </summary>
        /// <param name="status">  </param>
        /// <param name="iccid">  </param>
        /// <param name="ratePlan">  </param>
        /// <param name="eId">  </param>
        /// <param name="simRegistrationCode">  </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <param name="limit"> Record limit </param>
        /// <returns> A single instance of Sim </returns>
        public static ResourceSet<SimResource> Read(
                                                     string status = null,
                                                     string iccid = null,
                                                     string ratePlan = null,
                                                     string eId = null,
                                                     string simRegistrationCode = null,
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     ITwilioRestClient client = null)
        {
            var options = new ReadSimOptions(){ Status = status, Iccid = iccid, RatePlan = ratePlan, EId = eId, SimRegistrationCode = simRegistrationCode, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary> read </summary>
        /// <param name="status">  </param>
        /// <param name="iccid">  </param>
        /// <param name="ratePlan">  </param>
        /// <param name="eId">  </param>
        /// <param name="simRegistrationCode">  </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <param name="limit"> Record limit </param>
        /// <returns> Task that resolves to A single instance of Sim </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<SimResource>> ReadAsync(
                                                                                             string status = null,
                                                                                             string iccid = null,
                                                                                             string ratePlan = null,
                                                                                             string eId = null,
                                                                                             string simRegistrationCode = null,
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             ITwilioRestClient client = null)
        {
            var options = new ReadSimOptions(){ Status = status, Iccid = iccid, RatePlan = ratePlan, EId = eId, SimRegistrationCode = simRegistrationCode, PageSize = pageSize, Limit = limit};
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
            
            string path = "/wireless/Sims/{Sid}";

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

        /// <summary> update </summary>
        /// <param name="options"> Update Sim parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Sim </returns>
        public static SimResource Update(UpdateSimOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        /// <summary> update </summary>
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

        /// <summary> update </summary>
        /// <param name="pathSid">  </param>
        /// <param name="uniqueName">  </param>
        /// <param name="callbackMethod">  </param>
        /// <param name="callbackUrl">  </param>
        /// <param name="friendlyName">  </param>
        /// <param name="ratePlan">  </param>
        /// <param name="status">  </param>
        /// <param name="commandsCallbackMethod">  </param>
        /// <param name="commandsCallbackUrl">  </param>
        /// <param name="smsFallbackMethod">  </param>
        /// <param name="smsFallbackUrl">  </param>
        /// <param name="smsMethod">  </param>
        /// <param name="smsUrl">  </param>
        /// <param name="voiceFallbackMethod">  </param>
        /// <param name="voiceFallbackUrl">  </param>
        /// <param name="voiceMethod">  </param>
        /// <param name="voiceUrl">  </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Sim </returns>
        public static SimResource Update(
                                          string pathSid,
                                          string uniqueName = null,
                                          string callbackMethod = null,
                                          Uri callbackUrl = null,
                                          string friendlyName = null,
                                          string ratePlan = null,
                                          string status = null,
                                          Twilio.Http.HttpMethod commandsCallbackMethod = null,
                                          Uri commandsCallbackUrl = null,
                                          Twilio.Http.HttpMethod smsFallbackMethod = null,
                                          Uri smsFallbackUrl = null,
                                          Twilio.Http.HttpMethod smsMethod = null,
                                          Uri smsUrl = null,
                                          Twilio.Http.HttpMethod voiceFallbackMethod = null,
                                          Uri voiceFallbackUrl = null,
                                          Twilio.Http.HttpMethod voiceMethod = null,
                                          Uri voiceUrl = null,
                                          ITwilioRestClient client = null)
        {
            var options = new UpdateSimOptions(pathSid){ UniqueName = uniqueName, CallbackMethod = callbackMethod, CallbackUrl = callbackUrl, FriendlyName = friendlyName, RatePlan = ratePlan, Status = status, CommandsCallbackMethod = commandsCallbackMethod, CommandsCallbackUrl = commandsCallbackUrl, SmsFallbackMethod = smsFallbackMethod, SmsFallbackUrl = smsFallbackUrl, SmsMethod = smsMethod, SmsUrl = smsUrl, VoiceFallbackMethod = voiceFallbackMethod, VoiceFallbackUrl = voiceFallbackUrl, VoiceMethod = voiceMethod, VoiceUrl = voiceUrl };
            return Update(options, client);
        }

        #if !NET35
        /// <summary> update </summary>
        /// <param name="pathSid">  </param>
        /// <param name="uniqueName">  </param>
        /// <param name="callbackMethod">  </param>
        /// <param name="callbackUrl">  </param>
        /// <param name="friendlyName">  </param>
        /// <param name="ratePlan">  </param>
        /// <param name="status">  </param>
        /// <param name="commandsCallbackMethod">  </param>
        /// <param name="commandsCallbackUrl">  </param>
        /// <param name="smsFallbackMethod">  </param>
        /// <param name="smsFallbackUrl">  </param>
        /// <param name="smsMethod">  </param>
        /// <param name="smsUrl">  </param>
        /// <param name="voiceFallbackMethod">  </param>
        /// <param name="voiceFallbackUrl">  </param>
        /// <param name="voiceMethod">  </param>
        /// <param name="voiceUrl">  </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Sim </returns>
        public static async System.Threading.Tasks.Task<SimResource> UpdateAsync(
                                                                              string pathSid,
                                                                              string uniqueName = null,
                                                                              string callbackMethod = null,
                                                                              Uri callbackUrl = null,
                                                                              string friendlyName = null,
                                                                              string ratePlan = null,
                                                                              string status = null,
                                                                              Twilio.Http.HttpMethod commandsCallbackMethod = null,
                                                                              Uri commandsCallbackUrl = null,
                                                                              Twilio.Http.HttpMethod smsFallbackMethod = null,
                                                                              Uri smsFallbackUrl = null,
                                                                              Twilio.Http.HttpMethod smsMethod = null,
                                                                              Uri smsUrl = null,
                                                                              Twilio.Http.HttpMethod voiceFallbackMethod = null,
                                                                              Uri voiceFallbackUrl = null,
                                                                              Twilio.Http.HttpMethod voiceMethod = null,
                                                                              Uri voiceUrl = null,
                                                                              ITwilioRestClient client = null)
        {
            var options = new UpdateSimOptions(pathSid){ UniqueName = uniqueName, CallbackMethod = callbackMethod, CallbackUrl = callbackUrl, FriendlyName = friendlyName, RatePlan = ratePlan, Status = status, CommandsCallbackMethod = commandsCallbackMethod, CommandsCallbackUrl = commandsCallbackUrl, SmsFallbackMethod = smsFallbackMethod, SmsFallbackUrl = smsFallbackUrl, SmsMethod = smsMethod, SmsUrl = smsUrl, VoiceFallbackMethod = voiceFallbackMethod, VoiceFallbackUrl = voiceFallbackUrl, VoiceMethod = voiceMethod, VoiceUrl = voiceUrl };
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

    
        ///<summary> The sid </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> The unique_name </summary> 
        [JsonProperty("unique_name")]
        public string UniqueName { get; private set; }

        ///<summary> The account_sid </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The rate_plan_sid </summary> 
        [JsonProperty("rate_plan_sid")]
        public string RatePlanSid { get; private set; }

        ///<summary> The friendly_name </summary> 
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }

        ///<summary> The iccid </summary> 
        [JsonProperty("iccid")]
        public string Iccid { get; private set; }

        ///<summary> The e_id </summary> 
        [JsonProperty("e_id")]
        public string EId { get; private set; }

        ///<summary> The status </summary> 
        [JsonProperty("status")]
        public string Status { get; private set; }

        ///<summary> The commands_callback_url </summary> 
        [JsonProperty("commands_callback_url")]
        public Uri CommandsCallbackUrl { get; private set; }

        ///<summary> The commands_callback_method </summary> 
        [JsonProperty("commands_callback_method")]
        public string CommandsCallbackMethod { get; private set; }

        
        [JsonProperty("sms_fallback_method")]
        public Twilio.Http.HttpMethod SmsFallbackMethod { get; private set; }

        ///<summary> The sms_fallback_url </summary> 
        [JsonProperty("sms_fallback_url")]
        public Uri SmsFallbackUrl { get; private set; }

        
        [JsonProperty("sms_method")]
        public Twilio.Http.HttpMethod SmsMethod { get; private set; }

        ///<summary> The sms_url </summary> 
        [JsonProperty("sms_url")]
        public Uri SmsUrl { get; private set; }

        
        [JsonProperty("voice_fallback_method")]
        public Twilio.Http.HttpMethod VoiceFallbackMethod { get; private set; }

        ///<summary> The voice_fallback_url </summary> 
        [JsonProperty("voice_fallback_url")]
        public Uri VoiceFallbackUrl { get; private set; }

        
        [JsonProperty("voice_method")]
        public Twilio.Http.HttpMethod VoiceMethod { get; private set; }

        ///<summary> The voice_url </summary> 
        [JsonProperty("voice_url")]
        public Uri VoiceUrl { get; private set; }

        ///<summary> The date_created </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The date_updated </summary> 
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }

        ///<summary> The url </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        ///<summary> The links </summary> 
        [JsonProperty("links")]
        public Dictionary<string, string> Links { get; private set; }



        private SimResource() {

        }
    }
}

