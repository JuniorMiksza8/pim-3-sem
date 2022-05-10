class User {

    private string firstname;
    private string lastname;
    private string email;
    private string password;
    private decimal cpf;
    private decimal phone;

    private Address[] addresses;

    private Social social;

    private Vehicle[] vehicles;

    public User(string firstname, string lastname, string email, string password, decimal cpf, decimal phone, Address[] addresses,Social social, Vehicle[] vehicles){
        this.firstname = firstname;
        this.lastname = lastname;
        this.email = email;
        this.password = password;
        this.cpf = cpf;
        this.phone = phone;
        this.addresses = addresses;
        this.firstname = firstname;
        this.lastname = lastname;
        this.email = email;
        this.password = password;
        this.cpf = cpf;
        this.phone = phone;
        this.addresses = addresses;
        this.social = social;
        this.vehicles = vehicles;
    }

    public string Firstname { get => firstname; set => firstname = value; }
    public string Lastname { get => lastname; set => lastname = value; }
    public string Email { get => email; set => email = value; }
    public string Password { get => password; set => password = value; }
    public decimal Cpf { get => cpf; set => cpf = value; }
    public decimal Phone { get => phone; set => phone = value; }
    public Address[] Addresses { get => addresses; set => addresses = value; }
    internal Social Social { get => social; set => social = value; }
    internal Vehicle[] Vehicles { get => vehicles; set => vehicles = value; }
}