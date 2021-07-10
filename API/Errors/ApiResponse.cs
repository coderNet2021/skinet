using System;

namespace API.Errors
{
    public class ApiResponse
    {
        public ApiResponse(int statusCode, string message= null)
        {
            StatusCode = statusCode;
            Message = message ?? GetDefaultMessageForStatusCode(statusCode);
        }

       

        public int  StatusCode { get; set; }
        public string Message { get; set; }
         private string GetDefaultMessageForStatusCode(int statusCode)
        {
            return statusCode switch
            {
                400=>"bad request is made",
                401=>"not authorized",
                404=>"resource not found",
                500=>"internal Server Error App",
                _=>null
            };
        }
    }
}