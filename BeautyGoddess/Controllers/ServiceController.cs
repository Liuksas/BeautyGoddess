using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using BeautyGoddess.Models.Service;
using System.Web.Caching;
using BeautyGoddess.Utilities;

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
                    _serviceList = ModelsPopulate.ServiceModelPopulate();
                    var cacheTime = GettAppSetting<double>("cacheTimeInSeconds");
                    HttpContext.Cache.Insert("ServiceList", _serviceList, null, DateTime.Now.AddSeconds(cacheTime), Cache.NoSlidingExpiration, CacheItemPriority.High, null);
                }
                return _serviceList;
            }
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