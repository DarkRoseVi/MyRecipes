using MyRecipes.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyRecipes.Pages
{
    /// <summary>
    /// Interaction logic for IngridientPage.xaml
    /// </summary>
    public partial class IngridientPage : Page
    {
        private decimal sum;

        public IngridientPage()
        {
            InitializeComponent();
            IngridientList.ItemsSource = Connection.db.Ingredient.ToList();
            Navigation.main.MenuInMain.Visibility = Visibility.Collapsed;
            Navigation.main.IngTitle.Visibility = Visibility.Visible;
            Navigation.main.CountIngTb.Text = $"{Connection.db.Ingredient.ToList().Count()} наименований";
            var ings = Connection.db.Ingredient.ToList();
            foreach (var item in ings)
            {
                sum += item.Cost / (decimal)item.CostForCount * (decimal)item.AvailableCount;
            }
            Navigation.main.SumIngTb.Text = $"Запасов в холодильнике на сумму: {sum:N0}";

            
        }

        private void AddMenuBTN_Click(object sender, RoutedEventArgs e)
        {
            Navigation.NextPage(new AddEditIngPage());
        }
    }
}
