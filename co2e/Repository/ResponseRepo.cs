using co2e.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using co2e.DataObjectTransfer;
using co2e.Mapper;

namespace co2e.Repositorio
{
    public class ResponseRepo
    {
        private readonly string _connection = @"Data Source=ITELABD05\SQLEXPRESS;Initial Catalog=co2eAPI;Integrated Security=True;";

        public bool SaveConstituentGasesApi(ConstituentGases constituentgases)
        {
            try
            {
                var query = @"INSERT INTO ConstituentGases
                            (ch4, co2, co2e_other, co2e_total, n2o)
                            VALUES(@ch4, @co2, @co2e_other, @co2e_total, @n2o)";

                using (var connection = new SqlConnection(_connection))
                {
                    var parametros = new
                    {
                   
                        ch4 = constituentgases.ch4,
                        co2 = constituentgases.co2,
                        co2e_other = constituentgases.co2e_other,
                        co2e_total = constituentgases.co2e_total,                                                                
                        n2o = constituentgases.n2o

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

        public bool SaveResponse(ApiResponseMapper apiresponse)
        {
            try
            {
                var query = @"INSERT INTO ApiClimatiqResponse
                                (Co2e, Co2eUnit, Co2eCalculationMethod, Co2eCalculationOrigin, Id_ConstituentGases, Id_EmissionFactor)
                                VALUES(@co2e, @co2eunit, @co2ecalculationmethod, @co2ecalculationorigin,@id_constituentgases, @id_emissionfactor";

                using (var connection = new SqlConnection(_connection))
                {
                    var parametros = new
                    {

                        co2e = apiresponse.Co2e,
                        co2eunit = apiresponse.Co2eCalculationMethod,
                        co2ecalculationmethod = apiresponse.Co2eCalculationOrigin,
                        co2ecalculationorigin = apiresponse.Co2eUnit,
                        id_constituentgases = apiresponse.ConstituentGases,
                        id_emissionfactor = apiresponse.EmissionFactor,

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

        public bool DeleteResponse(ApiResponseMapper apiresponse)
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

