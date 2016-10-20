﻿using Cinotam.TwoFactorAuth.Contracts;
using Cinotam.TwoFactorAuth.Twilio.Credentials;
using Cinotam.TwoFactorAuth.Twilio.Credentials.Input;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Twilio;

namespace Cinotam.TwoFactorAuth.Twilio.TwilioService
{
    public class TwilioService : ITwilioService
    {
        private readonly TwilioRestClient _client;
        public TwilioService(ITwilioSenderCredentials twilioSenderCredentials)
        {
            _client = twilioSenderCredentials.GetClient(new TwilioCredentials()
            {
                ApiKeyVarName = "TApiKey",
                ApiSecretVarName = "TApiSecret",
                EnvTarget = EnvironmentVariableTarget.User
            });
        }

        public Task SendMessage(CinotamAbpIdentityMessage message)
        {
            var result = _client.SendMessage(message.From, message.Destination, message.Body);
            Trace.TraceInformation(result.Status);
            return Task.FromResult(0);
        }

        public string ServiceName => "Twilio";
    }
}
