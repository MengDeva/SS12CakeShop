using Microsoft.Data.SqlClient;

namespace SS12CarWashing.Models;

public class AdoDB
{
    public SqlConnection connection;
    public static string conString = @"Server=.;Database=SS12CakeShop;User Id=sa;Password=sa;TrustServerCertificate=true;";
    public AdoDB()
    {
        connection = new SqlConnection(conString);
    }
    public SqlDataReader Execute(string sql)
    {
        connection.Open();
        var cmd =new SqlCommand(sql, connection);
        return cmd.ExecuteReader();
    }
}
