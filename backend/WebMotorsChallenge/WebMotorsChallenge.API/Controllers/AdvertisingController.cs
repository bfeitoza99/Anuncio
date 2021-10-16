using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;
using WebMotorsChallenge.Application.Commands.CreateAdvertisingCommand;
using WebMotorsChallenge.Application.Queries.AdversitingQuery;
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

        [HttpGet]
        [Route("{id}")]
        [ProducesResponseType(typeof(AdversitingQueryResponse), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetById([FromServices] IMediator mediator,
                                                            [FromServices] ILogger<AdvertisingController> logger, int id)
        {
            try
            {
                logger.LogInformation($"Get Advertising by id: {id}");

                var result = await mediator.Send(new AdversitingQueryRequest(id));

                return Ok(result);
            }
            catch (Exception ex)
            {

                logger.LogInformation(ex.Message);

                return BadRequest(StatusCodes.Status400BadRequest);

            }
        }

        [HttpPost]
        [ProducesResponseType(typeof(CreateAdvertisingCommandResponse), StatusCodes.Status200OK)]
        public async Task<IActionResult> Post([FromServices] IMediator mediator,
                                                            [FromServices] ILogger<AdvertisingController> logger, 
                                                            [FromBody] CreateAdvertisingCommandRequest request )
        {
            try
            {
                logger.LogInformation($"Create a new Advertising with proprerties: {JsonConvert.SerializeObject(request)}");

                var result = await mediator.Send(request);

                return Ok(result);
            }
            catch (Exception ex)
            {

                logger.LogInformation(ex.Message);

                return BadRequest(StatusCodes.Status400BadRequest);

            }
        }

        [HttpDelete]
        [Route("{id}")]
        [ProducesResponseType(typeof(CreateAdvertisingCommandResponse), StatusCodes.Status200OK)]
        public async Task<IActionResult> Delete([FromServices] IMediator mediator,
                                                            [FromServices] ILogger<AdvertisingController> logger,
                                                            int id)
        {
            try
            {
                logger.LogInformation($"Delete an Advertising with id: {id}");

                var result = await mediator.Send(request);

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
