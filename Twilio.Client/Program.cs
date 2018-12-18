﻿using System;
using TwilioSMS.Service;
using TwilioSMS.Utils;

namespace Twilio.Client
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var message = new Message(TwilioCredentials.SenderPhoneNumber, "5511954673640", "Hello John Due, you received 5 news messages. Check there!", MessageType.Transactional);
            var result = TwilioService.Send(message);

            if (result.IsValid)
                Console.WriteLine("SMS sent successful!");
            else
            {
                foreach (string error in result.Errors)
                    Console.WriteLine(error);
            }

        }
    }
}
