using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebMotorsChallenge.Domain.DTOS;

namespace WebMotorsChallenge.Domain.Interfaces.Service
{
    public interface IChallengeIntegrationService
    {
        Task<List<VehicleMarkResponseDTO>> GetVehiclesMarks();

        Task<List<VehicleModelResponseDTO>> GetVehiclesModels(int id);

        Task<List<VehicleVersionResponseDTO>> GetVehiclesVestions(int id);
    }
}
