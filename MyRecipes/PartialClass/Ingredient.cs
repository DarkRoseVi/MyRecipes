using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRecipes.DataBase
{
    partial class Ingredient
    {
        public string CostOFUnit
        {
            get
            {
                return $"{Cost:N0} руб. за {CostForCount} {Unit.Name}";
            }
        }
    }
}
