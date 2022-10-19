/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Trusthub
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




namespace Twilio.Rest.Trusthub.V1.CustomerProfiles
{

    /// <summary> Create a new Assigned Item. </summary>
    public class CreateCustomerProfilesChannelEndpointAssignmentOptions : IOptions<CustomerProfilesChannelEndpointAssignmentResource>
    {
        
        ///<summary> The unique string that we created to identify the CustomerProfile resource. </summary> 
        public string PathCustomerProfileSid { get; }

        ///<summary> The type of channel endpoint. eg: phone-number </summary> 
        public string ChannelEndpointType { get; }

        ///<summary> The SID of an channel endpoint </summary> 
        public string ChannelEndpointSid { get; }


        /// <summary> Construct a new CreateCustomerProfileChannelEndpointAssignmentOptions </summary>
        /// <param name="pathCustomerProfileSid"> The unique string that we created to identify the CustomerProfile resource. </param>        /// <param name="channelEndpointType"> The type of channel endpoint. eg: phone-number </param>        /// <param name="channelEndpointSid"> The SID of an channel endpoint </param>
        public CreateCustomerProfilesChannelEndpointAssignmentOptions(string pathCustomerProfileSid, string channelEndpointType, string channelEndpointSid)
        {
            PathCustomerProfileSid = pathCustomerProfileSid;
            ChannelEndpointType = channelEndpointType;
            ChannelEndpointSid = channelEndpointSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (ChannelEndpointType != null)
            {
                p.Add(new KeyValuePair<string, string>("ChannelEndpointType", ChannelEndpointType));
            }
            if (ChannelEndpointSid != null)
            {
                p.Add(new KeyValuePair<string, string>("ChannelEndpointSid", ChannelEndpointSid));
            }
            return p;
        }
        

    }
    /// <summary> Remove an Assignment Item Instance. </summary>
    public class DeleteCustomerProfilesChannelEndpointAssignmentOptions : IOptions<CustomerProfilesChannelEndpointAssignmentResource>
    {
        
        ///<summary> The unique string that we created to identify the CustomerProfile resource. </summary> 
        public string PathCustomerProfileSid { get; }

        ///<summary> The unique string that we created to identify the resource. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new DeleteCustomerProfileChannelEndpointAssignmentOptions </summary>
        /// <param name="pathCustomerProfileSid"> The unique string that we created to identify the CustomerProfile resource. </param>        /// <param name="pathSid"> The unique string that we created to identify the resource. </param>
        public DeleteCustomerProfilesChannelEndpointAssignmentOptions(string pathCustomerProfileSid, string pathSid)
        {
            PathCustomerProfileSid = pathCustomerProfileSid;
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }


    /// <summary> Fetch specific Assigned Item Instance. </summary>
    public class FetchCustomerProfilesChannelEndpointAssignmentOptions : IOptions<CustomerProfilesChannelEndpointAssignmentResource>
    {
    
        ///<summary> The unique string that we created to identify the CustomerProfile resource. </summary> 
        public string PathCustomerProfileSid { get; }

        ///<summary> The unique string that we created to identify the resource. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new FetchCustomerProfileChannelEndpointAssignmentOptions </summary>
        /// <param name="pathCustomerProfileSid"> The unique string that we created to identify the CustomerProfile resource. </param>        /// <param name="pathSid"> The unique string that we created to identify the resource. </param>
        public FetchCustomerProfilesChannelEndpointAssignmentOptions(string pathCustomerProfileSid, string pathSid)
        {
            PathCustomerProfileSid = pathCustomerProfileSid;
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }


    /// <summary> Retrieve a list of all Assigned Items for an account. </summary>
    public class ReadCustomerProfilesChannelEndpointAssignmentOptions : ReadOptions<CustomerProfilesChannelEndpointAssignmentResource>
    {
    
        ///<summary> The unique string that we created to identify the CustomerProfile resource. </summary> 
        public string PathCustomerProfileSid { get; }

        ///<summary> The SID of an channel endpoint </summary> 
        public string ChannelEndpointSid { get; set; }

        ///<summary> comma separated list of channel endpoint sids </summary> 
        public string ChannelEndpointSids { get; set; }



        /// <summary> Construct a new ListCustomerProfileChannelEndpointAssignmentOptions </summary>
        /// <param name="pathCustomerProfileSid"> The unique string that we created to identify the CustomerProfile resource. </param>
        public ReadCustomerProfilesChannelEndpointAssignmentOptions(string pathCustomerProfileSid)
        {
            PathCustomerProfileSid = pathCustomerProfileSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (ChannelEndpointSid != null)
            {
                p.Add(new KeyValuePair<string, string>("ChannelEndpointSid", ChannelEndpointSid));
            }
            if (ChannelEndpointSids != null)
            {
                p.Add(new KeyValuePair<string, string>("ChannelEndpointSids", ChannelEndpointSids));
            }
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }
            return p;
        }
        

    }

}

