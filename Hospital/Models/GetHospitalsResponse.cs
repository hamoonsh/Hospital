using System.Collections.Generic;

namespace Hospital.Models
{
    public class GetHospitalsResponse
    {
        public Hospital[] hospitals { get; set; }
    }

    public class Hospital
    {
        public int hospitalID { get; set; }
        public string name { get; set; }
        public int waitingTime { get; set; }
        public string doctor { get; set; }
    }
}