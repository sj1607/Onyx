using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onyx.Classes
{
    public class GSC
    {
        public string? Hash { get; set; }
        public string? Unhash { get; set; }
        public List<string>? Params { get; set; }
        public string? Path { get; set; }
        public string? Type { get; set; }

        public string ParamsText
        {
            get
            {
                if (Params == null || !Params.Any())
                {
                    return "";
                }
                return string.Join(", ", Params);
            }
        }
    }
}
