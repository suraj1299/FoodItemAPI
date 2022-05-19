using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestaurantAPI.Models;

namespace FoodItemsWebAPI.services
{
    public interface IFoodItemsService
    {
        Task<IEnumerable<FoodItems>> GetFoodItems();

    }
}
