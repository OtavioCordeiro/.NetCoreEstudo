using OdeToFood.Models;
using OdeToFood.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Services
{
    public class InMemoryRestaurant : IRestaurantData
    {
        public InMemoryRestaurant()
        {
            _restaurants = new List<Restaurant>()
            {
                new Restaurant(){Id = 1, Name = "DOUZÃO"},
                new Restaurant(){Id = 2, Name = "Tia zezé"},
                new Restaurant(){Id = 3, Name = "Dom zelittos"}
            };
        }

        List<Restaurant> _restaurants;

        public IEnumerable<Restaurant> GetAll()
        {
            return _restaurants.OrderBy(x => x.Name);
        }

        public Restaurant GetById(int id)
        {
            return _restaurants.FirstOrDefault(r => r.Id == id);
        }

        public Restaurant Add(Restaurant restaurant)
        {
            restaurant.Id = _restaurants.Max(r => r.Id) + 1;
            _restaurants.Add(restaurant);
            return restaurant;
        }
    }
}
