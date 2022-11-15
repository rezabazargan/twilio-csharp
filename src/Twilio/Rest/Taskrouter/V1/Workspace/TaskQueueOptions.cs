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
    public class CreateTaskQueueOptions : IOptions<TaskQueueResource>
    {
        
        ///<summary> The SID of the Workspace that the new TaskQueue belongs to. </summary> 
        public string PathWorkspaceSid { get; }

        ///<summary> A descriptive string that you create to describe the TaskQueue. For example `Support-Tier 1`, `Sales`, or `Escalation`. </summary> 
        public string FriendlyName { get; }

        ///<summary> A string that describes the Worker selection criteria for any Tasks that enter the TaskQueue. For example, `'\\\"language\\\" == \\\"spanish\\\"'`. The default value is `1==1`. If this value is empty, Tasks will wait in the TaskQueue until they are deleted or moved to another TaskQueue. For more information about Worker selection, see [Describing Worker selection criteria](https://www.twilio.com/docs/taskrouter/api/taskqueues#target-workers). </summary> 
        public string TargetWorkers { get; set; }

        ///<summary> The maximum number of Workers to reserve for the assignment of a Task in the queue. Can be an integer between 1 and 50, inclusive and defaults to 1. </summary> 
        public int? MaxReservedWorkers { get; set; }

        
        public TaskQueueResource.TaskOrderEnum TaskOrder { get; set; }

        ///<summary> The SID of the Activity to assign Workers when a task is reserved for them. </summary> 
        public string ReservationActivitySid { get; set; }

        ///<summary> The SID of the Activity to assign Workers when a task is assigned to them. </summary> 
        public string AssignmentActivitySid { get; set; }


        /// <summary> Construct a new CreateTaskQueueOptions </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace that the new TaskQueue belongs to. </param>        /// <param name="friendlyName"> A descriptive string that you create to describe the TaskQueue. For example &#x60;Support-Tier 1&#x60;, &#x60;Sales&#x60;, or &#x60;Escalation&#x60;. </param>
        public CreateTaskQueueOptions(string pathWorkspaceSid, string friendlyName)
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
            if (TargetWorkers != null)
            {
                p.Add(new KeyValuePair<string, string>("TargetWorkers", TargetWorkers));
            }
            if (MaxReservedWorkers != null)
            {
                p.Add(new KeyValuePair<string, string>("MaxReservedWorkers", MaxReservedWorkers.ToString()));
            }
            if (TaskOrder != null)
            {
                p.Add(new KeyValuePair<string, string>("TaskOrder", TaskOrder.ToString()));
            }
            if (ReservationActivitySid != null)
            {
                p.Add(new KeyValuePair<string, string>("ReservationActivitySid", ReservationActivitySid));
            }
            if (AssignmentActivitySid != null)
            {
                p.Add(new KeyValuePair<string, string>("AssignmentActivitySid", AssignmentActivitySid));
            }
            return p;
        }
        

    }
    /// <summary> delete </summary>
    public class DeleteTaskQueueOptions : IOptions<TaskQueueResource>
    {
        
        ///<summary> The SID of the Workspace with the TaskQueue to delete. </summary> 
        public string PathWorkspaceSid { get; }

        ///<summary> The SID of the TaskQueue resource to delete. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new DeleteTaskQueueOptions </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace with the TaskQueue to delete. </param>        /// <param name="pathSid"> The SID of the TaskQueue resource to delete. </param>
        public DeleteTaskQueueOptions(string pathWorkspaceSid, string pathSid)
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
    public class FetchTaskQueueOptions : IOptions<TaskQueueResource>
    {
    
        ///<summary> The SID of the Workspace with the TaskQueue to fetch. </summary> 
        public string PathWorkspaceSid { get; }

        ///<summary> The SID of the TaskQueue resource to fetch. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new FetchTaskQueueOptions </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace with the TaskQueue to fetch. </param>        /// <param name="pathSid"> The SID of the TaskQueue resource to fetch. </param>
        public FetchTaskQueueOptions(string pathWorkspaceSid, string pathSid)
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
    public class ReadTaskQueueOptions : ReadOptions<TaskQueueResource>
    {
    
        ///<summary> The SID of the Workspace with the TaskQueue to read. </summary> 
        public string PathWorkspaceSid { get; }

        ///<summary> The `friendly_name` of the TaskQueue resources to read. </summary> 
        public string FriendlyName { get; set; }

        ///<summary> The attributes of the Workers to read. Returns the TaskQueues with Workers that match the attributes specified in this parameter. </summary> 
        public string EvaluateWorkerAttributes { get; set; }

        ///<summary> The SID of the Worker with the TaskQueue resources to read. </summary> 
        public string WorkerSid { get; set; }

        ///<summary> Sorting parameter for TaskQueues </summary> 
        public string Ordering { get; set; }



        /// <summary> Construct a new ListTaskQueueOptions </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace with the TaskQueue to read. </param>
        public ReadTaskQueueOptions(string pathWorkspaceSid)
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
            if (EvaluateWorkerAttributes != null)
            {
                p.Add(new KeyValuePair<string, string>("EvaluateWorkerAttributes", EvaluateWorkerAttributes));
            }
            if (WorkerSid != null)
            {
                p.Add(new KeyValuePair<string, string>("WorkerSid", WorkerSid));
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
    public class UpdateTaskQueueOptions : IOptions<TaskQueueResource>
    {
    
        ///<summary> The SID of the Workspace with the TaskQueue to update. </summary> 
        public string PathWorkspaceSid { get; }

        ///<summary> The SID of the TaskQueue resource to update. </summary> 
        public string PathSid { get; }

        ///<summary> A descriptive string that you create to describe the TaskQueue. For example `Support-Tier 1`, `Sales`, or `Escalation`. </summary> 
        public string FriendlyName { get; set; }

        ///<summary> A string describing the Worker selection criteria for any Tasks that enter the TaskQueue. For example '\\\"language\\\" == \\\"spanish\\\"' If no TargetWorkers parameter is provided, Tasks will wait in the queue until they are either deleted or moved to another queue. Additional examples on how to describing Worker selection criteria below. </summary> 
        public string TargetWorkers { get; set; }

        ///<summary> The SID of the Activity to assign Workers when a task is reserved for them. </summary> 
        public string ReservationActivitySid { get; set; }

        ///<summary> The SID of the Activity to assign Workers when a task is assigned for them. </summary> 
        public string AssignmentActivitySid { get; set; }

        ///<summary> The maximum number of Workers to create reservations for the assignment of a task while in the queue. Maximum of 50. </summary> 
        public int? MaxReservedWorkers { get; set; }

        
        public TaskQueueResource.TaskOrderEnum TaskOrder { get; set; }



        /// <summary> Construct a new UpdateTaskQueueOptions </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace with the TaskQueue to update. </param>        /// <param name="pathSid"> The SID of the TaskQueue resource to update. </param>
        public UpdateTaskQueueOptions(string pathWorkspaceSid, string pathSid)
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
            if (TargetWorkers != null)
            {
                p.Add(new KeyValuePair<string, string>("TargetWorkers", TargetWorkers));
            }
            if (ReservationActivitySid != null)
            {
                p.Add(new KeyValuePair<string, string>("ReservationActivitySid", ReservationActivitySid));
            }
            if (AssignmentActivitySid != null)
            {
                p.Add(new KeyValuePair<string, string>("AssignmentActivitySid", AssignmentActivitySid));
            }
            if (MaxReservedWorkers != null)
            {
                p.Add(new KeyValuePair<string, string>("MaxReservedWorkers", MaxReservedWorkers.ToString()));
            }
            if (TaskOrder != null)
            {
                p.Add(new KeyValuePair<string, string>("TaskOrder", TaskOrder.ToString()));
            }
            return p;
        }
        

    }


}

