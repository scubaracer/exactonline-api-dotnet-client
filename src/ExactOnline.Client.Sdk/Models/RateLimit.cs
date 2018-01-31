using System;

namespace ExactOnline.Client.Sdk.Models
{
    public class RateLimit
    {
        public int? Limit { get; set; }
        public int? Remaining { get; set; }
        public long? Reset { get; set; }
    }
}