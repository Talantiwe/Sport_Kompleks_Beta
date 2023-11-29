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
using System.Data;
using System.Data.SqlClient;
using static Sport.User;
using System.Data.Entity;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Threading;

namespace Sport
{
    /// <summary>
    /// Логика взаимодействия для Cabinet.xaml
    /// </summary>
    public partial class Cabinet : Window
    {
        //private readonly User user;
        // DataBase dataBase = new DataBase();

        private User loggedInUser;

        public Cabinet(User user)
        {
            InitializeComponent();
            loggedInUser = user;
            primer(null, null, loggedInUser);
        }



        public class SportsDataContextt : DbContext
        {

            public DbSet<User> Users { get; set; }

            public SportsDataContextt() : base("Data Source=DESKTOP-JT2CST3;Initial Catalog=SportKompleks2;Integrated Security=True")
            {
               
            }

        }
        /*
       private void primer(object sender, RoutedEventArgs e)
       {
           try
           {
               using (var context = new SportsDataContextt())
               {
                   var users = from User in context.Users

                               select User.Name;

                   foreach (var User in users)
                   {
                       NameTextBlock.Text += $"Имя: {User}{Environment.NewLine}";
                   }
               }
           }
           catch (Exception ex)
           {
               MessageBox.Show($"An error occurred: {ex.Message}");
           }


       }

        */



        private void primer(object sender, RoutedEventArgs e, User loggedInUser)
        {
            try
            {
                using (var context = new SportsDataContextt())
                {
                    var foundUser = context.Users.FirstOrDefault(u => u.login == loggedInUser.login);

                    if (foundUser != null)
                    {
                        NameTextBlock.Text += $"Имя: {foundUser.Name}{Environment.NewLine}";
                        loginTextBlock.Text += $"Логин: {foundUser.login} {Environment.NewLine}";
                    }
                    else
                    {
                        // Логика обработки, если пользователь с таким логином не найден
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}\n\nInner Exception: {ex.InnerException?.Message}");
            }
        }





        private void Zad_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }




    }
}

