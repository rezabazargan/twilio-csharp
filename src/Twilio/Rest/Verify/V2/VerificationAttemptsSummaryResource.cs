/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Verify
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


namespace Twilio.Rest.Verify.V2
{
    public class VerificationAttemptsSummaryResource : Resource
    {
    
        public sealed class ChannelsEnum : StringEnum
        {
            private ChannelsEnum(string value) : base(value) {}
            public ChannelsEnum() {}
            public static implicit operator ChannelsEnum(string value)
            {
                return new ChannelsEnum(value);
            }
            public static readonly ChannelsEnum Sms = new ChannelsEnum("sms");
            public static readonly ChannelsEnum Call = new ChannelsEnum("call");
            public static readonly ChannelsEnum Email = new ChannelsEnum("email");
            public static readonly ChannelsEnum Whatsapp = new ChannelsEnum("whatsapp");

        }

        
        private static Request BuildFetchRequest(FetchVerificationAttemptsSummaryOptions options, ITwilioRestClient client)
        {
            
            string path = "/v2/Attempts/Summary";



            return new Request(
                HttpMethod.Get,
                Rest.Domain.Verify,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Get a summary of how many attempts were made and how many were converted. </summary>
        /// <param name="options"> Fetch VerificationAttemptsSummary parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of VerificationAttemptsSummary </returns>
        public static VerificationAttemptsSummaryResource Fetch(FetchVerificationAttemptsSummaryOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Get a summary of how many attempts were made and how many were converted. </summary>
        /// <param name="options"> Fetch VerificationAttemptsSummary parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of VerificationAttemptsSummary </returns>
        public static async System.Threading.Tasks.Task<VerificationAttemptsSummaryResource> FetchAsync(FetchVerificationAttemptsSummaryOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
        /// <summary> Get a summary of how many attempts were made and how many were converted. </summary>
        /// <param name="verifyServiceSid"> Filter used to consider only Verification Attempts of the given verify service on the summary aggregation. </param>
        /// <param name="dateCreatedAfter"> Datetime filter used to consider only Verification Attempts created after this datetime on the summary aggregation. Given as GMT in RFC 2822 format. </param>
        /// <param name="dateCreatedBefore"> Datetime filter used to consider only Verification Attempts created before this datetime on the summary aggregation. Given as GMT in RFC 2822 format. </param>
        /// <param name="country"> Filter used to consider only Verification Attempts sent to the specified destination country on the summary aggregation. </param>
        /// <param name="channel"> Filter Verification Attempts considered on the summary aggregation by communication channel. Valid values are `SMS` and `CALL` </param>
        /// <param name="destinationPrefix"> Filter the Verification Attempts considered on the summary aggregation by Destination prefix. It is the prefix of a phone number in E.164 format. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of VerificationAttemptsSummary </returns>
        public static VerificationAttemptsSummaryResource Fetch(
                                         string verifyServiceSid = null, 
                                         DateTime? dateCreatedAfter = null, 
                                         DateTime? dateCreatedBefore = null, 
                                         string country = null, 
                                         VerificationAttemptsSummaryResource.ChannelsEnum channel = null, 
                                         string destinationPrefix = null, 
                                         ITwilioRestClient client = null)
        {
            var options = new FetchVerificationAttemptsSummaryOptions(){ VerifyServiceSid = verifyServiceSid,DateCreatedAfter = dateCreatedAfter,DateCreatedBefore = dateCreatedBefore,Country = country,Channel = channel,DestinationPrefix = destinationPrefix };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> Get a summary of how many attempts were made and how many were converted. </summary>
        /// <param name="verifyServiceSid"> Filter used to consider only Verification Attempts of the given verify service on the summary aggregation. </param>
        /// <param name="dateCreatedAfter"> Datetime filter used to consider only Verification Attempts created after this datetime on the summary aggregation. Given as GMT in RFC 2822 format. </param>
        /// <param name="dateCreatedBefore"> Datetime filter used to consider only Verification Attempts created before this datetime on the summary aggregation. Given as GMT in RFC 2822 format. </param>
        /// <param name="country"> Filter used to consider only Verification Attempts sent to the specified destination country on the summary aggregation. </param>
        /// <param name="channel"> Filter Verification Attempts considered on the summary aggregation by communication channel. Valid values are `SMS` and `CALL` </param>
        /// <param name="destinationPrefix"> Filter the Verification Attempts considered on the summary aggregation by Destination prefix. It is the prefix of a phone number in E.164 format. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of VerificationAttemptsSummary </returns>
        public static async System.Threading.Tasks.Task<VerificationAttemptsSummaryResource> FetchAsync(string verifyServiceSid = null, DateTime? dateCreatedAfter = null, DateTime? dateCreatedBefore = null, string country = null, VerificationAttemptsSummaryResource.ChannelsEnum channel = null, string destinationPrefix = null, ITwilioRestClient client = null)
        {
            var options = new FetchVerificationAttemptsSummaryOptions(){ VerifyServiceSid = verifyServiceSid,DateCreatedAfter = dateCreatedAfter,DateCreatedBefore = dateCreatedBefore,Country = country,Channel = channel,DestinationPrefix = destinationPrefix };
            return await FetchAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a VerificationAttemptsSummaryResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> VerificationAttemptsSummaryResource object represented by the provided JSON </returns>
        public static VerificationAttemptsSummaryResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<VerificationAttemptsSummaryResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

    
        ///<summary> Total of attempts made. </summary> 
        [JsonProperty("total_attempts")]
        public int? TotalAttempts { get; private set; }

        ///<summary> Total of attempts confirmed by the end user. </summary> 
        [JsonProperty("total_converted")]
        public int? TotalConverted { get; private set; }

        ///<summary> Total of attempts made that were not confirmed by the end user. </summary> 
        [JsonProperty("total_unconverted")]
        public int? TotalUnconverted { get; private set; }

        ///<summary> Percentage of the confirmed messages over the total. </summary> 
        [JsonProperty("conversion_rate_percentage")]
        public decimal? ConversionRatePercentage { get; private set; }

        ///<summary> The url </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }



        private VerificationAttemptsSummaryResource() {

        }
    }
}

