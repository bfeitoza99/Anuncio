using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WebMotorsChallenge.Domain.DTOS;
using WebMotorsChallenge.Domain.HttpClientInstance;
using WebMotorsChallenge.Domain.Interfaces.Service;

namespace WebMotorsChallenge.Application.AppServices
{
    public class ChallengeIntegrationService : IChallengeIntegrationService
    {

        public ChallengeIntegrationService() { }

        public async  Task<List<VehicleMarkResponseDTO>> GetVehiclesMarks()
        {           

            HttpResponseMessage response = await HttpClientInstance.GetHttpClientInstance().GetAsync("https://desafioonline.webmotors.com.br/api/OnlineChallenge/Make");

            return JsonConvert.DeserializeObject<List<VehicleMarkResponseDTO>>(response.Content.ReadAsStringAsync().Result);
        }


        public async Task<List<VehicleModelResponseDTO>> GetVehiclesModels(int id)
        {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, "https://desafioonline.webmotors.com.br/api/OnlineChallenge/Model?MakeID=" + id);

            HttpResponseMessage response = await HttpClientInstance.GetHttpClientInstance().GetAsync($"https://desafioonline.webmotors.com.br/api/OnlineChallenge/Model?MakeID=" + id);

            return JsonConvert.DeserializeObject<List<VehicleModelResponseDTO>>(response.Content.ReadAsStringAsync().Result);
        }                

        public async Task<List<VehicleVersionResponseDTO>> GetVehiclesVestions(int id)
        {
            HttpResponseMessage response = await  HttpClientInstance.GetHttpClientInstance().GetAsync("https://desafioonline.webmotors.com.br/api/OnlineChallenge/Version?ModelID=" + id);

            return JsonConvert.DeserializeObject<List<VehicleVersionResponseDTO>>(response.Content.ReadAsStringAsync().Result);
        }
    }
}
