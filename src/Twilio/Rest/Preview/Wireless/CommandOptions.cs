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




namespace Twilio.Rest.Preview.Wireless
{

    /// <summary> create </summary>
    public class CreateCommandOptions : IOptions<CommandResource>
    {
        
        
        public string Command { get; }

        
        public string Device { get; set; }

        
        public string Sim { get; set; }

        
        public string CallbackMethod { get; set; }

        
        public Uri CallbackUrl { get; set; }

        
        public string CommandMode { get; set; }

        
        public string IncludeSid { get; set; }


        /// <summary> Construct a new CreateWirelessCommandOptions </summary>
        /// <param name="command">  </param>
        public CreateCommandOptions(string command)
        {
            Command = command;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (Command != null)
            {
                p.Add(new KeyValuePair<string, string>("Command", Command));
            }
            if (Device != null)
            {
                p.Add(new KeyValuePair<string, string>("Device", Device));
            }
            if (Sim != null)
            {
                p.Add(new KeyValuePair<string, string>("Sim", Sim));
            }
            if (CallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("CallbackMethod", CallbackMethod));
            }
            if (CallbackUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("CallbackUrl", Serializers.Url(CallbackUrl)));
            }
            if (CommandMode != null)
            {
                p.Add(new KeyValuePair<string, string>("CommandMode", CommandMode));
            }
            if (IncludeSid != null)
            {
                p.Add(new KeyValuePair<string, string>("IncludeSid", IncludeSid));
            }
            return p;
        }
        

    }
    /// <summary> fetch </summary>
    public class FetchCommandOptions : IOptions<CommandResource>
    {
    
        
        public string PathSid { get; }



        /// <summary> Construct a new FetchWirelessCommandOptions </summary>
        /// <param name="pathSid">  </param>
        public FetchCommandOptions(string pathSid)
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
    public class ReadCommandOptions : ReadOptions<CommandResource>
    {
    
        
        public string Device { get; set; }

        
        public string Sim { get; set; }

        
        public string Status { get; set; }

        
        public string Direction { get; set; }




        
        /// <summary> Generate the necessary parameters </summary>
        public  override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (Device != null)
            {
                p.Add(new KeyValuePair<string, string>("Device", Device));
            }
            if (Sim != null)
            {
                p.Add(new KeyValuePair<string, string>("Sim", Sim));
            }
            if (Status != null)
            {
                p.Add(new KeyValuePair<string, string>("Status", Status));
            }
            if (Direction != null)
            {
                p.Add(new KeyValuePair<string, string>("Direction", Direction));
            }
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }
            return p;
        }
        

    }

}

