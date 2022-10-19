/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Insights
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




namespace Twilio.Rest.Insights.V1.Call
{
    /// <summary> Fetch a specific Annotation. </summary>
    public class FetchAnnotationOptions : IOptions<AnnotationResource>
    {
    
        ///<summary> The unique SID identifier of the Call. </summary> 
        public string PathCallSid { get; }



        /// <summary> Construct a new FetchAnnotationOptions </summary>
        /// <param name="pathCallSid"> The unique SID identifier of the Call. </param>
        public FetchAnnotationOptions(string pathCallSid)
        {
            PathCallSid = pathCallSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }


    /// <summary> Create/Update the annotation for the call </summary>
    public class UpdateAnnotationOptions : IOptions<AnnotationResource>
    {
    
        ///<summary> The unique string that Twilio created to identify this Call resource. It always starts with a CA. </summary> 
        public string PathCallSid { get; }

        
        public AnnotationResource.AnsweredByEnum AnsweredBy { get; set; }

        
        public AnnotationResource.ConnectivityIssueEnum ConnectivityIssue { get; set; }

        ///<summary> Specify if the call had any subjective quality issues. Possible values, one or more of:  no_quality_issue, low_volume, choppy_robotic, echo, dtmf, latency, owa, static_noise. Use comma separated values to indicate multiple quality issues for the same call </summary> 
        public string QualityIssues { get; set; }

        ///<summary> Specify if the call was a spam call. Use this to provide feedback on whether calls placed from your account were marked as spam, or if inbound calls received by your account were unwanted spam. Is of type Boolean: true, false. Use true if the call was a spam call. </summary> 
        public bool? Spam { get; set; }

        ///<summary> Specify the call score. This is of type integer. Use a range of 1-5 to indicate the call experience score, with the following mapping as a reference for rating the call [5: Excellent, 4: Good, 3 : Fair, 2 : Poor, 1: Bad]. </summary> 
        public int? CallScore { get; set; }

        ///<summary> Specify any comments pertaining to the call. This of type string with a max limit of 100 characters. Twilio does not treat this field as PII, so don’t put any PII in here. </summary> 
        public string Comment { get; set; }

        ///<summary> Associate this call with an incident or support ticket. This is of type string with a max limit of 100 characters. Twilio does not treat this field as PII, so don’t put any PII in here. </summary> 
        public string Incident { get; set; }



        /// <summary> Construct a new UpdateAnnotationOptions </summary>
        /// <param name="pathCallSid"> The unique string that Twilio created to identify this Call resource. It always starts with a CA. </param>
        public UpdateAnnotationOptions(string pathCallSid)
        {
            PathCallSid = pathCallSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (AnsweredBy != null)
            {
                p.Add(new KeyValuePair<string, string>("AnsweredBy", AnsweredBy.ToString()));
            }
            if (ConnectivityIssue != null)
            {
                p.Add(new KeyValuePair<string, string>("ConnectivityIssue", ConnectivityIssue.ToString()));
            }
            if (QualityIssues != null)
            {
                p.Add(new KeyValuePair<string, string>("QualityIssues", QualityIssues));
            }
            if (Spam != null)
            {
                p.Add(new KeyValuePair<string, string>("Spam", Spam.Value.ToString().ToLower()));
            }
            if (CallScore != null)
            {
                p.Add(new KeyValuePair<string, string>("CallScore", CallScore.ToString()));
            }
            if (Comment != null)
            {
                p.Add(new KeyValuePair<string, string>("Comment", Comment));
            }
            if (Incident != null)
            {
                p.Add(new KeyValuePair<string, string>("Incident", Incident));
            }
            return p;
        }
        

    }


}

