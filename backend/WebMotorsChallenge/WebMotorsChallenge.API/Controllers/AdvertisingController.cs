using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using WebMotorsChallenge.Application.Queries.AdvertisementsQuery;

namespace WebMotorsChallenge.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdvertisingController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        [ProducesResponseType(typeof(AdvertisementsQueryResponse), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAdvertisements([FromServices] IMediator mediator,
                                                            [FromServices] ILogger<AdvertisingController>  logger)
        {
            try
            {
                logger.LogInformation("Get all Advertisements");

                var result = await mediator.Send(new AdvertisementsQueryRequest());

                return Ok(result);
            }
            catch (Exception ex)
            {

                logger.LogInformation(ex.Message);

                return BadRequest(StatusCodes.Status400BadRequest);

            }
        }
    }
}
