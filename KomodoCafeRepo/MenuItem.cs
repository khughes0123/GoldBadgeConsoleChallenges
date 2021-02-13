using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoCafeRepo
{
    public class MenuItem
    {
        public int MenuNumber { get; set; }
        public string MealName { get; set; }
        public string MealDescription { get; set; }
        public decimal MealPrice { get; set; }

        public List<string> IngredientsList = new List<string>();

        public MenuItem() { }
        public MenuItem(int menunumber, string mealname, string mealdescription, decimal mealprice, List<string> ingredientslist)
        {
            MenuNumber = menunumber;
            MealName = mealname;
            MealDescription = mealdescription;
            MealPrice = mealprice;
            IngredientsList = ingredientslist;

        }

    }
}
