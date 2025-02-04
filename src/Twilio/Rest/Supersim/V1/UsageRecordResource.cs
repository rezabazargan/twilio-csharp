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
    public class UsageRecordResource : Resource
    {
    
        public sealed class GroupEnum : StringEnum
        {
            private GroupEnum(string value) : base(value) {}
            public GroupEnum() {}
            public static implicit operator GroupEnum(string value)
            {
                return new GroupEnum(value);
            }
            public static readonly GroupEnum Sim = new GroupEnum("sim");
            public static readonly GroupEnum Fleet = new GroupEnum("fleet");
            public static readonly GroupEnum Network = new GroupEnum("network");
            public static readonly GroupEnum Isocountry = new GroupEnum("isoCountry");

        }
        public sealed class GranularityEnum : StringEnum
        {
            private GranularityEnum(string value) : base(value) {}
            public GranularityEnum() {}
            public static implicit operator GranularityEnum(string value)
            {
                return new GranularityEnum(value);
            }
            public static readonly GranularityEnum Hour = new GranularityEnum("hour");
            public static readonly GranularityEnum Day = new GranularityEnum("day");
            public static readonly GranularityEnum All = new GranularityEnum("all");

        }

        
        private static Request BuildReadRequest(ReadUsageRecordOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/UsageRecords";


            return new Request(
                HttpMethod.Get,
                Rest.Domain.Supersim,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> List UsageRecords </summary>
        /// <param name="options"> Read UsageRecord parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of UsageRecord </returns>
        public static ResourceSet<UsageRecordResource> Read(ReadUsageRecordOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<UsageRecordResource>.FromJson("usage_records", response.Content);
            return new ResourceSet<UsageRecordResource>(page, options, client);
        }

        #if !NET35
        /// <summary> List UsageRecords </summary>
        /// <param name="options"> Read UsageRecord parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of UsageRecord </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<UsageRecordResource>> ReadAsync(ReadUsageRecordOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<UsageRecordResource>.FromJson("usage_records", response.Content);
            return new ResourceSet<UsageRecordResource>(page, options, client);
        }
        #endif
        /// <summary> List UsageRecords </summary>
        /// <param name="sim"> SID or unique name of a Sim resource. Only show UsageRecords representing usage incurred by this Super SIM. </param>
        /// <param name="fleet"> SID or unique name of a Fleet resource. Only show UsageRecords representing usage for Super SIMs belonging to this Fleet resource at the time the usage occurred. </param>
        /// <param name="network"> SID of a Network resource. Only show UsageRecords representing usage on this network. </param>
        /// <param name="isoCountry"> Alpha-2 ISO Country Code. Only show UsageRecords representing usage in this country. </param>
        /// <param name="group"> Dimension over which to aggregate usage records. Can be: `sim`, `fleet`, `network`, `isoCountry`. Default is to not aggregate across any of these dimensions, UsageRecords will be aggregated into the time buckets described by the `Granularity` parameter. </param>
        /// <param name="granularity"> Time-based grouping that UsageRecords should be aggregated by. Can be: `hour`, `day`, or `all`. Default is `all`. `all` returns one UsageRecord that describes the usage for the entire period. </param>
        /// <param name="startTime"> Only include usage that occurred at or after this time, specified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. Default is one month before the `end_time`. </param>
        /// <param name="endTime"> Only include usage that occurred before this time (exclusive), specified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. Default is the current time. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <param name="limit"> Record limit </param>
        /// <returns> A single instance of UsageRecord </returns>
        public static ResourceSet<UsageRecordResource> Read(
                                                     string sim = null,
                                                     string fleet = null,
                                                     string network = null,
                                                     string isoCountry = null,
                                                     UsageRecordResource.GroupEnum group = null,
                                                     UsageRecordResource.GranularityEnum granularity = null,
                                                     DateTime? startTime = null,
                                                     DateTime? endTime = null,
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     ITwilioRestClient client = null)
        {
            var options = new ReadUsageRecordOptions(){ Sim = sim, Fleet = fleet, Network = network, IsoCountry = isoCountry, Group = group, Granularity = granularity, StartTime = startTime, EndTime = endTime, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary> List UsageRecords </summary>
        /// <param name="sim"> SID or unique name of a Sim resource. Only show UsageRecords representing usage incurred by this Super SIM. </param>
        /// <param name="fleet"> SID or unique name of a Fleet resource. Only show UsageRecords representing usage for Super SIMs belonging to this Fleet resource at the time the usage occurred. </param>
        /// <param name="network"> SID of a Network resource. Only show UsageRecords representing usage on this network. </param>
        /// <param name="isoCountry"> Alpha-2 ISO Country Code. Only show UsageRecords representing usage in this country. </param>
        /// <param name="group"> Dimension over which to aggregate usage records. Can be: `sim`, `fleet`, `network`, `isoCountry`. Default is to not aggregate across any of these dimensions, UsageRecords will be aggregated into the time buckets described by the `Granularity` parameter. </param>
        /// <param name="granularity"> Time-based grouping that UsageRecords should be aggregated by. Can be: `hour`, `day`, or `all`. Default is `all`. `all` returns one UsageRecord that describes the usage for the entire period. </param>
        /// <param name="startTime"> Only include usage that occurred at or after this time, specified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. Default is one month before the `end_time`. </param>
        /// <param name="endTime"> Only include usage that occurred before this time (exclusive), specified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. Default is the current time. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <param name="limit"> Record limit </param>
        /// <returns> Task that resolves to A single instance of UsageRecord </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<UsageRecordResource>> ReadAsync(
                                                                                             string sim = null,
                                                                                             string fleet = null,
                                                                                             string network = null,
                                                                                             string isoCountry = null,
                                                                                             UsageRecordResource.GroupEnum group = null,
                                                                                             UsageRecordResource.GranularityEnum granularity = null,
                                                                                             DateTime? startTime = null,
                                                                                             DateTime? endTime = null,
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             ITwilioRestClient client = null)
        {
            var options = new ReadUsageRecordOptions(){ Sim = sim, Fleet = fleet, Network = network, IsoCountry = isoCountry, Group = group, Granularity = granularity, StartTime = startTime, EndTime = endTime, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        
        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<UsageRecordResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<UsageRecordResource>.FromJson("usage_records", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<UsageRecordResource> NextPage(Page<UsageRecordResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<UsageRecordResource>.FromJson("usage_records", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<UsageRecordResource> PreviousPage(Page<UsageRecordResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<UsageRecordResource>.FromJson("usage_records", response.Content);
        }

    
        /// <summary>
        /// Converts a JSON string into a UsageRecordResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> UsageRecordResource object represented by the provided JSON </returns>
        public static UsageRecordResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<UsageRecordResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

    
        ///<summary> The SID of the Account that incurred the usage. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> SID of a Sim resource to which the UsageRecord belongs. </summary> 
        [JsonProperty("sim_sid")]
        public string SimSid { get; private set; }

        ///<summary> SID of the Network resource on which the usage occurred. </summary> 
        [JsonProperty("network_sid")]
        public string NetworkSid { get; private set; }

        ///<summary> SID of the Fleet resource on which the usage occurred. </summary> 
        [JsonProperty("fleet_sid")]
        public string FleetSid { get; private set; }

        ///<summary> Alpha-2 ISO Country Code of the country the usage occurred in. </summary> 
        [JsonProperty("iso_country")]
        public string IsoCountry { get; private set; }

        ///<summary> The time period for which the usage is reported. </summary> 
        [JsonProperty("period")]
        public object Period { get; private set; }

        ///<summary> Total data uploaded in bytes, aggregated by the query parameters. </summary> 
        [JsonProperty("data_upload")]
        public long? DataUpload { get; private set; }

        ///<summary> Total data downloaded in bytes, aggregated by the query parameters. </summary> 
        [JsonProperty("data_download")]
        public long? DataDownload { get; private set; }

        ///<summary> Total of data_upload and data_download. </summary> 
        [JsonProperty("data_total")]
        public long? DataTotal { get; private set; }

        ///<summary> Total amount in the `billed_unit` that was charged for the data uploaded or downloaded. </summary> 
        [JsonProperty("data_total_billed")]
        public decimal? DataTotalBilled { get; private set; }

        ///<summary> The currency in which the billed amounts are measured, specified in the 3 letter ISO 4127 format (e.g. `USD`, `EUR`, `JPY`). </summary> 
        [JsonProperty("billed_unit")]
        public string BilledUnit { get; private set; }



        private UsageRecordResource() {

        }
    }
}

