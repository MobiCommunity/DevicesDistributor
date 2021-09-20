using System;
using System.Net.Http;
using System.Threading.Tasks;
using DevicesDistributor.Core.Services.Abstract;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using SerialNumberProvider.Api.Models;

namespace DevicesDistributor.Core.Services.Concrete
{
    public class SerialNumberProviderClient : ISerialNumberProviderClient
    {
        private readonly string _address;

        public SerialNumberProviderClient(IConfiguration configuration)
        {
            _address = configuration.GetSection("SerialNumberProviderClientAddress").Value;
        }

        public async Task<string> GenerateAsyncSHA256(GenerateSerialNumberRequest request)
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(_address);

            HttpResponseMessage httpResponseMessage = await httpClient.PostAsync("api/serial-number/sha256", new StringContent(JsonConvert.SerializeObject(
                new GenerateSerialNumberRequestModel
                {
                    Id = request.Id,
                    Name = request.Name,
                    Version = request.Version,
                    ProductionDate = request.ProductionDate
                })));

            string resultContent = await httpResponseMessage.Content.ReadAsStringAsync();
            
            if (!httpResponseMessage.IsSuccessStatusCode)
            {
                throw new Exception(
                    $"Error in connection. Details : {resultContent}");
            }

            return resultContent;
        }

        public async Task<string> GenerateAsyncMD5(GenerateSerialNumberRequest request)
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(_address);

            HttpResponseMessage httpResponseMessage = await httpClient.PostAsync("api/serial-number/MD5", new StringContent(JsonConvert.SerializeObject(
                new GenerateSerialNumberRequestModel
                {
                    Id = request.Id,
                    Name = request.Name,
                    Version = request.Version,
                    ProductionDate = request.ProductionDate
                })));

            string resultContent = await httpResponseMessage.Content.ReadAsStringAsync();

            if (!httpResponseMessage.IsSuccessStatusCode)
            {
                throw new Exception(
                    $"Error in connection. Details : {resultContent}");
            }

            return resultContent;
        }
    }
}