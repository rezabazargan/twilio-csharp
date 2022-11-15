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




namespace Twilio.Rest.Api.V2010.Account.Sip.Domain.AuthTypes.AuthTypeRegistrations
{

    /// <summary> Create a new credential list mapping resource </summary>
    public class CreateAuthRegistrationsCredentialListMappingOptions : IOptions<AuthRegistrationsCredentialListMappingResource>
    {
        
        ///<summary> The SID of the SIP domain that will contain the new resource. </summary> 
        public string PathDomainSid { get; }

        ///<summary> The SID of the CredentialList resource to map to the SIP domain. </summary> 
        public string CredentialListSid { get; }

        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that will create the resource. </summary> 
        public string PathAccountSid { get; set; }


        /// <summary> Construct a new CreateSipAuthRegistrationsCredentialListMappingOptions </summary>
        /// <param name="pathDomainSid"> The SID of the SIP domain that will contain the new resource. </param>        /// <param name="credentialListSid"> The SID of the CredentialList resource to map to the SIP domain. </param>
        public CreateAuthRegistrationsCredentialListMappingOptions(string pathDomainSid, string credentialListSid)
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
    /// <summary> Delete a credential list mapping from the requested domain </summary>
    public class DeleteAuthRegistrationsCredentialListMappingOptions : IOptions<AuthRegistrationsCredentialListMappingResource>
    {
        
        ///<summary> The SID of the SIP domain that contains the resources to delete. </summary> 
        public string PathDomainSid { get; }

        ///<summary> The Twilio-provided string that uniquely identifies the CredentialListMapping resource to delete. </summary> 
        public string PathSid { get; }

        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the CredentialListMapping resources to delete. </summary> 
        public string PathAccountSid { get; set; }



        /// <summary> Construct a new DeleteSipAuthRegistrationsCredentialListMappingOptions </summary>
        /// <param name="pathDomainSid"> The SID of the SIP domain that contains the resources to delete. </param>        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the CredentialListMapping resource to delete. </param>
        public DeleteAuthRegistrationsCredentialListMappingOptions(string pathDomainSid, string pathSid)
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


    /// <summary> Fetch a specific instance of a credential list mapping </summary>
    public class FetchAuthRegistrationsCredentialListMappingOptions : IOptions<AuthRegistrationsCredentialListMappingResource>
    {
    
        ///<summary> The SID of the SIP domain that contains the resource to fetch. </summary> 
        public string PathDomainSid { get; }

        ///<summary> The Twilio-provided string that uniquely identifies the CredentialListMapping resource to fetch. </summary> 
        public string PathSid { get; }

        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the CredentialListMapping resource to fetch. </summary> 
        public string PathAccountSid { get; set; }



        /// <summary> Construct a new FetchSipAuthRegistrationsCredentialListMappingOptions </summary>
        /// <param name="pathDomainSid"> The SID of the SIP domain that contains the resource to fetch. </param>        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the CredentialListMapping resource to fetch. </param>
        public FetchAuthRegistrationsCredentialListMappingOptions(string pathDomainSid, string pathSid)
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


    /// <summary> Retrieve a list of credential list mappings belonging to the domain used in the request </summary>
    public class ReadAuthRegistrationsCredentialListMappingOptions : ReadOptions<AuthRegistrationsCredentialListMappingResource>
    {
    
        ///<summary> The SID of the SIP domain that contains the resources to read. </summary> 
        public string PathDomainSid { get; }

        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the CredentialListMapping resources to read. </summary> 
        public string PathAccountSid { get; set; }



        /// <summary> Construct a new ListSipAuthRegistrationsCredentialListMappingOptions </summary>
        /// <param name="pathDomainSid"> The SID of the SIP domain that contains the resources to read. </param>
        public ReadAuthRegistrationsCredentialListMappingOptions(string pathDomainSid)
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

