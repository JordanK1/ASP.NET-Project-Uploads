using System;

namespace DailyBlogger__ASP.NET_Sec._2_Project_.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
