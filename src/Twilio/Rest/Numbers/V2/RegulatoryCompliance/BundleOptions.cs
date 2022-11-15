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




namespace Twilio.Rest.Numbers.V2.RegulatoryCompliance
{

    /// <summary> Create a new Bundle. </summary>
    public class CreateBundleOptions : IOptions<BundleResource>
    {
        
        ///<summary> The string that you assigned to describe the resource. </summary> 
        public string FriendlyName { get; }

        ///<summary> The email address that will receive updates when the Bundle resource changes status. </summary> 
        public string Email { get; }

        ///<summary> The URL we call to inform your application of status changes. </summary> 
        public Uri StatusCallback { get; set; }

        ///<summary> The unique string of a regulation that is associated to the Bundle resource. </summary> 
        public string RegulationSid { get; set; }

        ///<summary> The [ISO country code](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) of the Bundle's phone number country ownership request. </summary> 
        public string IsoCountry { get; set; }

        
        public BundleResource.EndUserTypeEnum EndUserType { get; set; }

        ///<summary> The type of phone number of the Bundle's ownership request. Can be `local`, `mobile`, `national`, or `toll free`. </summary> 
        public string NumberType { get; set; }


        /// <summary> Construct a new CreateBundleOptions </summary>
        /// <param name="friendlyName"> The string that you assigned to describe the resource. </param>        /// <param name="email"> The email address that will receive updates when the Bundle resource changes status. </param>
        public CreateBundleOptions(string friendlyName, string email)
        {
            FriendlyName = friendlyName;
            Email = email;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }
            if (Email != null)
            {
                p.Add(new KeyValuePair<string, string>("Email", Email));
            }
            if (StatusCallback != null)
            {
                p.Add(new KeyValuePair<string, string>("StatusCallback", Serializers.Url(StatusCallback)));
            }
            if (RegulationSid != null)
            {
                p.Add(new KeyValuePair<string, string>("RegulationSid", RegulationSid));
            }
            if (IsoCountry != null)
            {
                p.Add(new KeyValuePair<string, string>("IsoCountry", IsoCountry));
            }
            if (EndUserType != null)
            {
                p.Add(new KeyValuePair<string, string>("EndUserType", EndUserType.ToString()));
            }
            if (NumberType != null)
            {
                p.Add(new KeyValuePair<string, string>("NumberType", NumberType));
            }
            return p;
        }
        

    }
    /// <summary> Delete a specific Bundle. </summary>
    public class DeleteBundleOptions : IOptions<BundleResource>
    {
        
        ///<summary> The unique string that we created to identify the Bundle resource. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new DeleteBundleOptions </summary>
        /// <param name="pathSid"> The unique string that we created to identify the Bundle resource. </param>
        public DeleteBundleOptions(string pathSid)
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


    /// <summary> Fetch a specific Bundle instance. </summary>
    public class FetchBundleOptions : IOptions<BundleResource>
    {
    
        ///<summary> The unique string that we created to identify the Bundle resource. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new FetchBundleOptions </summary>
        /// <param name="pathSid"> The unique string that we created to identify the Bundle resource. </param>
        public FetchBundleOptions(string pathSid)
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


    /// <summary> Retrieve a list of all Bundles for an account. </summary>
    public class ReadBundleOptions : ReadOptions<BundleResource>
    {
    
        ///<summary> The verification status of the Bundle resource. Please refer to [Bundle Statuses](https://www.twilio.com/docs/phone-numbers/regulatory/api/bundles#bundle-statuses) for more details. </summary> 
        public BundleResource.StatusEnum Status { get; set; }

        ///<summary> The string that you assigned to describe the resource. The column can contain 255 variable characters. </summary> 
        public string FriendlyName { get; set; }

        ///<summary> The unique string of a [Regulation resource](https://www.twilio.com/docs/phone-numbers/regulatory/api/regulations) that is associated to the Bundle resource. </summary> 
        public string RegulationSid { get; set; }

        ///<summary> The 2-digit [ISO country code](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) of the Bundle's phone number country ownership request. </summary> 
        public string IsoCountry { get; set; }

        ///<summary> The type of phone number of the Bundle's ownership request. Can be `local`, `mobile`, `national`, or `tollfree`. </summary> 
        public string NumberType { get; set; }

        ///<summary> Indicates that the Bundle is a valid Bundle until a specified expiration date. </summary> 
        public bool? HasValidUntilDate { get; set; }

        ///<summary> Can be `valid-until` or `date-updated`. Defaults to `date-created`. </summary> 
        public BundleResource.SortByEnum SortBy { get; set; }

        ///<summary> Default is `DESC`. Can be `ASC` or `DESC`. </summary> 
        public BundleResource.SortDirectionEnum SortDirection { get; set; }

        ///<summary> Date to filter Bundles having their `valid_until_date` before or after the specified date. Can be `ValidUntilDate>=` or `ValidUntilDate<=`. Both can be used in conjunction as well. [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) is the acceptable date format. </summary> 
        public DateTime? ValidUntilDate { get; set; }

        ///<summary> Date to filter Bundles having their `valid_until_date` before or after the specified date. Can be `ValidUntilDate>=` or `ValidUntilDate<=`. Both can be used in conjunction as well. [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) is the acceptable date format. </summary> 
        public DateTime? ValidUntilDateBefore { get; set; }

        ///<summary> Date to filter Bundles having their `valid_until_date` before or after the specified date. Can be `ValidUntilDate>=` or `ValidUntilDate<=`. Both can be used in conjunction as well. [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) is the acceptable date format. </summary> 
        public DateTime? ValidUntilDateAfter { get; set; }




        
        /// <summary> Generate the necessary parameters </summary>
        public  override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (Status != null)
            {
                p.Add(new KeyValuePair<string, string>("Status", Status.ToString()));
            }
            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }
            if (RegulationSid != null)
            {
                p.Add(new KeyValuePair<string, string>("RegulationSid", RegulationSid));
            }
            if (IsoCountry != null)
            {
                p.Add(new KeyValuePair<string, string>("IsoCountry", IsoCountry));
            }
            if (NumberType != null)
            {
                p.Add(new KeyValuePair<string, string>("NumberType", NumberType));
            }
            if (HasValidUntilDate != null)
            {
                p.Add(new KeyValuePair<string, string>("HasValidUntilDate", HasValidUntilDate.Value.ToString().ToLower()));
            }
            if (SortBy != null)
            {
                p.Add(new KeyValuePair<string, string>("SortBy", SortBy.ToString()));
            }
            if (SortDirection != null)
            {
                p.Add(new KeyValuePair<string, string>("SortDirection", SortDirection.ToString()));
            }
            if (ValidUntilDate != null)
            {
                p.Add(new KeyValuePair<string, string>("ValidUntilDate", Serializers.DateTimeIso8601(ValidUntilDate)));
            }
            else
            {
                if (ValidUntilDateBefore != null)
                {
                    p.Add(new KeyValuePair<string, string>("ValidUntilDate<", Serializers.DateTimeIso8601(ValidUntilDateBefore)));
                }
                if (ValidUntilDateAfter != null)
                {
                    p.Add(new KeyValuePair<string, string>("ValidUntilDate>", Serializers.DateTimeIso8601(ValidUntilDateAfter)));
                }

            }
            if (ValidUntilDateBefore != null)
            {
                p.Add(new KeyValuePair<string, string>("ValidUntilDateBefore", Serializers.DateTimeIso8601(ValidUntilDateBefore)));
            }
            if (ValidUntilDateAfter != null)
            {
                p.Add(new KeyValuePair<string, string>("ValidUntilDateAfter", Serializers.DateTimeIso8601(ValidUntilDateAfter)));
            }
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }
            return p;
        }
        

    }

    /// <summary> Updates a Bundle in an account. </summary>
    public class UpdateBundleOptions : IOptions<BundleResource>
    {
    
        ///<summary> The unique string that we created to identify the Bundle resource. </summary> 
        public string PathSid { get; }

        
        public BundleResource.StatusEnum Status { get; set; }

        ///<summary> The URL we call to inform your application of status changes. </summary> 
        public Uri StatusCallback { get; set; }

        ///<summary> The string that you assigned to describe the resource. </summary> 
        public string FriendlyName { get; set; }

        ///<summary> The email address that will receive updates when the Bundle resource changes status. </summary> 
        public string Email { get; set; }



        /// <summary> Construct a new UpdateBundleOptions </summary>
        /// <param name="pathSid"> The unique string that we created to identify the Bundle resource. </param>
        public UpdateBundleOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (Status != null)
            {
                p.Add(new KeyValuePair<string, string>("Status", Status.ToString()));
            }
            if (StatusCallback != null)
            {
                p.Add(new KeyValuePair<string, string>("StatusCallback", Serializers.Url(StatusCallback)));
            }
            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }
            if (Email != null)
            {
                p.Add(new KeyValuePair<string, string>("Email", Email));
            }
            return p;
        }
        

    }


}

