using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;

public class ConcesionarioService
{
    public string InsertVehicle(VehicleModel vehicle)
    {
        // Variables
        string sql, message;
        SqlConnection connection = null;
        int rows_affected;
        try
        {
            connection = SqlDatabaseConnection.GetConnection();
            sql = $"INSERT INTO vehicle VALUES('{vehicle.GetPlate()}','{vehicle.GetModel()}','{vehicle.GetMark()}','{vehicle.GetColor()}', 'active')";
            SqlCommand command = new SqlCommand(sql, connection);
            rows_affected = command.ExecuteNonQuery();
            if (rows_affected == 1) message = "Vehiculo agregado correctamente";
            else message = "No se pudo agregar el vehiculo";
        }
        catch (SqlException sqlex)
        {
            throw new Exception($"Ocurrio un error: {sqlex.Message}");
        }
        catch (Exception ex)
        {
            throw new Exception($"Ocurrio un error interno: {ex.Message}");
        }
        finally
        {
            connection.Close();
        }
        return message;
    }

    public List<VehicleModel> GetVehicle(int id_vehicle)
    {
        // Variables
        SqlConnection connection = null;
        string sql;
        List<VehicleModel> vehicles = new List<VehicleModel>();

        try
        {
            connection = SqlDatabaseConnection.GetConnection();
            sql = $"SELECT * FROM vehicle WHERE id_vehicle='{id_vehicle}'";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int db_id_vehicle = Convert.ToInt32(reader["id_vehicle"]);
                string plate = reader["plate"].ToString();
                string mark = reader["mark"].ToString();
                string model = reader["model"].ToString();
                string color = reader["color"].ToString();
                string status = reader["status"].ToString();

                vehicles.Add(new VehicleModel(db_id_vehicle, plate, mark, model, color, status));
            }
            reader.Close();
        }
        catch (SqlException sqlex)
        {
            throw new Exception($"Ocurrio un error: {sqlex.Message}");
        }
        catch (Exception ex)
        {
            throw new Exception($"Ocurrio un error interno: {ex.Message}");
        }
        finally
        {
            connection.Close();
        }
        return vehicles;
    }

    public List<VehicleModel> GetAllVehicles()
    {
        // Variables
        SqlConnection connection = null;
        string sql;
        List<VehicleModel> vehicles = new List<VehicleModel>();

        try
        {
            connection = SqlDatabaseConnection.GetConnection();
            sql = "SELECT * FROM vehicle WHERE status='active'";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int id_vehicle = Convert.ToInt32(reader["id_vehicle"]);
                string plate = reader["plate"].ToString();
                string mark = reader["mark"].ToString();
                string model = reader["model"].ToString();
                string color = reader["color"].ToString();
                string status = reader["status"].ToString();

                vehicles.Add(new VehicleModel(id_vehicle,plate, mark, model, color,status));
            }
            reader.Close();
        }
        catch (SqlException sqlex)
        {
            throw new Exception($"Ocurrio un error: {sqlex.Message}");
        }
        catch (Exception ex)
        {
            throw new Exception($"Ocurrio un error interno: {ex.Message}");
        }
        finally
        {
            connection.Close();
        }
        return vehicles;
    }

    public string DeleteVehicle(int id_vehicle)
    {
        // Variables
        SqlConnection connection = null;
        string sql, message;
        int rows_affected;

        try
        {
            connection = SqlDatabaseConnection.GetConnection();
            sql = $"UPDATE vehicle SET status = 'deactivate' WHERE id_vehicle = {id_vehicle}";
            SqlCommand command = new SqlCommand(sql, connection);
            rows_affected = command.ExecuteNonQuery();

            if (rows_affected == 1) message = "Vehiculo eliminado correctamente";
            else message = "No se elimino el vehiculo";

        }
        catch (SqlException sqlex)
        {
            throw new Exception($"Ocurrio un error: {sqlex.Message}");
        }
        catch (Exception ex)
        {
            throw new Exception($"Ocurrio un error interno: {ex.Message}");
        }
        finally
        {
            connection.Close();
        }
        return message;
    }

    public string UpdateVehicle(VehicleModel vehicle)
    {
        SqlConnection connection = null;
        string sql, message;
        int rows_affected;

        try
        {
            connection = SqlDatabaseConnection.GetConnection();
            sql = $"UPDATE vehicle SET plate='{vehicle.GetPlate()}', model='{vehicle.GetModel()}', mark='{vehicle.GetMark()}', color='{vehicle.GetColor()}', status='{vehicle.GetStatus()}'";
            sql+= $" WHERE id_vehicle = {vehicle.GetIdVehicle()}";
            SqlCommand command = new SqlCommand(sql, connection);
            rows_affected = command.ExecuteNonQuery();

            if (rows_affected == 1) message = "Vehiculo actualizado correctamente";
            else message = "No se actualizo el vehiculo";

        }
        catch (SqlException sqlex)
        {
            throw new Exception($"Ocurrio un error: {sqlex.Message}");
        }
        catch (Exception ex)
        {
            throw new Exception($"Ocurrio un error interno: {ex.Message}");
        }
        finally
        {
            connection.Close();
        }
        return message;
    }
}

