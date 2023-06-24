
using System.Collections.Generic;

public class ConsesionarioController
{
    private readonly ConcesionarioService consesionario_service = new ConcesionarioService();   

    public string InsertVehicle(VehicleModel vehicle)
    {
        return consesionario_service.InsertVehicle(vehicle);
    }
    
    public List<VehicleModel> GetVehicle(int id_vehicle)
    {
        return consesionario_service.GetVehicle(id_vehicle);
    }


    public List<VehicleModel> GetAllVehicles()
    {
        return consesionario_service.GetAllVehicles();
    }

    public string DeleteVehicle(int id_vehicle)
    {
        return consesionario_service.DeleteVehicle(id_vehicle);
    }
    
    public string UpdateVehicle(VehicleModel vehicle)
    {
        return consesionario_service.UpdateVehicle(vehicle);
    }

}
