using System;
using System.Collections.Generic;
using System.Text;

namespace TwilioSMS.Service
{
    public class ServiceResponse
    {
        public bool IsValid { get; set; }
        public IList<string> Errors = new List<string>();
    }
}
