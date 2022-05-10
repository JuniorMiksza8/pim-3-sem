class Vehicle {
    private string name ;
    private string plate;
    private string model;
    private string renavam;
    private string color;
    private string user_email;

    public Vehicle(string name, string plate, string model, string renavam, string color, string user_email)
    {
        this.name = name;
        this.plate = plate;
        this.model = model;
        this.renavam = renavam;
        this.color = color;
        this.user_email = user_email;
    }

    public string Name { get => name; set => name = value; }
    public string Plate { get => plate; set => plate = value; }
    public string Model { get => model; set => model = value; }
    public string Renavam { get => renavam; set => renavam = value; }
    public string Color { get => color; set => color = value; }
    public string User_email { get => user_email; set => user_email = value; }
}