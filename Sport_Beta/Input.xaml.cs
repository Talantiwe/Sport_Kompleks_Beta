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
using md5_sql_hash;



namespace Sport
{

    public partial class Input : Window
    {

        private readonly User user;
        DataBase dataBase = new DataBase();

        public Input()
        {
            InitializeComponent();
        }

        public Input(User user)
        {
            InitializeComponent();
            this.user = user;
        }




        private void Inputt_Click(object sender, RoutedEventArgs e)
        {

            

            string login = Login.Text;
            string pass = md5.GetHash(password.Password);

            User user = AuthenticateUser(login, pass);

            if (login == "ad" && pass == "Ujr1N5RrecT4Np7Tm6eGBQ==")
            {
                MessageBox.Show("Вы вошли успешно как администратор");
                Admin admin = new Admin();
                admin.Show();
                this.Close();
            }
            else if (user != null)
            {   

                MessageBox.Show("Вы вошли успешно как пользователь");
                MainWindow mainWindow = new MainWindow(user);
                this.Hide();
                mainWindow.ShowDialog();
                this.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Нету пользователя с такими учетными данными");
            }
        }

        public User AuthenticateUser(string login, string pass)
        {
            
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string queryString = $"SELECT Id_User, login, pass FROM [User] WHERE login = '{login}' AND pass = '{pass}'";

            SqlCommand command = new SqlCommand(queryString, dataBase.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                // Пользователь найден
                User user = new User();
                user.Id_User = Convert.ToInt32(table.Rows[0]["Id_User"]);
                user.login = table.Rows[0]["login"].ToString();
                return user;
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
            // this.Close();
            this.Hide();
        }
    }
        
   
}

