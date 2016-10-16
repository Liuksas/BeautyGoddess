﻿namespace BeautyGoddess.Models.Price
{
    public class PriceModel
    {
        public int Id { get; set; }
        public int? ServiceId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public string PriceWithDiscount { get; set; }
        public bool IsGroup { get; set; }
    }
}