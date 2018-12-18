using System;
using System.Collections.Generic;
using System.Text;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;
using TwilioSMS.Utils;
using static Twilio.Rest.Api.V2010.Account.Call.FeedbackSummaryResource;

namespace TwilioSMS.Service
{
    public class TwilioService
    {
        public static ServiceResponse Send(Message message)
        {
            ServiceResponse response = new ServiceResponse();
            if (message.IsValid())
            {


                TwilioClient.Init(TwilioCredentials.AccountSid, TwilioCredentials.AuthToken);
                
                var result = MessageResource.Create(
                                            to: new PhoneNumber($"+{message.PhoneNumber}"),
                                            from: new PhoneNumber($"+{message.SenderId}"),
                                            body: "Hello from C#");

                if (result.Status != StatusEnum.Failed)
                    response.IsValid = true;
                else
                {
                    response.Errors.Add("SMS failed!");
                    response.IsValid = false;
                }
            }
            else
            {
                response.Errors = message.Errors;
                response.IsValid = false;
            }
            return response;
        }
    }
}
