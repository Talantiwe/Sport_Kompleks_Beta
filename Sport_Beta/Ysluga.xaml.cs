using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Data;
using System.IO;

namespace Sport
{
    /// <summary>
    /// Логика взаимодействия для Ysluga.xaml
    /// </summary>
    public partial class Ysluga : Window
    {
  
        public Ysluga()
        {
            InitializeComponent();
            primer(null, null);
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }
        

        public class SportsDataContext : DbContext
        {
            public DbSet<Price> Price { get; set; }
            public DbSet<Main_Price> Main_Price { get; set; }
            public SportsDataContext() : base("Data Source=DESKTOP-JT2CST3;Initial Catalog=SportKompleks2;Integrated Security=True")
            {

            }
        }

        private void primer(object sender, RoutedEventArgs e)
        {
            try
            {
                using (var context = new SportsDataContext())
                {
                    var prices = from price in context.Price
                                 select new { price.Name, price.Money };
                    foreach(var price in prices)
                    {
                        dop_TextBlock.Text += $" {price.Name} {price.Money}₽ \n\n";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }


            try
            {
                using(var context=new SportsDataContext())
                {
                    var main = from main_price in context.Main_Price
                               select new { main_price.Name, main_price.Money };
                    
                    foreach(var main_price in main)
                    {
                        main_TextBlock.Text += $"{main_price.Name} {main_price.Money}₽ \n\n";
                    }
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show($"An error occured: {ex.Message}");
            }
        }
    }
}
