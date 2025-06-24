namespace Npedidos.Entities
{
    class Client
    {
        public string Email { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }

        public Client()
        {
        }

        public Client(string email, string name, DateTime birthDate)
        {
            Email = email;
            Name = name;
            BirthDate = birthDate;
        }

        public override string ToString()
        {
            return Name + ", (" + BirthDate.ToString("dd/MM/yyyy") + ") - " + Email;
        }

    }
}
