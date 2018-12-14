using OdeToFood.Models;
using System.Collections.Generic;

namespace OdeToFood.Services.Interfaces
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();

        Restaurant GetById(int id);

        Restaurant Add(Restaurant restaurant);
    }
}
