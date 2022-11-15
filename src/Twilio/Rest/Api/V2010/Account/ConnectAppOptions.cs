/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Api
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



namespace Twilio.Rest.Api.V2010.Account
{
    /// <summary> Delete an instance of a connect-app </summary>
    public class DeleteConnectAppOptions : IOptions<ConnectAppResource>
    {
        
        ///<summary> The Twilio-provided string that uniquely identifies the ConnectApp resource to fetch. </summary> 
        public string PathSid { get; }

        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the ConnectApp resource to fetch. </summary> 
        public string PathAccountSid { get; set; }



        /// <summary> Construct a new DeleteConnectAppOptions </summary>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the ConnectApp resource to fetch. </param>
        public DeleteConnectAppOptions(string pathSid)
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


    /// <summary> Fetch an instance of a connect-app </summary>
    public class FetchConnectAppOptions : IOptions<ConnectAppResource>
    {
    
        ///<summary> The Twilio-provided string that uniquely identifies the ConnectApp resource to fetch. </summary> 
        public string PathSid { get; }

        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the ConnectApp resource to fetch. </summary> 
        public string PathAccountSid { get; set; }



        /// <summary> Construct a new FetchConnectAppOptions </summary>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the ConnectApp resource to fetch. </param>
        public FetchConnectAppOptions(string pathSid)
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


    /// <summary> Retrieve a list of connect-apps belonging to the account used to make the request </summary>
    public class ReadConnectAppOptions : ReadOptions<ConnectAppResource>
    {
    
        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the ConnectApp resources to read. </summary> 
        public string PathAccountSid { get; set; }




        
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

    /// <summary> Update a connect-app with the specified parameters </summary>
    public class UpdateConnectAppOptions : IOptions<ConnectAppResource>
    {
    
        ///<summary> The Twilio-provided string that uniquely identifies the ConnectApp resource to update. </summary> 
        public string PathSid { get; }

        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the ConnectApp resources to update. </summary> 
        public string PathAccountSid { get; set; }

        ///<summary> The URL to redirect the user to after we authenticate the user and obtain authorization to access the Connect App. </summary> 
        public Uri AuthorizeRedirectUrl { get; set; }

        ///<summary> The company name to set for the Connect App. </summary> 
        public string CompanyName { get; set; }

        ///<summary> The HTTP method to use when calling `deauthorize_callback_url`. </summary> 
        public Twilio.Http.HttpMethod DeauthorizeCallbackMethod { get; set; }

        ///<summary> The URL to call using the `deauthorize_callback_method` to de-authorize the Connect App. </summary> 
        public Uri DeauthorizeCallbackUrl { get; set; }

        ///<summary> A description of the Connect App. </summary> 
        public string Description { get; set; }

        ///<summary> A descriptive string that you create to describe the resource. It can be up to 64 characters long. </summary> 
        public string FriendlyName { get; set; }

        ///<summary> A public URL where users can obtain more information about this Connect App. </summary> 
        public Uri HomepageUrl { get; set; }

        ///<summary> A comma-separated list of the permissions you will request from the users of this ConnectApp.  Can include: `get-all` and `post-all`. </summary> 
        public List<ConnectAppResource.PermissionEnum> Permissions { get; set; }



        /// <summary> Construct a new UpdateConnectAppOptions </summary>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the ConnectApp resource to update. </param>
        public UpdateConnectAppOptions(string pathSid)
        {
            PathSid = pathSid;
            Permissions = new List<ConnectAppResource.PermissionEnum>();
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (AuthorizeRedirectUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("AuthorizeRedirectUrl", Serializers.Url(AuthorizeRedirectUrl)));
            }
            if (CompanyName != null)
            {
                p.Add(new KeyValuePair<string, string>("CompanyName", CompanyName));
            }
            if (DeauthorizeCallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("DeauthorizeCallbackMethod", DeauthorizeCallbackMethod.ToString()));
            }
            if (DeauthorizeCallbackUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("DeauthorizeCallbackUrl", Serializers.Url(DeauthorizeCallbackUrl)));
            }
            if (Description != null)
            {
                p.Add(new KeyValuePair<string, string>("Description", Description));
            }
            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }
            if (HomepageUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("HomepageUrl", Serializers.Url(HomepageUrl)));
            }
            if (Permissions != null)
            {
                p.AddRange(Permissions.Select(Permissions => new KeyValuePair<string, string>("Permissions", Permissions.ToString())));
            }
            return p;
        }
        

    }


}

