/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Messaging
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




namespace Twilio.Rest.Messaging.V1
{

    /// <summary> create </summary>
    public class CreateExternalCampaignOptions : IOptions<ExternalCampaignResource>
    {
        
        ///<summary> ID of the preregistered campaign. </summary> 
        public string CampaignId { get; }

        ///<summary> The SID of the [Messaging Service](https://www.twilio.com/docs/messaging/services/api) that the resource is associated with. </summary> 
        public string MessagingServiceSid { get; }


        /// <summary> Construct a new CreateExternalCampaignOptions </summary>
        /// <param name="campaignId"> ID of the preregistered campaign. </param>        /// <param name="messagingServiceSid"> The SID of the [Messaging Service](https://www.twilio.com/docs/messaging/services/api) that the resource is associated with. </param>
        public CreateExternalCampaignOptions(string campaignId, string messagingServiceSid)
        {
            CampaignId = campaignId;
            MessagingServiceSid = messagingServiceSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (CampaignId != null)
            {
                p.Add(new KeyValuePair<string, string>("CampaignId", CampaignId));
            }
            if (MessagingServiceSid != null)
            {
                p.Add(new KeyValuePair<string, string>("MessagingServiceSid", MessagingServiceSid));
            }
            return p;
        }
        

    }
}

