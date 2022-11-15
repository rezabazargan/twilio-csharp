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




namespace Twilio.Rest.IpMessaging.V2.Service.User
{
    /// <summary> delete </summary>
    public class DeleteUserChannelOptions : IOptions<UserChannelResource>
    {
        
        
        public string PathServiceSid { get; }

        
        public string PathUserSid { get; }

        
        public string PathChannelSid { get; }



        /// <summary> Construct a new DeleteUserChannelOptions </summary>
        /// <param name="pathServiceSid">  </param>        /// <param name="pathUserSid">  </param>        /// <param name="pathChannelSid">  </param>
        public DeleteUserChannelOptions(string pathServiceSid, string pathUserSid, string pathChannelSid)
        {
            PathServiceSid = pathServiceSid;
            PathUserSid = pathUserSid;
            PathChannelSid = pathChannelSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }


    /// <summary> fetch </summary>
    public class FetchUserChannelOptions : IOptions<UserChannelResource>
    {
    
        
        public string PathServiceSid { get; }

        
        public string PathUserSid { get; }

        
        public string PathChannelSid { get; }



        /// <summary> Construct a new FetchUserChannelOptions </summary>
        /// <param name="pathServiceSid">  </param>        /// <param name="pathUserSid">  </param>        /// <param name="pathChannelSid">  </param>
        public FetchUserChannelOptions(string pathServiceSid, string pathUserSid, string pathChannelSid)
        {
            PathServiceSid = pathServiceSid;
            PathUserSid = pathUserSid;
            PathChannelSid = pathChannelSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }


    /// <summary> read </summary>
    public class ReadUserChannelOptions : ReadOptions<UserChannelResource>
    {
    
        
        public string PathServiceSid { get; }

        
        public string PathUserSid { get; }



        /// <summary> Construct a new ListUserChannelOptions </summary>
        /// <param name="pathServiceSid">  </param>        /// <param name="pathUserSid">  </param>
        public ReadUserChannelOptions(string pathServiceSid, string pathUserSid)
        {
            PathServiceSid = pathServiceSid;
            PathUserSid = pathUserSid;
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
    public class UpdateUserChannelOptions : IOptions<UserChannelResource>
    {
    
        
        public string PathServiceSid { get; }

        
        public string PathUserSid { get; }

        
        public string PathChannelSid { get; }

        
        public UserChannelResource.NotificationLevelEnum NotificationLevel { get; set; }

        
        public int? LastConsumedMessageIndex { get; set; }

        
        public DateTime? LastConsumptionTimestamp { get; set; }



        /// <summary> Construct a new UpdateUserChannelOptions </summary>
        /// <param name="pathServiceSid">  </param>        /// <param name="pathUserSid">  </param>        /// <param name="pathChannelSid">  </param>
        public UpdateUserChannelOptions(string pathServiceSid, string pathUserSid, string pathChannelSid)
        {
            PathServiceSid = pathServiceSid;
            PathUserSid = pathUserSid;
            PathChannelSid = pathChannelSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (NotificationLevel != null)
            {
                p.Add(new KeyValuePair<string, string>("NotificationLevel", NotificationLevel.ToString()));
            }
            if (LastConsumedMessageIndex != null)
            {
                p.Add(new KeyValuePair<string, string>("LastConsumedMessageIndex", LastConsumedMessageIndex.ToString()));
            }
            if (LastConsumptionTimestamp != null)
            {
                p.Add(new KeyValuePair<string, string>("LastConsumptionTimestamp", Serializers.DateTimeIso8601(LastConsumptionTimestamp)));
            }
            return p;
        }
        

    }


}

