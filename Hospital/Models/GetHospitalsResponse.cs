namespace Hospital.Models
{
    public class GetHospitalsResponse
    {
        public int HospitalID { get; set; }
        public string Name { get; set; }
        public int WaitingTime { get; set; }
        public string Doctor { get; set; }
    }
}
