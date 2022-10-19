/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Proxy
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




namespace Twilio.Rest.Proxy.V1.Service.Session
{

    /// <summary> Add a new Participant to the Session </summary>
    public class CreateParticipantOptions : IOptions<ParticipantResource>
    {
        
        ///<summary> The SID of the parent [Service](https://www.twilio.com/docs/proxy/api/service) resource. </summary> 
        public string PathServiceSid { get; }

        ///<summary> The SID of the parent [Session](https://www.twilio.com/docs/proxy/api/session) resource. </summary> 
        public string PathSessionSid { get; }

        ///<summary> The phone number of the Participant. </summary> 
        public string Identifier { get; }

        ///<summary> The string that you assigned to describe the participant. This value must be 255 characters or fewer. **This value should not have PII.** </summary> 
        public string FriendlyName { get; set; }

        ///<summary> The proxy phone number to use for the Participant. If not specified, Proxy will select a number from the pool. </summary> 
        public string ProxyIdentifier { get; set; }

        ///<summary> The SID of the Proxy Identifier to assign to the Participant. </summary> 
        public string ProxyIdentifierSid { get; set; }

        ///<summary> [Experimental] For accounts with the ProxyAllowParticipantConflict account flag, setting to true enables per-request opt-in to allowing Proxy to reject a Participant create request that could cause the same Identifier/ProxyIdentifier pair to be active in multiple Sessions. Depending on the context, this could be a 409 error (Twilio error code 80623) or a 400 error (Twilio error code 80604). If not provided, requests will be allowed to succeed and a Debugger notification (80802) will be emitted. Having multiple, active Participants with the same Identifier/ProxyIdentifier pair causes calls and messages from affected Participants to be routed incorrectly. Please note, the default behavior for accounts without the ProxyAllowParticipantConflict flag is to reject the request as described.  This will eventually be the default for all accounts. </summary> 
        public bool? FailOnParticipantConflict { get; set; }


        /// <summary> Construct a new CreateParticipantOptions </summary>
        /// <param name="pathServiceSid"> The SID of the parent [Service](https://www.twilio.com/docs/proxy/api/service) resource. </param>        /// <param name="pathSessionSid"> The SID of the parent [Session](https://www.twilio.com/docs/proxy/api/session) resource. </param>        /// <param name="identifier"> The phone number of the Participant. </param>
        public CreateParticipantOptions(string pathServiceSid, string pathSessionSid, string identifier)
        {
            PathServiceSid = pathServiceSid;
            PathSessionSid = pathSessionSid;
            Identifier = identifier;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (Identifier != null)
            {
                p.Add(new KeyValuePair<string, string>("Identifier", Identifier));
            }
            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }
            if (ProxyIdentifier != null)
            {
                p.Add(new KeyValuePair<string, string>("ProxyIdentifier", ProxyIdentifier));
            }
            if (ProxyIdentifierSid != null)
            {
                p.Add(new KeyValuePair<string, string>("ProxyIdentifierSid", ProxyIdentifierSid));
            }
            if (FailOnParticipantConflict != null)
            {
                p.Add(new KeyValuePair<string, string>("FailOnParticipantConflict", FailOnParticipantConflict.Value.ToString().ToLower()));
            }
            return p;
        }
        

    }
    /// <summary> Delete a specific Participant. This is a soft-delete. The participant remains associated with the session and cannot be re-added. Participants are only permanently deleted when the [Session](https://www.twilio.com/docs/proxy/api/session) is deleted. </summary>
    public class DeleteParticipantOptions : IOptions<ParticipantResource>
    {
        
        ///<summary> The SID of the parent [Service](https://www.twilio.com/docs/proxy/api/service) of the resource to delete. </summary> 
        public string PathServiceSid { get; }

        ///<summary> The SID of the parent [Session](https://www.twilio.com/docs/proxy/api/session) of the resource to delete. </summary> 
        public string PathSessionSid { get; }

        ///<summary> The Twilio-provided string that uniquely identifies the Participant resource to delete. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new DeleteParticipantOptions </summary>
        /// <param name="pathServiceSid"> The SID of the parent [Service](https://www.twilio.com/docs/proxy/api/service) of the resource to delete. </param>        /// <param name="pathSessionSid"> The SID of the parent [Session](https://www.twilio.com/docs/proxy/api/session) of the resource to delete. </param>        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the Participant resource to delete. </param>
        public DeleteParticipantOptions(string pathServiceSid, string pathSessionSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathSessionSid = pathSessionSid;
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }


    /// <summary> Fetch a specific Participant. </summary>
    public class FetchParticipantOptions : IOptions<ParticipantResource>
    {
    
        ///<summary> The SID of the parent [Service](https://www.twilio.com/docs/proxy/api/service) of the resource to fetch. </summary> 
        public string PathServiceSid { get; }

        ///<summary> The SID of the parent [Session](https://www.twilio.com/docs/proxy/api/session) of the resource to fetch. </summary> 
        public string PathSessionSid { get; }

        ///<summary> The Twilio-provided string that uniquely identifies the Participant resource to fetch. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new FetchParticipantOptions </summary>
        /// <param name="pathServiceSid"> The SID of the parent [Service](https://www.twilio.com/docs/proxy/api/service) of the resource to fetch. </param>        /// <param name="pathSessionSid"> The SID of the parent [Session](https://www.twilio.com/docs/proxy/api/session) of the resource to fetch. </param>        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the Participant resource to fetch. </param>
        public FetchParticipantOptions(string pathServiceSid, string pathSessionSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathSessionSid = pathSessionSid;
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }


    /// <summary> Retrieve a list of all Participants in a Session. </summary>
    public class ReadParticipantOptions : ReadOptions<ParticipantResource>
    {
    
        ///<summary> The SID of the parent [Service](https://www.twilio.com/docs/proxy/api/service) of the resources to read. </summary> 
        public string PathServiceSid { get; }

        ///<summary> The SID of the parent [Session](https://www.twilio.com/docs/proxy/api/session) of the resources to read. </summary> 
        public string PathSessionSid { get; }



        /// <summary> Construct a new ListParticipantOptions </summary>
        /// <param name="pathServiceSid"> The SID of the parent [Service](https://www.twilio.com/docs/proxy/api/service) of the resources to read. </param>        /// <param name="pathSessionSid"> The SID of the parent [Session](https://www.twilio.com/docs/proxy/api/session) of the resources to read. </param>
        public ReadParticipantOptions(string pathServiceSid, string pathSessionSid)
        {
            PathServiceSid = pathServiceSid;
            PathSessionSid = pathSessionSid;
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

