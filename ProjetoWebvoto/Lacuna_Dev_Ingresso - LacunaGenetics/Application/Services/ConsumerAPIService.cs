using Lacuna.Dev.Ingresso.LacunaGenetics.Abstraction;
using Lacuna.Dev.Ingresso.LacunaGenetics.Enum;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace Lacuna.Dev.Ingresso.LacunaGenetics.Services
{
    public class ConsumerAPIService<TRequest, TResponse> where TRequest : IRequest
    {
        public TResponse ConnectToApi(TRequest request, TResponse responseGenerico, string token = "", string idJob = "")
        {

            string endereco = request.GetAddress().Replace("{id}",idJob);

            using (var cliente = new HttpClient())
            {
                cliente.BaseAddress = new Uri("https://gene.lacuna.cc/");
                cliente.DefaultRequestHeaders.Accept.Clear();
                cliente.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                if (!String.IsNullOrEmpty(token))
                {
                    cliente.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                }
                HttpResponseMessage response;

                try
                {
                    if (request.GetTypeHttpRequest() == TypeEnum.HttpGet)
                    {
                        response = cliente.GetAsync(endereco).Result;
                    }
                    else
                    {
                        response = cliente.PostAsJsonAsync(endereco, request).Result;
                    }

                    if (response.IsSuccessStatusCode)
                    {
                        var customerJsonString = response.Content.ReadAsStringAsync().Result;
                        responseGenerico = System.Text.Json.JsonSerializer.Deserialize<TResponse>(customerJsonString);
                        
                        return responseGenerico;
                    }
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
            return responseGenerico;

        }
    }
}
