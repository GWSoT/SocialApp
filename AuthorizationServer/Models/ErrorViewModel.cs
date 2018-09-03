using System;

namespace AuthorizationServer.Models
{
    public class ErrorViewModel
    {
        public bool ShowRequestId { get; set; }
        public string RequestId { get; set; }
        public string Error { get; set; }
        public string  ErrorDescription { get; set; }
    }
}