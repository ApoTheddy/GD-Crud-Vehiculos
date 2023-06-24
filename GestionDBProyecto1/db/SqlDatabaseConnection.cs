using System;
using System.Data.SqlClient;

public class SqlDatabaseConnection
{
    public static SqlConnection GetConnection()
    {
        try
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-4HE0THI\\SQLEXPRESS;database=concesionario ; Integrated Security=True");
            connection.Open();
            return connection;
        }
        catch (SqlException sqlex)
        {
            throw sqlex;
        }
    }
}
