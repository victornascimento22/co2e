using co2e.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using co2e.DataObjectTransfer;

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
                                VALUES(@co2e, @co2eunit, @co2ecalculationmethod, @co2ecalculationorigin, @id_emissionfactor, @constituentgases";

                using (var connection = new SqlConnection(_connection))
                {
                    var parametros = new
                    {

                        apiresponse.Co2e,
                        apiresponse.Co2eCalculationMethod,
                        apiresponse.Co2eCalculationOrigin,
                        apiresponse.Co2eUnit,
                        apiresponse.ConstituentGases,
                        apiresponse.EmissionFactor,
                    };
                    connection.ExecuteAsync(query, parametros);
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;

            }
        }

        public bool DeleteResponse(ApiClimatiqResponse apiresponse)
        {
            try
            {
                var query = @"DELETE FROM ApiClimatiqResponse
                              (id)
                                VALUES(@id)";

                using (var connection = new SqlConnection(_connection))
                {
                    var parametros = new
                    {
                        apiresponse.Id_ApiClimatiqResponse

                    };
                    connection.ExecuteAsync(query, parametros);
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;

            }
        }

        public List<ApiClimatiqDTO> BuscarTodosResponse()
        {
            try
            {
                var query = @"SELECT * FROM ApiClimatiqResponse";

                using (var connection = new SqlConnection(_connection))
                {
                    return connection.Query<ApiClimatiqDTO>(query).ToList();
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return new List<ApiClimatiqDTO>();
            }
        }

        public ApiClimatiqDTO BuscarResponse(int idresponse)
        {
            try
            {
                var query = @"SELECT * FROM ApiClimatiqResponse WHERE Id = @idresponse";

                using (var connection = new SqlConnection(_connection))
                {
                    var parametros = new
                    {
                        idresponse
                    };
                    return connection.QueryFirstOrDefault<ApiClimatiqDTO>(query, parametros);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}

