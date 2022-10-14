using BusinessLayer.Concrete;
using BusinessLayer.ServiceModel;
using EntityLayer.Model;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Web.Mvc;

namespace MVC5WebApplication.Controllers
{
    public class CountryController : Controller
    {
        CountryManager _countryManager = new CountryManager();
        CountryService.CountryInfoServiceSoapTypeClient client = new CountryService.CountryInfoServiceSoapTypeClient("CountryInfoServiceSoap");

        public ActionResult Index()
        {
            var countrylist = client.ListOfCountryNamesByCode().ToList();
            var model = countrylist.Select(x => new ServiceCountryDetail { CountryName = x.sName, CountryISOCode = x.sISOCode }).ToList();
            ViewBag.countryNameList = countrylist.Select(x=> new SelectListItem
            {
                Text = x.sName,
                Value = x.sISOCode
            });
            return View();
        }
        [HttpPost]
        public ActionResult CountryDetails(string IsoCode)
        {
            try
            {
                var countrylist = client.ListOfCountryNamesByCode().ToList().Where(x => x.sISOCode == IsoCode).ToList();
                var cCurrency = client.CountryCurrency(IsoCode).sISOCode;
                var cCity = client.CapitalCity(IsoCode);
                var model = countrylist.Select(x => new ServiceCountryDetail { CountryName = x.sName, CountryISOCode = x.sISOCode, CapitalCity = cCity, CountryCurrency = cCurrency }).ToList();
                var json = JsonConvert.SerializeObject(model);
                return Json(json);
            }

            catch (Exception e)
            {

                return Json(new { result = e, message = e.Message });
            }

        }

        [HttpPost]
        public ActionResult Index(CountryInfo country)
        {
            country.Status = true;
            try
            {
                _countryManager.CountryAddBL(country);
                return Json(new { result = 1, message = "Başarılı." });
            }
            catch (Exception ex)
            {
                return Json(new { result = ex, message = ex.Message });
            }

        }
    }
}