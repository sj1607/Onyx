using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onyx.Classes
{
    public class JSON
    {
        public static List<T>? LoadData<T>(string jsonFileName) where T : class 
        {
            try
            {
                string basePath = Application.StartupPath;
                string filePath = Path.Combine(basePath, "JSON", jsonFileName);

                if (!File.Exists(filePath))
                {
                    MessageBox.Show($"The JSON file '{jsonFileName}' cannot be found at the location : {filePath}", "Error File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }

                string jsonContent = File.ReadAllText(filePath);

                List<T>? data = JsonConvert.DeserializeObject<List<T>>(jsonContent);

                return data;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading data for {jsonFileName} : {ex.Message}", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
