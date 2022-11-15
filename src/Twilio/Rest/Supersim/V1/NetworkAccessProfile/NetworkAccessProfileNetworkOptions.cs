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


using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;




namespace Twilio.Rest.Supersim.V1.NetworkAccessProfile
{

    /// <summary> Add a Network resource to the Network Access Profile resource. </summary>
    public class CreateNetworkAccessProfileNetworkOptions : IOptions<NetworkAccessProfileNetworkResource>
    {
        
        ///<summary> The unique string that identifies the Network Access Profile resource. </summary> 
        public string PathNetworkAccessProfileSid { get; }

        ///<summary> The SID of the Network resource to be added to the Network Access Profile resource. </summary> 
        public string Network { get; }


        /// <summary> Construct a new CreateNetworkAccessProfileNetworkOptions </summary>
        /// <param name="pathNetworkAccessProfileSid"> The unique string that identifies the Network Access Profile resource. </param>        /// <param name="network"> The SID of the Network resource to be added to the Network Access Profile resource. </param>
        public CreateNetworkAccessProfileNetworkOptions(string pathNetworkAccessProfileSid, string network)
        {
            PathNetworkAccessProfileSid = pathNetworkAccessProfileSid;
            Network = network;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (Network != null)
            {
                p.Add(new KeyValuePair<string, string>("Network", Network));
            }
            return p;
        }
        

    }
    /// <summary> Remove a Network resource from the Network Access Profile resource&#39;s. </summary>
    public class DeleteNetworkAccessProfileNetworkOptions : IOptions<NetworkAccessProfileNetworkResource>
    {
        
        ///<summary> The unique string that identifies the Network Access Profile resource. </summary> 
        public string PathNetworkAccessProfileSid { get; }

        ///<summary> The SID of the Network resource to be removed from the Network Access Profile resource. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new DeleteNetworkAccessProfileNetworkOptions </summary>
        /// <param name="pathNetworkAccessProfileSid"> The unique string that identifies the Network Access Profile resource. </param>        /// <param name="pathSid"> The SID of the Network resource to be removed from the Network Access Profile resource. </param>
        public DeleteNetworkAccessProfileNetworkOptions(string pathNetworkAccessProfileSid, string pathSid)
        {
            PathNetworkAccessProfileSid = pathNetworkAccessProfileSid;
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }


    /// <summary> Fetch a Network Access Profile resource&#39;s Network resource. </summary>
    public class FetchNetworkAccessProfileNetworkOptions : IOptions<NetworkAccessProfileNetworkResource>
    {
    
        ///<summary> The unique string that identifies the Network Access Profile resource. </summary> 
        public string PathNetworkAccessProfileSid { get; }

        ///<summary> The SID of the Network resource to fetch. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new FetchNetworkAccessProfileNetworkOptions </summary>
        /// <param name="pathNetworkAccessProfileSid"> The unique string that identifies the Network Access Profile resource. </param>        /// <param name="pathSid"> The SID of the Network resource to fetch. </param>
        public FetchNetworkAccessProfileNetworkOptions(string pathNetworkAccessProfileSid, string pathSid)
        {
            PathNetworkAccessProfileSid = pathNetworkAccessProfileSid;
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }


    /// <summary> Retrieve a list of Network Access Profile resource&#39;s Network resource. </summary>
    public class ReadNetworkAccessProfileNetworkOptions : ReadOptions<NetworkAccessProfileNetworkResource>
    {
    
        ///<summary> The unique string that identifies the Network Access Profile resource. </summary> 
        public string PathNetworkAccessProfileSid { get; }



        /// <summary> Construct a new ListNetworkAccessProfileNetworkOptions </summary>
        /// <param name="pathNetworkAccessProfileSid"> The unique string that identifies the Network Access Profile resource. </param>
        public ReadNetworkAccessProfileNetworkOptions(string pathNetworkAccessProfileSid)
        {
            PathNetworkAccessProfileSid = pathNetworkAccessProfileSid;
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

}

