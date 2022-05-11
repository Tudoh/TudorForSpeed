using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using TudorForSpeed.Data;
using TudorForSpeed.Data.APIControl;
using TudorForSpeed.Data.APIControl.Reponse;
using TudorForSpeed.Data.APIControl.Request;

namespace TudorForSpeed.Helper
{
    public class APIForSpeed_API {
        public static string url = "https://localhost:44380";

        public static async Task<List<CarOrder>> GetAllOrders()
        {
            HttpClient client = new HttpClient();
            try
            {
                var result = await client.GetStringAsync(url + "/GetAll");

                List<CarOrder> lista = JsonConvert.DeserializeObject<List<CarOrder>>(result);

                return lista;
            }
            catch
            {
                return null;
            }

        }
        public static async Task<CarOrder> GetOrderByID(int id)
        {
            HttpClient client = new HttpClient();
            try
            {
                var result = await client.GetStringAsync(url + $"/SearchOrders={id}");

                CarOrder response = JsonConvert.DeserializeObject<CarOrder>(result);

                return response;
            }
            catch
            {
                return null;
            }
        }
        public static async Task<CreateOrderResponse> CreateOrder(CreateOrderRequest request)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(url + "/Create");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
            try
            {
                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string json = JsonConvert.SerializeObject(request);

                    streamWriter.Write(json);
                }

                var httpResponse = (HttpWebResponse)await httpWebRequest.GetResponseAsync();
                CreateOrderResponse response;
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    response = JsonConvert.DeserializeObject<CreateOrderResponse>(result);
                }
                return response;
            }
            catch (Exception ex)
            {
                return new CreateOrderResponse()
                {
                    state = false,
                    Error = new List<string>
                    {
                        ex.Message
                    }
                };
            }
        }

        public static async Task<DeleteOrderResponse> DelateOrder(DeleteOrderRequest request)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(url + $"/DeleteCarOrder");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "DELETE";
            try
            {
                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string json = JsonConvert.SerializeObject(request);

                    streamWriter.Write(json);
                }

                var httpResponse = (HttpWebResponse)await httpWebRequest.GetResponseAsync();
                DeleteOrderResponse response;
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    response = JsonConvert.DeserializeObject<DeleteOrderResponse>(result);
                }
                return response;
            }
            catch (Exception ex)
            {
                return new DeleteOrderResponse()
                {
                    state = false,
                    Error = new List<string>
                    {
                        ex.Message
                    }
                };
            }
        }

    }

}
