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




namespace Twilio.Rest.Verify.V2
{
    /// <summary> Fetch the forms for a specific Form Type. </summary>
    public class FetchFormOptions : IOptions<FormResource>
    {
    
        ///<summary> The Type of this Form. Currently only `form-push` is supported. </summary> 
        public FormResource.FormTypesEnum PathFormType { get; }



        /// <summary> Construct a new FetchFormOptions </summary>
        /// <param name="pathFormType"> The Type of this Form. Currently only &#x60;form-push&#x60; is supported. </param>
        public FetchFormOptions(FormResource.FormTypesEnum pathFormType)
        {
            PathFormType = pathFormType;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }


}

