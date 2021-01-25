using Newtonsoft.Json;
using Picoletes.Core.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace Picoletes.Interface.Repository
{
    public class RetiradaRepository
    {
        private readonly string APIURL = "https://localhost:44315/api/estoque";
        public List<Estoque> GetEstoqueAtual()
        {
            var request = (HttpWebRequest)WebRequest.Create(APIURL);
            request.Method = "GET";
            request.ContentType = "application/json";
            using (var response = request.GetResponse())
            {
                using (var reader = new StreamReader(response.GetResponseStream()))
                {
                    return JsonConvert.DeserializeObject<List<Estoque>>(reader.ReadToEnd());
                }
            }
        }
    }
}
