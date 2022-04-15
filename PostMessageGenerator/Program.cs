using System.Text.Json;

List<OutboundMessage> messages = new();
for(int i = 0; i < 3; i++) 
{
    OutboundMessage message = new();
    message.ProviderName = "email-postmark";
    message.Properties = new Dictionary<string, string>()
    {
        { "From", Faker.Internet.FreeEmail() },
        { "HtmlBody", Faker.Address.StreetAddress() },
        { "ReplyTo", Faker.Internet.FreeEmail() },
        { "Subject", Faker.Country.Name() },
        { "To", Faker.Internet.Email() }
    };
    messages.Add(message);
}

var data = JsonSerializer.Serialize(messages);

Console.WriteLine(data);

//foreach (var mes in message.Properties)
//{
//    Console.WriteLine(mes.Key + "   " + mes.Value);
//}

//Console.ReadLine();
public class OutboundMessage 
{
    public string? ProviderName { get; set; }
    public Dictionary<string, string>? Properties { get; set; }
}