/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Sync.V1.Service.SyncMap
{

    /// <summary>
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    ///
    /// FetchSyncMapItemOptions
    /// </summary>
    public class FetchSyncMapItemOptions : IOptions<SyncMapItemResource>
    {
        /// <summary>
        /// The SID of the Sync Service with the Sync Map Item resource to fetch
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The SID of the Sync Map with the Sync Map Item resource to fetch
        /// </summary>
        public string PathMapSid { get; }
        /// <summary>
        /// The key value of the Sync Map Item resource to fetch
        /// </summary>
        public string PathKey { get; }

        /// <summary>
        /// Construct a new FetchSyncMapItemOptions
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Sync Service with the Sync Map Item resource to fetch </param>
        /// <param name="pathMapSid"> The SID of the Sync Map with the Sync Map Item resource to fetch </param>
        /// <param name="pathKey"> The key value of the Sync Map Item resource to fetch </param>
        public FetchSyncMapItemOptions(string pathServiceSid, string pathMapSid, string pathKey)
        {
            PathServiceSid = pathServiceSid;
            PathMapSid = pathMapSid;
            PathKey = pathKey;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    ///
    /// DeleteSyncMapItemOptions
    /// </summary>
    public class DeleteSyncMapItemOptions : IOptions<SyncMapItemResource>
    {
        /// <summary>
        /// The SID of the Sync Service with the Sync Map Item resource to delete
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The SID of the Sync Map with the Sync Map Item resource to delete
        /// </summary>
        public string PathMapSid { get; }
        /// <summary>
        /// The key value of the Sync Map Item resource to delete
        /// </summary>
        public string PathKey { get; }
        /// <summary>
        /// The If-Match HTTP request header
        /// </summary>
        public string IfMatch { get; set; }

        /// <summary>
        /// Construct a new DeleteSyncMapItemOptions
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Sync Service with the Sync Map Item resource to delete </param>
        /// <param name="pathMapSid"> The SID of the Sync Map with the Sync Map Item resource to delete </param>
        /// <param name="pathKey"> The key value of the Sync Map Item resource to delete </param>
        public DeleteSyncMapItemOptions(string pathServiceSid, string pathMapSid, string pathKey)
        {
            PathServiceSid = pathServiceSid;
            PathMapSid = pathMapSid;
            PathKey = pathKey;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }

        /// <summary>
        /// Generate the necessary header parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetHeaderParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (IfMatch != null)
            {
                p.Add(new KeyValuePair<string, string>("If-Match", IfMatch));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    ///
    /// CreateSyncMapItemOptions
    /// </summary>
    public class CreateSyncMapItemOptions : IOptions<SyncMapItemResource>
    {
        /// <summary>
        /// The SID of the Sync Service to create the Map Item in
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The SID of the Sync Map to add the new Map Item to
        /// </summary>
        public string PathMapSid { get; }
        /// <summary>
        /// The unique, user-defined key for the Map Item
        /// </summary>
        public string Key { get; }
        /// <summary>
        /// A JSON string that represents an arbitrary, schema-less object that the Map Item stores
        /// </summary>
        public object Data { get; }
        /// <summary>
        /// An alias for item_ttl
        /// </summary>
        public int? Ttl { get; set; }
        /// <summary>
        /// How long, in seconds, before the Map Item expires
        /// </summary>
        public int? ItemTtl { get; set; }
        /// <summary>
        /// How long, in seconds, before the Map Item's parent Sync Map expires and is deleted
        /// </summary>
        public int? CollectionTtl { get; set; }

        /// <summary>
        /// Construct a new CreateSyncMapItemOptions
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Sync Service to create the Map Item in </param>
        /// <param name="pathMapSid"> The SID of the Sync Map to add the new Map Item to </param>
        /// <param name="key"> The unique, user-defined key for the Map Item </param>
        /// <param name="data"> A JSON string that represents an arbitrary, schema-less object that the Map Item stores </param>
        public CreateSyncMapItemOptions(string pathServiceSid, string pathMapSid, string key, object data)
        {
            PathServiceSid = pathServiceSid;
            PathMapSid = pathMapSid;
            Key = key;
            Data = data;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Key != null)
            {
                p.Add(new KeyValuePair<string, string>("Key", Key));
            }

            if (Data != null)
            {
                p.Add(new KeyValuePair<string, string>("Data", Serializers.JsonObject(Data)));
            }

            if (Ttl != null)
            {
                p.Add(new KeyValuePair<string, string>("Ttl", Ttl.ToString()));
            }

            if (ItemTtl != null)
            {
                p.Add(new KeyValuePair<string, string>("ItemTtl", ItemTtl.ToString()));
            }

            if (CollectionTtl != null)
            {
                p.Add(new KeyValuePair<string, string>("CollectionTtl", CollectionTtl.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    ///
    /// ReadSyncMapItemOptions
    /// </summary>
    public class ReadSyncMapItemOptions : ReadOptions<SyncMapItemResource>
    {
        /// <summary>
        /// The SID of the Sync Service with the Map Item resources to read
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The SID of the Sync Map with the Sync Map Item resource to fetch
        /// </summary>
        public string PathMapSid { get; }
        /// <summary>
        /// How to order the Map Items returned by their key value
        /// </summary>
        public SyncMapItemResource.QueryResultOrderEnum Order { get; set; }
        /// <summary>
        /// The index of the first Sync Map Item resource to read
        /// </summary>
        public string From { get; set; }
        /// <summary>
        /// Whether to include the Map Item referenced by the from parameter
        /// </summary>
        public SyncMapItemResource.QueryFromBoundTypeEnum Bounds { get; set; }

        /// <summary>
        /// Construct a new ReadSyncMapItemOptions
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Sync Service with the Map Item resources to read </param>
        /// <param name="pathMapSid"> The SID of the Sync Map with the Sync Map Item resource to fetch </param>
        public ReadSyncMapItemOptions(string pathServiceSid, string pathMapSid)
        {
            PathServiceSid = pathServiceSid;
            PathMapSid = pathMapSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Order != null)
            {
                p.Add(new KeyValuePair<string, string>("Order", Order.ToString()));
            }

            if (From != null)
            {
                p.Add(new KeyValuePair<string, string>("From", From));
            }

            if (Bounds != null)
            {
                p.Add(new KeyValuePair<string, string>("Bounds", Bounds.ToString()));
            }

            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    ///
    /// UpdateSyncMapItemOptions
    /// </summary>
    public class UpdateSyncMapItemOptions : IOptions<SyncMapItemResource>
    {
        /// <summary>
        /// The SID of the Sync Service with the Sync Map Item resource to update
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The SID of the Sync Map with the Sync Map Item resource to update
        /// </summary>
        public string PathMapSid { get; }
        /// <summary>
        /// The key value of the Sync Map Item resource to update
        /// </summary>
        public string PathKey { get; }
        /// <summary>
        /// A JSON string that represents an arbitrary, schema-less object that the Map Item stores
        /// </summary>
        public object Data { get; set; }
        /// <summary>
        /// An alias for item_ttl
        /// </summary>
        public int? Ttl { get; set; }
        /// <summary>
        /// How long, in seconds, before the Map Item expires
        /// </summary>
        public int? ItemTtl { get; set; }
        /// <summary>
        /// How long, in seconds, before the Map Item's parent Sync Map expires and is deleted
        /// </summary>
        public int? CollectionTtl { get; set; }
        /// <summary>
        /// The If-Match HTTP request header
        /// </summary>
        public string IfMatch { get; set; }

        /// <summary>
        /// Construct a new UpdateSyncMapItemOptions
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Sync Service with the Sync Map Item resource to update </param>
        /// <param name="pathMapSid"> The SID of the Sync Map with the Sync Map Item resource to update </param>
        /// <param name="pathKey"> The key value of the Sync Map Item resource to update </param>
        public UpdateSyncMapItemOptions(string pathServiceSid, string pathMapSid, string pathKey)
        {
            PathServiceSid = pathServiceSid;
            PathMapSid = pathMapSid;
            PathKey = pathKey;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Data != null)
            {
                p.Add(new KeyValuePair<string, string>("Data", Serializers.JsonObject(Data)));
            }

            if (Ttl != null)
            {
                p.Add(new KeyValuePair<string, string>("Ttl", Ttl.ToString()));
            }

            if (ItemTtl != null)
            {
                p.Add(new KeyValuePair<string, string>("ItemTtl", ItemTtl.ToString()));
            }

            if (CollectionTtl != null)
            {
                p.Add(new KeyValuePair<string, string>("CollectionTtl", CollectionTtl.ToString()));
            }

            return p;
        }

        /// <summary>
        /// Generate the necessary header parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetHeaderParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (IfMatch != null)
            {
                p.Add(new KeyValuePair<string, string>("If-Match", IfMatch));
            }

            return p;
        }
    }

}