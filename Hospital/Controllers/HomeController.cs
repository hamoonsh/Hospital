using Hospital.Models;
using System.Collections.Generic;
using System.Net.Http;

using System.Web.Mvc;

namespace Hospital.Controllers
{
    public class HomeController : Controller
    {
        private const string URL = "https://hospitalapi.pmwebsite.ir/";
        private HttpClient client = new HttpClient();
        public async System.Threading.Tasks.Task<ActionResult> Index()
        {
            //client.DefaultRequestHeaders.Accept.Add(
            //      new MediaTypeWithQualityHeaderValue("application/json"));
            //HttpResponseMessage response = await client.PostAsJsonAsync(URL + "Logon", 0);

            //List<GetHospitalsResponse> Res = await response.Content.ReadAsAsync<List<GetHospitalsResponse>>();
            List<GetHospitalsResponse> Res = new List<GetHospitalsResponse>() { new GetHospitalsResponse() {
                Doctor="kazemi",
                WaitingTime=10,
                HospitalID =1,
            Name="hospital"},new GetHospitalsResponse() {
                Doctor="kazemi2",
                WaitingTime=10,
                HospitalID =2,
            Name="hospital2"},
            new GetHospitalsResponse() {
                Doctor="kazemi3",
                WaitingTime=10,
                HospitalID =3,
            Name="hospital3"},
            new GetHospitalsResponse() {
                Doctor="kazemi4",
                WaitingTime=10,
                HospitalID =4,
            Name="hospital4"},
                new GetHospitalsResponse() {
                Doctor="kazemi5",
                WaitingTime=10,
                HospitalID =5,
            Name="hospital5"},
            new GetHospitalsResponse() {
                Doctor="kazemi6",
                WaitingTime=10,
                HospitalID =6,
            Name="hospital6"}};
            return View(Res);
        }
    }
}
