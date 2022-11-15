/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Verify
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




namespace Twilio.Rest.Verify.V2.Service.Entity
{
    /// <summary> Delete a specific Factor. </summary>
    public class DeleteFactorOptions : IOptions<FactorResource>
    {
        
        ///<summary> The unique SID identifier of the Service. </summary> 
        public string PathServiceSid { get; }

        ///<summary> Customer unique identity for the Entity owner of the Factor. This identifier should be immutable, not PII, length between 8 and 64 characters, and generated by your external system, such as your user's UUID, GUID, or SID. It can only contain dash (-) separated alphanumeric characters. </summary> 
        public string PathIdentity { get; }

        ///<summary> A 34 character string that uniquely identifies this Factor. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new DeleteFactorOptions </summary>
        /// <param name="pathServiceSid"> The unique SID identifier of the Service. </param>        /// <param name="pathIdentity"> Customer unique identity for the Entity owner of the Factor. This identifier should be immutable, not PII, length between 8 and 64 characters, and generated by your external system, such as your user&#39;s UUID, GUID, or SID. It can only contain dash (-) separated alphanumeric characters. </param>        /// <param name="pathSid"> A 34 character string that uniquely identifies this Factor. </param>
        public DeleteFactorOptions(string pathServiceSid, string pathIdentity, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathIdentity = pathIdentity;
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }


    /// <summary> Fetch a specific Factor. </summary>
    public class FetchFactorOptions : IOptions<FactorResource>
    {
    
        ///<summary> The unique SID identifier of the Service. </summary> 
        public string PathServiceSid { get; }

        ///<summary> Customer unique identity for the Entity owner of the Factor. This identifier should be immutable, not PII, length between 8 and 64 characters, and generated by your external system, such as your user's UUID, GUID, or SID. It can only contain dash (-) separated alphanumeric characters. </summary> 
        public string PathIdentity { get; }

        ///<summary> A 34 character string that uniquely identifies this Factor. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new FetchFactorOptions </summary>
        /// <param name="pathServiceSid"> The unique SID identifier of the Service. </param>        /// <param name="pathIdentity"> Customer unique identity for the Entity owner of the Factor. This identifier should be immutable, not PII, length between 8 and 64 characters, and generated by your external system, such as your user&#39;s UUID, GUID, or SID. It can only contain dash (-) separated alphanumeric characters. </param>        /// <param name="pathSid"> A 34 character string that uniquely identifies this Factor. </param>
        public FetchFactorOptions(string pathServiceSid, string pathIdentity, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathIdentity = pathIdentity;
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }


    /// <summary> Retrieve a list of all Factors for an Entity. </summary>
    public class ReadFactorOptions : ReadOptions<FactorResource>
    {
    
        ///<summary> The unique SID identifier of the Service. </summary> 
        public string PathServiceSid { get; }

        ///<summary> Customer unique identity for the Entity owner of the Factors. This identifier should be immutable, not PII, length between 8 and 64 characters, and generated by your external system, such as your user's UUID, GUID, or SID. It can only contain dash (-) separated alphanumeric characters. </summary> 
        public string PathIdentity { get; }



        /// <summary> Construct a new ListFactorOptions </summary>
        /// <param name="pathServiceSid"> The unique SID identifier of the Service. </param>        /// <param name="pathIdentity"> Customer unique identity for the Entity owner of the Factors. This identifier should be immutable, not PII, length between 8 and 64 characters, and generated by your external system, such as your user&#39;s UUID, GUID, or SID. It can only contain dash (-) separated alphanumeric characters. </param>
        public ReadFactorOptions(string pathServiceSid, string pathIdentity)
        {
            PathServiceSid = pathServiceSid;
            PathIdentity = pathIdentity;
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

    /// <summary> Update a specific Factor. This endpoint can be used to Verify a Factor if passed an &#x60;AuthPayload&#x60; param. </summary>
    public class UpdateFactorOptions : IOptions<FactorResource>
    {
    
        ///<summary> The unique SID identifier of the Service. </summary> 
        public string PathServiceSid { get; }

        ///<summary> Customer unique identity for the Entity owner of the Factor. This identifier should be immutable, not PII, length between 8 and 64 characters, and generated by your external system, such as your user's UUID, GUID, or SID. It can only contain dash (-) separated alphanumeric characters. </summary> 
        public string PathIdentity { get; }

        ///<summary> A 34 character string that uniquely identifies this Factor. </summary> 
        public string PathSid { get; }

        ///<summary> The optional payload needed to verify the Factor for the first time. E.g. for a TOTP, the numeric code. </summary> 
        public string AuthPayload { get; set; }

        ///<summary> The new friendly name of this Factor. It can be up to 64 characters. </summary> 
        public string FriendlyName { get; set; }

        ///<summary> For APN, the device token. For FCM, the registration token. It is used to send the push notifications. Required when `factor_type` is `push`. If specified, this value must be between 32 and 255 characters long. </summary> 
        public string ConfigNotificationToken { get; set; }

        ///<summary> The Verify Push SDK version used to configure the factor </summary> 
        public string ConfigSdkVersion { get; set; }

        ///<summary> Defines how often, in seconds, are TOTP codes generated. i.e, a new TOTP code is generated every time_step seconds. Must be between 20 and 60 seconds, inclusive </summary> 
        public int? ConfigTimeStep { get; set; }

        ///<summary> The number of time-steps, past and future, that are valid for validation of TOTP codes. Must be between 0 and 2, inclusive </summary> 
        public int? ConfigSkew { get; set; }

        ///<summary> Number of digits for generated TOTP codes. Must be between 3 and 8, inclusive </summary> 
        public int? ConfigCodeLength { get; set; }

        
        public FactorResource.TotpAlgorithmsEnum ConfigAlg { get; set; }

        ///<summary> The transport technology used to generate the Notification Token. Can be `apn`, `fcm` or `none`.  Required when `factor_type` is `push`. </summary> 
        public string ConfigNotificationPlatform { get; set; }



        /// <summary> Construct a new UpdateFactorOptions </summary>
        /// <param name="pathServiceSid"> The unique SID identifier of the Service. </param>        /// <param name="pathIdentity"> Customer unique identity for the Entity owner of the Factor. This identifier should be immutable, not PII, length between 8 and 64 characters, and generated by your external system, such as your user&#39;s UUID, GUID, or SID. It can only contain dash (-) separated alphanumeric characters. </param>        /// <param name="pathSid"> A 34 character string that uniquely identifies this Factor. </param>
        public UpdateFactorOptions(string pathServiceSid, string pathIdentity, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathIdentity = pathIdentity;
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (AuthPayload != null)
            {
                p.Add(new KeyValuePair<string, string>("AuthPayload", AuthPayload));
            }
            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }
            if (ConfigNotificationToken != null)
            {
                p.Add(new KeyValuePair<string, string>("ConfigNotificationToken", ConfigNotificationToken));
            }
            if (ConfigSdkVersion != null)
            {
                p.Add(new KeyValuePair<string, string>("ConfigSdkVersion", ConfigSdkVersion));
            }
            if (ConfigTimeStep != null)
            {
                p.Add(new KeyValuePair<string, string>("ConfigTimeStep", ConfigTimeStep.ToString()));
            }
            if (ConfigSkew != null)
            {
                p.Add(new KeyValuePair<string, string>("ConfigSkew", ConfigSkew.ToString()));
            }
            if (ConfigCodeLength != null)
            {
                p.Add(new KeyValuePair<string, string>("ConfigCodeLength", ConfigCodeLength.ToString()));
            }
            if (ConfigAlg != null)
            {
                p.Add(new KeyValuePair<string, string>("ConfigAlg", ConfigAlg.ToString()));
            }
            if (ConfigNotificationPlatform != null)
            {
                p.Add(new KeyValuePair<string, string>("ConfigNotificationPlatform", ConfigNotificationPlatform));
            }
            return p;
        }
        

    }


}

