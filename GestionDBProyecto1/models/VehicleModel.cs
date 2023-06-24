public class VehicleModel
{
    private int id_vehicle;
    private string plate;
    private string mark;
    private string model;
    private string color;
    private string status;

    public VehicleModel() { }

    public VehicleModel(string plate, string mark, string model, string color)
    {
        this.plate = plate;
        this.mark = mark;
        this.model = model;
        this.color = color;
    }

    public VehicleModel(int id_vehicle, string plate, string mark, string model, string color, string status)
    {
        this.id_vehicle = id_vehicle;
        this.plate = plate;
        this.mark = mark;
        this.model = model;
        this.color = color;
        this.status = status;
    }

    // GETTERS

    public void SetIdVehicle(int id_vehicle) => this.id_vehicle = id_vehicle;
    public void SetPlate(string plate) => this.plate = plate;

    public void SetMark(string mark) => this.mark = mark;

    public void SetModel(string model) => this.model = model;

    public void SetColor(string color) => this.color = color;
    public void SetStatus(string status) => this.status = status;

    // SETTERS
    public string GetPlate() => plate;
    public string GetMark() => mark;
    public string GetModel() => model;
    public string GetColor() => color;
    public int GetIdVehicle() => id_vehicle;
    public string GetStatus() => status;
}
