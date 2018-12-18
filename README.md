# TwilioSMS
.Core project to send SMS using Twilio 

# Twilio REST API
This program uses Twilio REST API 5.24.0 available on https://www.nuget.org/packages/Twilio/

# Service Layer
In TwilioSMS.Service project there are the following objects:

- Message: The message containing the properties MessageText, PhoneNumber*, MessageType and SenderId. 
- MessageContract: DesignContract to verify well filled properties 
- MessageType: Promotional or Transaction SMS
- TwilioService: The class responsible for send SMS
- ServiceResponse: The class responsible for obtain result after sending.

*Pay attention with phone number formats, check the documentation:
https://support.twilio.com/hc/en-us/articles/223183008-formatting-international-phone-numbers

# Configuring Twilio API Credentials
In TwilioSMS.Utils project, open TwilioCredentials.cs and define the variables:

        public static string AccountSid = "";
        public static string AuthToken = "";
        public static string SenderPhoneNumber = ""; //A Twilio phone number buyed on Twilio Dashboard


