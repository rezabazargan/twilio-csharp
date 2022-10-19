/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Preview
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




namespace Twilio.Rest.Preview.Understand.Assistant
{

    /// <summary> create </summary>
    public class CreateTaskOptions : IOptions<TaskResource>
    {
        
        ///<summary> The unique ID of the Assistant. </summary> 
        public string PathAssistantSid { get; }

        ///<summary> A user-provided string that uniquely identifies this resource as an alternative to the sid. Unique up to 64 characters long. </summary> 
        public string UniqueName { get; }

        ///<summary> A user-provided string that identifies this resource. It is non-unique and can up to 255 characters long. </summary> 
        public string FriendlyName { get; set; }

        ///<summary> A user-provided JSON object encoded as a string to specify the actions for this task. It is optional and non-unique. </summary> 
        public object Actions { get; set; }

        ///<summary> User-provided HTTP endpoint where from the assistant fetches actions </summary> 
        public Uri ActionsUrl { get; set; }


        /// <summary> Construct a new CreateUnderstandTaskOptions </summary>
        /// <param name="pathAssistantSid"> The unique ID of the Assistant. </param>        /// <param name="uniqueName"> A user-provided string that uniquely identifies this resource as an alternative to the sid. Unique up to 64 characters long. </param>
        public CreateTaskOptions(string pathAssistantSid, string uniqueName)
        {
            PathAssistantSid = pathAssistantSid;
            UniqueName = uniqueName;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (UniqueName != null)
            {
                p.Add(new KeyValuePair<string, string>("UniqueName", UniqueName));
            }
            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }
            if (Actions != null)
            {
                p.Add(new KeyValuePair<string, string>("Actions", Serializers.JsonObject(Actions)));
            }
            if (ActionsUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("ActionsUrl", Serializers.Url(ActionsUrl)));
            }
            return p;
        }
        

    }
    /// <summary> delete </summary>
    public class DeleteTaskOptions : IOptions<TaskResource>
    {
        
        ///<summary> The unique ID of the Assistant. </summary> 
        public string PathAssistantSid { get; }

        ///<summary> A 34 character string that uniquely identifies this resource. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new DeleteUnderstandTaskOptions </summary>
        /// <param name="pathAssistantSid"> The unique ID of the Assistant. </param>        /// <param name="pathSid"> A 34 character string that uniquely identifies this resource. </param>
        public DeleteTaskOptions(string pathAssistantSid, string pathSid)
        {
            PathAssistantSid = pathAssistantSid;
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
    public class FetchTaskOptions : IOptions<TaskResource>
    {
    
        ///<summary> The unique ID of the Assistant. </summary> 
        public string PathAssistantSid { get; }

        ///<summary> A 34 character string that uniquely identifies this resource. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new FetchUnderstandTaskOptions </summary>
        /// <param name="pathAssistantSid"> The unique ID of the Assistant. </param>        /// <param name="pathSid"> A 34 character string that uniquely identifies this resource. </param>
        public FetchTaskOptions(string pathAssistantSid, string pathSid)
        {
            PathAssistantSid = pathAssistantSid;
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
    public class ReadTaskOptions : ReadOptions<TaskResource>
    {
    
        ///<summary> The unique ID of the Assistant. </summary> 
        public string PathAssistantSid { get; }



        /// <summary> Construct a new ListUnderstandTaskOptions </summary>
        /// <param name="pathAssistantSid"> The unique ID of the Assistant. </param>
        public ReadTaskOptions(string pathAssistantSid)
        {
            PathAssistantSid = pathAssistantSid;
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

    /// <summary> update </summary>
    public class UpdateTaskOptions : IOptions<TaskResource>
    {
    
        ///<summary> The unique ID of the Assistant. </summary> 
        public string PathAssistantSid { get; }

        ///<summary> A 34 character string that uniquely identifies this resource. </summary> 
        public string PathSid { get; }

        ///<summary> A user-provided string that identifies this resource. It is non-unique and can up to 255 characters long. </summary> 
        public string FriendlyName { get; set; }

        ///<summary> A user-provided string that uniquely identifies this resource as an alternative to the sid. Unique up to 64 characters long. </summary> 
        public string UniqueName { get; set; }

        ///<summary> A user-provided JSON object encoded as a string to specify the actions for this task. It is optional and non-unique. </summary> 
        public object Actions { get; set; }

        ///<summary> User-provided HTTP endpoint where from the assistant fetches actions </summary> 
        public Uri ActionsUrl { get; set; }



        /// <summary> Construct a new UpdateUnderstandTaskOptions </summary>
        /// <param name="pathAssistantSid"> The unique ID of the Assistant. </param>        /// <param name="pathSid"> A 34 character string that uniquely identifies this resource. </param>
        public UpdateTaskOptions(string pathAssistantSid, string pathSid)
        {
            PathAssistantSid = pathAssistantSid;
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
            if (UniqueName != null)
            {
                p.Add(new KeyValuePair<string, string>("UniqueName", UniqueName));
            }
            if (Actions != null)
            {
                p.Add(new KeyValuePair<string, string>("Actions", Serializers.JsonObject(Actions)));
            }
            if (ActionsUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("ActionsUrl", Serializers.Url(ActionsUrl)));
            }
            return p;
        }
        

    }


}

