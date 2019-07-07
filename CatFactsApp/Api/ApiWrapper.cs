using CatFactsApp.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CatFactsApp.Api
{
    public class ApiWrapper
    {
        public async static Task<Facts> RetrieveFacts()
        {
            Uri reqGetFacts = new Uri(@"https://cat-fact.herokuapp.com/facts");

            using (HttpClient hClient = new HttpClient())
            {

                try
                {
                    HttpResponseMessage responseMessage = await hClient.GetAsync(reqGetFacts);
                    if (responseMessage.IsSuccessStatusCode == false)
                    {

                        MessageBox.Show("MainWindow = " +
                        responseMessage.StatusCode.ToString());
                        return null;
                    }

                    responseMessage.EnsureSuccessStatusCode();

                    Facts allFacts = await responseMessage.Content.ReadAsAsync<Facts>();

                    return allFacts;
                }
                catch (Exception)
                {

                    throw;
                }

            }

        }
    }
}
