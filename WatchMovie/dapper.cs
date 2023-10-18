using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchMovie
{
            //public class dapper
            //    {
            //        string connectionString = "Server=localhost;Port=5433;User Id=postgres;Password=1234;Database=YandexGo;";

            //                using (var connection = new NpgsqlConnection(connectionString))
            //                {
            //                    var user = new Users()
            //                    {
            //                        UserName =
            //                    };
            //    var sqlQuery = "delete from public.\"Users\" where \"PhoneNumber\" = @PhoneNumber";

            //    connection.Execute(sqlQuery, user);

            //                    MessageBox.Show("Sucesfully Deleted");
            //                    LoginPage login = new LoginPage();
            //    login.Show();
            //                    Hide();
            //}


            //string connectionString = "Server=localhost;Port=5433;User Id=postgres;Password=1234;Database=YandexGo;";

            //using (var connection = new NpgsqlConnection(connectionString))
            //{
            //    var user = new User()
            //    {
            //        FullName = fullName,
            //        PhoneNumber = phoneNumber,
            //        Password = Password
            //    };

            //    var sqlQuery = "INSERT INTO public.\"Users\"(\"FullName\", \"PhoneNumber\", \"Password\") values (@FullName,@PhoneNumber,@Password)";


            //    if (res1 == null && res2 == null)
            //    {
            //        connection.Execute(sqlQuery, user);
            //        return false;
            //    }
            //    return true;
            //}


            //public bool CheckUserLogin2(int UserPhoneNumber, string Password)
            //{
            //    string connectionString = "Server=localhost;Port=5433;User Id=postgres;Password=1234;Database=YandexGo;";

            //    using (var connection = new NpgsqlConnection(connectionString))
            //    {
            //        var user = new User()
            //        {
            //            PhoneNumber = UserPhoneNumber,
            //            Password = Password
            //        };

            //        var sqlQuery = "SELECT \"PhoneNumber\", \"Password\" FROm public.\"Users\" where \"PhoneNumber\" = @PhoneNumber and  \"Password\" = @Password";

            //        var res = connection.Query<User>(sqlQuery, user).ToList();

            //        foreach (var i in res)
            //        {
            //            if (i.PhoneNumber == UserPhoneNumber && i.Password == Password)
            //            {
            //                return true;
            //            }
            //        }
            //        return false;
            //    }
  }

