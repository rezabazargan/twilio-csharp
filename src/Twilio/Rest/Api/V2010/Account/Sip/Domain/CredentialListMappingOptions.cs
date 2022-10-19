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




namespace Twilio.Rest.Api.V2010.Account.Sip.Domain
{

    /// <summary> Create a CredentialListMapping resource for an account. </summary>
    public class CreateCredentialListMappingOptions : IOptions<CredentialListMappingResource>
    {
        
        ///<summary> A 34 character string that uniquely identifies the SIP Domain for which the CredentialList resource will be mapped. </summary> 
        public string PathDomainSid { get; }

        ///<summary> A 34 character string that uniquely identifies the CredentialList resource to map to the SIP domain. </summary> 
        public string CredentialListSid { get; }

        ///<summary> The unique id of the [Account](https://www.twilio.com/docs/iam/api/account) responsible for this resource. </summary> 
        public string PathAccountSid { get; set; }


        /// <summary> Construct a new CreateSipCredentialListMappingOptions </summary>
        /// <param name="pathDomainSid"> A 34 character string that uniquely identifies the SIP Domain for which the CredentialList resource will be mapped. </param>        /// <param name="credentialListSid"> A 34 character string that uniquely identifies the CredentialList resource to map to the SIP domain. </param>
        public CreateCredentialListMappingOptions(string pathDomainSid, string credentialListSid)
        {
            PathDomainSid = pathDomainSid;
            CredentialListSid = credentialListSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (CredentialListSid != null)
            {
                p.Add(new KeyValuePair<string, string>("CredentialListSid", CredentialListSid));
            }
            return p;
        }
        

    }
    /// <summary> Delete a CredentialListMapping resource from an account. </summary>
    public class DeleteCredentialListMappingOptions : IOptions<CredentialListMappingResource>
    {
        
        ///<summary> A 34 character string that uniquely identifies the SIP Domain that includes the resource to delete. </summary> 
        public string PathDomainSid { get; }

        ///<summary> A 34 character string that uniquely identifies the resource to delete. </summary> 
        public string PathSid { get; }

        ///<summary> The unique id of the [Account](https://www.twilio.com/docs/iam/api/account) responsible for this resource. </summary> 
        public string PathAccountSid { get; set; }



        /// <summary> Construct a new DeleteSipCredentialListMappingOptions </summary>
        /// <param name="pathDomainSid"> A 34 character string that uniquely identifies the SIP Domain that includes the resource to delete. </param>        /// <param name="pathSid"> A 34 character string that uniquely identifies the resource to delete. </param>
        public DeleteCredentialListMappingOptions(string pathDomainSid, string pathSid)
        {
            PathDomainSid = pathDomainSid;
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }


    /// <summary> Fetch a single CredentialListMapping resource from an account. </summary>
    public class FetchCredentialListMappingOptions : IOptions<CredentialListMappingResource>
    {
    
        ///<summary> A 34 character string that uniquely identifies the SIP Domain that includes the resource to fetch. </summary> 
        public string PathDomainSid { get; }

        ///<summary> A 34 character string that uniquely identifies the resource to fetch. </summary> 
        public string PathSid { get; }

        ///<summary> The unique id of the [Account](https://www.twilio.com/docs/iam/api/account) responsible for this resource. </summary> 
        public string PathAccountSid { get; set; }



        /// <summary> Construct a new FetchSipCredentialListMappingOptions </summary>
        /// <param name="pathDomainSid"> A 34 character string that uniquely identifies the SIP Domain that includes the resource to fetch. </param>        /// <param name="pathSid"> A 34 character string that uniquely identifies the resource to fetch. </param>
        public FetchCredentialListMappingOptions(string pathDomainSid, string pathSid)
        {
            PathDomainSid = pathDomainSid;
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }


    /// <summary> Read multiple CredentialListMapping resources from an account. </summary>
    public class ReadCredentialListMappingOptions : ReadOptions<CredentialListMappingResource>
    {
    
        ///<summary> A 34 character string that uniquely identifies the SIP Domain that includes the resource to read. </summary> 
        public string PathDomainSid { get; }

        ///<summary> The unique id of the [Account](https://www.twilio.com/docs/iam/api/account) responsible for this resource. </summary> 
        public string PathAccountSid { get; set; }



        /// <summary> Construct a new ListSipCredentialListMappingOptions </summary>
        /// <param name="pathDomainSid"> A 34 character string that uniquely identifies the SIP Domain that includes the resource to read. </param>
        public ReadCredentialListMappingOptions(string pathDomainSid)
        {
            PathDomainSid = pathDomainSid;
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

