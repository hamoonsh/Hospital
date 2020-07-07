using Hospital.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Mvc;

namespace Hospital.Controllers
{
    public class HomeController : Controller
    {
        private const string URL = "https://hospitalapi.pmwebsite.ir/";
        private HttpClient client = new HttpClient();

        public async System.Threading.Tasks.Task<ActionResult> Index()
        {
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = await client.GetAsync(URL + "Hospital?level=0");
            GetHospitalsResponse Res = await response.Content.ReadAsAsync<GetHospitalsResponse>();
            foreach (var item in Res.hospitals)
            {
                item.waitingTime = 0;
            }
            return View(Res);
        }

        [AjaxOnly]
        [HttpPost]
        public async System.Threading.Tasks.Task<ActionResult> RegPatientAsync(Patient patient)
        {
            if (!ModelState.IsValid)
            {
                return Json(new { result = false });
            }
            client.DefaultRequestHeaders.Accept.Add(
                 new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage res = await client.PostAsJsonAsync(URL + "Patient", patient);
            if (res.IsSuccessStatusCode)
            {
                return Json(new { result = true });
            }
            else
            {
                return Json(new { result = false });
            }
        }
    }
}