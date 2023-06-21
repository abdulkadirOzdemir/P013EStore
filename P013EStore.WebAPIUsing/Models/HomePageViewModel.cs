﻿using P013EStore.Core.Entities;

namespace P013EStore.WebAPIUsing.Models
{
    public class HomePageViewModel
    {
        public List<Slider>? Sliders { get; set; }
        public List<Product>? Products { get; set; }
		public List<Brand>? Brands { get; set; }
		public List<News>? News { get; set; }
	}
}