using co2e.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;

namespace co2e.Repositorio
{
    public class ResponseRepo
    {
        private readonly string _connection = "asdasd";

        public bool SaveResponse(ApiClimatiqResponse apiresponse)
        {
            try
            {


                var query = @"INSERT INTO ApiClimatiqResponse
                                (Co2e, Co2eUnit, Co2eCalculationMethod, Co2eCalculationOrigin, EmissionFactor, ConstituentGases)
                                VALUES(@co2e, @co2eunit, @co2ecalculationmethod, @co2ecalculationorigin, @emissionfactor, @constituentgases";

                using (var connection = new SqlConnection(_connection))
                {

                    var parametros = new
                    {

                        //apiresponse.Co2e,
                        //apiresponse.Co2eCalculationMethod,
                        //apiresponse.Co2eCalculationOrigin,
                        //apiresponse.Co2eUnit,
                        //apiresponse.ConstituentGases,
                        //apiresponse.EmissionFactor,


                    };
                    connection.Execute(query, parametros);
                    return true;


                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;

            }


        }
    }
}
