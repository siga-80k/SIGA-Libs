using System;
using System.Net;
using System.Net.Mail;
using Twilio.Rest.Autopilot.V1.Assistant;
using System.IO;
using System.Security.Cryptography;

namespace CCR_DEV_Tool.Helpers.TeleCom.email
{
    public class Email
    {
        public static void Send(string fromMail, string fromName, string fromPass, string toMail, string toName, string subjectText, string hostSmtp)
        {
            var fromAddress = new MailAddress(fromMail, fromName);
            var toAddress = new MailAddress(toMail, toName);
            /*const*/ string fromPassword = fromPass;
            /*const*/ string subject = subjectText;
            /*const*/ string body = EmailModel.content;

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                message.IsBodyHtml = true;
                smtp.Send(message);
            }
        }
    }
}
