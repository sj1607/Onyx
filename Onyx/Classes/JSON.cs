using Newtonsoft.Json;
using System.Net;

namespace Onyx.Classes
{
    public class JSON
    {
        public static List<T>? LoadData<T>(string jsonFileName) where T : class
        {
            try
            {
                string baseUrl = "https://raw.githubusercontent.com/sj1607/Onyx/refs/heads/main/Onyx/JSON/";
                string url = baseUrl + jsonFileName;

                using (WebClient wc = new WebClient())
                {
                    string jsonContent = wc.DownloadString(url);
                    return JsonConvert.DeserializeObject<List<T>>(jsonContent);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading JSON : {ex.Message}");
                return null;
            }
        }

    }
}
