/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Video
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


namespace Twilio.Rest.Video.V1.Room
{
    public class RecordingRulesResource : Resource
    {
    

        
        private static Request BuildFetchRequest(FetchRecordingRulesOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Rooms/{RoomSid}/RecordingRules";

            string PathRoomSid = options.PathRoomSid;
            path = path.Replace("{"+"RoomSid"+"}", PathRoomSid);


            return new Request(
                HttpMethod.Get,
                Rest.Domain.Video,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Returns a list of Recording Rules for the Room. </summary>
        /// <param name="options"> Fetch RecordingRules parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of RecordingRules </returns>
        public static RecordingRulesResource Fetch(FetchRecordingRulesOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Returns a list of Recording Rules for the Room. </summary>
        /// <param name="options"> Fetch RecordingRules parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of RecordingRules </returns>
        public static async System.Threading.Tasks.Task<RecordingRulesResource> FetchAsync(FetchRecordingRulesOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
        /// <summary> Returns a list of Recording Rules for the Room. </summary>
        /// <param name="pathRoomSid"> The SID of the Room resource where the recording rules to fetch apply. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of RecordingRules </returns>
        public static RecordingRulesResource Fetch(
                                         string pathRoomSid, 
                                         ITwilioRestClient client = null)
        {
            var options = new FetchRecordingRulesOptions(pathRoomSid){  };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> Returns a list of Recording Rules for the Room. </summary>
        /// <param name="pathRoomSid"> The SID of the Room resource where the recording rules to fetch apply. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of RecordingRules </returns>
        public static async System.Threading.Tasks.Task<RecordingRulesResource> FetchAsync(string pathRoomSid, ITwilioRestClient client = null)
        {
            var options = new FetchRecordingRulesOptions(pathRoomSid){  };
            return await FetchAsync(options, client);
        }
        #endif
        
        private static Request BuildUpdateRequest(UpdateRecordingRulesOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Rooms/{RoomSid}/RecordingRules";

            string PathRoomSid = options.PathRoomSid;
            path = path.Replace("{"+"RoomSid"+"}", PathRoomSid);


            return new Request(
                HttpMethod.Post,
                Rest.Domain.Video,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Update the Recording Rules for the Room </summary>
        /// <param name="options"> Update RecordingRules parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of RecordingRules </returns>
        public static RecordingRulesResource Update(UpdateRecordingRulesOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        /// <summary> Update the Recording Rules for the Room </summary>
        /// <param name="options"> Update RecordingRules parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of RecordingRules </returns>
        #if !NET35
        public static async System.Threading.Tasks.Task<RecordingRulesResource> UpdateAsync(UpdateRecordingRulesOptions options,
                                                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> Update the Recording Rules for the Room </summary>
        /// <param name="pathRoomSid"> The SID of the Room resource where the recording rules to update apply. </param>
        /// <param name="rules"> A JSON-encoded array of recording rules. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of RecordingRules </returns>
        public static RecordingRulesResource Update(
                                          string pathRoomSid,
                                          object rules = null,
                                          ITwilioRestClient client = null)
        {
            var options = new UpdateRecordingRulesOptions(pathRoomSid){ Rules = rules };
            return Update(options, client);
        }

        #if !NET35
        /// <summary> Update the Recording Rules for the Room </summary>
        /// <param name="pathRoomSid"> The SID of the Room resource where the recording rules to update apply. </param>
        /// <param name="rules"> A JSON-encoded array of recording rules. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of RecordingRules </returns>
        public static async System.Threading.Tasks.Task<RecordingRulesResource> UpdateAsync(
                                                                              string pathRoomSid,
                                                                              object rules = null,
                                                                              ITwilioRestClient client = null)
        {
            var options = new UpdateRecordingRulesOptions(pathRoomSid){ Rules = rules };
            return await UpdateAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a RecordingRulesResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> RecordingRulesResource object represented by the provided JSON </returns>
        public static RecordingRulesResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<RecordingRulesResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

    
        ///<summary> The SID of the Room resource for the Recording Rules </summary> 
        [JsonProperty("room_sid")]
        public string RoomSid { get; private set; }

        ///<summary> A collection of recording Rules that describe how to include or exclude matching tracks for recording </summary> 
        [JsonProperty("rules")]
        public List<RecordingRule> Rules { get; private set; }

        ///<summary> The ISO 8601 date and time in GMT when the resource was created </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The ISO 8601 date and time in GMT when the resource was last updated </summary> 
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }



        private RecordingRulesResource() {

        }
    }
}

