# .NET MailKit Example

This example shows how to use the [MailKit](https://github.com/jstedfast/MailKit)
library to send emails from a .NET application.

## Prerequisites

- .NET 8.0 or later
- Gmail account
- Gmail app password (see [How to generate an app password](https://support.google.com/accounts/answer/185833))

## Running the example

1. Clone the repository
2. Edit the `Program.cs` file and replace the following values:
   - `senderEmail`: the email address of the Gmail account you want to send emails from
   - `senderName`: the name of the sender
   - `senderPassword`: the app password generated for the Gmail account
   - `recipientEmail`: the email address of the recipient
   - `recipientName`: the name of the recipient
3. Run the example:
    ```bash
    dotnet run
    ```
4. Check the inbox of the recipient email address

## License

This example is licensed under the [MIT License](LICENSE).
