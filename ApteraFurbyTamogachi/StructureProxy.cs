using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ApteraFurbyTamogachi
{
    public class StructureProxy
    {
        public async Task<string> stuff() {
            var client = new HttpClient();
            var uri = new Uri("https://app.trystructure.com");
            var apimethod = new Uri("api/v1/login"); 
            client.BaseAddress = uri;
            var result = await client.SendAsync(new HttpRequestMessage() { Content = new StringContent("{\"username\" = \"ldohse@apterainc.com\", \"password\" = \"65Y2q108!\"}", Encoding.UTF8, "application\\json"), RequestUri = apimethod});
            return await result.Content.ReadAsStringAsync();
        }
    }
}
