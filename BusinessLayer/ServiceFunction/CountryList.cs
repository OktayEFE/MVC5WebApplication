using BusinessLayer.CountryInfoService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ServiceFunction
{
    public class CountryList
    {
        //TypeClient servis bağlantısın da endpoint gönderme sonucu hata aldığımdan dolayı burdan devam edemedim.
        //Servici Pl(MVC5WebApplication) katmaına kurdum. Çözüm sağlanması sonucu burdaki fonksiyonlardan veri çekme işlemi sağlanabiliyor.
        //.Net6 da yaparken burda ki fonksiyonları kullandığımı bilmenizi isterim.
        // Yaklaşık 4 saat uğraştım fakat çözemedim. Bir çok farklı yöntem ve farklı işleyiş sağladım fakat sonuc varamadım.
        CountryInfoServiceSoapTypeClient client = new CountryInfoServiceSoapTypeClient("CountryInfoServiceSoap");

        public List<tCountryCodeAndName> ListOfCountry()
        {
            //var list = new List<string>();
            var list = client.ListOfCountryNamesByCode().ToList();
            return list;
        }
        public string CapitalCity(string IsoCode)
        {
            var value = client.CapitalCity(IsoCode);
            return value;
        }
        public string CountryCurency(string IsoCode)
        {
            var value = client.CountryCurrency(IsoCode).sISOCode;
            return value;
        }
    }
}
