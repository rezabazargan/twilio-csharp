using System;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

#if NET40
using System.Threading.Tasks;
#endif

namespace Twilio.Rest.Monitor.V1 
{

    public class AlertReader : Reader<AlertResource> 
    {
        public string logLevel { get; set; }
        public DateTime? startDate { get; set; }
        public DateTime? endDate { get; set; }
    
        /// <summary>
        /// Construct a new AlertReader
        /// </summary>
        ///
        /// <param name="logLevel"> The log_level </param>
        /// <param name="startDate"> The start_date </param>
        /// <param name="endDate"> The end_date </param>
        public AlertReader(string logLevel=null, DateTime? startDate=null, DateTime? endDate=null)
        {
            this.logLevel = logLevel;
            this.startDate = startDate;
            this.endDate = endDate;
        }
    
        #if NET40
        /// <summary>
        /// Make the request to the Twilio API to perform the read
        /// </summary>
        ///
        /// <param name="client"> ITwilioRestClient with which to make the request </param>
        /// <returns> AlertResource ResourceSet </returns> 
        public override Task<ResourceSet<AlertResource>> ReadAsync(ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.GET,
                Domains.MONITOR,
                "/v1/Alerts"
            );
            AddQueryParams(request);
            
            var page = PageForRequest(client, request);
            
            return System.Threading.Tasks.Task.FromResult(new ResourceSet<AlertResource>(this, client, page));
        }
        #endif
    
        /// <summary>
        /// Make the request to the Twilio API to perform the read
        /// </summary>
        ///
        /// <param name="client"> ITwilioRestClient with which to make the request </param>
        /// <returns> AlertResource ResourceSet </returns> 
        public override ResourceSet<AlertResource> Read(ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.GET,
                Domains.MONITOR,
                "/v1/Alerts"
            );
            
            AddQueryParams(request);
            var page = PageForRequest(client, request);
            
            return new ResourceSet<AlertResource>(this, client, page);
        }
    
        /// <summary>
        /// Retrieve the next page from the Twilio API
        /// </summary>
        ///
        /// <param name="nextPageUri"> URI from which to retrieve the next page </param>
        /// <param name="client"> ITwilioRestClient with which to make the request </param>
        /// <returns> Next Page </returns> 
        public override Page<AlertResource> NextPage(Page<AlertResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.GET,
                page.GetNextPageUrl(
                    Domains.MONITOR
                )
            );
            
            return PageForRequest(client, request);
        }
    
        /// <summary>
        /// Generate a Page of AlertResource Resources for a given request
        /// </summary>
        ///
        /// <param name="client"> ITwilioRestClient with which to make the request </param>
        /// <param name="request"> Request to generate a page for </param>
        /// <returns> Page for the Request </returns> 
        protected Page<AlertResource> PageForRequest(ITwilioRestClient client, Request request)
        {
            var response = client.Request(request);
            if (response == null)
            {
                throw new ApiConnectionException("AlertResource read failed: Unable to connect to server");
            }
            
            if (response.StatusCode < System.Net.HttpStatusCode.OK || response.StatusCode > System.Net.HttpStatusCode.NoContent)
            {
                var restException = RestException.FromJson(response.Content);
                if (restException == null)
                {
                    throw new ApiException("Server Error, no content");
                }
            
                throw new ApiException(
                    restException.Code,
                    (int)response.StatusCode,
                    restException.Message ?? "Unable to read records, " + response.StatusCode,
                    restException.MoreInfo
                );
            }
            
            return Page<AlertResource>.FromJson("alerts", response.Content);
        }
    
        /// <summary>
        /// Add the requested query string arguments to the Request
        /// </summary>
        ///
        /// <param name="request"> Request to add query string arguments to </param>
        private void AddQueryParams(Request request)
        {
            if (logLevel != null)
            {
                request.AddQueryParam("LogLevel", logLevel);
            }
            
            if (startDate != null)
            {
                request.AddQueryParam("StartDate", startDate.ToString());
            }
            
            if (endDate != null)
            {
                request.AddQueryParam("EndDate", endDate.ToString());
            }
            
            if (PageSize != null)
            {
                request.AddQueryParam("PageSize", PageSize.ToString());
            }
        }
    }
}