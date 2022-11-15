/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Taskrouter
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




namespace Twilio.Rest.Taskrouter.V1.Workspace
{

    /// <summary> create </summary>
    public class CreateWorkflowOptions : IOptions<WorkflowResource>
    {
        
        ///<summary> The SID of the Workspace that the new Workflow to create belongs to. </summary> 
        public string PathWorkspaceSid { get; }

        ///<summary> A descriptive string that you create to describe the Workflow resource. For example, `Inbound Call Workflow` or `2014 Outbound Campaign`. </summary> 
        public string FriendlyName { get; }

        ///<summary> A JSON string that contains the rules to apply to the Workflow. See [Configuring Workflows](https://www.twilio.com/docs/taskrouter/workflow-configuration) for more information. </summary> 
        public string Configuration { get; }

        ///<summary> The URL from your application that will process task assignment events. See [Handling Task Assignment Callback](https://www.twilio.com/docs/taskrouter/handle-assignment-callbacks) for more details. </summary> 
        public Uri AssignmentCallbackUrl { get; set; }

        ///<summary> The URL that we should call when a call to the `assignment_callback_url` fails. </summary> 
        public Uri FallbackAssignmentCallbackUrl { get; set; }

        ///<summary> How long TaskRouter will wait for a confirmation response from your application after it assigns a Task to a Worker. Can be up to `86,400` (24 hours) and the default is `120`. </summary> 
        public int? TaskReservationTimeout { get; set; }


        /// <summary> Construct a new CreateWorkflowOptions </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace that the new Workflow to create belongs to. </param>        /// <param name="friendlyName"> A descriptive string that you create to describe the Workflow resource. For example, &#x60;Inbound Call Workflow&#x60; or &#x60;2014 Outbound Campaign&#x60;. </param>        /// <param name="configuration"> A JSON string that contains the rules to apply to the Workflow. See [Configuring Workflows](https://www.twilio.com/docs/taskrouter/workflow-configuration) for more information. </param>
        public CreateWorkflowOptions(string pathWorkspaceSid, string friendlyName, string configuration)
        {
            PathWorkspaceSid = pathWorkspaceSid;
            FriendlyName = friendlyName;
            Configuration = configuration;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }
            if (Configuration != null)
            {
                p.Add(new KeyValuePair<string, string>("Configuration", Configuration));
            }
            if (AssignmentCallbackUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("AssignmentCallbackUrl", Serializers.Url(AssignmentCallbackUrl)));
            }
            if (FallbackAssignmentCallbackUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("FallbackAssignmentCallbackUrl", Serializers.Url(FallbackAssignmentCallbackUrl)));
            }
            if (TaskReservationTimeout != null)
            {
                p.Add(new KeyValuePair<string, string>("TaskReservationTimeout", TaskReservationTimeout.ToString()));
            }
            return p;
        }
        

    }
    /// <summary> delete </summary>
    public class DeleteWorkflowOptions : IOptions<WorkflowResource>
    {
        
        ///<summary> The SID of the Workspace with the Workflow to delete. </summary> 
        public string PathWorkspaceSid { get; }

        ///<summary> The SID of the Workflow resource to delete. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new DeleteWorkflowOptions </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace with the Workflow to delete. </param>        /// <param name="pathSid"> The SID of the Workflow resource to delete. </param>
        public DeleteWorkflowOptions(string pathWorkspaceSid, string pathSid)
        {
            PathWorkspaceSid = pathWorkspaceSid;
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
    public class FetchWorkflowOptions : IOptions<WorkflowResource>
    {
    
        ///<summary> The SID of the Workspace with the Workflow to fetch. </summary> 
        public string PathWorkspaceSid { get; }

        ///<summary> The SID of the Workflow resource to fetch. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new FetchWorkflowOptions </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace with the Workflow to fetch. </param>        /// <param name="pathSid"> The SID of the Workflow resource to fetch. </param>
        public FetchWorkflowOptions(string pathWorkspaceSid, string pathSid)
        {
            PathWorkspaceSid = pathWorkspaceSid;
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
    public class ReadWorkflowOptions : ReadOptions<WorkflowResource>
    {
    
        ///<summary> The SID of the Workspace with the Workflow to read. </summary> 
        public string PathWorkspaceSid { get; }

        ///<summary> The `friendly_name` of the Workflow resources to read. </summary> 
        public string FriendlyName { get; set; }



        /// <summary> Construct a new ListWorkflowOptions </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace with the Workflow to read. </param>
        public ReadWorkflowOptions(string pathWorkspaceSid)
        {
            PathWorkspaceSid = pathWorkspaceSid;
        }

        
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
    public class UpdateWorkflowOptions : IOptions<WorkflowResource>
    {
    
        ///<summary> The SID of the Workspace with the Workflow to update. </summary> 
        public string PathWorkspaceSid { get; }

        ///<summary> The SID of the Workflow resource to update. </summary> 
        public string PathSid { get; }

        ///<summary> A descriptive string that you create to describe the Workflow resource. For example, `Inbound Call Workflow` or `2014 Outbound Campaign`. </summary> 
        public string FriendlyName { get; set; }

        ///<summary> The URL from your application that will process task assignment events. See [Handling Task Assignment Callback](https://www.twilio.com/docs/taskrouter/handle-assignment-callbacks) for more details. </summary> 
        public Uri AssignmentCallbackUrl { get; set; }

        ///<summary> The URL that we should call when a call to the `assignment_callback_url` fails. </summary> 
        public Uri FallbackAssignmentCallbackUrl { get; set; }

        ///<summary> A JSON string that contains the rules to apply to the Workflow. See [Configuring Workflows](https://www.twilio.com/docs/taskrouter/workflow-configuration) for more information. </summary> 
        public string Configuration { get; set; }

        ///<summary> How long TaskRouter will wait for a confirmation response from your application after it assigns a Task to a Worker. Can be up to `86,400` (24 hours) and the default is `120`. </summary> 
        public int? TaskReservationTimeout { get; set; }

        ///<summary> Whether or not to re-evaluate Tasks. The default is `false`, which means Tasks in the Workflow will not be processed through the assignment loop again. </summary> 
        public string ReEvaluateTasks { get; set; }



        /// <summary> Construct a new UpdateWorkflowOptions </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace with the Workflow to update. </param>        /// <param name="pathSid"> The SID of the Workflow resource to update. </param>
        public UpdateWorkflowOptions(string pathWorkspaceSid, string pathSid)
        {
            PathWorkspaceSid = pathWorkspaceSid;
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
            if (AssignmentCallbackUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("AssignmentCallbackUrl", Serializers.Url(AssignmentCallbackUrl)));
            }
            if (FallbackAssignmentCallbackUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("FallbackAssignmentCallbackUrl", Serializers.Url(FallbackAssignmentCallbackUrl)));
            }
            if (Configuration != null)
            {
                p.Add(new KeyValuePair<string, string>("Configuration", Configuration));
            }
            if (TaskReservationTimeout != null)
            {
                p.Add(new KeyValuePair<string, string>("TaskReservationTimeout", TaskReservationTimeout.ToString()));
            }
            if (ReEvaluateTasks != null)
            {
                p.Add(new KeyValuePair<string, string>("ReEvaluateTasks", ReEvaluateTasks));
            }
            return p;
        }
        

    }


}

