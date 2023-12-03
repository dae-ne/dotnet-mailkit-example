using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;

const string host = "smtp.gmail.com";
const int port = 587;

const string senderEmail = "";
const string senderName = "";
const string password = "";

const string recipientEmail = "";
const string recipientName = "";

const string subject = "How you doin'?";
const string body = $"""
    Hey,
    I am just writing to let you know that I am still alive.
    -- {senderEmail}
    """;

await SendEmailAsync(
    senderEmail,
    senderName,
    password,
    recipientEmail,
    recipientName,
    subject,
    body);

return;

static async Task SendEmailAsync(
    string senderEmail,
    string senderName,
    string password,
    string recipientEmail,
    string recipientName,
    string subject,
    string body)
{
    using var message = new MimeMessage();
    message.From.Add(new MailboxAddress(senderName, senderEmail));
    message.To.Add(new MailboxAddress(recipientName, recipientEmail));
    message.Subject = subject;
    message.Body = new TextPart("plain") { Text = body };

    using var client = new SmtpClient();
    await client.ConnectAsync(host, port, SecureSocketOptions.StartTls);
    await client.AuthenticateAsync(senderEmail, password);
    await client.SendAsync(message);
    await client.DisconnectAsync(true);
}
