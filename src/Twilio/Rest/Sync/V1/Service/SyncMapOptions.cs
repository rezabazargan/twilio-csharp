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




namespace Twilio.Rest.Sync.V1.Service
{

    /// <summary> create </summary>
    public class CreateSyncMapOptions : IOptions<SyncMapResource>
    {
        
        ///<summary> The SID of the [Sync Service](https://www.twilio.com/docs/sync/api/service) to create the Sync Map in. </summary> 
        public string PathServiceSid { get; }

        ///<summary> An application-defined string that uniquely identifies the resource. It can be used as an alternative to the `sid` in the URL path to address the resource. </summary> 
        public string UniqueName { get; set; }

        ///<summary> An alias for `collection_ttl`. If both parameters are provided, this value is ignored. </summary> 
        public int? Ttl { get; set; }

        ///<summary> How long, [in seconds](https://www.twilio.com/docs/sync/limits#sync-payload-limits), before the Sync Map expires (time-to-live) and is deleted. </summary> 
        public int? CollectionTtl { get; set; }


        /// <summary> Construct a new CreateSyncMapOptions </summary>
        /// <param name="pathServiceSid"> The SID of the [Sync Service](https://www.twilio.com/docs/sync/api/service) to create the Sync Map in. </param>
        public CreateSyncMapOptions(string pathServiceSid)
        {
            PathServiceSid = pathServiceSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (UniqueName != null)
            {
                p.Add(new KeyValuePair<string, string>("UniqueName", UniqueName));
            }
            if (Ttl != null)
            {
                p.Add(new KeyValuePair<string, string>("Ttl", Ttl.ToString()));
            }
            if (CollectionTtl != null)
            {
                p.Add(new KeyValuePair<string, string>("CollectionTtl", CollectionTtl.ToString()));
            }
            return p;
        }
        

    }
    /// <summary> delete </summary>
    public class DeleteSyncMapOptions : IOptions<SyncMapResource>
    {
        
        ///<summary> The SID of the [Sync Service](https://www.twilio.com/docs/sync/api/service) with the Sync Map resource to delete. </summary> 
        public string PathServiceSid { get; }

        ///<summary> The SID of the Sync Map resource to delete. Can be the Sync Map's `sid` or its `unique_name`. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new DeleteSyncMapOptions </summary>
        /// <param name="pathServiceSid"> The SID of the [Sync Service](https://www.twilio.com/docs/sync/api/service) with the Sync Map resource to delete. </param>        /// <param name="pathSid"> The SID of the Sync Map resource to delete. Can be the Sync Map&#39;s &#x60;sid&#x60; or its &#x60;unique_name&#x60;. </param>
        public DeleteSyncMapOptions(string pathServiceSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }


    /// <summary> fetch </summary>
    public class FetchSyncMapOptions : IOptions<SyncMapResource>
    {
    
        ///<summary> The SID of the [Sync Service](https://www.twilio.com/docs/sync/api/service) with the Sync Map resource to fetch. </summary> 
        public string PathServiceSid { get; }

        ///<summary> The SID of the Sync Map resource to fetch. Can be the Sync Map's `sid` or its `unique_name`. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new FetchSyncMapOptions </summary>
        /// <param name="pathServiceSid"> The SID of the [Sync Service](https://www.twilio.com/docs/sync/api/service) with the Sync Map resource to fetch. </param>        /// <param name="pathSid"> The SID of the Sync Map resource to fetch. Can be the Sync Map&#39;s &#x60;sid&#x60; or its &#x60;unique_name&#x60;. </param>
        public FetchSyncMapOptions(string pathServiceSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }


    /// <summary> read </summary>
    public class ReadSyncMapOptions : ReadOptions<SyncMapResource>
    {
    
        ///<summary> The SID of the [Sync Service](https://www.twilio.com/docs/sync/api/service) with the Sync Map resources to read. </summary> 
        public string PathServiceSid { get; }



        /// <summary> Construct a new ListSyncMapOptions </summary>
        /// <param name="pathServiceSid"> The SID of the [Sync Service](https://www.twilio.com/docs/sync/api/service) with the Sync Map resources to read. </param>
        public ReadSyncMapOptions(string pathServiceSid)
        {
            PathServiceSid = pathServiceSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }
            return p;
        }
        

    }

    /// <summary> update </summary>
    public class UpdateSyncMapOptions : IOptions<SyncMapResource>
    {
    
        ///<summary> The SID of the [Sync Service](https://www.twilio.com/docs/sync/api/service) with the Sync Map resource to update. </summary> 
        public string PathServiceSid { get; }

        ///<summary> The SID of the Sync Map resource to update. Can be the Sync Map's `sid` or its `unique_name`. </summary> 
        public string PathSid { get; }

        ///<summary> An alias for `collection_ttl`. If both parameters are provided, this value is ignored. </summary> 
        public int? Ttl { get; set; }

        ///<summary> How long, [in seconds](https://www.twilio.com/docs/sync/limits#sync-payload-limits), before the Sync Map expires (time-to-live) and is deleted. </summary> 
        public int? CollectionTtl { get; set; }



        /// <summary> Construct a new UpdateSyncMapOptions </summary>
        /// <param name="pathServiceSid"> The SID of the [Sync Service](https://www.twilio.com/docs/sync/api/service) with the Sync Map resource to update. </param>        /// <param name="pathSid"> The SID of the Sync Map resource to update. Can be the Sync Map&#39;s &#x60;sid&#x60; or its &#x60;unique_name&#x60;. </param>
        public UpdateSyncMapOptions(string pathServiceSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (Ttl != null)
            {
                p.Add(new KeyValuePair<string, string>("Ttl", Ttl.ToString()));
            }
            if (CollectionTtl != null)
            {
                p.Add(new KeyValuePair<string, string>("CollectionTtl", CollectionTtl.ToString()));
            }
            return p;
        }
        

    }


}

