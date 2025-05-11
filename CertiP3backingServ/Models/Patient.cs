namespace CertiP3backingServ.Models
{
    public class Patient
    {
        public string CI { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
      

        public Patient(string ci, string name, string lastName)
        {
            CI = ci;
            Name = name;
            LastName = lastName;
          
        }

        
    }
}
