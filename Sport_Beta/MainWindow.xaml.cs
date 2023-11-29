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

namespace Sport
{




    public partial class MainWindow : Window
    {
        private readonly User user;


        /*
        public MainWindow(string username)
        {
            InitializeComponent();
            this.username = username; // Сохраняем логин пользователя
        }
        */



        DataBase dataBase = new DataBase();
        private DispatcherTimer inactivityTimer;
        private const int InactivityTimeoutInSeconds = 5; // 30 seconds

        public MainWindow()
        {
            InitializeComponent();

            // Инициализация таймера
            inactivityTimer = new DispatcherTimer();
            inactivityTimer.Interval = TimeSpan.FromSeconds(InactivityTimeoutInSeconds);
            inactivityTimer.Tick += InactivityTimer_Tick;

            // Запуск таймера при загрузке формы
            Loaded += MainWindow_Loaded;

            // Добавление обработчиков событий мыши и клавиатуры
            MouseMove += MainWindow_MouseMove;
            PreviewKeyDown += MainWindow_PreviewKeyDown;

            // Начать следить за бездействием
            StartInactivityTimer();
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
            RAspisanie rasp = new RAspisanie();
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

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            // Запуск таймера при загрузке формы
            StartInactivityTimer();
        }

        private void StartInactivityTimer()
        {
            inactivityTimer.Start();
        }

        private void ResetInactivityTimer()
        {
            inactivityTimer.Stop();
            inactivityTimer.Start();
        }

        private void InactivityTimer_Tick(object sender, EventArgs e)
        {
            // Событие срабатывает после бездействия пользователя в течение указанного времени

            // Здесь добавлен код для выхода из всего приложения
            Application.Current.Shutdown();
            Environment.Exit(0);
        }

        // Обработчик события для сброса таймера при любой активности пользователя (например, при нажатии кнопок)
        private void OnUserActivity()
        {
            ResetInactivityTimer();
        }

        private void MainWindow_MouseMove(object sender, MouseEventArgs e)
        {
            // Обработчик события MouseMove вызывается при каждом движении мыши.
            // Сбросить таймер после каждого движения мыши
            OnUserActivity();
        }

        private void MainWindow_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            // Обработчик события PreviewKeyDown вызывается перед обработкой клавиш.
            // Сбросить таймер после каждого нажатия клавиши
            OnUserActivity();
        }
    }
}



