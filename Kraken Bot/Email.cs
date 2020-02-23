using System.Net;
using System.Collections.Specialized;
using System.Text;
using System;

namespace Kraken_Bot
{
    class Email
    {
        private string url, source, to, from, subject, body, discordemailwebhook;
        private DiscordBot emailrecipt = new DiscordBot("https://discordapp.com/api/webhooks/680979941990465549/zJTyiSxLIjnaJ4NSWXqraRZvqxFTv7ct1KILefLU3bFkkl-zTVQrjmiweLbjIo__Z5Ds", "email recipt bot", "http://morgan.games/kraken/krakenbeta.png");

        public Email(
            string url,
            string source,
            string to,
            string from,
            string subject,
            string body,
            string discordemailwebhook)
        {
            this.url = url;
            this.source = source;
            this.to = to;
            this.from = from;
            this.subject = subject;
            this.body = body;
            this.discordemailwebhook = discordemailwebhook;
        }

        public String Send()
        {
            using (var wb = new WebClient())
            {
                var data = new NameValueCollection();
                data["source"] = source;
                data["to"] = to;
                data["from"] = from;
                data["subject"] = subject;
                data["body"] = body;
                data["webhook"] = discordemailwebhook;

                var response = wb.UploadValues(url, "POST", data);
                string responseInString = Encoding.UTF8.GetString(response);              

                return responseInString;
            }            
        }
    }
}
