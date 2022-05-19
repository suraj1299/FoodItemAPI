using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodItemsWebAPI.services;
using Microsoft.AspNetCore.Mvc;
using RestaurantAPI.Models;

namespace RestaurantAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodItemController : ControllerBase
    {

        private readonly IFoodItemsService _foodItemService;
        public FoodItemController(IFoodItemsService foodItemService)
        {
            _foodItemService = foodItemService;
        }
        [HttpGet]
        [Route("GetFoodItems/")]
        public async Task<ActionResult<IEnumerable<FoodItems>>> GetFoodItems()
        {
            return (await _foodItemService.GetFoodItems()).ToList();
        }



    }
}
