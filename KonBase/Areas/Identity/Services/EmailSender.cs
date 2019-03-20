using Microsoft.AspNetCore.Identity.UI.Services;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KonBase.Areas.Identity.Services
{
    public class EmailSender
    {
        public async Task SendEmail(string email, string subject, string template, string link)
        {
            /*
            var apiKey = Environment.GetEnvironmentVariable("SEND_GRID_API_KEY");

            var client = new SendGridClient("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");

            var msg = new SendGridMessage()
            {
                From = new EmailAddress("noreply@konbase.com.br", "Equipe Konbase"),
                Subject = subject,
                TemplateId = template
            };

            msg.AddSubstitution("link", link);

            msg.AddTo(new EmailAddress(email));

            var response = await client.SendEmailAsync(msg);

            */

            var apiKey = Environment.GetEnvironmentVariable("SEND_GRID_API_KEY");

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
