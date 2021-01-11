using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            /*string jsonPath = @"C:\Users\Team603\Desktop\test.json";
            string json = File.ReadAllText(jsonPath);
            JObject jObject = JObject.Parse(json);

            var a = from x in jObject["data"]
                    select x.ToList();

            foreach (var item in a)
            {
                Console.WriteLine(item[0]);
                //Console.WriteLine(item[0]["id"]);
            }*/


            string jsonPath = @"C:\Users\Team603\Desktop\csharp\BlazorApp1\BlazorApp1\championFull.json";
            string json = File.ReadAllText(jsonPath);
            JObject jObject = JObject.Parse(json);

            var a = from x in jObject["data"]
                    select x.ToList();

            List<List<JToken>> tt = new List<List<JToken>>();

            foreach (var item in a)
            {
                tt.Add(item);
            }

            Console.WriteLine(tt[0][0].ToString());

        }
    }
}
