/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Trunking
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




namespace Twilio.Rest.Trunking.V1.Trunk
{

    /// <summary> create </summary>
    public class CreatePhoneNumberOptions : IOptions<PhoneNumberResource>
    {
        
        ///<summary> The SID of the Trunk to associate the phone number with. </summary> 
        public string PathTrunkSid { get; }

        ///<summary> The SID of the [Incoming Phone Number](https://www.twilio.com/docs/phone-numbers/api/incomingphonenumber-resource) that you want to associate with the trunk. </summary> 
        public string PhoneNumberSid { get; }


        /// <summary> Construct a new CreatePhoneNumberOptions </summary>
        /// <param name="pathTrunkSid"> The SID of the Trunk to associate the phone number with. </param>        /// <param name="phoneNumberSid"> The SID of the [Incoming Phone Number](https://www.twilio.com/docs/phone-numbers/api/incomingphonenumber-resource) that you want to associate with the trunk. </param>
        public CreatePhoneNumberOptions(string pathTrunkSid, string phoneNumberSid)
        {
            PathTrunkSid = pathTrunkSid;
            PhoneNumberSid = phoneNumberSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (PhoneNumberSid != null)
            {
                p.Add(new KeyValuePair<string, string>("PhoneNumberSid", PhoneNumberSid));
            }
            return p;
        }
        

    }
    /// <summary> delete </summary>
    public class DeletePhoneNumberOptions : IOptions<PhoneNumberResource>
    {
        
        ///<summary> The SID of the Trunk from which to delete the PhoneNumber resource. </summary> 
        public string PathTrunkSid { get; }

        ///<summary> The unique string that we created to identify the PhoneNumber resource to delete. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new DeletePhoneNumberOptions </summary>
        /// <param name="pathTrunkSid"> The SID of the Trunk from which to delete the PhoneNumber resource. </param>        /// <param name="pathSid"> The unique string that we created to identify the PhoneNumber resource to delete. </param>
        public DeletePhoneNumberOptions(string pathTrunkSid, string pathSid)
        {
            PathTrunkSid = pathTrunkSid;
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
    public class FetchPhoneNumberOptions : IOptions<PhoneNumberResource>
    {
    
        ///<summary> The SID of the Trunk from which to fetch the PhoneNumber resource. </summary> 
        public string PathTrunkSid { get; }

        ///<summary> The unique string that we created to identify the PhoneNumber resource to fetch. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new FetchPhoneNumberOptions </summary>
        /// <param name="pathTrunkSid"> The SID of the Trunk from which to fetch the PhoneNumber resource. </param>        /// <param name="pathSid"> The unique string that we created to identify the PhoneNumber resource to fetch. </param>
        public FetchPhoneNumberOptions(string pathTrunkSid, string pathSid)
        {
            PathTrunkSid = pathTrunkSid;
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
    public class ReadPhoneNumberOptions : ReadOptions<PhoneNumberResource>
    {
    
        ///<summary> The SID of the Trunk from which to read the PhoneNumber resources. </summary> 
        public string PathTrunkSid { get; }



        /// <summary> Construct a new ListPhoneNumberOptions </summary>
        /// <param name="pathTrunkSid"> The SID of the Trunk from which to read the PhoneNumber resources. </param>
        public ReadPhoneNumberOptions(string pathTrunkSid)
        {
            PathTrunkSid = pathTrunkSid;
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

