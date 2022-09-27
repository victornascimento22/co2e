using co2e.Models;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        public static void Menu()
        {


            int opcao = Convert.ToInt32(Console.ReadLine());

            if (opcao == 1)
            {
                var request = new EmissionFactorRequest()
                {
                    activity_id = "freight_vehicle-vehicle_type-hgv_refrig-fuel_source_diesel-vehicle_weight_na-percentage_load_100"
                };

                var requestoi = new ParametersRequest()
                {
                    weight = 10,
                    weight_unit = "t",
                    distance = 500,
                    distance_unit = "km"



                };

                //services.Services(request, requestoi);

            }
        }
    }

}

