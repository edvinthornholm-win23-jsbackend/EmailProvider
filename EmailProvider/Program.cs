using Azure.Communication.Email;
using EmailProvider.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var host = new HostBuilder()
    .ConfigureFunctionsWorkerDefaults()

    .ConfigureServices(services =>
    {
        services.AddSingleton<EmailClient>(new EmailClient(Environment.GetEnvironmentVariable("CommunicationServices")));
        services.AddSingleton<IEmailService, EmailService>();
    })

    .Build();
// Run the host

host.Run();
