using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WF_Pokedex
{
    public class HttpImageLoader
    {
        private static readonly HttpClient client;

        static HttpImageLoader()
        {
            client = new HttpClient();
        }

        public async Task<Image> LoadImage(string url)
        {
            Stream stream = await client.GetStreamAsync(url);
            return Image.FromStream(stream);
        }
    }
}
