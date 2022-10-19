/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Media
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




namespace Twilio.Rest.Media.V1
{

    /// <summary> create </summary>
    public class CreateMediaProcessorOptions : IOptions<MediaProcessorResource>
    {
        
        ///<summary> The [Media Extension](/docs/live/api/media-extensions-overview) name or URL. Ex: `video-composer-v2` </summary> 
        public string Extension { get; }

        ///<summary> The context of the Media Extension, represented as a JSON dictionary. See the documentation for the specific [Media Extension](/docs/live/api/media-extensions-overview) you are using for more information about the context to send. </summary> 
        public string ExtensionContext { get; }

        ///<summary> User-defined environment variables for the Media Extension, represented as a JSON dictionary of key/value strings. See the documentation for the specific [Media Extension](/docs/live/api/media-extensions-overview) you are using for more information about whether you need to provide this. </summary> 
        public object ExtensionEnvironment { get; set; }

        ///<summary> The URL to which Twilio will send asynchronous webhook requests for every MediaProcessor event. See [Status Callbacks](/docs/live/status-callbacks) for details. </summary> 
        public Uri StatusCallback { get; set; }

        ///<summary> The HTTP method Twilio should use to call the `status_callback` URL. Can be `POST` or `GET` and the default is `POST`. </summary> 
        public Twilio.Http.HttpMethod StatusCallbackMethod { get; set; }

        ///<summary> The maximum time, in seconds, that the MediaProcessor can run before automatically ends. The default value is 300 seconds, and the maximum value is 90000 seconds. Once this maximum duration is reached, Twilio will end the MediaProcessor, regardless of whether media is still streaming. </summary> 
        public int? MaxDuration { get; set; }


        /// <summary> Construct a new CreateMediaProcessorOptions </summary>
        /// <param name="extension"> The [Media Extension](/docs/live/api/media-extensions-overview) name or URL. Ex: &#x60;video-composer-v2&#x60; </param>        /// <param name="extensionContext"> The context of the Media Extension, represented as a JSON dictionary. See the documentation for the specific [Media Extension](/docs/live/api/media-extensions-overview) you are using for more information about the context to send. </param>
        public CreateMediaProcessorOptions(string extension, string extensionContext)
        {
            Extension = extension;
            ExtensionContext = extensionContext;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (Extension != null)
            {
                p.Add(new KeyValuePair<string, string>("Extension", Extension));
            }
            if (ExtensionContext != null)
            {
                p.Add(new KeyValuePair<string, string>("ExtensionContext", ExtensionContext));
            }
            if (ExtensionEnvironment != null)
            {
                p.Add(new KeyValuePair<string, string>("ExtensionEnvironment", Serializers.JsonObject(ExtensionEnvironment)));
            }
            if (StatusCallback != null)
            {
                p.Add(new KeyValuePair<string, string>("StatusCallback", Serializers.Url(StatusCallback)));
            }
            if (StatusCallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("StatusCallbackMethod", StatusCallbackMethod.ToString()));
            }
            if (MaxDuration != null)
            {
                p.Add(new KeyValuePair<string, string>("MaxDuration", MaxDuration.ToString()));
            }
            return p;
        }
        

    }
    /// <summary> Returns a single MediaProcessor resource identified by a SID. </summary>
    public class FetchMediaProcessorOptions : IOptions<MediaProcessorResource>
    {
    
        ///<summary> The SID of the MediaProcessor resource to fetch. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new FetchMediaProcessorOptions </summary>
        /// <param name="pathSid"> The SID of the MediaProcessor resource to fetch. </param>
        public FetchMediaProcessorOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }


    /// <summary> Returns a list of MediaProcessors. </summary>
    public class ReadMediaProcessorOptions : ReadOptions<MediaProcessorResource>
    {
    
        ///<summary> The sort order of the list by `date_created`. Can be: `asc` (ascending) or `desc` (descending) with `desc` as the default. </summary> 
        public MediaProcessorResource.OrderEnum Order { get; set; }

        ///<summary> Status to filter by, with possible values `started`, `ended` or `failed`. </summary> 
        public MediaProcessorResource.StatusEnum Status { get; set; }




        
        /// <summary> Generate the necessary parameters </summary>
        public  override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (Order != null)
            {
                p.Add(new KeyValuePair<string, string>("Order", Order.ToString()));
            }
            if (Status != null)
            {
                p.Add(new KeyValuePair<string, string>("Status", Status.ToString()));
            }
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }
            return p;
        }
        

    }

    /// <summary> Updates a MediaProcessor resource identified by a SID. </summary>
    public class UpdateMediaProcessorOptions : IOptions<MediaProcessorResource>
    {
    
        ///<summary> The SID of the MediaProcessor resource to update. </summary> 
        public string PathSid { get; }

        
        public MediaProcessorResource.UpdateStatusEnum Status { get; }



        /// <summary> Construct a new UpdateMediaProcessorOptions </summary>
        /// <param name="pathSid"> The SID of the MediaProcessor resource to update. </param>        /// <param name="status">  </param>
        public UpdateMediaProcessorOptions(string pathSid, MediaProcessorResource.UpdateStatusEnum status)
        {
            PathSid = pathSid;
            Status = status;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (Status != null)
            {
                p.Add(new KeyValuePair<string, string>("Status", Status.ToString()));
            }
            return p;
        }
        

    }


}

