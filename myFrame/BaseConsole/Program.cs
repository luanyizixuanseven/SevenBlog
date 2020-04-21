
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BaseConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            WebClient web = new WebClient();
            string param = "content=aa?bb#cc%ee/ff=";
            string url = "http://localhost:51857/api/test";
           
            byte[] postData = Encoding.UTF8.GetBytes(param);

            web.Headers.Add("Content-Type", "application/json;");
            byte[] result = web.UploadData(url, "POST", postData);
            Console.WriteLine(Encoding.UTF8.GetString(result));
            Console.ReadLine();
        }
        
    }
}
