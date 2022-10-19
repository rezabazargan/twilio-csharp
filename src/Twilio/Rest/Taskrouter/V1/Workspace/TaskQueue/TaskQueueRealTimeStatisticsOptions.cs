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




namespace Twilio.Rest.Taskrouter.V1.Workspace.TaskQueue
{
    /// <summary> fetch </summary>
    public class FetchTaskQueueRealTimeStatisticsOptions : IOptions<TaskQueueRealTimeStatisticsResource>
    {
    
        ///<summary> The SID of the Workspace with the TaskQueue to fetch. </summary> 
        public string PathWorkspaceSid { get; }

        ///<summary> The SID of the TaskQueue for which to fetch statistics. </summary> 
        public string PathTaskQueueSid { get; }

        ///<summary> The TaskChannel for which to fetch statistics. Can be the TaskChannel's SID or its `unique_name`, such as `voice`, `sms`, or `default`. </summary> 
        public string TaskChannel { get; set; }



        /// <summary> Construct a new FetchTaskQueueRealTimeStatisticsOptions </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace with the TaskQueue to fetch. </param>        /// <param name="pathTaskQueueSid"> The SID of the TaskQueue for which to fetch statistics. </param>
        public FetchTaskQueueRealTimeStatisticsOptions(string pathWorkspaceSid, string pathTaskQueueSid)
        {
            PathWorkspaceSid = pathWorkspaceSid;
            PathTaskQueueSid = pathTaskQueueSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (TaskChannel != null)
            {
                p.Add(new KeyValuePair<string, string>("TaskChannel", TaskChannel));
            }
            return p;
        }
        

    }


}

