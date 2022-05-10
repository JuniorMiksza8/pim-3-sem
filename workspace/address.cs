class Address {
    private string street;
    private string number;
    private string neighborhood;
    private string complement;
    private string reference;
    private string city;
    private string state;
    private decimal id;
    private string name;
    private string user_email;

    public Address(string street, string number, string neighborhood, string complement, string reference, string city, string state, decimal id, string name, string user_email)
    {
        this.street = street;
        this.number = number;
        this.neighborhood = neighborhood;
        this.complement = complement;
        this.reference = reference;
        this.city = city;
        this.state = state;
        this.id = id;
        this.name = name;
        this.user_email = user_email;
    }

    public string Street { get => street; set => street = value; }
    public string Number { get => number; set => number = value; }
    public string Neighborhood { get => neighborhood; set => neighborhood = value; }
    public string Complement { get => complement; set => complement = value; }
    public string Reference { get => reference; set => reference = value; }
    public string City { get => city; set => city = value; }
    public string State { get => state; set => state = value; }
    public decimal Id { get => id; set => id = value; }
    public string Name { get => name; set => name = value; }
    public string User_email { get => user_email; set => user_email = value; }
}
   