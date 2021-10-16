using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMotorsChallenge.Domain.DTOS;
using WebMotorsChallenge.Domain.Interfaces.Service;

namespace WebMotorsChallenge.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class VehiclesController : ControllerBase
    {
        [HttpGet]
        [Route("Mark")]
        [ProducesResponseType(typeof(List<VehicleMarkResponseDTO>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetVehiclesMark([FromServices] IChallengeIntegrationService service,
                                                             [FromServices] ILogger<VehiclesController> logger, int id)
        {
            try
            {
                logger.LogInformation($"Get All Vehicles Marks ");

                var result = await service.GetVehiclesMarks();

                return Ok(result);
            }
            catch (Exception ex)
            {

                logger.LogInformation(ex.Message);

                return BadRequest(StatusCodes.Status400BadRequest);

            }
        }

        [HttpGet]
        [Route("Model/{id}")]
        [ProducesResponseType(typeof(List<VehicleModelResponseDTO>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetVehiclesModel([FromServices] IChallengeIntegrationService service,
                                                             [FromServices] ILogger<VehiclesController> logger, int id)
        {
            try
            {
                logger.LogInformation($"Get All Vehicles Models by id: {id} ");

                var result = await service.GetVehiclesModels(id);

                return Ok(result);
            }
            catch (Exception ex)
            {

                logger.LogInformation(ex.Message);

                return BadRequest(StatusCodes.Status400BadRequest);

            }
        }

        [HttpGet]
        [Route("Version/{id}")]
        [ProducesResponseType(typeof(List<VehicleVersionResponseDTO>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetVehiclesVersion([FromServices] IChallengeIntegrationService service,
                                                             [FromServices] ILogger<VehiclesController> logger, int id)
        {
            try
            {
                logger.LogInformation($"Get All Vehicles Version by id: {id}");

                var result = await service.GetVehiclesVestions(id);

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
