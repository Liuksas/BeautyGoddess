using System;
using System.Collections.Generic;
using System.Web.Caching;
using System.Web.Mvc;
using BeautyGoddess.Models.Price;
using BeautyGoddess.Models.Service;
using BeautyGoddess.Utilities;

namespace BeautyGoddess.Controllers
{
    public class PriceController : BaseController
    {
        private List<PriceGroupModel> _priceGroupList;

        public List<PriceGroupModel> PriceGroupList
        {
            get
            {
                if (_priceGroupList != null) return PriceGroupList;
                _priceGroupList = (HttpContext.Cache["PriceGroupList"] as List<PriceGroupModel>);
                if (_priceGroupList == null)
                {
                    _priceGroupList = ModelsPopulate.PriceGroupModelPopulate();
                    var cacheTime = GettAppSetting<double>("cacheTimeInSeconds");
                    HttpContext.Cache.Insert("PriceGroupList", _priceGroupList, null, DateTime.Now.AddSeconds(cacheTime), Cache.NoSlidingExpiration, CacheItemPriority.High, null);
                }
                return _priceGroupList;
            }
        }

        public ActionResult Prices()
        {
            var priceList = new PriceGroupListModel()
            {
                PriceGroupList = PriceGroupList
            };
            return View(priceList);
        }
    }
}