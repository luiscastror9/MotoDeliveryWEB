using System;
using System.Net.Mail;
using System.Net.Mime;
using System.ServiceModel.Channels;
using System.Web;

namespace IdentitySample.Models
{
    internal class SendGridMessage
    {
        public SendGridMessage()
        {
        }

        public MailAddress From { get; internal set; }
        public string Html { get; internal set; }
        public string Subject { get; internal set; }
        public string Text { get; internal set; }

        internal void AddTo(string destination)
        {
            throw new NotImplementedException();
        }

        
    }
}