using System;
using System.Collections.Generic;
using System.Web.Caching;
using System.Web.Mvc;
using BeautyGoddess.Models.Price;

namespace BeautyGoddess.Controllers
{
    public class PriceController : BaseController
    {
        private List<PriceModel> _priceList;

        public List<PriceModel> PriceList
        {
            get
            {
                if (_priceList != null) return PriceList;
                _priceList = (HttpContext.Cache["PriceList"] as List<PriceModel>);
                if (_priceList == null)
                {
                    _priceList = GetPriceList();
                    var cacheTime = GettAppSetting<double>("cacheTimeInSeconds");
                    HttpContext.Cache.Insert("PriceList", _priceList, null, DateTime.Now.AddSeconds(cacheTime), Cache.NoSlidingExpiration, CacheItemPriority.High, null);
                }
                return _priceList;
            }
        }

        private List<PriceModel> GetPriceList ()
        {
            var priceList = new List<PriceModel>
            {
                new PriceModel {Id = 1, ServiceId = null, Title = "Konsultacija atliekant procedūrą pas specialistą nemokama", Description="", Price = "", PriceWithDiscount = "", IsGroup = true},
                new PriceModel {Id = 2, ServiceId = 8, Title = "Aparatūrinės veido procedūros", Description="", Price = "", PriceWithDiscount = "", IsGroup = true},
                new PriceModel {Id = 3, ServiceId = null, Title = "Sonoforezė (ultragarso aparatu) + kaukė", Description="Odos renjefą lyginanti, drėkinanti,maitinanti procedūra", Price = "55 €", PriceWithDiscount = "", IsGroup = false},
                new PriceModel {Id = 4, ServiceId = null, Title = "Sonoforezė (ultragarso aparatu)", Description="Odos renjefą lyginanti, drėkinanti,maitinanti procedūra", Price = "40 €", PriceWithDiscount = "", IsGroup = false},
                new PriceModel {Id = 5, ServiceId = null, Title = "Jonoforezė (aktyvių medžiagų įvedimas) + kaukė", Description="Jauninanti, liftingo efekto procedūra", Price = "55 €", PriceWithDiscount = "", IsGroup = false},
                new PriceModel {Id = 6, ServiceId = null, Title = "Jonoforezė (aktyvių medžiagų įvedimas)", Description="Jauninanti, liftingo efekto procedūra", Price = "40 €", PriceWithDiscount = "", IsGroup = false},
                new PriceModel {Id = 7, ServiceId = null, Title = "Darsonvalis + kaukė", Description="Palaikanti odos turgorą ir elastingumą procedūra ", Price = "40 €", PriceWithDiscount = "", IsGroup = false},
                new PriceModel {Id = 8, ServiceId = null, Title = "Darsonvalis", Description="Palaikanti odos turgorą ir elastingumą procedūra ", Price = "30 €", PriceWithDiscount = "", IsGroup = false},
                new PriceModel {Id = 9, ServiceId = null, Title = "Dezinkrustacija + kaukė", Description="Švelniai, matinei odos būklei palaikyti", Price = "45 €", PriceWithDiscount = "", IsGroup = false},
                new PriceModel {Id = 10, ServiceId = null, Title = "Dezinkrustacija", Description="Švelniai, matinei odos būklei palaikyti", Price = "30 €", PriceWithDiscount = "", IsGroup = false},
                new PriceModel {Id = 11, ServiceId = 1, Title = "Veido odos procedūros", Description="", Price = "", PriceWithDiscount = "", IsGroup = true},
                new PriceModel {Id = 12, ServiceId = null, Title = "Mechaninis veido valymas", Description="Demakiažas, pilingas, veido brinkinimas, mechaninis išvalymas, raminanti kaukė + poras sutraukianti kaukė, tonizavimas, kremas", Price = " 35 €", PriceWithDiscount = "", IsGroup = false},
                new PriceModel {Id = 13, ServiceId = null, Title = "Cheminis pilingas", Description="", Price = " 30 €", PriceWithDiscount = "", IsGroup = false},
                new PriceModel {Id = 14, ServiceId = null, Title = "Veido procedūra pagal odos poreikius (giliai drėkinanti / valomoji / maitinanti / raminanti)", Description="", Price = "20 €", PriceWithDiscount = "", IsGroup = false},
                new PriceModel {Id = 15, ServiceId = null, Title = "Veido odos procedūra pagal odos poreikius  + Žake-leri masažas", Description="", Price = "35 €", PriceWithDiscount = "", IsGroup = false},
                new PriceModel {Id = 16, ServiceId = null, Title = "Veido odos prozedūra pagal odos poreikius + Plastinis veido masažas", Description="", Price = "45 €", PriceWithDiscount = "", IsGroup = false},
                new PriceModel {Id = 17, ServiceId = null, Title = "Plastinis veido masažas su prabangiu drėkinančiu, atpalaiduojančiu veido serumu", Description="", Price = "32 €", PriceWithDiscount = "", IsGroup = false},
                new PriceModel {Id = 18, ServiceId = null, Title = "Vitamino C terapija", Description="Demakiažas, pilingas, vitamino C koncentratas, kaukė, tonizavimas, kremas", Price = "35 €", PriceWithDiscount = "", IsGroup = false},
                new PriceModel {Id = 19, ServiceId = 2, Title = "Mezoterapija", Description="", Price = "", PriceWithDiscount = "", IsGroup = true},
                new PriceModel {Id = 20, ServiceId = null, Title = "Mezoterapija veidui /  kaklui ir dekolte", Description="", Price = "50-80€", PriceWithDiscount = "", IsGroup = false},
                new PriceModel {Id = 21, ServiceId = null, Title = "Paakių srities mezoterapija", Description="", Price = "30 €", PriceWithDiscount = "", IsGroup = false},
                new PriceModel {Id = 22, ServiceId = null, Title = "Lipolitinė mezoterapija dvigubo pagurklio / šlaunų / pilvo", Description="", Price = "50-70 €", PriceWithDiscount = "", IsGroup = false},
                new PriceModel {Id = 23, ServiceId = null, Title = "Mezoterapija skatinanti plaukų augimą", Description="", Price = "50-60 €", PriceWithDiscount = "", IsGroup = false},
                new PriceModel {Id = 24, ServiceId = null, Title = "Homeopatinė mezoterapija (randams post acne / pigmentinėms dėmėms / kuperozei)", Description="", Price = " 40-60 €", PriceWithDiscount = "", IsGroup = false},
                new PriceModel {Id = 25, ServiceId = null, Title = "Biorevitalizacija (veido / kaklo ir dekolte)", Description="", Price = "110-150 €", PriceWithDiscount = "", IsGroup = false},
                new PriceModel {Id = 26, ServiceId = null, Title = "Nuskausminimas procedūros metu", Description="", Price = "8 €", PriceWithDiscount = "", IsGroup = false},
                new PriceModel {Id = 27, ServiceId = 4, Title = "Hialurono rūgšties užpildai", Description="", Price = "", PriceWithDiscount = "", IsGroup = true},
                new PriceModel {Id = 28, ServiceId = null, Title = "Veido raukšlėms", Description="", Price = "nuo 150 €", PriceWithDiscount = "", IsGroup = false},
                new PriceModel {Id = 29, ServiceId = null, Title = "Lūpų putlinimas", Description="", Price = "150-280 €", PriceWithDiscount = "", IsGroup = false},
                new PriceModel {Id = 30, ServiceId = 7, Title = "Adatinė Dermaroler terapija", Description="", Price = "", PriceWithDiscount = "", IsGroup = true},
                new PriceModel {Id = 31, ServiceId = null, Title = "Procedūros kaina", Description="", Price = "38 €", PriceWithDiscount = "", IsGroup = false},
                new PriceModel {Id = 32, ServiceId = null, Title = "Dermorolerio įsigyjimas pirmos procedūros metu", Description="", Price = "30 €", PriceWithDiscount = "", IsGroup = false},
                new PriceModel {Id = 33, ServiceId = 10, Title = "Blakstienų priauginimas 'Volume'", Description="", Price = "", PriceWithDiscount = "", IsGroup = true},
                new PriceModel {Id = 34, ServiceId = null, Title = "2D-6D blakstienų priauginimas", Description="", Price = "40-60 €", PriceWithDiscount = "25-40 €", IsGroup = false},
                new PriceModel {Id = 35, ServiceId = null, Title = "2D-6D blakstienų korekcija", Description="", Price = "25-45 €", PriceWithDiscount = "19-29 €", IsGroup = false},
                new PriceModel {Id = 36, ServiceId = null, Title = "Blakstienų nuėmimas", Description="", Price = "15 €", PriceWithDiscount = "", IsGroup = false},
                new PriceModel {Id = 37, ServiceId = 11, Title = "Antakių dažymas", Description="", Price = "", PriceWithDiscount = "", IsGroup = true},
                new PriceModel {Id = 38, ServiceId = null, Title = "Antakių dažymas ir korekcija", Description="", Price = "3-6 €", PriceWithDiscount = "", IsGroup = false},
                new PriceModel {Id = 39, ServiceId = 12, Title = "Estetinis plaukų šalinimas vašku", Description="", Price = "", PriceWithDiscount = "", IsGroup = true},
                new PriceModel {Id = 40, ServiceId = null, Title = "Veido", Description="", Price = "5-8 €", PriceWithDiscount = "", IsGroup = false},
                new PriceModel {Id = 41, ServiceId = null, Title = "Kojų", Description="", Price = "20 €", PriceWithDiscount = "", IsGroup = false},
                new PriceModel {Id = 42, ServiceId = null, Title = "Blauzdų sritis", Description="", Price = "10-12 €", PriceWithDiscount = "", IsGroup = false},
                new PriceModel {Id = 43, ServiceId = null, Title = "Pažastų sritis", Description="", Price = "8-10 €", PriceWithDiscount = "", IsGroup = false},
                new PriceModel {Id = 44, ServiceId = null, Title = "Rankų", Description="", Price = "10-12 €", PriceWithDiscount = "", IsGroup = false},
                new PriceModel {Id = 45, ServiceId = null, Title = "Bikini zonos", Description="", Price = "16-21 €", PriceWithDiscount = "", IsGroup = false}
            };
            return priceList;
        }

        public ActionResult Prices()
        {
            var priceList = new PriceListModel
            {
                PriceList = PriceList
            };
            return View(priceList);
        }
    }
}