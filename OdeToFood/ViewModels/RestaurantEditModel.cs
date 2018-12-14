using OdeToFood.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.ViewModels
{
    public class RestaurantEditModel
    {
        [Display(Name = "Restaurant Name:")]
        [Required, MaxLength(30)]
        public string Name { get; set; }
        public CuisineType Cuisine { get; set; }
    }
}
