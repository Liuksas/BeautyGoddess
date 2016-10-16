using System.Collections.Generic;

namespace BeautyGoddess.Models.Price
{
    public class PriceGroupModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool HasUrl { get; set; }
        public List<PriceModel> Prices { get; set; }
    }
}