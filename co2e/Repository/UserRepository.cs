using co2e.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace co2e.Repository
{
    public class UserRepository
    {
        private readonly string _connection = @"Data Source=ITELABD05\SQLEXPRESS;Initial Catalog=co2eAPI;Integrated Security=True;";

        public bool UserCreate(User user)
        {
            try
            {
                var query = @"INSERT INTO User
                            (Nome, CNPJ, Email, Ramo, Senha, Empresa)
                            VALUES(@nome, @cnpj, @email, @ramo, @senha, @empresa)";

                using (var connection = new SqlConnection(_connection))
                {
                    var parametros = new
                    {

                        user = user.Nome,
                        cnpj = user.CNPJ,
                        email = user.Email,
                        ramo = user.Ramo,
                        senha = user.Senha,
                        empresa = user.Empresa

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
