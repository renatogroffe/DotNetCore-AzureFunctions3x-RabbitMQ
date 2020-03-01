using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace FunctionAppRabbitMQ
{
    public static class RabbitMQTrigger
    {
        [FunctionName("RabbitMQTrigger")]
        public static void Run(
            [RabbitMQTrigger("TesteAzureFunctionsLocal", ConnectionStringSetting = "RabbitMQConnection")]string inputMessage,
            ILogger log)
        {
            log.LogInformation($"Mensagem recebida: {inputMessage}");
        }
    }
}