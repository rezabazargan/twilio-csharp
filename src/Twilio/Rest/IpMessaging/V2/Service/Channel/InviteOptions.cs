/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Ip_messaging
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
using System.Linq;



namespace Twilio.Rest.IpMessaging.V2.Service.Channel
{

    /// <summary> create </summary>
    public class CreateInviteOptions : IOptions<InviteResource>
    {
        
        
        public string PathServiceSid { get; }

        
        public string PathChannelSid { get; }

        
        public string Identity { get; }

        
        public string RoleSid { get; set; }


        /// <summary> Construct a new CreateInviteOptions </summary>
        /// <param name="pathServiceSid">  </param>        /// <param name="pathChannelSid">  </param>        /// <param name="identity">  </param>
        public CreateInviteOptions(string pathServiceSid, string pathChannelSid, string identity)
        {
            PathServiceSid = pathServiceSid;
            PathChannelSid = pathChannelSid;
            Identity = identity;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (Identity != null)
            {
                p.Add(new KeyValuePair<string, string>("Identity", Identity));
            }
            if (RoleSid != null)
            {
                p.Add(new KeyValuePair<string, string>("RoleSid", RoleSid));
            }
            return p;
        }
        

    }
    /// <summary> delete </summary>
    public class DeleteInviteOptions : IOptions<InviteResource>
    {
        
        
        public string PathServiceSid { get; }

        
        public string PathChannelSid { get; }

        
        public string PathSid { get; }



        /// <summary> Construct a new DeleteInviteOptions </summary>
        /// <param name="pathServiceSid">  </param>        /// <param name="pathChannelSid">  </param>        /// <param name="pathSid">  </param>
        public DeleteInviteOptions(string pathServiceSid, string pathChannelSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathChannelSid = pathChannelSid;
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
    public class FetchInviteOptions : IOptions<InviteResource>
    {
    
        
        public string PathServiceSid { get; }

        
        public string PathChannelSid { get; }

        
        public string PathSid { get; }



        /// <summary> Construct a new FetchInviteOptions </summary>
        /// <param name="pathServiceSid">  </param>        /// <param name="pathChannelSid">  </param>        /// <param name="pathSid">  </param>
        public FetchInviteOptions(string pathServiceSid, string pathChannelSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathChannelSid = pathChannelSid;
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
    public class ReadInviteOptions : ReadOptions<InviteResource>
    {
    
        
        public string PathServiceSid { get; }

        
        public string PathChannelSid { get; }

        
        public List<string> Identity { get; set; }



        /// <summary> Construct a new ListInviteOptions </summary>
        /// <param name="pathServiceSid">  </param>        /// <param name="pathChannelSid">  </param>
        public ReadInviteOptions(string pathServiceSid, string pathChannelSid)
        {
            PathServiceSid = pathServiceSid;
            PathChannelSid = pathChannelSid;
            Identity = new List<string>();
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (Identity != null)
            {
                p.AddRange(Identity.Select(Identity => new KeyValuePair<string, string>("Identity", Identity)));
            }
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }
            return p;
        }
        

    }

}

