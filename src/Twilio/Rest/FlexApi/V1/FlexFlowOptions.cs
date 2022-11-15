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
    public class CreateFlexFlowOptions : IOptions<FlexFlowResource>
    {
        
        ///<summary> A descriptive string that you create to describe the Flex Flow resource. </summary> 
        public string FriendlyName { get; }

        ///<summary> The SID of the chat service. </summary> 
        public string ChatServiceSid { get; }

        
        public FlexFlowResource.ChannelTypeEnum ChannelType { get; }

        ///<summary> The channel contact's Identity. </summary> 
        public string ContactIdentity { get; set; }

        ///<summary> Whether the new Flex Flow is enabled. </summary> 
        public bool? Enabled { get; set; }

        
        public FlexFlowResource.IntegrationTypeEnum IntegrationType { get; set; }

        ///<summary> The SID of the Studio Flow. Required when `integrationType` is `studio`. </summary> 
        public string IntegrationFlowSid { get; set; }

        ///<summary> The URL of the external webhook. Required when `integrationType` is `external`. </summary> 
        public Uri IntegrationUrl { get; set; }

        ///<summary> The Workspace SID for a new Task. Required when `integrationType` is `task`. </summary> 
        public string IntegrationWorkspaceSid { get; set; }

        ///<summary> The Workflow SID for a new Task. Required when `integrationType` is `task`. </summary> 
        public string IntegrationWorkflowSid { get; set; }

        ///<summary> The Task Channel SID (TCXXXX) or unique name (e.g., `sms`) to use for the Task that will be created. Applicable and required when `integrationType` is `task`. The default value is `default`. </summary> 
        public string IntegrationChannel { get; set; }

        ///<summary> The Task timeout in seconds for a new Task. Default is 86,400 seconds (24 hours). Optional when `integrationType` is `task`, not applicable otherwise. </summary> 
        public int? IntegrationTimeout { get; set; }

        ///<summary> The Task priority of a new Task. The default priority is 0. Optional when `integrationType` is `task`, not applicable otherwise. </summary> 
        public int? IntegrationPriority { get; set; }

        ///<summary> In the context of outbound messaging, defines whether to create a Task immediately (and therefore reserve the conversation to current agent), or delay Task creation until the customer sends the first response. Set to false to create immediately, true to delay Task creation. This setting is only applicable for outbound messaging. </summary> 
        public bool? IntegrationCreationOnMessage { get; set; }

        ///<summary> When enabled, Flex will keep the chat channel active so that it may be used for subsequent interactions with a contact identity. Defaults to `false`. </summary> 
        public bool? LongLived { get; set; }

        ///<summary> When enabled, the Messaging Channel Janitor will remove active Proxy sessions if the associated Task is deleted outside of the Flex UI. Defaults to `false`. </summary> 
        public bool? JanitorEnabled { get; set; }

        ///<summary> The number of times to retry the Studio Flow or webhook in case of failure. Takes integer values from 0 to 3 with the default being 3. Optional when `integrationType` is `studio` or `external`, not applicable otherwise. </summary> 
        public int? IntegrationRetryCount { get; set; }


        /// <summary> Construct a new CreateFlexFlowOptions </summary>
        /// <param name="friendlyName"> A descriptive string that you create to describe the Flex Flow resource. </param>        /// <param name="chatServiceSid"> The SID of the chat service. </param>        /// <param name="channelType">  </param>
        public CreateFlexFlowOptions(string friendlyName, string chatServiceSid, FlexFlowResource.ChannelTypeEnum channelType)
        {
            FriendlyName = friendlyName;
            ChatServiceSid = chatServiceSid;
            ChannelType = channelType;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }
            if (ChatServiceSid != null)
            {
                p.Add(new KeyValuePair<string, string>("ChatServiceSid", ChatServiceSid));
            }
            if (ChannelType != null)
            {
                p.Add(new KeyValuePair<string, string>("ChannelType", ChannelType.ToString()));
            }
            if (ContactIdentity != null)
            {
                p.Add(new KeyValuePair<string, string>("ContactIdentity", ContactIdentity));
            }
            if (Enabled != null)
            {
                p.Add(new KeyValuePair<string, string>("Enabled", Enabled.Value.ToString().ToLower()));
            }
            if (IntegrationType != null)
            {
                p.Add(new KeyValuePair<string, string>("IntegrationType", IntegrationType.ToString()));
            }
            if (IntegrationFlowSid != null)
            {
                p.Add(new KeyValuePair<string, string>("IntegrationFlowSid", IntegrationFlowSid));
            }
            if (IntegrationUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("IntegrationUrl", Serializers.Url(IntegrationUrl)));
            }
            if (IntegrationWorkspaceSid != null)
            {
                p.Add(new KeyValuePair<string, string>("IntegrationWorkspaceSid", IntegrationWorkspaceSid));
            }
            if (IntegrationWorkflowSid != null)
            {
                p.Add(new KeyValuePair<string, string>("IntegrationWorkflowSid", IntegrationWorkflowSid));
            }
            if (IntegrationChannel != null)
            {
                p.Add(new KeyValuePair<string, string>("IntegrationChannel", IntegrationChannel));
            }
            if (IntegrationTimeout != null)
            {
                p.Add(new KeyValuePair<string, string>("IntegrationTimeout", IntegrationTimeout.ToString()));
            }
            if (IntegrationPriority != null)
            {
                p.Add(new KeyValuePair<string, string>("IntegrationPriority", IntegrationPriority.ToString()));
            }
            if (IntegrationCreationOnMessage != null)
            {
                p.Add(new KeyValuePair<string, string>("IntegrationCreationOnMessage", IntegrationCreationOnMessage.Value.ToString().ToLower()));
            }
            if (LongLived != null)
            {
                p.Add(new KeyValuePair<string, string>("LongLived", LongLived.Value.ToString().ToLower()));
            }
            if (JanitorEnabled != null)
            {
                p.Add(new KeyValuePair<string, string>("JanitorEnabled", JanitorEnabled.Value.ToString().ToLower()));
            }
            if (IntegrationRetryCount != null)
            {
                p.Add(new KeyValuePair<string, string>("IntegrationRetryCount", IntegrationRetryCount.ToString()));
            }
            return p;
        }
        

    }
    /// <summary> delete </summary>
    public class DeleteFlexFlowOptions : IOptions<FlexFlowResource>
    {
        
        ///<summary> The SID of the Flex Flow resource to delete. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new DeleteFlexFlowOptions </summary>
        /// <param name="pathSid"> The SID of the Flex Flow resource to delete. </param>
        public DeleteFlexFlowOptions(string pathSid)
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
    public class FetchFlexFlowOptions : IOptions<FlexFlowResource>
    {
    
        ///<summary> The SID of the Flex Flow resource to fetch. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new FetchFlexFlowOptions </summary>
        /// <param name="pathSid"> The SID of the Flex Flow resource to fetch. </param>
        public FetchFlexFlowOptions(string pathSid)
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
    public class ReadFlexFlowOptions : ReadOptions<FlexFlowResource>
    {
    
        ///<summary> The `friendly_name` of the Flex Flow resources to read. </summary> 
        public string FriendlyName { get; set; }




        
        /// <summary> Generate the necessary parameters </summary>
        public  override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }
            return p;
        }
        

    }

    /// <summary> update </summary>
    public class UpdateFlexFlowOptions : IOptions<FlexFlowResource>
    {
    
        ///<summary> The SID of the Flex Flow resource to update. </summary> 
        public string PathSid { get; }

        ///<summary> A descriptive string that you create to describe the Flex Flow resource. </summary> 
        public string FriendlyName { get; set; }

        ///<summary> The SID of the chat service. </summary> 
        public string ChatServiceSid { get; set; }

        
        public FlexFlowResource.ChannelTypeEnum ChannelType { get; set; }

        ///<summary> The channel contact's Identity. </summary> 
        public string ContactIdentity { get; set; }

        ///<summary> Whether the new Flex Flow is enabled. </summary> 
        public bool? Enabled { get; set; }

        
        public FlexFlowResource.IntegrationTypeEnum IntegrationType { get; set; }

        ///<summary> The SID of the Studio Flow. Required when `integrationType` is `studio`. </summary> 
        public string IntegrationFlowSid { get; set; }

        ///<summary> The URL of the external webhook. Required when `integrationType` is `external`. </summary> 
        public Uri IntegrationUrl { get; set; }

        ///<summary> The Workspace SID for a new Task. Required when `integrationType` is `task`. </summary> 
        public string IntegrationWorkspaceSid { get; set; }

        ///<summary> The Workflow SID for a new Task. Required when `integrationType` is `task`. </summary> 
        public string IntegrationWorkflowSid { get; set; }

        ///<summary> The Task Channel SID (TCXXXX) or unique name (e.g., `sms`) to use for the Task that will be created. Applicable and required when `integrationType` is `task`. The default value is `default`. </summary> 
        public string IntegrationChannel { get; set; }

        ///<summary> The Task timeout in seconds for a new Task. Default is 86,400 seconds (24 hours). Optional when `integrationType` is `task`, not applicable otherwise. </summary> 
        public int? IntegrationTimeout { get; set; }

        ///<summary> The Task priority of a new Task. The default priority is 0. Optional when `integrationType` is `task`, not applicable otherwise. </summary> 
        public int? IntegrationPriority { get; set; }

        ///<summary> In the context of outbound messaging, defines whether to create a Task immediately (and therefore reserve the conversation to current agent), or delay Task creation until the customer sends the first response. Set to false to create immediately, true to delay Task creation. This setting is only applicable for outbound messaging. </summary> 
        public bool? IntegrationCreationOnMessage { get; set; }

        ///<summary> When enabled, Flex will keep the chat channel active so that it may be used for subsequent interactions with a contact identity. Defaults to `false`. </summary> 
        public bool? LongLived { get; set; }

        ///<summary> When enabled, the Messaging Channel Janitor will remove active Proxy sessions if the associated Task is deleted outside of the Flex UI. Defaults to `false`. </summary> 
        public bool? JanitorEnabled { get; set; }

        ///<summary> The number of times to retry the Studio Flow or webhook in case of failure. Takes integer values from 0 to 3 with the default being 3. Optional when `integrationType` is `studio` or `external`, not applicable otherwise. </summary> 
        public int? IntegrationRetryCount { get; set; }



        /// <summary> Construct a new UpdateFlexFlowOptions </summary>
        /// <param name="pathSid"> The SID of the Flex Flow resource to update. </param>
        public UpdateFlexFlowOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }
            if (ChatServiceSid != null)
            {
                p.Add(new KeyValuePair<string, string>("ChatServiceSid", ChatServiceSid));
            }
            if (ChannelType != null)
            {
                p.Add(new KeyValuePair<string, string>("ChannelType", ChannelType.ToString()));
            }
            if (ContactIdentity != null)
            {
                p.Add(new KeyValuePair<string, string>("ContactIdentity", ContactIdentity));
            }
            if (Enabled != null)
            {
                p.Add(new KeyValuePair<string, string>("Enabled", Enabled.Value.ToString().ToLower()));
            }
            if (IntegrationType != null)
            {
                p.Add(new KeyValuePair<string, string>("IntegrationType", IntegrationType.ToString()));
            }
            if (IntegrationFlowSid != null)
            {
                p.Add(new KeyValuePair<string, string>("IntegrationFlowSid", IntegrationFlowSid));
            }
            if (IntegrationUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("IntegrationUrl", Serializers.Url(IntegrationUrl)));
            }
            if (IntegrationWorkspaceSid != null)
            {
                p.Add(new KeyValuePair<string, string>("IntegrationWorkspaceSid", IntegrationWorkspaceSid));
            }
            if (IntegrationWorkflowSid != null)
            {
                p.Add(new KeyValuePair<string, string>("IntegrationWorkflowSid", IntegrationWorkflowSid));
            }
            if (IntegrationChannel != null)
            {
                p.Add(new KeyValuePair<string, string>("IntegrationChannel", IntegrationChannel));
            }
            if (IntegrationTimeout != null)
            {
                p.Add(new KeyValuePair<string, string>("IntegrationTimeout", IntegrationTimeout.ToString()));
            }
            if (IntegrationPriority != null)
            {
                p.Add(new KeyValuePair<string, string>("IntegrationPriority", IntegrationPriority.ToString()));
            }
            if (IntegrationCreationOnMessage != null)
            {
                p.Add(new KeyValuePair<string, string>("IntegrationCreationOnMessage", IntegrationCreationOnMessage.Value.ToString().ToLower()));
            }
            if (LongLived != null)
            {
                p.Add(new KeyValuePair<string, string>("LongLived", LongLived.Value.ToString().ToLower()));
            }
            if (JanitorEnabled != null)
            {
                p.Add(new KeyValuePair<string, string>("JanitorEnabled", JanitorEnabled.Value.ToString().ToLower()));
            }
            if (IntegrationRetryCount != null)
            {
                p.Add(new KeyValuePair<string, string>("IntegrationRetryCount", IntegrationRetryCount.ToString()));
            }
            return p;
        }
        

    }


}

