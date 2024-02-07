using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using md5_sql_hash;

namespace Sport
{
    public partial class Input : Window
    {
        private readonly User user;
        private readonly DataBase dataBase = new DataBase();
        private int numberAttempts = 0;

        public Input()
        {
            InitializeComponent();
        }

        public Input(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private async Task Blocking()
        {
            numberAttempts++;
            if (numberAttempts == 3)
            {
                MessageBox.Show("Система заблокирована на 10 секунд.");
                Inputt.IsEnabled = false;
                Reg.IsEnabled = false;
                await Task.Delay(10000);
                Inputt.IsEnabled = true;
                Reg.IsEnabled = true;
                numberAttempts = 0;
            }
        }

        private async void Inputt_Click(object sender, RoutedEventArgs e)
        {
            string login = Login.Text;
            string pass = md5.GetHash(password.Password);

            User authenticatedUser = AuthenticateUser(login, pass);

            if (login == "ad" && pass == "Ujr1N5RrecT4Np7Tm6eGBQ==")
            {
                MessageBox.Show("Вы вошли успешно как администратор");
                Admin admin = new Admin();
                admin.Show();
                this.Close();
            }
            else if (authenticatedUser != null)
            {
                MessageBox.Show("Вы вошли успешно как пользователь");
                MainWindow mainWindow = new MainWindow(authenticatedUser);
                this.Hide();
                mainWindow.ShowDialog();
                this.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
                await Blocking(); 
                
            }
        }

        public User AuthenticateUser(string login, string pass)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string queryString = $"SELECT Id_User, login, pass FROM [User] WHERE login = '{login}' AND pass = '{pass}'";

            using (SqlCommand command = new SqlCommand(queryString, dataBase.GetConnection()))
            {
                adapter.SelectCommand = command;
                adapter.Fill(table);
            }

            if (table.Rows.Count == 1)
            {
                // Пользователь найден
                User authenticatedUser = new User();
                authenticatedUser.Id_User = Convert.ToInt32(table.Rows[0]["Id_User"]);
                authenticatedUser.login = table.Rows[0]["login"].ToString();
                return authenticatedUser;
            }

            return null; // Если пользователь не найден
        }

        private void Exit_Click_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void Reg_Click(object sender, RoutedEventArgs e)
        {
            Registration reg = new Registration();
            reg.Show();
            this.Hide();
        }
    }
}
