using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using movil1.Common.Models;

namespace movil1.Services

{
    public class ApiService
    {
        public async Task<Response> GetList<T>(string urlBase, string)
        {
            try
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri(urlBase);
                var url = string.Format("{0}{1}", prefix, controller);
            }
            catch (Exception ex)
            {
                return new Response
                {
                    IsSuccess = false,
                    Message = ex.Message,

                };
                
            }
        }
    }
}
