using System.Net;
using System.Collections.Specialized;
using System.Text;
using System;

namespace Kraken_Bot
{
    class Email
    {
        private string url, source, to, from, subject, body, logger;

        public Email(
            string url,
            string source,
            string to,
            string from,
            string subject,
            string body,
            string logger)
        {
            this.url = url;
            this.source = source;
            this.to = to;
            this.from = from;
            this.subject = subject;
            this.body = body;
            this.logger = logger;
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
                data["logger"] = logger;

                var response = wb.UploadValues(url, "POST", data);
                string responseInString = Encoding.UTF8.GetString(response);

                return responseInString;
            }
        }
    }
}
