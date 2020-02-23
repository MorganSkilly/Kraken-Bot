using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Configuration;
using System.Collections.Specialized;
using RandomNameGen;

namespace Kraken_Bot
{
    public partial class EmailTest : Form
    {
        public EmailTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string version = "PRE ALPHA";
            string license = "LICENSE";
            Console.WriteLine(nameof(Kraken_Bot) + " Version: " + version);
            Console.WriteLine("License: " + license);
            Console.WriteLine();
            LoadProfiles profiles = new LoadProfiles("profiles.json");
            Console.WriteLine();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("to edit settings change the settings in App.Config");
            Console.WriteLine();

            NameValueCollection sAll;
            sAll = ConfigurationManager.AppSettings;

            foreach (string s in sAll.AllKeys)
                Console.WriteLine(s + ": " + sAll.Get(s));

            String domainName = ConfigurationManager.AppSettings.Get("DomainName");
            String phpscript = ConfigurationManager.AppSettings.Get("PHPScript");
            int delay = int.Parse(ConfigurationManager.AppSettings.Get("Delay"));
            int count = int.Parse(ConfigurationManager.AppSettings.Get("Count"));
            String logEmail = ConfigurationManager.AppSettings.Get("LogEmail");
            String logDiscord = ConfigurationManager.AppSettings.Get("DiscordWebhook");
            String sendEmail = ConfigurationManager.AppSettings.Get("SendEmail");
            IList<string> addresses = profiles.GetAddresses();
            IList<string> emails = profiles.GetEmails();
            IList<string> instagrams = profiles.GetInstagrams();

            Console.WriteLine();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine();

            string bodyText = "##NAME##\n\nneed shipping\n\n##ADDRESS##\n\n##PHONE##\n\nUK size ##SIZE##";
            string nameText = "Morgan";
            string addressText;
            string sizeText;
            string instagramText = "@morganskilly";
            string phoneText;
            string discordEmailWebhook = "https://discordapp.com/api/webhooks/680979941990465549/zJTyiSxLIjnaJ4NSWXqraRZvqxFTv7ct1KILefLU3bFkkl-zTVQrjmiweLbjIo__Z5Ds";

            MarkDownText text = new MarkDownText();

            Console.WriteLine("TASKS STARTED");
            Console.WriteLine();

            int addresscount = 0;

            for (int i = 0; i <= count; i++)
            {
                addressText = addresses[addresscount];
                addresscount++;

                if (addresscount >= addresses.Count)
                {
                    addresscount = 0;
                }

                Random generator = new Random();
                int r = generator.Next(100000, 1000000);
                phoneText = "07454" + r.ToString();

                r = generator.Next(4, 8);
                sizeText = r.ToString();

                if (generator.Next(100) < 50)
                {
                    sizeText = sizeText + ".5";
                }

                Random rand = new Random(DateTime.Now.Second);
                RandomName nameGen = new RandomName(rand);
                string name = nameGen.Generate(Sex.Male);
                string nameNoSpaces = new string(name.ToCharArray()
                    .Where(c => !Char.IsWhiteSpace(c))
                    .ToArray());

                Console.WriteLine();
                Console.WriteLine("-----------------------------------");
                Console.WriteLine();
                Email email = new Email(
                    phpscript,
                    nameof(Kraken_Bot) + " Version: " + version,
                    sendEmail,
                    nameNoSpaces + "@" + domainName,
                    "350 TAIL LIGHT UK" + sizeText,
                    text.MarkDownOutput(bodyText,
                        nameNoSpaces + "@" + domainName,
                        addressText,
                        name,
                        sizeText,
                        instagramText,
                        phoneText),

                    discordEmailWebhook);

                string output = email.Send();
                Console.WriteLine("event triggered at: " + DateTime.Now.ToString());
                Console.WriteLine();
                Console.WriteLine(output);
                System.Threading.Thread.Sleep(delay * 1000);
            }
        }

        private void EmailTest_Load(object sender, EventArgs e)
        {

        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            DiscordBot testbot = new DiscordBot(
                "https://discordapp.com/api/webhooks/680980116632895587/56WU6lGCjn4fuYywh3C4B3uSD0gNE2amgdWneiUIIffuseUNwMj3hQ9TqQBjsE_g-7rg",
                "Mr.Test Bot",
                "http://morgan.games/kraken/krakenbeta.png");

            DiscordEmbedField emptyfield = new DiscordEmbedField("field name", "field value [link](http://morgan.games)");

            testbot.SendDiscordWebHookEmbeded(
                "https://media3.giphy.com/media/GRF4gJYMQmdUI/giphy.gif?cid=790b76118b48fa14c668987a44f9f81552fe2621fe52ac59&rid=giphy.gif",
                "This is a test",
                "http://morgan.games",
                emptyfield,
                emptyfield,
                emptyfield,
                emptyfield);
        }

    }
}
