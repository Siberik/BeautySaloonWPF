using BeautySaloonWPF.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BeautySaloonWPF.Controllers
{
   public static class UsersController
    {
        /// <summary>
        /// Авторизация пользователя
        /// </summary>
        /// <param name="login">
        /// Логин пользователя
        /// </param>
        /// <param name="password">
        /// Пароль пользователя
        /// </param>
        /// <returns>
        /// Аунтификация пользователя
        /// </returns>
        public static bool Auth(string login,string password)

        {

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = client.GetAsync($"{Manager.RootUrl}Users/{login}/{password}").Result;
                
                return response.IsSuccessStatusCode;

            }

        }
        /// <summary>
        /// Регистрация пользователя
        /// </summary>
        /// <param name="user">
        /// На вход приходят данные пользователя
        /// </param>
        /// <returns>
        /// Регистрация пользователя
        /// </returns>
        public static bool AddUser(Users user)

        {

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = client.PostAsync($"{Manager.RootUrl}Users",null).Result;

                return response.IsSuccessStatusCode;

            }

        }
    }
}
