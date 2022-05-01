using System;
using System.Collections.Generic;

namespace Assignment4.Models
{
    public class FoodDetails
    {
        public Decimal Calories { get; set; }
        public Decimal Fat { get; set; }
        public Decimal Carbs { get; set; }
        public Decimal Protein { get; set;}
        public List<FoodForMealFoodItem> data { get; set; }
    }

    public class FoodForMealFoodItem
    {
        public int MealID { get; set; }
        
    }
}
