/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Flex
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




namespace Twilio.Rest.FlexApi.V1
{

    /// <summary> create </summary>
    public class CreateWebChannelOptions : IOptions<WebChannelResource>
    {
        
        ///<summary> The SID of the Flex Flow. </summary> 
        public string FlexFlowSid { get; }

        ///<summary> The chat identity. </summary> 
        public string Identity { get; }

        ///<summary> The chat participant's friendly name. </summary> 
        public string CustomerFriendlyName { get; }

        ///<summary> The chat channel's friendly name. </summary> 
        public string ChatFriendlyName { get; }

        ///<summary> The chat channel's unique name. </summary> 
        public string ChatUniqueName { get; set; }

        ///<summary> The pre-engagement data. </summary> 
        public string PreEngagementData { get; set; }


        /// <summary> Construct a new CreateWebChannelOptions </summary>
        /// <param name="flexFlowSid"> The SID of the Flex Flow. </param>        /// <param name="identity"> The chat identity. </param>        /// <param name="customerFriendlyName"> The chat participant&#39;s friendly name. </param>        /// <param name="chatFriendlyName"> The chat channel&#39;s friendly name. </param>
        public CreateWebChannelOptions(string flexFlowSid, string identity, string customerFriendlyName, string chatFriendlyName)
        {
            FlexFlowSid = flexFlowSid;
            Identity = identity;
            CustomerFriendlyName = customerFriendlyName;
            ChatFriendlyName = chatFriendlyName;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (FlexFlowSid != null)
            {
                p.Add(new KeyValuePair<string, string>("FlexFlowSid", FlexFlowSid));
            }
            if (Identity != null)
            {
                p.Add(new KeyValuePair<string, string>("Identity", Identity));
            }
            if (CustomerFriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("CustomerFriendlyName", CustomerFriendlyName));
            }
            if (ChatFriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("ChatFriendlyName", ChatFriendlyName));
            }
            if (ChatUniqueName != null)
            {
                p.Add(new KeyValuePair<string, string>("ChatUniqueName", ChatUniqueName));
            }
            if (PreEngagementData != null)
            {
                p.Add(new KeyValuePair<string, string>("PreEngagementData", PreEngagementData));
            }
            return p;
        }
        

    }
    /// <summary> delete </summary>
    public class DeleteWebChannelOptions : IOptions<WebChannelResource>
    {
        
        ///<summary> The SID of the WebChannel resource to delete. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new DeleteWebChannelOptions </summary>
        /// <param name="pathSid"> The SID of the WebChannel resource to delete. </param>
        public DeleteWebChannelOptions(string pathSid)
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


    /// <summary> fetch </summary>
    public class FetchWebChannelOptions : IOptions<WebChannelResource>
    {
    
        ///<summary> The SID of the WebChannel resource to fetch. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new FetchWebChannelOptions </summary>
        /// <param name="pathSid"> The SID of the WebChannel resource to fetch. </param>
        public FetchWebChannelOptions(string pathSid)
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


    /// <summary> read </summary>
    public class ReadWebChannelOptions : ReadOptions<WebChannelResource>
    {
    



        
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
    public class UpdateWebChannelOptions : IOptions<WebChannelResource>
    {
    
        ///<summary> The SID of the WebChannel resource to update. </summary> 
        public string PathSid { get; }

        
        public WebChannelResource.ChatStatusEnum ChatStatus { get; set; }

        ///<summary> The post-engagement data. </summary> 
        public string PostEngagementData { get; set; }



        /// <summary> Construct a new UpdateWebChannelOptions </summary>
        /// <param name="pathSid"> The SID of the WebChannel resource to update. </param>
        public UpdateWebChannelOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (ChatStatus != null)
            {
                p.Add(new KeyValuePair<string, string>("ChatStatus", ChatStatus.ToString()));
            }
            if (PostEngagementData != null)
            {
                p.Add(new KeyValuePair<string, string>("PostEngagementData", PostEngagementData));
            }
            return p;
        }
        

    }


}

