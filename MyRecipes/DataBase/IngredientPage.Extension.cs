using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MyRecipes.DataBase
{
    partial class IngredientPage
    {
        public int TotalNumberPages // общее количество страниц 
        {
            get { return (int)GetValue(TotalNumberPagesProperty); }
            set { SetValue(TotalNumberPagesProperty, value); }
        }

        public static readonly DependencyProperty TotalNumberPagesProperty =
            DependencyProperty.Register("TotalNumberPages", typeof(int), typeof(IngredientPage));

        public int NumberPage // номер страницы на которой находится пользователь
        {
            get { return (int)GetValue(NumberPageProperty); }
            set { SetValue(NumberPageProperty, value); }
        }

        public static readonly DependencyProperty NumberPageProperty =
            DependencyProperty.Register("NumberPage", typeof(int), typeof(IngredientPage));

        public IEnumerable<Ingredient> Ingredient // все записи
        {
            get { return (IEnumerable<Ingredient>)GetValue(MyPropertyProperty); }
            set { SetValue(MyPropertyProperty, value); }
        }

        public static readonly DependencyProperty MyPropertyProperty =
            DependencyProperty.Register("Ingredient", typeof(IEnumerable<Ingredient>), typeof(IngredientPage));

        public List<int> NumberEntriestOnOnePage // количество всех записей 
        {
            get { return (List<int>)GetValue(NumberEntriestOnOnePageProperty); }
            set { SetValue(NumberEntriestOnOnePageProperty, value); }
        }

        public static readonly DependencyProperty NumberEntriestOnOnePageProperty =
            DependencyProperty.Register("NumberEntriestOnOnePage", typeof(List<int>), typeof(IngredientPage));
    }
}
