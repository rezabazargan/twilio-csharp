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
    public class CreateWorkerOptions : IOptions<WorkerResource>
    {
        
        ///<summary> The SID of the Workspace that the new Worker belongs to. </summary> 
        public string PathWorkspaceSid { get; }

        ///<summary> A descriptive string that you create to describe the new Worker. It can be up to 64 characters long. </summary> 
        public string FriendlyName { get; }

        ///<summary> The SID of a valid Activity that will describe the new Worker's initial state. See [Activities](https://www.twilio.com/docs/taskrouter/api/activity) for more information. If not provided, the new Worker's initial state is the `default_activity_sid` configured on the Workspace. </summary> 
        public string ActivitySid { get; set; }

        ///<summary> A valid JSON string that describes the new Worker. For example: `{ \\\"email\\\": \\\"Bob@example.com\\\", \\\"phone\\\": \\\"+5095551234\\\" }`. This data is passed to the `assignment_callback_url` when TaskRouter assigns a Task to the Worker. Defaults to {}. </summary> 
        public string Attributes { get; set; }


        /// <summary> Construct a new CreateWorkerOptions </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace that the new Worker belongs to. </param>        /// <param name="friendlyName"> A descriptive string that you create to describe the new Worker. It can be up to 64 characters long. </param>
        public CreateWorkerOptions(string pathWorkspaceSid, string friendlyName)
        {
            PathWorkspaceSid = pathWorkspaceSid;
            FriendlyName = friendlyName;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }
            if (ActivitySid != null)
            {
                p.Add(new KeyValuePair<string, string>("ActivitySid", ActivitySid));
            }
            if (Attributes != null)
            {
                p.Add(new KeyValuePair<string, string>("Attributes", Attributes));
            }
            return p;
        }
        

    }
    /// <summary> delete </summary>
    public class DeleteWorkerOptions : IOptions<WorkerResource>
    {
        
        ///<summary> The SID of the Workspace with the Worker to delete. </summary> 
        public string PathWorkspaceSid { get; }

        ///<summary> The SID of the Worker resource to delete. </summary> 
        public string PathSid { get; }

        ///<summary> The If-Match HTTP request header </summary> 
        public string IfMatch { get; set; }



        /// <summary> Construct a new DeleteWorkerOptions </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace with the Worker to delete. </param>        /// <param name="pathSid"> The SID of the Worker resource to delete. </param>
        public DeleteWorkerOptions(string pathWorkspaceSid, string pathSid)
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
        
    /// <summary> Generate the necessary header parameters </summary>
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


    /// <summary> fetch </summary>
    public class FetchWorkerOptions : IOptions<WorkerResource>
    {
    
        ///<summary> The SID of the Workspace with the Worker to fetch. </summary> 
        public string PathWorkspaceSid { get; }

        ///<summary> The SID of the Worker resource to fetch. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new FetchWorkerOptions </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace with the Worker to fetch. </param>        /// <param name="pathSid"> The SID of the Worker resource to fetch. </param>
        public FetchWorkerOptions(string pathWorkspaceSid, string pathSid)
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
    public class ReadWorkerOptions : ReadOptions<WorkerResource>
    {
    
        ///<summary> The SID of the Workspace with the Workers to read. </summary> 
        public string PathWorkspaceSid { get; }

        ///<summary> The `activity_name` of the Worker resources to read. </summary> 
        public string ActivityName { get; set; }

        ///<summary> The `activity_sid` of the Worker resources to read. </summary> 
        public string ActivitySid { get; set; }

        ///<summary> Whether to return only Worker resources that are available or unavailable. Can be `true`, `1`, or `yes` to return Worker resources that are available, and `false`, or any value returns the Worker resources that are not available. </summary> 
        public string Available { get; set; }

        ///<summary> The `friendly_name` of the Worker resources to read. </summary> 
        public string FriendlyName { get; set; }

        ///<summary> Filter by Workers that would match an expression on a TaskQueue. This is helpful for debugging which Workers would match a potential queue. </summary> 
        public string TargetWorkersExpression { get; set; }

        ///<summary> The `friendly_name` of the TaskQueue that the Workers to read are eligible for. </summary> 
        public string TaskQueueName { get; set; }

        ///<summary> The SID of the TaskQueue that the Workers to read are eligible for. </summary> 
        public string TaskQueueSid { get; set; }

        ///<summary> Sorting parameter for Workers </summary> 
        public string Ordering { get; set; }



        /// <summary> Construct a new ListWorkerOptions </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace with the Workers to read. </param>
        public ReadWorkerOptions(string pathWorkspaceSid)
        {
            PathWorkspaceSid = pathWorkspaceSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (ActivityName != null)
            {
                p.Add(new KeyValuePair<string, string>("ActivityName", ActivityName));
            }
            if (ActivitySid != null)
            {
                p.Add(new KeyValuePair<string, string>("ActivitySid", ActivitySid));
            }
            if (Available != null)
            {
                p.Add(new KeyValuePair<string, string>("Available", Available));
            }
            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }
            if (TargetWorkersExpression != null)
            {
                p.Add(new KeyValuePair<string, string>("TargetWorkersExpression", TargetWorkersExpression));
            }
            if (TaskQueueName != null)
            {
                p.Add(new KeyValuePair<string, string>("TaskQueueName", TaskQueueName));
            }
            if (TaskQueueSid != null)
            {
                p.Add(new KeyValuePair<string, string>("TaskQueueSid", TaskQueueSid));
            }
            if (Ordering != null)
            {
                p.Add(new KeyValuePair<string, string>("Ordering", Ordering));
            }
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }
            return p;
        }
        

    }

    /// <summary> update </summary>
    public class UpdateWorkerOptions : IOptions<WorkerResource>
    {
    
        ///<summary> The SID of the Workspace with the Worker to update. </summary> 
        public string PathWorkspaceSid { get; }

        ///<summary> The SID of the Worker resource to update. </summary> 
        public string PathSid { get; }

        ///<summary> The If-Match HTTP request header </summary> 
        public string IfMatch { get; set; }

        ///<summary> The SID of a valid Activity that will describe the Worker's initial state. See [Activities](https://www.twilio.com/docs/taskrouter/api/activity) for more information. </summary> 
        public string ActivitySid { get; set; }

        ///<summary> The JSON string that describes the Worker. For example: `{ \\\"email\\\": \\\"Bob@example.com\\\", \\\"phone\\\": \\\"+5095551234\\\" }`. This data is passed to the `assignment_callback_url` when TaskRouter assigns a Task to the Worker. Defaults to {}. </summary> 
        public string Attributes { get; set; }

        ///<summary> A descriptive string that you create to describe the Worker. It can be up to 64 characters long. </summary> 
        public string FriendlyName { get; set; }

        ///<summary> Whether to reject the Worker's pending reservations. This option is only valid if the Worker's new [Activity](https://www.twilio.com/docs/taskrouter/api/activity) resource has its `availability` property set to `False`. </summary> 
        public bool? RejectPendingReservations { get; set; }



        /// <summary> Construct a new UpdateWorkerOptions </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace with the Worker to update. </param>        /// <param name="pathSid"> The SID of the Worker resource to update. </param>
        public UpdateWorkerOptions(string pathWorkspaceSid, string pathSid)
        {
            PathWorkspaceSid = pathWorkspaceSid;
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (ActivitySid != null)
            {
                p.Add(new KeyValuePair<string, string>("ActivitySid", ActivitySid));
            }
            if (Attributes != null)
            {
                p.Add(new KeyValuePair<string, string>("Attributes", Attributes));
            }
            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }
            if (RejectPendingReservations != null)
            {
                p.Add(new KeyValuePair<string, string>("RejectPendingReservations", RejectPendingReservations.Value.ToString().ToLower()));
            }
            return p;
        }
        
    /// <summary> Generate the necessary header parameters </summary>
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

