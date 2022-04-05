using System;

namespace Security2.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }
    Type ErrorType { get; set; }
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
