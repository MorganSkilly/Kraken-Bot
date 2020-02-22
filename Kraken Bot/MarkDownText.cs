using System;
using System.Collections.Generic;

namespace Kraken_Bot
{
    class MarkDownText
    {
        public string MarkDownOutput(string markdownInput, string email, string address, string name, string size, string instagram, string phone)
        {
            IDictionary<string, string> markupTags = new Dictionary<string, string>()
            {
                {"##EMAIL##", email},
                {"##ADDRESS##", address},
                {"##NAME##", name},
                {"##SIZE##", size},
                {"##INSTAGRAM##", instagram},
                {"##PHONE##", phone}
            };

            string editingText, newText;
            editingText = markdownInput;
            newText = editingText;

            foreach (KeyValuePair<string, string> tag in markupTags)
            {
                editingText = editingText.Replace(tag.Key, tag.Value);
            }

            newText = editingText;

            return newText;
        } 
    }
}
