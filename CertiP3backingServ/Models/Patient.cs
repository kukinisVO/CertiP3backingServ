namespace CertiP3backingServ.Models
{
    public class Patient
    {
        public string CI { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string BloodType { get; set; }

        public Patient(string ci, string name, string lastName)
        {
            CI = ci;
            Name = name;
            LastName = lastName;
            BloodType = RandomBloodType();
        }

        private string RandomBloodType()
        {
            string[] bloodTypes = { "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" };
            Random random = new Random();
            return bloodTypes[random.Next(bloodTypes.Length)];
        }
    }
}
