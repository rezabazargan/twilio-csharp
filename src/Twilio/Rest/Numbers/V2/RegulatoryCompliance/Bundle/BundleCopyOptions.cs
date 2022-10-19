/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Numbers
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




namespace Twilio.Rest.Numbers.V2.RegulatoryCompliance.Bundle
{

    /// <summary> Creates a new copy of a Bundle. It will internally create copies of all the bundle items (identities and documents) of the original bundle </summary>
    public class CreateBundleCopyOptions : IOptions<BundleCopyResource>
    {
        
        ///<summary> The unique string that identifies the Bundle to be copied. </summary> 
        public string PathBundleSid { get; }

        ///<summary> The string that you assigned to describe the copied bundle. </summary> 
        public string FriendlyName { get; set; }


        /// <summary> Construct a new CreateBundleCopyOptions </summary>
        /// <param name="pathBundleSid"> The unique string that identifies the Bundle to be copied. </param>
        public CreateBundleCopyOptions(string pathBundleSid)
        {
            PathBundleSid = pathBundleSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }
            return p;
        }
        

    }
    /// <summary> Retrieve a list of all Bundles Copies for a Bundle. </summary>
    public class ReadBundleCopyOptions : ReadOptions<BundleCopyResource>
    {
    
        ///<summary> The unique string that we created to identify the Bundle resource. </summary> 
        public string PathBundleSid { get; }



        /// <summary> Construct a new ListBundleCopyOptions </summary>
        /// <param name="pathBundleSid"> The unique string that we created to identify the Bundle resource. </param>
        public ReadBundleCopyOptions(string pathBundleSid)
        {
            PathBundleSid = pathBundleSid;
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

}

