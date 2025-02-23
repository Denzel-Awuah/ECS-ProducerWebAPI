using Amazon.SQS;
using ECS_ProducerWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECS_ProducerWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProducerController : ControllerBase
    {

        private IAmazonSQS sqsClient;

        public ProducerController(IAmazonSQS sqsClient)
        {
            this.sqsClient = sqsClient;
        }

        [HttpPost]
        public async Task<IActionResult> SendMessage([FromBody] Message message)
        {
            //Send the message to Queue 
            return Ok("Message Sent");
        }

    }
}
