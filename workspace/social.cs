class Social {

    private string user_email;
    private decimal whatsapp;
    private string instagram;
    private string linkedin;

    private string github;

    public Social( string user_email,decimal whatsapp, string instagram,string linkedin,string github){
        this.user_email = user_email;
        this.whatsapp = whatsapp;
        this.instagram = instagram;
        this.linkedin = linkedin;
        this.github = github;
    }

    public string User_email { get => user_email; set => user_email = value; }
    public decimal Whatsapp { get => whatsapp; set => whatsapp = value; }
    public string Instagram { get => instagram; set => instagram = value; }
    public string Linkedin { get => linkedin; set => linkedin = value; }
}