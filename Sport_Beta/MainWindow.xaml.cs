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
using System.Windows.Shapes;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Threading;
using System.Windows.Interop;
using System.Runtime.InteropServices;
using System.Threading;


namespace Sport
{




    public partial class MainWindow : Window
    {
        private readonly User user;
        DataBase dataBase = new DataBase();


        /*
        public MainWindow(string username)
        {
            InitializeComponent();
            this.username = username; // Сохраняем логин пользователя
        }
        */




        private DispatcherTimer exitTimer;

        public MainWindow()
        {
            InitializeComponent();

            // Инициализация и запуск таймера для автоматического закрытия окна через 10 секунд
            exitTimer = new DispatcherTimer();
            exitTimer.Interval = TimeSpan.FromSeconds(10);
            exitTimer.Tick += AutoCloseWindow;
            exitTimer.Start();
        }

        private void AutoCloseWindow(object sender, EventArgs e)
        {
            Console.WriteLine("Автоматическое закрытие окна.");

            // Закрытие текущего окна
            this.Close();
        }

        private void Exit_Click(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }



        private void Kat_Click(object sender, MouseButtonEventArgs e)
        {
            if (kaat2.Visibility == Visibility.Hidden)
            {
                kaat2.Visibility = Visibility.Visible;
            }
            else
            {
                kaat2.Visibility = Visibility.Hidden;
            }

        }

        private void Raspisan_Click(object sender, RoutedEventArgs e)
        {
            RAspisanie rasp = new RAspisanie(user);
            rasp.Show();
        }

        private void Novosti_Click(object sender, RoutedEventArgs e)
        {
            Novosti nov = new Novosti();
            nov.Show();
        }

        private void Trener_Click(object sender, RoutedEventArgs e)
        {
            Trener trener = new Trener();
            trener.Show();


        }

        private void ysluga_Click(object sender, RoutedEventArgs e)
        {
            Ysluga ysluga = new Ysluga();
            ysluga.Show();
        }


       
        private void Cabinet_Click(object sender, RoutedEventArgs e)
        {
            Cabinet cabinet = new Cabinet(user);
            cabinet.Show();
        }


        public MainWindow(User user)
        {
            InitializeComponent();
            this.user = user;
            //UsernameTextBlock.Text = "Логин: " + user.login;
            //NameTextBlock.Text = "Имя: " + user.Name1;
        }

        
    }
}
