/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Sync
 * This is the public Twilio REST API.
 *
 * NOTE: This class is auto generated by OpenAPI Generator.
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;




namespace Twilio.Rest.Sync.V1.Service.SyncStream
{

    /// <summary> Create a new Stream Message. </summary>
    public class CreateStreamMessageOptions : IOptions<StreamMessageResource>
    {
        
        ///<summary> The SID of the [Sync Service](https://www.twilio.com/docs/sync/api/service) to create the new Stream Message in. </summary> 
        public string PathServiceSid { get; }

        ///<summary> The SID of the Sync Stream to create the new Stream Message resource for. </summary> 
        public string PathStreamSid { get; }

        ///<summary> A JSON string that represents an arbitrary, schema-less object that makes up the Stream Message body. Can be up to 4 KiB in length. </summary> 
        public object Data { get; }


        /// <summary> Construct a new CreateStreamMessageOptions </summary>
        /// <param name="pathServiceSid"> The SID of the [Sync Service](https://www.twilio.com/docs/sync/api/service) to create the new Stream Message in. </param>        /// <param name="pathStreamSid"> The SID of the Sync Stream to create the new Stream Message resource for. </param>        /// <param name="data"> A JSON string that represents an arbitrary, schema-less object that makes up the Stream Message body. Can be up to 4 KiB in length. </param>
        public CreateStreamMessageOptions(string pathServiceSid, string pathStreamSid, object data)
        {
            PathServiceSid = pathServiceSid;
            PathStreamSid = pathStreamSid;
            Data = data;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (Data != null)
            {
                p.Add(new KeyValuePair<string, string>("Data", Serializers.JsonObject(Data)));
            }
            return p;
        }
        

    }
}

