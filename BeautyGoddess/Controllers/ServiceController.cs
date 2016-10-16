using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using BeautyGoddess.Models.Service;
using System.Web.Caching;

namespace BeautyGoddess.Controllers
{
    public class ServiceController : BaseController
    {
        private List<ServiceModel> _serviceList;

        public List<ServiceModel> ServiceList
        {
            get
            {
                if (_serviceList != null) return ServiceList;

                _serviceList = (HttpContext.Cache["ServiceList"] as List<ServiceModel>);
                if (_serviceList == null)
                {
                    _serviceList = GetPriceList();
                    var cacheTime = GettAppSetting<double>("cacheTimeInSeconds");
                    HttpContext.Cache.Insert("ServiceList", _serviceList, null, DateTime.Now.AddSeconds(cacheTime), Cache.NoSlidingExpiration, CacheItemPriority.High, null);
                }
                return _serviceList;
            }
        }

        private List<ServiceModel> GetPriceList()
        {
            var serviceList = new List<ServiceModel>
            {
                new ServiceModel {Id = 1, Title = "Veido odos procedūros", ImgUrl = "/Content/Images/Services/veido_odos_proceduros.jpg"},
                new ServiceModel {Id = 2, Title = "Mezoterapija", ImgUrl = "/Content/Images/Services/mezoterapija.jpg"},
                new ServiceModel {Id = 3, Title = "Biorevitalizacija", ImgUrl = "/Content/Images/Services/biorevitalizacija.jpg"},
                new ServiceModel {Id = 4, Title = "Hialurono rūgšties užpildai", ImgUrl = "/Content/Images/Services/hialurono_rugsties_uzpildai.jpg"},
                new ServiceModel {Id = 5, Title = "Lūpų putlinimas", ImgUrl = "/Content/Images/Services/lupu_putlinimas.jpg"},
                new ServiceModel {Id = 6, Title = "Botulino injekcijos", ImgUrl = "/Content/Images/Services/botulino_injekcijos.jpg"},
                new ServiceModel {Id = 7, Title = "Adatinė Dermaroler terapija", ImgUrl = "/Content/Images/Services/adatine_dermaroler_terapija.jpg"},
                new ServiceModel {Id = 8, Title = "Aparatūrinės veido procedūros", ImgUrl = "/Content/Images/Services/aparaturines_veido_proceduros.jpg"},
                new ServiceModel {Id = 9, Title = "Cheminis pilingas", ImgUrl = "/Content/Images/Services/cheminis_pilingas.jpg"},
                new ServiceModel {Id = 10, Title = "Blakstienų priauginimas 'Volume'", ImgUrl = "/Content/Images/Services/blakstienu_priauginimas.jpg"},
                new ServiceModel {Id = 11, Title = "Antakių dažymas", ImgUrl = "/Content/Images/Services/antakiu_dazymas.jpg"},
                new ServiceModel {Id = 12, Title = "Estetinis plaukų šalinimas vašku", ImgUrl = "/Content/Images/Services/estetinis_plauku_salinimas_vasku.jpg"}
            };
            return serviceList;
        }

        public ActionResult Services()
        {
            var serviceList = new ServiceListModel
            {
                ServiceList = ServiceList
            };
            return View(serviceList);
        }

        public ActionResult ServiceDetails(int? id)
        {
            var service = ServiceList.FirstOrDefault(x => x.Id == id);
            return View(service);
        }
    }
}