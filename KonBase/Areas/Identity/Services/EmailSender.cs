using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace KonBase.Areas.Identity.Services
{
    public class EmailSender
    {
        public static IConfigurationRoot Configuration { get; set; }

        public async Task SendEmail(string email, string subject, string template, string link)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            Configuration = builder.Build();

            var apiKey = Configuration["SendGrid:SEND_GRID_API_KEY"];

            var client = new SendGridClient(apiKey);

            var msg = new SendGridMessage()
            {
                From = new EmailAddress("noreply@konbase.com.br", "Equipe Konbase"),
                Subject = subject,
                TemplateId = template
            };

            msg.AddSubstitution("link", link);

            msg.AddTo(new EmailAddress(email, "Usuário"));

            string messageJSON = msg.Serialize();

            var obj = (JObject)JsonConvert.DeserializeObject(messageJSON);

            var personalizations = (JArray)obj["personalizations"];

            foreach (var personalization in personalizations.Cast<JObject>())
            {
                var substitutions = personalization.Property("substitutions");
                substitutions.Replace(new JProperty("dynamic_template_data", substitutions.Value));
            }

            messageJSON = JsonConvert.SerializeObject(obj);

            var response = await client.RequestAsync(SendGridClient.Method.POST, messageJSON, null, "mail/send");

        }
    
    }
}
