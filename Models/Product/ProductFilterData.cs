﻿//using Common.Query;
using Eshop.RazorPage.Models;

namespace AppRazorPage.Models.Product
{
    public class ProductFilterData : BaseDto
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public DateTime CreationDate { get; set; }
        public string Price { get; set; }
    }
}
