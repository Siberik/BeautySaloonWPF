using BeautySaloonWPF.Models;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;

namespace BeautySaloonWPF.Controllers
{
   public class ServicesController
    {
        /// <summary>
        /// Вывод всех сервисов
        /// </summary>
      
      
        public static List<Services> GetService()

        {

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = client.GetAsync($"{Manager.RootUrl}Services").Result;
                var content = response.Content.ReadAsStringAsync();
                var answer = JsonConvert.DeserializeObject<List<Services>>(content.Result);
                return answer;

            }

        }



        /// <summary>
        /// Вывод всех сервисов заданной категории
        /// </summary>
        public static List<Services> GetCategoryService(int categoryId)

        {

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = client.GetAsync($"{Manager.RootUrl}Services/{categoryId}").Result;
                var content = response.Content.ReadAsStringAsync();
                var answer = JsonConvert.DeserializeObject<List<Services>>(content.Result);
                return answer;

            }

        }
        
    }
}
