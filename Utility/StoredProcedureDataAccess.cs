using Dapper;
using StoredProcedureExtractor.Models;
using Microsoft.Data.SqlClient;
using System.Diagnostics;

namespace StoredProcedureExtractor.DataAccess
{
    public class StoredProcedureDataAccess
    {
        public static async Task<IEnumerable<StoredProcedure>> GetAllAsync(string connStr, string command)
        {
            try
            {
                using var con = new SqlConnection(connStr);
                var storedProcedures = await con.QueryAsync<StoredProcedure>(command);
                return storedProcedures;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Retrieving procedures error: {ex.Message}");
                return null!;
            }
        }
    }
}