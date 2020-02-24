using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Kraken_Bot
{
    public class Profile
    {
        public IList<string> addresses { get; set; }
        public IList<string> bodytext { get; set; }
        public IList<string> instagram { get; set; }
    }

    class LoadProfiles
    {
        Profile profile;

        public LoadProfiles(String path)
        {
            try
            {
                string content;
                using (StreamReader reader = new StreamReader(path))
                {
                    content = reader.ReadToEnd();
                }

                profile = JsonConvert.DeserializeObject<Profile>(content);

                Console.WriteLine("Loaded profiles successfully\n");
            }
            catch
            {
                Console.WriteLine("Error loading profiles\n");
            }

        }

        public IList<string> GetAddresses()
        {
            try
            {
                return profile.addresses;
            }
            catch
            {
                Console.WriteLine("Error loading profiles\n");
                return null;
            }
        }

        public IList<string> GetBodyText()
        {
            try
            {
                return profile.bodytext;
            }
            catch
            {
                Console.WriteLine("Error loading profiles\n");
                return null;
            }
        }

        public IList<string> GetInstagrams()
        {
            try
            {
                return profile.instagram;
            }
            catch
            {
                Console.WriteLine("Error loading profiles\n");
                return null;
            }
        }
    }
}
