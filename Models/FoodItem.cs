using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment4.Models
{
    public class FoodItem
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int FoodId { get; set; }
        public Meal meal { get; set; }
        public Category category { get; set; }

        public FoodForMeal foodForMeal { get; set; }
        public string FoodName { get; set; }
        public string FoodServing { get; set; }

        public double Calories { get; set; }

        public double SatFat { get; set; }

        public double TransFat { get; set; }

        public double Carbs { get; set; }

        public double Protein { get; set; }

        public double Cholestrol { get; set; }

        public double Sodium { get; set; }

        public double Fiber { get; set; }

        public double Sugar { get; set; }

        public double VitaminA { get; set; }

        public double VitaminC { get; set; }

        public double Calcium { get; set; }

        public double Iron { get; set; }

        public int FoodID { get; set; }
    }
}
