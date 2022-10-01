using co2e.Models;
using co2e.Services;
using System;

namespace ConsoleApp1
{
    class Program
    {

        public static APIRequest apirequest = new APIRequest();
        static void Main(string[] args)
        {
            Menu();
        }
        public static void Menu()
        {


            int opcao = Convert.ToInt32(Console.ReadLine());

            if (opcao == 1)
            {
                var requestid = new EmissionFactorRequest()
                {
                    activity_id = "freight_vehicle-vehicle_type-hgv_refrig-fuel_source_diesel-vehicle_weight_na-percentage_load_100"
                };

                var requestparameters = new ParametersRequest()
                {
                    weight = 10,
                    weight_unit = "t",
                    distance = 500,
                    distance_unit = "km"



                };

                apirequest.ApiClimatiqRequest(requestid, requestparameters);

            }
        }
    }

}

