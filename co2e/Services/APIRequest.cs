using co2e.DataObjectTransfer;
using co2e.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace co2e.Services
{
    public class APIRequest
    {
        public static List<ApiClimatiqDTO> root = new List<ApiClimatiqDTO>();

        public ApiClimatiqDTO ApiClimatiqRequest(EmissionFactorRequest activityid, ParametersRequest parametersmodel)
        {

            HttpClient httpclient = new HttpClient();
            httpclient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "98J1Y90YD54XW4NYM934H68PW9J8");
            HttpResponseMessage response;

            var viewModel = new
            {

                emission_factor = activityid,
                parameters = parametersmodel

            };

            var json = JsonConvert.SerializeObject(viewModel);

            try
            {

                response = httpclient.PostAsync( "https://beta3.api.climatiq.io/estimate", new StringContent(json, Encoding.UTF8, "application/json")).Result;
                response.EnsureSuccessStatusCode();

                string resultado = response.Content.ReadAsStringAsync().Result;

                var obj = JsonConvert.DeserializeObject<ApiClimatiqDTO>(resultado);
           
                return obj;


                //var resultado = response.Content.ReadAsStringAsync().Result;

                //Console.WriteLine(resultado);

            }
            catch (HttpRequestException ex)
            {

                Console.WriteLine(ex.Message);
                return null;
            }

        }
    }
}

